using System;
using System.Threading;


namespace WordParser
{

    // Информация о запущенном потоке
    public class CThreadInfo 
    {
        public string ThreadID { get; set; } // ID потока
        public string FilePath { get; set; } // Путь к файлу
        public Thread Thread { get; set; }   // Поток
        public string Type { get; set; }     // Тип потока
        public DateTime Start { get; set; }  // Время старта потока

        public CThreadInfo(string _ThreadID, string _FilePath, Thread _Thread, string _Type)
        {
            this.ThreadID = _ThreadID;
            this.FilePath = _FilePath;
            this.Thread = _Thread;
            this.Type = _Type;
            this.Start = DateTime.Now;
        }
    }


    // Параметры для передачи в поток
    public class CParameters
    {
        public string ThreadID; // ID потока
        public string FilePath; // Путь к файлу
        public int WordLen;     // Длина искомого слова
    }


}


