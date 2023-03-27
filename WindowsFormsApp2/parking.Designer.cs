
namespace WindowsFormsApp2
{
    partial class parking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBlur = new System.Windows.Forms.Button();
            this.numberRecognizebtn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.picresult = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.carnumbertext = new System.Windows.Forms.TextBox();
            this.parkingstatusbtn = new System.Windows.Forms.Button();
            this.parkingstatus = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxserverreply = new System.Windows.Forms.RichTextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.connlabel = new System.Windows.Forms.Label();
            this.entrancebtn = new System.Windows.Forms.Button();
            this.carExitbtn = new System.Windows.Forms.Button();
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxcapture = new System.Windows.Forms.PictureBox();
            this.btncapture = new System.Windows.Forms.Button();
            this.btncctv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxcam = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.datatimelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnBin = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnEdge = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnOCR = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picresult)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcapture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcam)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 845);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBlur);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(6, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 94);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "가우시안";
            // 
            // btnBlur
            // 
            this.btnBlur.BackColor = System.Drawing.Color.Sienna;
            this.btnBlur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlur.FlatAppearance.BorderSize = 0;
            this.btnBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlur.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlur.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlur.Location = new System.Drawing.Point(12, 40);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(150, 37);
            this.btnBlur.TabIndex = 37;
            this.btnBlur.Text = "1단계";
            this.btnBlur.UseVisualStyleBackColor = false;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // numberRecognizebtn
            // 
            this.numberRecognizebtn.BackColor = System.Drawing.Color.Sienna;
            this.numberRecognizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberRecognizebtn.FlatAppearance.BorderSize = 0;
            this.numberRecognizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberRecognizebtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRecognizebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.numberRecognizebtn.Location = new System.Drawing.Point(347, 147);
            this.numberRecognizebtn.Name = "numberRecognizebtn";
            this.numberRecognizebtn.Size = new System.Drawing.Size(145, 42);
            this.numberRecognizebtn.TabIndex = 29;
            this.numberRecognizebtn.Text = "차량 번호인식";
            this.numberRecognizebtn.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.picresult);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Location = new System.Drawing.Point(936, 423);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(405, 400);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CAR";
            // 
            // picresult
            // 
            this.picresult.Location = new System.Drawing.Point(6, 38);
            this.picresult.Name = "picresult";
            this.picresult.Size = new System.Drawing.Size(391, 341);
            this.picresult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picresult.TabIndex = 23;
            this.picresult.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dateTimePicker1);
            this.groupBox8.Controls.Add(this.numberRecognizebtn);
            this.groupBox8.Controls.Add(this.carnumbertext);
            this.groupBox8.Controls.Add(this.parkingstatusbtn);
            this.groupBox8.Controls.Add(this.parkingstatus);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.richTextBoxserverreply);
            this.groupBox8.Controls.Add(this.exitbtn);
            this.groupBox8.Controls.Add(this.connlabel);
            this.groupBox8.Controls.Add(this.entrancebtn);
            this.groupBox8.Controls.Add(this.carExitbtn);
            this.groupBox8.Controls.Add(this.btnServerConnect);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Location = new System.Drawing.Point(12, 106);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(509, 727);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "서버요청";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 47;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // carnumbertext
            // 
            this.carnumbertext.Location = new System.Drawing.Point(201, 95);
            this.carnumbertext.Name = "carnumbertext";
            this.carnumbertext.Size = new System.Drawing.Size(291, 35);
            this.carnumbertext.TabIndex = 46;
            // 
            // parkingstatusbtn
            // 
            this.parkingstatusbtn.BackColor = System.Drawing.Color.Sienna;
            this.parkingstatusbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkingstatusbtn.FlatAppearance.BorderSize = 0;
            this.parkingstatusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingstatusbtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingstatusbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.parkingstatusbtn.Location = new System.Drawing.Point(18, 348);
            this.parkingstatusbtn.Name = "parkingstatusbtn";
            this.parkingstatusbtn.Size = new System.Drawing.Size(186, 47);
            this.parkingstatusbtn.TabIndex = 45;
            this.parkingstatusbtn.Text = "주차현황요청";
            this.parkingstatusbtn.UseVisualStyleBackColor = false;
            this.parkingstatusbtn.Click += new System.EventHandler(this.parkingstatusbtn_Click);
            // 
            // parkingstatus
            // 
            this.parkingstatus.FormattingEnabled = true;
            this.parkingstatus.ItemHeight = 29;
            this.parkingstatus.Location = new System.Drawing.Point(18, 401);
            this.parkingstatus.Name = "parkingstatus";
            this.parkingstatus.Size = new System.Drawing.Size(474, 294);
            this.parkingstatus.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "자동차 번호 :";
            // 
            // richTextBoxserverreply
            // 
            this.richTextBoxserverreply.Location = new System.Drawing.Point(18, 195);
            this.richTextBoxserverreply.Name = "richTextBoxserverreply";
            this.richTextBoxserverreply.Size = new System.Drawing.Size(474, 140);
            this.richTextBoxserverreply.TabIndex = 31;
            this.richTextBoxserverreply.Text = "";
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Sienna;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitbtn.Location = new System.Drawing.Point(342, 34);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(150, 42);
            this.exitbtn.TabIndex = 41;
            this.exitbtn.Text = "연결종료";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // connlabel
            // 
            this.connlabel.AutoSize = true;
            this.connlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.connlabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connlabel.Location = new System.Drawing.Point(194, 36);
            this.connlabel.Name = "connlabel";
            this.connlabel.Size = new System.Drawing.Size(113, 37);
            this.connlabel.TabIndex = 40;
            this.connlabel.Text = "연결상태";
            this.connlabel.Click += new System.EventHandler(this.connlabel_Click);
            // 
            // entrancebtn
            // 
            this.entrancebtn.BackColor = System.Drawing.Color.Sienna;
            this.entrancebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrancebtn.FlatAppearance.BorderSize = 0;
            this.entrancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrancebtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrancebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.entrancebtn.Location = new System.Drawing.Point(18, 142);
            this.entrancebtn.Name = "entrancebtn";
            this.entrancebtn.Size = new System.Drawing.Size(150, 47);
            this.entrancebtn.TabIndex = 34;
            this.entrancebtn.Text = "입차요청";
            this.entrancebtn.UseVisualStyleBackColor = false;
            this.entrancebtn.Click += new System.EventHandler(this.entrancebtn_Click);
            // 
            // carExitbtn
            // 
            this.carExitbtn.BackColor = System.Drawing.Color.Sienna;
            this.carExitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carExitbtn.FlatAppearance.BorderSize = 0;
            this.carExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carExitbtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carExitbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.carExitbtn.Location = new System.Drawing.Point(186, 142);
            this.carExitbtn.Name = "carExitbtn";
            this.carExitbtn.Size = new System.Drawing.Size(150, 47);
            this.carExitbtn.TabIndex = 35;
            this.carExitbtn.Text = "출차요청";
            this.carExitbtn.UseVisualStyleBackColor = false;
            this.carExitbtn.Click += new System.EventHandler(this.carExitbtn_Click);
            // 
            // btnServerConnect
            // 
            this.btnServerConnect.BackColor = System.Drawing.Color.Sienna;
            this.btnServerConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerConnect.FlatAppearance.BorderSize = 0;
            this.btnServerConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerConnect.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnServerConnect.Location = new System.Drawing.Point(18, 34);
            this.btnServerConnect.Name = "btnServerConnect";
            this.btnServerConnect.Size = new System.Drawing.Size(143, 42);
            this.btnServerConnect.TabIndex = 26;
            this.btnServerConnect.Text = "서버 연결";
            this.btnServerConnect.UseVisualStyleBackColor = false;
            this.btnServerConnect.Click += new System.EventHandler(this.btnServerConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btncapture);
            this.groupBox1.Controls.Add(this.btncctv);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(527, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 295);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxcapture);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(409, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 228);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAPTURE";
            // 
            // pictureBoxcapture
            // 
            this.pictureBoxcapture.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxcapture.Name = "pictureBoxcapture";
            this.pictureBoxcapture.Size = new System.Drawing.Size(379, 181);
            this.pictureBoxcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcapture.TabIndex = 24;
            this.pictureBoxcapture.TabStop = false;
            // 
            // btncapture
            // 
            this.btncapture.BackColor = System.Drawing.Color.Sienna;
            this.btncapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapture.FlatAppearance.BorderSize = 0;
            this.btncapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapture.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapture.ForeColor = System.Drawing.SystemColors.Control;
            this.btncapture.Location = new System.Drawing.Point(518, 17);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(168, 38);
            this.btncapture.TabIndex = 25;
            this.btncapture.Text = "이미지 캡쳐";
            this.btncapture.UseVisualStyleBackColor = false;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // btncctv
            // 
            this.btncctv.BackColor = System.Drawing.Color.Sienna;
            this.btncctv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncctv.FlatAppearance.BorderSize = 0;
            this.btncctv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncctv.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncctv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncctv.Location = new System.Drawing.Point(132, 20);
            this.btncctv.Name = "btncctv";
            this.btncctv.Size = new System.Drawing.Size(150, 35);
            this.btncctv.TabIndex = 6;
            this.btncctv.Text = "CCTV";
            this.btncctv.UseVisualStyleBackColor = false;
            this.btncctv.Click += new System.EventHandler(this.btncctv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxcam);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 228);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CCTV";
            // 
            // pictureBoxcam
            // 
            this.pictureBoxcam.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxcam.Name = "pictureBoxcam";
            this.pictureBoxcam.Size = new System.Drawing.Size(379, 187);
            this.pictureBoxcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcam.TabIndex = 23;
            this.pictureBoxcam.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.ExitLabel);
            this.panel2.Controls.Add(this.datatimelabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 100);
            this.panel2.TabIndex = 0;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ExitLabel.Location = new System.Drawing.Point(1313, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(29, 29);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // datatimelabel
            // 
            this.datatimelabel.AutoSize = true;
            this.datatimelabel.BackColor = System.Drawing.Color.AliceBlue;
            this.datatimelabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatimelabel.Location = new System.Drawing.Point(521, 58);
            this.datatimelabel.Name = "datatimelabel";
            this.datatimelabel.Size = new System.Drawing.Size(119, 34);
            this.datatimelabel.TabIndex = 33;
            this.datatimelabel.Text = "날짜/시간";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Login2;
            this.pictureBox1.InitialImage = global::WindowsFormsApp2.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "주차관리 시스템";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox11);
            this.groupBox4.Controls.Add(this.groupBox12);
            this.groupBox4.Controls.Add(this.groupBox13);
            this.groupBox4.Controls.Add(this.groupBox14);
            this.groupBox4.Controls.Add(this.groupBox10);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(533, 408);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 425);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "이미지 처리";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGray);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(210, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 94);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "흑백화";
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.Sienna;
            this.btnGray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGray.FlatAppearance.BorderSize = 0;
            this.btnGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGray.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGray.Location = new System.Drawing.Point(12, 40);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(150, 37);
            this.btnGray.TabIndex = 37;
            this.btnGray.Text = "2단계";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnBin);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox9.Location = new System.Drawing.Point(6, 138);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(175, 94);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "이진화";
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.Color.Sienna;
            this.btnBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBin.FlatAppearance.BorderSize = 0;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBin.Location = new System.Drawing.Point(12, 40);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(150, 37);
            this.btnBin.TabIndex = 37;
            this.btnBin.Text = "3단계";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnEdge);
            this.groupBox10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox10.Location = new System.Drawing.Point(210, 138);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(175, 94);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "경계추출";
            // 
            // btnEdge
            // 
            this.btnEdge.BackColor = System.Drawing.Color.Sienna;
            this.btnEdge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdge.FlatAppearance.BorderSize = 0;
            this.btnEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdge.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdge.Location = new System.Drawing.Point(12, 40);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(150, 37);
            this.btnEdge.TabIndex = 37;
            this.btnEdge.Text = "4단계";
            this.btnEdge.UseVisualStyleBackColor = false;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnOCR);
            this.groupBox12.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox12.Location = new System.Drawing.Point(6, 338);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(175, 81);
            this.groupBox12.TabIndex = 44;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "글자인식";
            // 
            // btnOCR
            // 
            this.btnOCR.BackColor = System.Drawing.Color.Sienna;
            this.btnOCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOCR.FlatAppearance.BorderSize = 0;
            this.btnOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOCR.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOCR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOCR.Location = new System.Drawing.Point(12, 40);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(150, 37);
            this.btnOCR.TabIndex = 37;
            this.btnOCR.Text = "7단계";
            this.btnOCR.UseVisualStyleBackColor = false;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button13);
            this.groupBox13.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox13.Location = new System.Drawing.Point(210, 238);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(175, 94);
            this.groupBox13.TabIndex = 43;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "영역찾기";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Sienna;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(12, 40);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 37);
            this.button13.TabIndex = 37;
            this.button13.Text = "6단계";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button14);
            this.groupBox14.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox14.Location = new System.Drawing.Point(6, 238);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(175, 94);
            this.groupBox14.TabIndex = 42;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "윤곽선찾기";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Sienna;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(12, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 37);
            this.button14.TabIndex = 37;
            this.button14.Text = "5단계";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnReset);
            this.groupBox11.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox11.Location = new System.Drawing.Point(210, 338);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(175, 81);
            this.groupBox11.TabIndex = 45;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "이미지";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Sienna;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(12, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 37);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 845);
            this.Controls.Add(this.panel1);
            this.Name = "parking";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.parking_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picresult)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcapture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncctv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxcapture;
        private System.Windows.Forms.PictureBox pictureBoxcam;
        private System.Windows.Forms.Button btncapture;
        private System.Windows.Forms.Button btnServerConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button numberRecognizebtn;
        private System.Windows.Forms.Label datatimelabel;
        private System.Windows.Forms.RichTextBox richTextBoxserverreply;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button carExitbtn;
        private System.Windows.Forms.Button entrancebtn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label connlabel;
        private System.Windows.Forms.Button parkingstatusbtn;
        private System.Windows.Forms.ListBox parkingstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox carnumbertext;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox picresult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGray;
    }
}