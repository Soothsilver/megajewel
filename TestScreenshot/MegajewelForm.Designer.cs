namespace Megajewel
{
    partial class MegajewelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pictureBoxOverview = new System.Windows.Forms.PictureBox();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaptureX = new System.Windows.Forms.TextBox();
            this.txtCaptureY = new System.Windows.Forms.TextBox();
            this.txtCaptureWidth = new System.Windows.Forms.TextBox();
            this.txtCaptureHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDebugLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAutoGAC = new System.Windows.Forms.CheckBox();
            this.rbDirect3D9 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D10 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D11 = new System.Windows.Forms.RadioButton();
            this.cbDrawOverlay = new System.Windows.Forms.CheckBox();
            this.rbAutodetect = new System.Windows.Forms.RadioButton();
            this.rbDirect3D10_1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResizeHeight = new System.Windows.Forms.TextBox();
            this.txtResizeWidth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.screenshottingTimer = new System.Windows.Forms.Timer(this.components);
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAutonomousStrategy = new System.Windows.Forms.ComboBox();
            this.cbRecognitionStrategy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bRecalcHisto = new System.Windows.Forms.Button();
            this.bTeachUnrecognized = new System.Windows.Forms.Button();
            this.lblTeachingQueue = new System.Windows.Forms.Label();
            this.bLearnAll = new System.Windows.Forms.Button();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.bSaveScreenshot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPaused = new System.Windows.Forms.Label();
            this.lblBejeweledActive = new System.Windows.Forms.Label();
            this.lblAutonomous = new System.Windows.Forms.Label();
            this.btnInject = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fullTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxGrid = new System.Windows.Forms.PictureBox();
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbTeachAuxiliary = new System.Windows.Forms.ComboBox();
            this.pictureBoxTeachingHistogram = new System.Windows.Forms.PictureBox();
            this.bSaveDatabase = new System.Windows.Forms.Button();
            this.bStartTeaching = new System.Windows.Forms.Button();
            this.bForget = new System.Windows.Forms.Button();
            this.bTeach = new System.Windows.Forms.Button();
            this.cbChooseColor = new System.Windows.Forms.ComboBox();
            this.pictureboxTeaching = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bReloadDB = new System.Windows.Forms.Button();
            this.bSaveKnowledgeToDisk2 = new System.Windows.Forms.Button();
            this.pictureBoxKnowledgeBase = new System.Windows.Forms.PictureBox();
            this.lblMineCleared = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverview)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeachingHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTeaching)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnowledgeBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Enabled = false;
            this.btnCapture.Location = new System.Drawing.Point(113, 52);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 41);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Request Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pictureBoxOverview
            // 
            this.pictureBoxOverview.Location = new System.Drawing.Point(879, 533);
            this.pictureBoxOverview.Name = "pictureBoxOverview";
            this.pictureBoxOverview.Size = new System.Drawing.Size(168, 105);
            this.pictureBoxOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOverview.TabIndex = 2;
            this.pictureBoxOverview.TabStop = false;
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Enabled = false;
            this.btnLoadTest.Location = new System.Drawing.Point(112, 109);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTest.TabIndex = 3;
            this.btnLoadTest.Text = "Load Test";
            this.btnLoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTest.Click += new System.EventHandler(this.btnLoadTest_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.Text = "100";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // txtCaptureX
            // 
            this.txtCaptureX.Location = new System.Drawing.Point(43, 180);
            this.txtCaptureX.Name = "txtCaptureX";
            this.txtCaptureX.Size = new System.Drawing.Size(47, 20);
            this.txtCaptureX.TabIndex = 11;
            this.txtCaptureX.Text = "0";
            // 
            // txtCaptureY
            // 
            this.txtCaptureY.Location = new System.Drawing.Point(140, 180);
            this.txtCaptureY.Name = "txtCaptureY";
            this.txtCaptureY.Size = new System.Drawing.Size(47, 20);
            this.txtCaptureY.TabIndex = 12;
            this.txtCaptureY.Text = "0";
            // 
            // txtCaptureWidth
            // 
            this.txtCaptureWidth.Location = new System.Drawing.Point(43, 206);
            this.txtCaptureWidth.Name = "txtCaptureWidth";
            this.txtCaptureWidth.Size = new System.Drawing.Size(47, 20);
            this.txtCaptureWidth.TabIndex = 13;
            this.txtCaptureWidth.Text = "0";
            // 
            // txtCaptureHeight
            // 
            this.txtCaptureHeight.Location = new System.Drawing.Point(140, 206);
            this.txtCaptureHeight.Name = "txtCaptureHeight";
            this.txtCaptureHeight.Size = new System.Drawing.Size(47, 20);
            this.txtCaptureHeight.TabIndex = 14;
            this.txtCaptureHeight.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Width of 0 means capture full window";
            // 
            // txtDebugLog
            // 
            this.txtDebugLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDebugLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugLog.Location = new System.Drawing.Point(0, 518);
            this.txtDebugLog.Multiline = true;
            this.txtDebugLog.Name = "txtDebugLog";
            this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugLog.Size = new System.Drawing.Size(1090, 142);
            this.txtDebugLog.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "EXE Name of Direct3D Application:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Capture Multiple:";
            // 
            // cbAutoGAC
            // 
            this.cbAutoGAC.AutoSize = true;
            this.cbAutoGAC.Location = new System.Drawing.Point(5, 381);
            this.cbAutoGAC.Name = "cbAutoGAC";
            this.cbAutoGAC.Size = new System.Drawing.Size(179, 17);
            this.cbAutoGAC.TabIndex = 25;
            this.cbAutoGAC.Text = "Auto register GAC (run as admin)";
            this.cbAutoGAC.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D9
            // 
            this.rbDirect3D9.AutoSize = true;
            this.rbDirect3D9.Location = new System.Drawing.Point(93, 312);
            this.rbDirect3D9.Name = "rbDirect3D9";
            this.rbDirect3D9.Size = new System.Drawing.Size(76, 17);
            this.rbDirect3D9.TabIndex = 21;
            this.rbDirect3D9.Text = "Direct3D 9";
            this.rbDirect3D9.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D10
            // 
            this.rbDirect3D10.AutoSize = true;
            this.rbDirect3D10.Location = new System.Drawing.Point(10, 335);
            this.rbDirect3D10.Name = "rbDirect3D10";
            this.rbDirect3D10.Size = new System.Drawing.Size(82, 17);
            this.rbDirect3D10.TabIndex = 22;
            this.rbDirect3D10.Text = "Direct3D 10";
            this.rbDirect3D10.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D11
            // 
            this.rbDirect3D11.AutoSize = true;
            this.rbDirect3D11.Location = new System.Drawing.Point(10, 358);
            this.rbDirect3D11.Name = "rbDirect3D11";
            this.rbDirect3D11.Size = new System.Drawing.Size(82, 17);
            this.rbDirect3D11.TabIndex = 24;
            this.rbDirect3D11.Text = "Direct3D 11";
            this.rbDirect3D11.UseVisualStyleBackColor = true;
            // 
            // cbDrawOverlay
            // 
            this.cbDrawOverlay.AutoSize = true;
            this.cbDrawOverlay.Checked = true;
            this.cbDrawOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDrawOverlay.Location = new System.Drawing.Point(5, 404);
            this.cbDrawOverlay.Name = "cbDrawOverlay";
            this.cbDrawOverlay.Size = new System.Drawing.Size(90, 17);
            this.cbDrawOverlay.TabIndex = 26;
            this.cbDrawOverlay.Text = "Draw Overlay";
            this.cbDrawOverlay.UseVisualStyleBackColor = true;
            // 
            // rbAutodetect
            // 
            this.rbAutodetect.AutoSize = true;
            this.rbAutodetect.Checked = true;
            this.rbAutodetect.Location = new System.Drawing.Point(10, 312);
            this.rbAutodetect.Name = "rbAutodetect";
            this.rbAutodetect.Size = new System.Drawing.Size(77, 17);
            this.rbAutodetect.TabIndex = 20;
            this.rbAutodetect.TabStop = true;
            this.rbAutodetect.Text = "Autodetect";
            this.rbAutodetect.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D10_1
            // 
            this.rbDirect3D10_1.AutoSize = true;
            this.rbDirect3D10_1.Location = new System.Drawing.Point(93, 335);
            this.rbDirect3D10_1.Name = "rbDirect3D10_1";
            this.rbDirect3D10_1.Size = new System.Drawing.Size(91, 17);
            this.rbDirect3D10_1.TabIndex = 23;
            this.rbDirect3D10_1.Text = "Direct3D 10.1";
            this.rbDirect3D10_1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "REGION:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "RESIZE:";
            // 
            // txtResizeHeight
            // 
            this.txtResizeHeight.Location = new System.Drawing.Point(140, 258);
            this.txtResizeHeight.Name = "txtResizeHeight";
            this.txtResizeHeight.Size = new System.Drawing.Size(47, 20);
            this.txtResizeHeight.TabIndex = 32;
            // 
            // txtResizeWidth
            // 
            this.txtResizeWidth.Location = new System.Drawing.Point(43, 258);
            this.txtResizeWidth.Name = "txtResizeWidth";
            this.txtResizeWidth.Size = new System.Drawing.Size(47, 20);
            this.txtResizeWidth.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Height";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Width";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "FORMAT:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "Bitmap",
            "Jpeg",
            "Png",
            "PixelData"});
            this.cmbFormat.Location = new System.Drawing.Point(65, 285);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbFormat.TabIndex = 34;
            this.cmbFormat.Text = "Bitmap";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Request Delayed Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // screenshottingTimer
            // 
            this.screenshottingTimer.Enabled = true;
            this.screenshottingTimer.Interval = 20;
            this.screenshottingTimer.Tick += new System.EventHandler(this.delayedTimer_Tick);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(204, 518);
            this.tabMenu.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.cbAutonomousStrategy);
            this.tabPage1.Controls.Add(this.cbRecognitionStrategy);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cbMode);
            this.tabPage1.Controls.Add(this.bSaveScreenshot);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnInject);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(196, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(3, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 66);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Help";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tab: Toggle autonomy\r\n[hold] Shift: Pause\r\nH: Print \"Hello\" to console\r\n";
            // 
            // cbAutonomousStrategy
            // 
            this.cbAutonomousStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutonomousStrategy.FormattingEnabled = true;
            this.cbAutonomousStrategy.Location = new System.Drawing.Point(6, 118);
            this.cbAutonomousStrategy.Name = "cbAutonomousStrategy";
            this.cbAutonomousStrategy.Size = new System.Drawing.Size(184, 21);
            this.cbAutonomousStrategy.TabIndex = 10;
            this.cbAutonomousStrategy.SelectedIndexChanged += new System.EventHandler(this.cbAutonomousStrategy_SelectedIndexChanged);
            // 
            // cbRecognitionStrategy
            // 
            this.cbRecognitionStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecognitionStrategy.FormattingEnabled = true;
            this.cbRecognitionStrategy.Location = new System.Drawing.Point(6, 91);
            this.cbRecognitionStrategy.Name = "cbRecognitionStrategy";
            this.cbRecognitionStrategy.Size = new System.Drawing.Size(184, 21);
            this.cbRecognitionStrategy.TabIndex = 9;
            this.cbRecognitionStrategy.SelectedIndexChanged += new System.EventHandler(this.cbRecognitionStrategy_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bRecalcHisto);
            this.groupBox2.Controls.Add(this.bTeachUnrecognized);
            this.groupBox2.Controls.Add(this.lblTeachingQueue);
            this.groupBox2.Controls.Add(this.bLearnAll);
            this.groupBox2.Location = new System.Drawing.Point(3, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teaching";
            // 
            // bRecalcHisto
            // 
            this.bRecalcHisto.Location = new System.Drawing.Point(8, 77);
            this.bRecalcHisto.Name = "bRecalcHisto";
            this.bRecalcHisto.Size = new System.Drawing.Size(173, 23);
            this.bRecalcHisto.TabIndex = 8;
            this.bRecalcHisto.Text = "Recalculate Histograms";
            this.bRecalcHisto.UseVisualStyleBackColor = true;
            this.bRecalcHisto.Click += new System.EventHandler(this.bRecalcHisto_Click);
            // 
            // bTeachUnrecognized
            // 
            this.bTeachUnrecognized.Location = new System.Drawing.Point(8, 48);
            this.bTeachUnrecognized.Name = "bTeachUnrecognized";
            this.bTeachUnrecognized.Size = new System.Drawing.Size(173, 23);
            this.bTeachUnrecognized.TabIndex = 7;
            this.bTeachUnrecognized.Text = "Teach Worst";
            this.bTeachUnrecognized.UseVisualStyleBackColor = true;
            this.bTeachUnrecognized.Click += new System.EventHandler(this.bTeachUnrecognized_Click);
            // 
            // lblTeachingQueue
            // 
            this.lblTeachingQueue.AutoSize = true;
            this.lblTeachingQueue.Location = new System.Drawing.Point(15, 106);
            this.lblTeachingQueue.Name = "lblTeachingQueue";
            this.lblTeachingQueue.Size = new System.Drawing.Size(58, 13);
            this.lblTeachingQueue.TabIndex = 2;
            this.lblTeachingQueue.Text = "Lessons: 0";
            // 
            // bLearnAll
            // 
            this.bLearnAll.Location = new System.Drawing.Point(8, 19);
            this.bLearnAll.Name = "bLearnAll";
            this.bLearnAll.Size = new System.Drawing.Size(173, 23);
            this.bLearnAll.TabIndex = 6;
            this.bLearnAll.Text = "Teach All";
            this.bLearnAll.UseVisualStyleBackColor = true;
            this.bLearnAll.Click += new System.EventHandler(this.bLearnAll_Click);
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(6, 64);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(184, 21);
            this.cbMode.TabIndex = 5;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // bSaveScreenshot
            // 
            this.bSaveScreenshot.Location = new System.Drawing.Point(6, 35);
            this.bSaveScreenshot.Name = "bSaveScreenshot";
            this.bSaveScreenshot.Size = new System.Drawing.Size(184, 23);
            this.bSaveScreenshot.TabIndex = 4;
            this.bSaveScreenshot.Text = "Save Screenshot";
            this.bSaveScreenshot.UseVisualStyleBackColor = true;
            this.bSaveScreenshot.Click += new System.EventHandler(this.bSaveScreenshot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMineCleared);
            this.groupBox1.Controls.Add(this.lblPaused);
            this.groupBox1.Controls.Add(this.lblBejeweledActive);
            this.groupBox1.Controls.Add(this.lblAutonomous);
            this.groupBox1.Location = new System.Drawing.Point(3, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblPaused
            // 
            this.lblPaused.AutoSize = true;
            this.lblPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaused.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPaused.Location = new System.Drawing.Point(15, 63);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(129, 13);
            this.lblPaused.TabIndex = 5;
            this.lblPaused.Text = "Megajewel is paused!";
            // 
            // lblBejeweledActive
            // 
            this.lblBejeweledActive.AutoSize = true;
            this.lblBejeweledActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBejeweledActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBejeweledActive.Location = new System.Drawing.Point(15, 17);
            this.lblBejeweledActive.Name = "lblBejeweledActive";
            this.lblBejeweledActive.Size = new System.Drawing.Size(152, 13);
            this.lblBejeweledActive.TabIndex = 4;
            this.lblBejeweledActive.Text = "Bejeweled is in the foreground.";
            // 
            // lblAutonomous
            // 
            this.lblAutonomous.AutoSize = true;
            this.lblAutonomous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomous.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAutonomous.Location = new System.Drawing.Point(15, 39);
            this.lblAutonomous.Name = "lblAutonomous";
            this.lblAutonomous.Size = new System.Drawing.Size(141, 13);
            this.lblAutonomous.TabIndex = 3;
            this.lblAutonomous.Text = "Megajewel is in control!";
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(6, 6);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(184, 23);
            this.btnInject.TabIndex = 1;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cmbFormat);
            this.tabPage2.Controls.Add(this.btnCapture);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnLoadTest);
            this.tabPage2.Controls.Add(this.txtResizeHeight);
            this.tabPage2.Controls.Add(this.txtNumber);
            this.tabPage2.Controls.Add(this.txtResizeWidth);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rbDirect3D10_1);
            this.tabPage2.Controls.Add(this.txtCaptureX);
            this.tabPage2.Controls.Add(this.rbAutodetect);
            this.tabPage2.Controls.Add(this.txtCaptureY);
            this.tabPage2.Controls.Add(this.cbDrawOverlay);
            this.tabPage2.Controls.Add(this.txtCaptureWidth);
            this.tabPage2.Controls.Add(this.rbDirect3D11);
            this.tabPage2.Controls.Add(this.txtCaptureHeight);
            this.tabPage2.Controls.Add(this.rbDirect3D10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.rbDirect3D9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbAutoGAC);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(196, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Legacy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fullTimer
            // 
            this.fullTimer.Enabled = true;
            this.fullTimer.Interval = 1;
            this.fullTimer.Tick += new System.EventHandler(this.fullTimer_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmaps|*.bmp";
            this.saveFileDialog1.Title = "Save as...";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(204, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(886, 518);
            this.tabMain.TabIndex = 37;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxGrid);
            this.tabPage3.Controls.Add(this.pictureBoxField);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGrid
            // 
            this.pictureBoxGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxGrid.Location = new System.Drawing.Point(460, 6);
            this.pictureBoxGrid.Name = "pictureBoxGrid";
            this.pictureBoxGrid.Size = new System.Drawing.Size(325, 325);
            this.pictureBoxGrid.TabIndex = 1;
            this.pictureBoxGrid.TabStop = false;
            this.pictureBoxGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGrid_Paint);
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxField.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(448, 448);
            this.pictureBoxField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxField.TabIndex = 0;
            this.pictureBoxField.TabStop = false;
            this.pictureBoxField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxField_Paint);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbTeachAuxiliary);
            this.tabPage4.Controls.Add(this.pictureBoxTeachingHistogram);
            this.tabPage4.Controls.Add(this.bSaveDatabase);
            this.tabPage4.Controls.Add(this.bStartTeaching);
            this.tabPage4.Controls.Add(this.bForget);
            this.tabPage4.Controls.Add(this.bTeach);
            this.tabPage4.Controls.Add(this.cbChooseColor);
            this.tabPage4.Controls.Add(this.pictureboxTeaching);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(878, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Teach";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbTeachAuxiliary
            // 
            this.cbTeachAuxiliary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeachAuxiliary.FormattingEnabled = true;
            this.cbTeachAuxiliary.Location = new System.Drawing.Point(184, 194);
            this.cbTeachAuxiliary.Name = "cbTeachAuxiliary";
            this.cbTeachAuxiliary.Size = new System.Drawing.Size(121, 21);
            this.cbTeachAuxiliary.TabIndex = 7;
            // 
            // pictureBoxTeachingHistogram
            // 
            this.pictureBoxTeachingHistogram.Location = new System.Drawing.Point(383, 48);
            this.pictureBoxTeachingHistogram.Name = "pictureBoxTeachingHistogram";
            this.pictureBoxTeachingHistogram.Size = new System.Drawing.Size(456, 381);
            this.pictureBoxTeachingHistogram.TabIndex = 6;
            this.pictureBoxTeachingHistogram.TabStop = false;
            this.pictureBoxTeachingHistogram.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTeachingHistogram_Paint);
            // 
            // bSaveDatabase
            // 
            this.bSaveDatabase.Location = new System.Drawing.Point(76, 310);
            this.bSaveDatabase.Name = "bSaveDatabase";
            this.bSaveDatabase.Size = new System.Drawing.Size(229, 23);
            this.bSaveDatabase.TabIndex = 5;
            this.bSaveDatabase.Text = "Save Knowledge Base To Disk";
            this.bSaveDatabase.UseVisualStyleBackColor = true;
            this.bSaveDatabase.Click += new System.EventHandler(this.bSaveDatabase_Click);
            // 
            // bStartTeaching
            // 
            this.bStartTeaching.Location = new System.Drawing.Point(77, 35);
            this.bStartTeaching.Name = "bStartTeaching";
            this.bStartTeaching.Size = new System.Drawing.Size(169, 23);
            this.bStartTeaching.TabIndex = 4;
            this.bStartTeaching.Text = "Start Teaching";
            this.bStartTeaching.UseVisualStyleBackColor = true;
            this.bStartTeaching.Click += new System.EventHandler(this.bStartTeaching_Click);
            // 
            // bForget
            // 
            this.bForget.Location = new System.Drawing.Point(230, 222);
            this.bForget.Name = "bForget";
            this.bForget.Size = new System.Drawing.Size(75, 23);
            this.bForget.TabIndex = 3;
            this.bForget.Text = "Forget";
            this.bForget.UseVisualStyleBackColor = true;
            this.bForget.Click += new System.EventHandler(this.bForget_Click);
            // 
            // bTeach
            // 
            this.bTeach.Location = new System.Drawing.Point(103, 221);
            this.bTeach.Name = "bTeach";
            this.bTeach.Size = new System.Drawing.Size(121, 24);
            this.bTeach.TabIndex = 2;
            this.bTeach.Text = "Teach";
            this.bTeach.UseVisualStyleBackColor = true;
            this.bTeach.Click += new System.EventHandler(this.bTeach_Click);
            // 
            // cbChooseColor
            // 
            this.cbChooseColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseColor.FormattingEnabled = true;
            this.cbChooseColor.Location = new System.Drawing.Point(58, 194);
            this.cbChooseColor.Name = "cbChooseColor";
            this.cbChooseColor.Size = new System.Drawing.Size(121, 21);
            this.cbChooseColor.TabIndex = 1;
            // 
            // pictureboxTeaching
            // 
            this.pictureboxTeaching.Location = new System.Drawing.Point(103, 68);
            this.pictureboxTeaching.Name = "pictureboxTeaching";
            this.pictureboxTeaching.Size = new System.Drawing.Size(121, 120);
            this.pictureboxTeaching.TabIndex = 0;
            this.pictureboxTeaching.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bReloadDB);
            this.tabPage5.Controls.Add(this.bSaveKnowledgeToDisk2);
            this.tabPage5.Controls.Add(this.pictureBoxKnowledgeBase);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(878, 492);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Knowledge Base";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bReloadDB
            // 
            this.bReloadDB.Location = new System.Drawing.Point(256, 452);
            this.bReloadDB.Name = "bReloadDB";
            this.bReloadDB.Size = new System.Drawing.Size(157, 23);
            this.bReloadDB.TabIndex = 7;
            this.bReloadDB.Text = "Reload Knowledge Base";
            this.bReloadDB.UseVisualStyleBackColor = true;
            this.bReloadDB.Click += new System.EventHandler(this.bReloadDB_Click);
            // 
            // bSaveKnowledgeToDisk2
            // 
            this.bSaveKnowledgeToDisk2.Location = new System.Drawing.Point(21, 452);
            this.bSaveKnowledgeToDisk2.Name = "bSaveKnowledgeToDisk2";
            this.bSaveKnowledgeToDisk2.Size = new System.Drawing.Size(229, 23);
            this.bSaveKnowledgeToDisk2.TabIndex = 6;
            this.bSaveKnowledgeToDisk2.Text = "Save Knowledge Base To Disk";
            this.bSaveKnowledgeToDisk2.UseVisualStyleBackColor = true;
            this.bSaveKnowledgeToDisk2.Click += new System.EventHandler(this.bSaveDatabase_Click);
            // 
            // pictureBoxKnowledgeBase
            // 
            this.pictureBoxKnowledgeBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxKnowledgeBase.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxKnowledgeBase.Name = "pictureBoxKnowledgeBase";
            this.pictureBoxKnowledgeBase.Size = new System.Drawing.Size(872, 486);
            this.pictureBoxKnowledgeBase.TabIndex = 0;
            this.pictureBoxKnowledgeBase.TabStop = false;
            this.pictureBoxKnowledgeBase.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxKnowledgeBase_Paint);
            this.pictureBoxKnowledgeBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxKnowledgeBase_MouseClick);
            // 
            // lblMineCleared
            // 
            this.lblMineCleared.AutoSize = true;
            this.lblMineCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineCleared.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMineCleared.Location = new System.Drawing.Point(15, 82);
            this.lblMineCleared.Name = "lblMineCleared";
            this.lblMineCleared.Size = new System.Drawing.Size(138, 13);
            this.lblMineCleared.TabIndex = 6;
            this.lblMineCleared.Text = "Diamond Mine Cleared!";
            // 
            // MegajewelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 660);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pictureBoxOverview);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.txtDebugLog);
            this.Controls.Add(this.label1);
            this.Name = "MegajewelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Megajewel Bot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverview)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeachingHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTeaching)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnowledgeBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnLoadTest;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaptureX;
        private System.Windows.Forms.TextBox txtCaptureY;
        private System.Windows.Forms.TextBox txtCaptureWidth;
        private System.Windows.Forms.TextBox txtCaptureHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAutoGAC;
        private System.Windows.Forms.RadioButton rbDirect3D9;
        private System.Windows.Forms.RadioButton rbDirect3D10;
        private System.Windows.Forms.RadioButton rbDirect3D11;
        private System.Windows.Forms.CheckBox cbDrawOverlay;
        private System.Windows.Forms.RadioButton rbAutodetect;
        private System.Windows.Forms.RadioButton rbDirect3D10_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResizeHeight;
        private System.Windows.Forms.TextBox txtResizeWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer screenshottingTimer;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer fullTimer;
        public System.Windows.Forms.PictureBox pictureBoxOverview;
        private System.Windows.Forms.Button bSaveScreenshot;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.PictureBox pictureBoxField;
        public System.Windows.Forms.TextBox txtDebugLog;
        public System.Windows.Forms.PictureBox pictureBoxGrid;
        private System.Windows.Forms.Button bLearnAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bTeachUnrecognized;
        private System.Windows.Forms.Label lblTeachingQueue;
        private System.Windows.Forms.Button bForget;
        private System.Windows.Forms.Button bTeach;
        private System.Windows.Forms.ComboBox cbChooseColor;
        public System.Windows.Forms.PictureBox pictureboxTeaching;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.PictureBox pictureBoxKnowledgeBase;
        private System.Windows.Forms.Button bStartTeaching;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbAutonomousStrategy;
        private System.Windows.Forms.ComboBox cbRecognitionStrategy;
        private System.Windows.Forms.Button bSaveDatabase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Label lblBejeweledActive;
        private System.Windows.Forms.Label lblAutonomous;
        private System.Windows.Forms.Button bSaveKnowledgeToDisk2;
        private System.Windows.Forms.Button bReloadDB;
        public System.Windows.Forms.PictureBox pictureBoxTeachingHistogram;
        private System.Windows.Forms.Button bRecalcHisto;
        private System.Windows.Forms.ComboBox cbTeachAuxiliary;
        private System.Windows.Forms.Label lblMineCleared;
    }
}

