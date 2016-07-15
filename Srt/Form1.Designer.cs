namespace Srt
{
    partial class srtMakerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(srtMakerForm));
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnAddCaption = new System.Windows.Forms.Button();
            this.txtFromSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromHours = new System.Windows.Forms.TextBox();
            this.txtFromMinutes = new System.Windows.Forms.TextBox();
            this.txtToSeconds = new System.Windows.Forms.TextBox();
            this.txtToHours = new System.Windows.Forms.TextBox();
            this.txtToMinutes = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCtrlQ = new System.Windows.Forms.Button();
            this.btnCtrlW = new System.Windows.Forms.Button();
            this.btnAltE = new System.Windows.Forms.Button();
            this.btnAltR = new System.Windows.Forms.Button();
            this.lblShown = new System.Windows.Forms.Label();
            this.txtFromMilliseconds = new System.Windows.Forms.TextBox();
            this.txtToMilliseconds = new System.Windows.Forms.TextBox();
            this.btnCtrlA = new System.Windows.Forms.Button();
            this.btnCtrlS = new System.Windows.Forms.Button();
            this.btnAltD = new System.Windows.Forms.Button();
            this.btnAltF = new System.Windows.Forms.Button();
            this.dividerOne = new System.Windows.Forms.Label();
            this.dividerTwo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstCaptions = new System.Windows.Forms.ListBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.saveTo = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnShowCaption = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.isSequencial = new System.Windows.Forms.CheckBox();
            this.progSave = new System.Windows.Forms.ProgressBar();
            this.txtShown = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.load = new System.Windows.Forms.Button();
            this.checkInserted = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(14, 124);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(468, 20);
            this.txtString.TabIndex = 0;
            this.txtString.Text = "Type Your Text Here";
            this.txtString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtString_KeyDown);
            // 
            // btnAddCaption
            // 
            this.btnAddCaption.Location = new System.Drawing.Point(326, 27);
            this.btnAddCaption.Name = "btnAddCaption";
            this.btnAddCaption.Size = new System.Drawing.Size(75, 68);
            this.btnAddCaption.TabIndex = 1;
            this.btnAddCaption.Text = "Insert Caption";
            this.btnAddCaption.UseVisualStyleBackColor = true;
            this.btnAddCaption.Click += new System.EventHandler(this.btnAddCaption_Click);
            this.btnAddCaption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddCaption_KeyDown);
            this.btnAddCaption.Validated += new System.EventHandler(this.btnAddCaption_Validated);
            // 
            // txtFromSeconds
            // 
            this.txtFromSeconds.Location = new System.Drawing.Point(90, 69);
            this.txtFromSeconds.MaxLength = 2;
            this.txtFromSeconds.Name = "txtFromSeconds";
            this.txtFromSeconds.Size = new System.Drawing.Size(32, 20);
            this.txtFromSeconds.TabIndex = 8;
            this.txtFromSeconds.Text = "00";
            this.txtFromSeconds.TextChanged += new System.EventHandler(this.txtSeconds_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // txtFromHours
            // 
            this.txtFromHours.Location = new System.Drawing.Point(14, 69);
            this.txtFromHours.MaxLength = 2;
            this.txtFromHours.Name = "txtFromHours";
            this.txtFromHours.Size = new System.Drawing.Size(32, 20);
            this.txtFromHours.TabIndex = 6;
            this.txtFromHours.Text = "00";
            this.txtFromHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtFromMinutes
            // 
            this.txtFromMinutes.Location = new System.Drawing.Point(52, 69);
            this.txtFromMinutes.MaxLength = 2;
            this.txtFromMinutes.Name = "txtFromMinutes";
            this.txtFromMinutes.Size = new System.Drawing.Size(32, 20);
            this.txtFromMinutes.TabIndex = 7;
            this.txtFromMinutes.Text = "00";
            this.txtFromMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // txtToSeconds
            // 
            this.txtToSeconds.Location = new System.Drawing.Point(250, 69);
            this.txtToSeconds.MaxLength = 2;
            this.txtToSeconds.Name = "txtToSeconds";
            this.txtToSeconds.Size = new System.Drawing.Size(32, 20);
            this.txtToSeconds.TabIndex = 12;
            this.txtToSeconds.Text = "00";
            this.txtToSeconds.TextChanged += new System.EventHandler(this.txtSeconds_TextChanged);
            // 
            // txtToHours
            // 
            this.txtToHours.Location = new System.Drawing.Point(174, 69);
            this.txtToHours.MaxLength = 2;
            this.txtToHours.Name = "txtToHours";
            this.txtToHours.Size = new System.Drawing.Size(32, 20);
            this.txtToHours.TabIndex = 10;
            this.txtToHours.Text = "00";
            this.txtToHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtToMinutes
            // 
            this.txtToMinutes.Location = new System.Drawing.Point(212, 69);
            this.txtToMinutes.MaxLength = 2;
            this.txtToMinutes.Name = "txtToMinutes";
            this.txtToMinutes.Size = new System.Drawing.Size(32, 20);
            this.txtToMinutes.TabIndex = 11;
            this.txtToMinutes.Text = "00";
            this.txtToMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(361, 241);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCtrlQ
            // 
            this.btnCtrlQ.Location = new System.Drawing.Point(52, 40);
            this.btnCtrlQ.Name = "btnCtrlQ";
            this.btnCtrlQ.Size = new System.Drawing.Size(32, 23);
            this.btnCtrlQ.TabIndex = 7;
            this.btnCtrlQ.TabStop = false;
            this.btnCtrlQ.Text = "q";
            this.btnCtrlQ.UseVisualStyleBackColor = true;
            this.btnCtrlQ.Click += new System.EventHandler(this.btnCtrlQ_Click);
            this.btnCtrlQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCtrlQ_KeyDown);
            // 
            // btnCtrlW
            // 
            this.btnCtrlW.Location = new System.Drawing.Point(90, 40);
            this.btnCtrlW.Name = "btnCtrlW";
            this.btnCtrlW.Size = new System.Drawing.Size(32, 23);
            this.btnCtrlW.TabIndex = 8;
            this.btnCtrlW.TabStop = false;
            this.btnCtrlW.Text = "w";
            this.btnCtrlW.UseVisualStyleBackColor = true;
            this.btnCtrlW.Click += new System.EventHandler(this.btnCtrlW_Click);
            this.btnCtrlW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCtrlW_KeyDown);
            // 
            // btnAltE
            // 
            this.btnAltE.Location = new System.Drawing.Point(212, 40);
            this.btnAltE.Name = "btnAltE";
            this.btnAltE.Size = new System.Drawing.Size(32, 23);
            this.btnAltE.TabIndex = 7;
            this.btnAltE.TabStop = false;
            this.btnAltE.Text = "e";
            this.btnAltE.UseVisualStyleBackColor = true;
            this.btnAltE.Click += new System.EventHandler(this.btnAltE_Click);
            this.btnAltE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAltE_KeyDown);
            // 
            // btnAltR
            // 
            this.btnAltR.Location = new System.Drawing.Point(250, 40);
            this.btnAltR.Name = "btnAltR";
            this.btnAltR.Size = new System.Drawing.Size(32, 23);
            this.btnAltR.TabIndex = 8;
            this.btnAltR.TabStop = false;
            this.btnAltR.Text = "r";
            this.btnAltR.UseVisualStyleBackColor = true;
            this.btnAltR.Click += new System.EventHandler(this.btnAltR_Click);
            this.btnAltR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAltR_KeyDown);
            // 
            // lblShown
            // 
            this.lblShown.AutoSize = true;
            this.lblShown.Location = new System.Drawing.Point(18, 151);
            this.lblShown.Name = "lblShown";
            this.lblShown.Size = new System.Drawing.Size(0, 13);
            this.lblShown.TabIndex = 9;
            // 
            // txtFromMilliseconds
            // 
            this.txtFromMilliseconds.Location = new System.Drawing.Point(128, 69);
            this.txtFromMilliseconds.MaxLength = 3;
            this.txtFromMilliseconds.Name = "txtFromMilliseconds";
            this.txtFromMilliseconds.Size = new System.Drawing.Size(32, 20);
            this.txtFromMilliseconds.TabIndex = 9;
            this.txtFromMilliseconds.Text = "000";
            this.txtFromMilliseconds.TextChanged += new System.EventHandler(this.txtMilliseconds_TextChanged);
            // 
            // txtToMilliseconds
            // 
            this.txtToMilliseconds.Location = new System.Drawing.Point(288, 69);
            this.txtToMilliseconds.MaxLength = 3;
            this.txtToMilliseconds.Name = "txtToMilliseconds";
            this.txtToMilliseconds.Size = new System.Drawing.Size(32, 20);
            this.txtToMilliseconds.TabIndex = 13;
            this.txtToMilliseconds.Text = "000";
            this.txtToMilliseconds.TextChanged += new System.EventHandler(this.txtMilliseconds_TextChanged);
            // 
            // btnCtrlA
            // 
            this.btnCtrlA.Location = new System.Drawing.Point(52, 95);
            this.btnCtrlA.Name = "btnCtrlA";
            this.btnCtrlA.Size = new System.Drawing.Size(32, 23);
            this.btnCtrlA.TabIndex = 7;
            this.btnCtrlA.TabStop = false;
            this.btnCtrlA.Text = "a";
            this.btnCtrlA.UseVisualStyleBackColor = true;
            this.btnCtrlA.Click += new System.EventHandler(this.btnCtrlA_Click);
            this.btnCtrlA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCtrlQ_KeyDown);
            // 
            // btnCtrlS
            // 
            this.btnCtrlS.Location = new System.Drawing.Point(90, 95);
            this.btnCtrlS.Name = "btnCtrlS";
            this.btnCtrlS.Size = new System.Drawing.Size(32, 23);
            this.btnCtrlS.TabIndex = 8;
            this.btnCtrlS.TabStop = false;
            this.btnCtrlS.Text = "s";
            this.btnCtrlS.UseVisualStyleBackColor = true;
            this.btnCtrlS.Click += new System.EventHandler(this.btnCtrlS_Click);
            this.btnCtrlS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCtrlW_KeyDown);
            // 
            // btnAltD
            // 
            this.btnAltD.Location = new System.Drawing.Point(212, 95);
            this.btnAltD.Name = "btnAltD";
            this.btnAltD.Size = new System.Drawing.Size(32, 23);
            this.btnAltD.TabIndex = 7;
            this.btnAltD.TabStop = false;
            this.btnAltD.Text = "d";
            this.btnAltD.UseVisualStyleBackColor = true;
            this.btnAltD.Click += new System.EventHandler(this.btnAltD_Click);
            this.btnAltD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAltE_KeyDown);
            // 
            // btnAltF
            // 
            this.btnAltF.Location = new System.Drawing.Point(250, 95);
            this.btnAltF.Name = "btnAltF";
            this.btnAltF.Size = new System.Drawing.Size(32, 23);
            this.btnAltF.TabIndex = 8;
            this.btnAltF.TabStop = false;
            this.btnAltF.Text = "f";
            this.btnAltF.UseVisualStyleBackColor = true;
            this.btnAltF.Click += new System.EventHandler(this.btnAltF_Click);
            this.btnAltF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAltR_KeyDown);
            // 
            // dividerOne
            // 
            this.dividerOne.AutoSize = true;
            this.dividerOne.Location = new System.Drawing.Point(44, 72);
            this.dividerOne.Name = "dividerOne";
            this.dividerOne.Size = new System.Drawing.Size(10, 13);
            this.dividerOne.TabIndex = 10;
            this.dividerOne.Text = ":";
            // 
            // dividerTwo
            // 
            this.dividerTwo.AutoSize = true;
            this.dividerTwo.Location = new System.Drawing.Point(82, 72);
            this.dividerTwo.Name = "dividerTwo";
            this.dividerTwo.Size = new System.Drawing.Size(10, 13);
            this.dividerTwo.TabIndex = 11;
            this.dividerTwo.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(407, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnReturnBack_Click);
            this.btnPrevious.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrevious_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(407, 50);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnReturnBack_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNext_KeyDown);
            // 
            // lstCaptions
            // 
            this.lstCaptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCaptions.FormattingEnabled = true;
            this.lstCaptions.Location = new System.Drawing.Point(14, 241);
            this.lstCaptions.Name = "lstCaptions";
            this.lstCaptions.Size = new System.Drawing.Size(341, 108);
            this.lstCaptions.TabIndex = 14;
            this.lstCaptions.SelectedIndexChanged += new System.EventHandler(this.lstCaptions_SelectedIndexChanged);
            this.lstCaptions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstCaptions_KeyDown);
            this.lstCaptions.Validated += new System.EventHandler(this.lstCaptions_Validated);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(361, 181);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(130, 24);
            this.btnShowList.TabIndex = 5;
            this.btnShowList.Text = "Show the list (optional)";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShowList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnShowList_KeyDown);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(407, 101);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 15;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            this.btnReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReplace_KeyDown);
            // 
            // saveTo
            // 
            this.saveTo.Location = new System.Drawing.Point(361, 270);
            this.saveTo.Name = "saveTo";
            this.saveTo.Size = new System.Drawing.Size(72, 23);
            this.saveTo.TabIndex = 16;
            this.saveTo.Text = "Save to";
            this.saveTo.UseVisualStyleBackColor = true;
            this.saveTo.Click += new System.EventHandler(this.saveTo_Click);
            this.saveTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saveTo_KeyDown);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(361, 299);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(130, 20);
            this.txtFileName.TabIndex = 17;
            this.txtFileName.Text = "Filename";
            // 
            // btnShowCaption
            // 
            this.btnShowCaption.Location = new System.Drawing.Point(361, 151);
            this.btnShowCaption.Name = "btnShowCaption";
            this.btnShowCaption.Size = new System.Drawing.Size(130, 24);
            this.btnShowCaption.TabIndex = 5;
            this.btnShowCaption.Text = "Show Caption (optional)";
            this.btnShowCaption.UseVisualStyleBackColor = true;
            this.btnShowCaption.Click += new System.EventHandler(this.btnShowCaption_Click);
            this.btnShowCaption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnShowCaption_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(407, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // isSequencial
            // 
            this.isSequencial.AutoSize = true;
            this.isSequencial.Checked = true;
            this.isSequencial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isSequencial.Location = new System.Drawing.Point(326, 101);
            this.isSequencial.Name = "isSequencial";
            this.isSequencial.Size = new System.Drawing.Size(79, 17);
            this.isSequencial.TabIndex = 19;
            this.isSequencial.Text = "Sequencial";
            this.isSequencial.UseVisualStyleBackColor = true;
            // 
            // progSave
            // 
            this.progSave.Location = new System.Drawing.Point(361, 325);
            this.progSave.Name = "progSave";
            this.progSave.Size = new System.Drawing.Size(130, 23);
            this.progSave.Step = 1;
            this.progSave.TabIndex = 20;
            // 
            // txtShown
            // 
            this.txtShown.Location = new System.Drawing.Point(14, 151);
            this.txtShown.Multiline = true;
            this.txtShown.Name = "txtShown";
            this.txtShown.Size = new System.Drawing.Size(341, 61);
            this.txtShown.TabIndex = 21;
            this.txtShown.Text = "Your Caption Displays Here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "List Index:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "ShCtr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.createToolStripMenuItem.Text = "Create New";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadToolStripMenuItem.Text = "Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(439, 270);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(52, 23);
            this.load.TabIndex = 25;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            this.load.KeyDown += new System.Windows.Forms.KeyEventHandler(this.load_KeyDown);
            // 
            // checkInserted
            // 
            this.checkInserted.AutoSize = true;
            this.checkInserted.Location = new System.Drawing.Point(14, 218);
            this.checkInserted.Name = "checkInserted";
            this.checkInserted.Size = new System.Drawing.Size(164, 17);
            this.checkInserted.TabIndex = 26;
            this.checkInserted.Text = "Auto-choose inserted caption";
            this.checkInserted.UseVisualStyleBackColor = true;
            // 
            // srtMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 359);
            this.Controls.Add(this.checkInserted);
            this.Controls.Add(this.load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShown);
            this.Controls.Add(this.progSave);
            this.Controls.Add(this.isSequencial);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.saveTo);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnShowCaption);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lstCaptions);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblShown);
            this.Controls.Add(this.btnAltF);
            this.Controls.Add(this.btnAltR);
            this.Controls.Add(this.btnCtrlS);
            this.Controls.Add(this.btnCtrlW);
            this.Controls.Add(this.btnAltD);
            this.Controls.Add(this.btnAltE);
            this.Controls.Add(this.btnCtrlA);
            this.Controls.Add(this.btnCtrlQ);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtToMinutes);
            this.Controls.Add(this.txtFromMinutes);
            this.Controls.Add(this.txtFromHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToHours);
            this.Controls.Add(this.txtToMilliseconds);
            this.Controls.Add(this.txtToSeconds);
            this.Controls.Add(this.txtFromMilliseconds);
            this.Controls.Add(this.txtFromSeconds);
            this.Controls.Add(this.btnAddCaption);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dividerOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dividerTwo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.Name = "srtMakerForm";
            this.Text = "Sealkeen Srt Composer";
            this.Load += new System.EventHandler(this.srtMakerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnAddCaption;
        private System.Windows.Forms.TextBox txtFromSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromHours;
        private System.Windows.Forms.TextBox txtFromMinutes;
        private System.Windows.Forms.TextBox txtToSeconds;
        private System.Windows.Forms.TextBox txtToHours;
        private System.Windows.Forms.TextBox txtToMinutes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCtrlQ;
        private System.Windows.Forms.Button btnCtrlW;
        private System.Windows.Forms.Button btnAltE;
        private System.Windows.Forms.Button btnAltR;
        private System.Windows.Forms.Label lblShown;
        private System.Windows.Forms.TextBox txtFromMilliseconds;
        private System.Windows.Forms.TextBox txtToMilliseconds;
        private System.Windows.Forms.Button btnCtrlA;
        private System.Windows.Forms.Button btnCtrlS;
        private System.Windows.Forms.Button btnAltD;
        private System.Windows.Forms.Button btnAltF;
        private System.Windows.Forms.Label dividerOne;
        private System.Windows.Forms.Label dividerTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstCaptions;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button saveTo;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnShowCaption;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox isSequencial;
        private System.Windows.Forms.ProgressBar progSave;
        private System.Windows.Forms.TextBox txtShown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkInserted;
    }
}

