
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxserverreply = new System.Windows.Forms.RichTextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.connlabel = new System.Windows.Forms.Label();
            this.entrancebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.btnrecognize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxcarnumber = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxcapture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxcam = new System.Windows.Forms.PictureBox();
            this.btncapture = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.carnumberpb = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.carimagepb = new System.Windows.Forms.PictureBox();
            this.btncctv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.datatimelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carnumbertext = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcarnumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcapture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcam)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carnumberpb)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carimagepb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.btnrecognize);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btncapture);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btncctv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 733);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.carnumbertext);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.listBox1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.richTextBoxserverreply);
            this.groupBox8.Controls.Add(this.exitbtn);
            this.groupBox8.Controls.Add(this.connlabel);
            this.groupBox8.Controls.Add(this.entrancebtn);
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.btnServerConnect);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Location = new System.Drawing.Point(12, 106);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(509, 587);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "서버요청";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(18, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 47);
            this.button2.TabIndex = 45;
            this.button2.Text = "주차현황요청";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(18, 401);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 178);
            this.listBox1.TabIndex = 44;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(186, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "출차요청";
            this.button1.UseVisualStyleBackColor = false;
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
            // btnrecognize
            // 
            this.btnrecognize.BackColor = System.Drawing.Color.Sienna;
            this.btnrecognize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecognize.FlatAppearance.BorderSize = 0;
            this.btnrecognize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecognize.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecognize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrecognize.Location = new System.Drawing.Point(1116, 649);
            this.btnrecognize.Name = "btnrecognize";
            this.btnrecognize.Size = new System.Drawing.Size(168, 44);
            this.btnrecognize.TabIndex = 29;
            this.btnrecognize.Text = "차량 번호인식";
            this.btnrecognize.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxcarnumber);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(936, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 215);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Car Number";
            // 
            // pictureBoxcarnumber
            // 
            this.pictureBoxcarnumber.Location = new System.Drawing.Point(7, 39);
            this.pictureBoxcarnumber.Name = "pictureBoxcarnumber";
            this.pictureBoxcarnumber.Size = new System.Drawing.Size(384, 170);
            this.pictureBoxcarnumber.TabIndex = 0;
            this.pictureBoxcarnumber.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(527, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 252);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxcapture);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(409, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 236);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAPTURE";
            // 
            // pictureBoxcapture
            // 
            this.pictureBoxcapture.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxcapture.Name = "pictureBoxcapture";
            this.pictureBoxcapture.Size = new System.Drawing.Size(379, 195);
            this.pictureBoxcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcapture.TabIndex = 24;
            this.pictureBoxcapture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxcam);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 236);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CCTV";
            // 
            // pictureBoxcam
            // 
            this.pictureBoxcam.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxcam.Name = "pictureBoxcam";
            this.pictureBoxcam.Size = new System.Drawing.Size(379, 195);
            this.pictureBoxcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcam.TabIndex = 23;
            this.pictureBoxcam.TabStop = false;
            // 
            // btncapture
            // 
            this.btncapture.BackColor = System.Drawing.Color.Sienna;
            this.btncapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapture.FlatAppearance.BorderSize = 0;
            this.btncapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapture.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapture.ForeColor = System.Drawing.SystemColors.Control;
            this.btncapture.Location = new System.Drawing.Point(1116, 601);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(168, 41);
            this.btncapture.TabIndex = 25;
            this.btncapture.Text = "이미지 캡쳐";
            this.btncapture.UseVisualStyleBackColor = false;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Location = new System.Drawing.Point(533, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 324);
            this.panel3.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 316);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "입/출차";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.carnumberpb);
            this.groupBox7.Location = new System.Drawing.Point(9, 228);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(361, 75);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "번호판";
            // 
            // carnumberpb
            // 
            this.carnumberpb.Location = new System.Drawing.Point(7, 21);
            this.carnumberpb.Name = "carnumberpb";
            this.carnumberpb.Size = new System.Drawing.Size(348, 50);
            this.carnumberpb.TabIndex = 0;
            this.carnumberpb.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.carimagepb);
            this.groupBox6.Location = new System.Drawing.Point(9, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(361, 201);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "차량이미지";
            // 
            // carimagepb
            // 
            this.carimagepb.Location = new System.Drawing.Point(6, 23);
            this.carimagepb.Name = "carimagepb";
            this.carimagepb.Size = new System.Drawing.Size(349, 164);
            this.carimagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carimagepb.TabIndex = 7;
            this.carimagepb.TabStop = false;
            // 
            // btncctv
            // 
            this.btncctv.BackColor = System.Drawing.Color.Sienna;
            this.btncctv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncctv.FlatAppearance.BorderSize = 0;
            this.btncctv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncctv.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncctv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncctv.Location = new System.Drawing.Point(942, 601);
            this.btncctv.Name = "btncctv";
            this.btncctv.Size = new System.Drawing.Size(150, 39);
            this.btncctv.TabIndex = 6;
            this.btncctv.Text = "CCTV";
            this.btncctv.UseVisualStyleBackColor = false;
            this.btncctv.Click += new System.EventHandler(this.btncctv_Click);
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
            // carnumbertext
            // 
            this.carnumbertext.Location = new System.Drawing.Point(201, 95);
            this.carnumbertext.Name = "carnumbertext";
            this.carnumbertext.Size = new System.Drawing.Size(291, 35);
            this.carnumbertext.TabIndex = 46;
            // 
            // parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 733);
            this.Controls.Add(this.panel1);
            this.Name = "parking";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.parking_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcarnumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcapture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carnumberpb)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carimagepb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox carimagepb;
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
        private System.Windows.Forms.Button btnrecognize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxcarnumber;
        private System.Windows.Forms.Label datatimelabel;
        private System.Windows.Forms.RichTextBox richTextBoxserverreply;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button entrancebtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox carnumberpb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label connlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox carnumbertext;
    }
}