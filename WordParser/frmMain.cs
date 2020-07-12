using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace WordParser
{

    public partial class frmMain : Form
    {
        private readonly CThreadsWork cThrWork = new CThreadsWork(); // Класс для работы с потоками


        public frmMain()
        {
            InitializeComponent();
        }


        // Загрузка формы
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion;

            tcMain.ImageList = imgMain16;               // Иконки закладок
            tpThread.ImageKey = "execute";
            tpResult.ImageKey = "list";       
            tpSett.ImageKey = "settings";

            lsvThreads.SmallImageList = imgMain16;      // Иконки listview (Потоки)
            lsvThreads.Columns[1].ImageKey = "date_time";
            lsvThreads.Columns[2].ImageKey = "bullets";
            lsvThreads.Columns[3].ImageKey = "folder";

            lsvWords.SmallImageList = imgMain16;        // Иконки listview (Результат)
            lsvWords.Columns[1].ImageKey = "word";
            lsvWords.Columns[2].ImageKey = "count";

            mnuStart.Image = imgMain16.Images["play"];  // Иконки меню и др.
            mnuStop.Image = imgMain16.Images["stop"];
            mnuClipboard.Image = imgMain16.Images["copy"];
            btnFeedback.Image = imgMain16.Images["mail"];
            picSumm.Image = imgMain16.Images["summ"];
            tssStatus.Image = imgMain16.Images["info"];
            tssThread.Image = imgMain16.Images["execute"];
        }


        // Меню - Старт парсинга
        private void mnuStart_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog() // Выбор папки 
            {
                Description = "Please select folder:",
                ShowNewFolderButton = false,
                SelectedPath = Properties.Settings.Default.pSelPath
            };
            if (FBD.ShowDialog() != DialogResult.OK) { return; }
            Properties.Settings.Default.pSelPath = FBD.SelectedPath; // Запоминаем папку
            Properties.Settings.Default.Save();

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start(); // Запуск секундомера
 
            cThrWork.Init();                            // Подготовка к работе с потоками

            mnuStart.Enabled = false;
            mnuStop.Enabled = true;
            tssStatus.Text = "Status: Working";
            lsvWords.Items.Clear();
            tcMain.SelectedTab = tpThread;              // Активация вкладки Потоки

            string sExt = cmbFileExt.Text;              // Расширение файлов для поиска
            int iWordLen = (int)nudWordLen.Value;       // Длина искомого слова
            int iMaxThCnt = (int)nudThreadsCount.Value; // Максимально допустимое количество одновременно работающих потоков

            CFilesWork cFilesWork = new CFilesWork();   // Класс для работы с файлами
            List<string> lFiles = cFilesWork.GetFiles(FBD.SelectedPath, sExt); // Список файлов в папке

            tspMain.Maximum = lFiles.Count;             // Прогрессбар

            foreach (string sFile in lFiles)            // Перебираем найденные файлы
            {
                Application.DoEvents();
                if (cThrWork.bBreak) { goto lblEnd; }   // Парсинг прерван

                if (tspMain.Value + 1 <= tspMain.Maximum) { tspMain.Value += 1; } // Прогрессбар
                tssFilesCount.Text = "File: " + tspMain.Value + " / " + tspMain.Maximum;

                cThrWork.AddNewThread(sFile, iWordLen); // Запускаем новый поток для поиска в файле слов с требуемой длинной

                do                                      // Контроль максимально допустимого количества одновременно запущенных потоков
                {
                    Application.DoEvents();
                    if (cThrWork.bBreak) { goto lblEnd; } // Парсинг прерван
                }
                while (cThrWork.cdThreads.Count >= iMaxThCnt);
            }


            do // Ожидание завершения всех запущенных потоков
            {
                Application.DoEvents();
                if (cThrWork.bBreak) { goto lblEnd; } // Парсинг прерван
            }
            while (cThrWork.cdThreads.Count > 0);

            myStopwatch.Stop();             // Остановка секундомера
            TimeSpan ts = myStopwatch.Elapsed;

            tcMain.SelectedTab = tpResult;  // Активация вкладки Результат
            RefrTabResults();               // Обновить информацию на вкладке
            lsvWords.Focus();

            MessageBox.Show(this, "Completed!\n\n" + "Execution time: " + String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        lblEnd:
            ;

            tspMain.Value = 0;
            tssStatus.Text = "Status: Completed";
            mnuStart.Enabled = true;
            mnuStop.Enabled = false;
        }


        // Меню - Остановка парсинга
        private void mnuStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Stop all threads?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) { return; }

            cThrWork.KillAllThreads(); // Остановить все потоки
        }


        // Таймер для обновления отображаемой информации
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            int iThrCnt = cThrWork.cdThreads.Count(); // Количество работающих потоков
            if (tssThread.Text != "Threads: " + iThrCnt) { tssThread.Text = "Threads: " + iThrCnt; } 

            RefrTabThreads(); // Обновить закладку Потоки
        }


        // Обновить закладку Потоки
        public void RefrTabThreads()
        {
            if (tcMain.SelectedTab.Name != tpThread.Name) { return; }   // Эта вкладка не активна
            if (!cThrWork.bUpdate) { return; }                          // Информация ещё не изменилась

            bool bChange = false; // Нужна принудительная прорисовка listview

            lsvThreads.BeginUpdate();

            for (int i = lsvThreads.Items.Count - 1; i >= 0; i += -1)   // Удаляем из listview закрывшиеся потоки
            {
                Application.DoEvents();

                if (!cThrWork.cdThreads.ContainsKey(lsvThreads.Items[i].Text))
                {
                    lsvThreads.Items[i].Remove(); 
                    bChange = true;
                }
            }

            foreach (KeyValuePair<string, CThreadInfo> oKVP in cThrWork.cdThreads) // Добавляем в listview новые потоки
            {
                Application.DoEvents();

                ListViewItem[] oItems = lsvThreads.Items.Find(oKVP.Key, false);
                if (oItems.Count() > 0) { continue; } // Поток есть в listview           

                ListViewItem oItem = lsvThreads.Items.Add(oKVP.Key, "green");
                oItem.SubItems[0].Name = oKVP.Key;
                oItem.SubItems.Add(oKVP.Value.Start.ToString("G"));
                oItem.SubItems.Add(oKVP.Value.Type);
                oItem.SubItems.Add(oKVP.Value.FilePath);
                bChange = true;
            }

            if (bChange) { lsvThreads.Refresh(); }
            lsvThreads.EndUpdate();
            cThrWork.bUpdate = false;
        }


        // Обновить закладку Результат
        public void RefrTabResults()
        {
            if (tcMain.SelectedTab.Name != tpResult.Name) { return; }   // Эта вкладка не активна           
            if (cThrWork.cdThreads.Count > 0) { return; }               // Ещё не закончили работать потоки

            bool bChange = false; // Нужна принудительная прорисовка listview
            List<KeyValuePair<string, int>> lResult = cThrWork.GetResult((int)nudWordCount.Value); // Получение результата для внесения в listview

            lsvWords.BeginUpdate();
            lsvWords.Items.Clear();

            foreach (KeyValuePair<string, int> oKVP in lResult)
            {
                Application.DoEvents();

                ListViewItem oItem = lsvWords.Items.Add(oKVP.Key, "green");
                oItem.SubItems[0].Name = oKVP.Key;
                oItem.SubItems.Add(oKVP.Key);
                oItem.SubItems.Add(oKVP.Value.ToString());
                bChange = true;
            }

            lblTotal.Text = "Total: " + lsvWords.Items.Count.ToString();

            if (bChange) { lsvWords.Refresh(); }             
            lsvWords.EndUpdate();
        }


        // Копировать результат в буфер обмена
        private void mnuClipboard_Click(object sender, EventArgs e)
        {
            if (lsvWords.Items.Count == 0) { return; } // listview пустой

            string sToClip = "";

            foreach(ListViewItem oItem in lsvWords.Items)
            {
                Application.DoEvents();
                sToClip += oItem.SubItems[1].Text + "\t" + oItem.SubItems[2].Text + Environment.NewLine;
            }  

            try 
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));   // Переключение раскладки
                Clipboard.SetText(sToClip, TextDataFormat.Text);                                            // Заполнение Clipboard
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }


        // Отправить фидбек разработчику
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            //Process.Start("mailto:SBalykov@kng.beeline.ru?subject=" + this.Text);
        
            




        
        
        
        
        }


    }


}


