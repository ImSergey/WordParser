namespace WordParser
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSett = new System.Windows.Forms.TabPage();
            this.cmbFileExt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudThreadsCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWordLen = new System.Windows.Forms.NumericUpDown();
            this.nudWordCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tpThread = new System.Windows.Forms.TabPage();
            this.lsvThreads = new System.Windows.Forms.ListView();
            this.ThID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpResult = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lsvWords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMain16 = new System.Windows.Forms.ImageList(this.components);
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssThread = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tssFilesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.picSumm = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpSett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordCount)).BeginInit();
            this.tpThread.SuspendLayout();
            this.tpResult.SuspendLayout();
            this.cmnuList.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSumm)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpSett);
            this.tcMain.Controls.Add(this.tpThread);
            this.tcMain.Controls.Add(this.tpResult);
            this.tcMain.ItemSize = new System.Drawing.Size(183, 18);
            this.tcMain.Location = new System.Drawing.Point(2, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(582, 394);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 0;
            // 
            // tpSett
            // 
            this.tpSett.Controls.Add(this.btnFeedback);
            this.tpSett.Controls.Add(this.cmbFileExt);
            this.tpSett.Controls.Add(this.label6);
            this.tpSett.Controls.Add(this.nudThreadsCount);
            this.tpSett.Controls.Add(this.label5);
            this.tpSett.Controls.Add(this.label4);
            this.tpSett.Controls.Add(this.label3);
            this.tpSett.Controls.Add(this.label2);
            this.tpSett.Controls.Add(this.nudWordLen);
            this.tpSett.Controls.Add(this.nudWordCount);
            this.tpSett.Controls.Add(this.label1);
            this.tpSett.Location = new System.Drawing.Point(4, 22);
            this.tpSett.Name = "tpSett";
            this.tpSett.Size = new System.Drawing.Size(574, 368);
            this.tpSett.TabIndex = 2;
            this.tpSett.Text = "       Settings";
            this.tpSett.UseVisualStyleBackColor = true;
            // 
            // cmbFileExt
            // 
            this.cmbFileExt.FormattingEnabled = true;
            this.cmbFileExt.Items.AddRange(new object[] {
            "*.txt",
            "*.*"});
            this.cmbFileExt.Location = new System.Drawing.Point(117, 22);
            this.cmbFileExt.Name = "cmbFileExt";
            this.cmbFileExt.Size = new System.Drawing.Size(56, 21);
            this.cmbFileExt.TabIndex = 2;
            this.cmbFileExt.Text = "*.*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "File extension";
            // 
            // nudThreadsCount
            // 
            this.nudThreadsCount.Location = new System.Drawing.Point(117, 75);
            this.nudThreadsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudThreadsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudThreadsCount.Name = "nudThreadsCount";
            this.nudThreadsCount.Size = new System.Drawing.Size(56, 20);
            this.nudThreadsCount.TabIndex = 9;
            this.nudThreadsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudThreadsCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = " threads at a time.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Run no more than ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = " letters.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "words longer ( > ) than ";
            // 
            // nudWordLen
            // 
            this.nudWordLen.Location = new System.Drawing.Point(300, 49);
            this.nudWordLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWordLen.Name = "nudWordLen";
            this.nudWordLen.Size = new System.Drawing.Size(56, 20);
            this.nudWordLen.TabIndex = 6;
            this.nudWordLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWordLen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudWordCount
            // 
            this.nudWordCount.Location = new System.Drawing.Point(117, 49);
            this.nudWordCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWordCount.Name = "nudWordCount";
            this.nudWordCount.Size = new System.Drawing.Size(56, 20);
            this.nudWordCount.TabIndex = 4;
            this.nudWordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWordCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for";
            // 
            // tpThread
            // 
            this.tpThread.Controls.Add(this.lsvThreads);
            this.tpThread.Location = new System.Drawing.Point(4, 22);
            this.tpThread.Name = "tpThread";
            this.tpThread.Padding = new System.Windows.Forms.Padding(3);
            this.tpThread.Size = new System.Drawing.Size(574, 364);
            this.tpThread.TabIndex = 0;
            this.tpThread.Text = "       Threads";
            this.tpThread.UseVisualStyleBackColor = true;
            // 
            // lsvThreads
            // 
            this.lsvThreads.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lsvThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvThreads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThID_,
            this.ThStart,
            this.ThType,
            this.ThPath});
            this.lsvThreads.FullRowSelect = true;
            this.lsvThreads.GridLines = true;
            this.lsvThreads.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvThreads.HideSelection = false;
            this.lsvThreads.Location = new System.Drawing.Point(3, 3);
            this.lsvThreads.MultiSelect = false;
            this.lsvThreads.Name = "lsvThreads";
            this.lsvThreads.ShowItemToolTips = true;
            this.lsvThreads.Size = new System.Drawing.Size(568, 361);
            this.lsvThreads.TabIndex = 0;
            this.lsvThreads.Tag = "-1";
            this.lsvThreads.UseCompatibleStateImageBehavior = false;
            this.lsvThreads.View = System.Windows.Forms.View.Details;
            // 
            // ThID_
            // 
            this.ThID_.Tag = "noresize";
            this.ThID_.Text = "";
            this.ThID_.Width = 10;
            // 
            // ThStart
            // 
            this.ThStart.Tag = "noresize";
            this.ThStart.Text = "Start";
            this.ThStart.Width = 120;
            // 
            // ThType
            // 
            this.ThType.Text = "Type";
            this.ThType.Width = 80;
            // 
            // ThPath
            // 
            this.ThPath.Text = "FilePath";
            this.ThPath.Width = 330;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.lblTotal);
            this.tpResult.Controls.Add(this.picSumm);
            this.tpResult.Controls.Add(this.label7);
            this.tpResult.Controls.Add(this.lsvWords);
            this.tpResult.Location = new System.Drawing.Point(4, 22);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tpResult.Size = new System.Drawing.Size(574, 364);
            this.tpResult.TabIndex = 1;
            this.tpResult.Text = "       Result";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(257, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Please use the right mouse button to copy the list.";
            // 
            // lsvWords
            // 
            this.lsvWords.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lsvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lsvWords.ContextMenuStrip = this.cmnuList;
            this.lsvWords.FullRowSelect = true;
            this.lsvWords.GridLines = true;
            this.lsvWords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvWords.HideSelection = false;
            this.lsvWords.Location = new System.Drawing.Point(3, 3);
            this.lsvWords.MultiSelect = false;
            this.lsvWords.Name = "lsvWords";
            this.lsvWords.ShowItemToolTips = true;
            this.lsvWords.Size = new System.Drawing.Size(568, 334);
            this.lsvWords.TabIndex = 6;
            this.lsvWords.Tag = "-1";
            this.lsvWords.UseCompatibleStateImageBehavior = false;
            this.lsvWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "noresize";
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 10;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "noresize";
            this.columnHeader2.Text = "Word";
            this.columnHeader2.Width = 440;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Count";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // cmnuList
            // 
            this.cmnuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClipboard});
            this.cmnuList.Name = "cmnuList";
            this.cmnuList.Size = new System.Drawing.Size(172, 26);
            // 
            // mnuClipboard
            // 
            this.mnuClipboard.Name = "mnuClipboard";
            this.mnuClipboard.Size = new System.Drawing.Size(171, 22);
            this.mnuClipboard.Text = "Copy to Clipboard";
            this.mnuClipboard.Click += new System.EventHandler(this.mnuClipboard_Click);
            // 
            // imgMain16
            // 
            this.imgMain16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMain16.ImageStream")));
            this.imgMain16.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMain16.Images.SetKeyName(0, "play");
            this.imgMain16.Images.SetKeyName(1, "stop");
            this.imgMain16.Images.SetKeyName(2, "execute");
            this.imgMain16.Images.SetKeyName(3, "list");
            this.imgMain16.Images.SetKeyName(4, "settings");
            this.imgMain16.Images.SetKeyName(5, "green");
            this.imgMain16.Images.SetKeyName(6, "bullets");
            this.imgMain16.Images.SetKeyName(7, "date_time");
            this.imgMain16.Images.SetKeyName(8, "folder");
            this.imgMain16.Images.SetKeyName(9, "info");
            this.imgMain16.Images.SetKeyName(10, "count");
            this.imgMain16.Images.SetKeyName(11, "word");
            this.imgMain16.Images.SetKeyName(12, "copy");
            this.imgMain16.Images.SetKeyName(13, "summ");
            this.imgMain16.Images.SetKeyName(14, "mail");
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssThread,
            this.tspMain,
            this.tssFilesCount});
            this.ssMain.Location = new System.Drawing.Point(0, 424);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(584, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.AutoSize = false;
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(130, 17);
            this.tssStatus.Text = "Status: Ready";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssThread
            // 
            this.tssThread.AutoSize = false;
            this.tssThread.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssThread.Name = "tssThread";
            this.tssThread.Size = new System.Drawing.Size(100, 17);
            this.tssThread.Text = "Threads: 0";
            this.tssThread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspMain
            // 
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(200, 16);
            // 
            // tssFilesCount
            // 
            this.tssFilesCount.AutoSize = false;
            this.tssFilesCount.Name = "tssFilesCount";
            this.tssFilesCount.Size = new System.Drawing.Size(100, 17);
            this.tssFilesCount.Text = "File: 0 / 0";
            this.tssFilesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(584, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip2";
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(74, 20);
            this.mnuStart.Text = "Start Parse";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Enabled = false;
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(74, 20);
            this.mnuStop.Text = "Stop Parse";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // picSumm
            // 
            this.picSumm.Location = new System.Drawing.Point(6, 343);
            this.picSumm.Name = "picSumm";
            this.picSumm.Size = new System.Drawing.Size(17, 17);
            this.picSumm.TabIndex = 8;
            this.picSumm.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: 0";
            // 
            // btnFeedback
            // 
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(428, 330);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(121, 25);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "Send Feedback  ";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordParser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpSett.ResumeLayout(false);
            this.tpSett.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordCount)).EndInit();
            this.tpThread.ResumeLayout(false);
            this.tpResult.ResumeLayout(false);
            this.tpResult.PerformLayout();
            this.cmnuList.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSumm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpThread;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.ImageList imgMain16;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.TabPage tpSett;
        internal System.Windows.Forms.ListView lsvThreads;
        internal System.Windows.Forms.ColumnHeader ThID_;
        internal System.Windows.Forms.ColumnHeader ThStart;
        internal System.Windows.Forms.ColumnHeader ThType;
        internal System.Windows.Forms.ColumnHeader ThPath;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssThread;
        internal System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStripProgressBar tspMain;
        private System.Windows.Forms.NumericUpDown nudWordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWordLen;
        private System.Windows.Forms.NumericUpDown nudThreadsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel tssFilesCount;
        internal System.Windows.Forms.ListView lsvWords;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbFileExt;
        private System.Windows.Forms.ContextMenuStrip cmnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuClipboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSumm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFeedback;
    }
}

