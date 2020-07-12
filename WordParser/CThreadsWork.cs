using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace WordParser 
{

    // Класс для работы с потоками
    class CThreadsWork
    {
        public ConcurrentDictionary<string, CThreadInfo> cdThreads; // Список запущенных потоков (ID и описание)
        public ConcurrentDictionary<string, int> cdResults;         // Список найденных слов (и их количество)
        public bool bBreak = false;                                 // Флаг - Выполнение парсинга прервано
        public bool bUpdate = false;                                // Флаг - Количество потоков изменилось, можно обновить закладку


        public CThreadsWork()
        {
            Init(); // Подготовка к работе с потоками
        }


        // Подготовка к работе с потоками
        public void Init()
        {
            cdThreads = new ConcurrentDictionary<string, CThreadInfo>();
            cdResults = new ConcurrentDictionary<string, int>();
            bBreak = false;
            bUpdate = false;
        }


        // Запускаем новый поток для поиска в файле слов с требуемой длинной
        public void AddNewThread(string sFile, int iWordLen)
        {
            string sThreadID = Guid.NewGuid().ToString(); // ID для нового потока

            Thread oThread = new Thread(new ParameterizedThreadStart(FileProcessing))
            {
                Priority = ThreadPriority.Normal,
                IsBackground = true
            };

            cdThreads.TryAdd(sThreadID, new CThreadInfo(sThreadID, sFile, oThread, "Check File")); // Добавляем новый поток в общий список запущенных потоков    
            bUpdate = true;

            oThread.Start(new CParameters { ThreadID = sThreadID, FilePath = sFile, WordLen = iWordLen });   // Запуск потока
        }


        // Поток для обработки конкретного файла 
        private void FileProcessing(object obj)
        {
            CParameters oParam = (CParameters)obj; // Параметры, переданные в поток
            string sBody = "";

            try
            {
                using (StreamReader sr = new StreamReader(oParam.FilePath, Encoding.Default)) // Чтение содержимого файла
                {
                    sBody = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("! " + ex.Message);
                goto lblEnd;
            }

            string sLen = (oParam.WordLen + 1).ToString();
            Regex regex = new Regex(@"[a-zA-Z]{" + sLen + ",}|[а-яА-ЯёЁ]{" + sLen + ",}"); // Поиск слов, состоящих из русских/латинскими букв, > заданной длины
            MatchCollection matches = regex.Matches(sBody);

            Dictionary<string, int> dWords = new Dictionary<string, int>(); // Локальный список слов

            foreach (Match match in matches)            // Записываем найденные слова в локальный список
            {
                if (bBreak) { goto lblEnd; }            // Парсинг прерван

                if (!dWords.ContainsKey(match.Value))   // Если слова нет в списке - добавляем, если есть, то +1
                    dWords.Add(match.Value, 1);
                else
                    dWords[match.Value] += 1;
            }

            foreach (KeyValuePair<string, int> oKVP in dWords) // Переносим слова из локального в общий список
            {
                if (bBreak) { goto lblEnd; } // Парсинг прерван
                if (!cdResults.TryAdd(oKVP.Key, oKVP.Value)) { cdResults[oKVP.Key] += oKVP.Value; }
            }

        lblEnd:
            ;

            cdThreads.TryRemove(oParam.ThreadID, out CThreadInfo ti); // Удаление потока из общего списка потоков
            bUpdate = true;
        }


        // Остановить все потоки
        public void KillAllThreads()
        {
            bBreak = true;
            Thread.Sleep(500); // Пауза, чтобы потоки завершились сами

            foreach (KeyValuePair<string, CThreadInfo> oItem in cdThreads) // Останавливаем все запущенные потоки
            {
                Application.DoEvents();

                Thread oThread = new Thread(new ParameterizedThreadStart(KillTheThread)); // Поток для остановки потока
                oThread.IsBackground = true;

                oThread.Start(oItem.Value.Thread);                  // Запуск потока
                cdThreads.TryRemove(oItem.Key, out CThreadInfo ti); // Удалить поток из списка потоков
            }

            bUpdate = true;
        }


        // Остановка конкретного потока
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        private void KillTheThread(object obj)
        {
            Thread oThread = (Thread)obj;
            oThread.Abort();
        }


        // Вывод списока слов и их количества (ТОР ..., с сортировкой по убыванию)
        public List<KeyValuePair<string, int>> GetResult(int iWordCount)
        {
            return cdResults.OrderByDescending(p => p.Value).Take(iWordCount).ToList(); 
        }


    }


}


