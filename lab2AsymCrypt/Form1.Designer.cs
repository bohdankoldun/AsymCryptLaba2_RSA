namespace lab2AsymCrypt
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.bobN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aliceN = new System.Windows.Forms.TextBox();
            this.aliceD = new System.Windows.Forms.TextBox();
            this.aliceE = new System.Windows.Forms.TextBox();
            this.bobD = new System.Windows.Forms.TextBox();
            this.bobE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lenghtLabel = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.getM = new System.Windows.Forms.Button();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.encryptAlice = new System.Windows.Forms.Button();
            this.encryptBob = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.TextBox();
            this.OpenText = new System.Windows.Forms.TextBox();
            this.decryptBob = new System.Windows.Forms.Button();
            this.decryptAlice = new System.Windows.Forms.Button();
            this.MForSignature = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.signBob = new System.Windows.Forms.Button();
            this.signAlice = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.verifyBob = new System.Windows.Forms.Button();
            this.verifyAlice = new System.Windows.Forms.Button();
            this.verificationBob = new System.Windows.Forms.Label();
            this.verificationAlice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.kBox = new System.Windows.Forms.TextBox();
            this.k1Box = new System.Windows.Forms.TextBox();
            this.SBox = new System.Windows.Forms.TextBox();
            this.generateK = new System.Windows.Forms.Button();
            this.S1Box = new System.Windows.Forms.TextBox();
            this.kBox1 = new System.Windows.Forms.TextBox();
            this.SBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.kBox2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.sendK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genarate Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bobN
            // 
            this.bobN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bobN.Location = new System.Drawing.Point(31, 25);
            this.bobN.Name = "bobN";
            this.bobN.Size = new System.Drawing.Size(885, 20);
            this.bobN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(430, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "e";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "d";
            // 
            // aliceN
            // 
            this.aliceN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aliceN.Location = new System.Drawing.Point(31, 131);
            this.aliceN.Name = "aliceN";
            this.aliceN.Size = new System.Drawing.Size(885, 20);
            this.aliceN.TabIndex = 15;
            // 
            // aliceD
            // 
            this.aliceD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aliceD.Location = new System.Drawing.Point(31, 183);
            this.aliceD.Name = "aliceD";
            this.aliceD.Size = new System.Drawing.Size(885, 20);
            this.aliceD.TabIndex = 16;
            // 
            // aliceE
            // 
            this.aliceE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aliceE.Location = new System.Drawing.Point(31, 157);
            this.aliceE.Name = "aliceE";
            this.aliceE.Size = new System.Drawing.Size(885, 20);
            this.aliceE.TabIndex = 17;
            // 
            // bobD
            // 
            this.bobD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bobD.Location = new System.Drawing.Point(31, 79);
            this.bobD.Name = "bobD";
            this.bobD.Size = new System.Drawing.Size(885, 20);
            this.bobD.TabIndex = 18;
            // 
            // bobE
            // 
            this.bobE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bobE.Location = new System.Drawing.Point(31, 51);
            this.bobE.Name = "bobE";
            this.bobE.Size = new System.Drawing.Size(885, 20);
            this.bobE.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "e";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(12, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "d";
            // 
            // lenghtLabel
            // 
            this.lenghtLabel.AutoSize = true;
            this.lenghtLabel.BackColor = System.Drawing.Color.Yellow;
            this.lenghtLabel.Location = new System.Drawing.Point(194, 219);
            this.lenghtLabel.Name = "lenghtLabel";
            this.lenghtLabel.Size = new System.Drawing.Size(179, 13);
            this.lenghtLabel.TabIndex = 24;
            this.lenghtLabel.Text = "Enter size n in the interval [128,256]:";
            // 
            // lengthBox
            // 
            this.lengthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lengthBox.Location = new System.Drawing.Point(398, 219);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 25;
            this.lengthBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.M.Location = new System.Drawing.Point(31, 246);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(747, 20);
            this.M.TabIndex = 26;
            this.M.Visible = false;
            this.M.TextChanged += new System.EventHandler(this.M_TextChanged);
            // 
            // getM
            // 
            this.getM.Location = new System.Drawing.Point(784, 244);
            this.getM.Name = "getM";
            this.getM.Size = new System.Drawing.Size(169, 23);
            this.getM.TabIndex = 27;
            this.getM.Text = "Generate M";
            this.getM.UseVisualStyleBackColor = true;
            this.getM.Visible = false;
            this.getM.Click += new System.EventHandler(this.getM_Click);
            // 
            // CipherText
            // 
            this.CipherText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CipherText.Location = new System.Drawing.Point(31, 272);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(747, 20);
            this.CipherText.TabIndex = 28;
            this.CipherText.Visible = false;
            // 
            // encryptAlice
            // 
            this.encryptAlice.Location = new System.Drawing.Point(865, 270);
            this.encryptAlice.Name = "encryptAlice";
            this.encryptAlice.Size = new System.Drawing.Size(88, 23);
            this.encryptAlice.TabIndex = 29;
            this.encryptAlice.Text = "Alice Encrypt";
            this.encryptAlice.UseVisualStyleBackColor = true;
            this.encryptAlice.Visible = false;
            this.encryptAlice.Click += new System.EventHandler(this.encryptAlice_Click);
            // 
            // encryptBob
            // 
            this.encryptBob.Location = new System.Drawing.Point(784, 270);
            this.encryptBob.Name = "encryptBob";
            this.encryptBob.Size = new System.Drawing.Size(75, 23);
            this.encryptBob.TabIndex = 31;
            this.encryptBob.Text = "Bob Encrypt ";
            this.encryptBob.UseVisualStyleBackColor = true;
            this.encryptBob.Visible = false;
            this.encryptBob.Click += new System.EventHandler(this.encryptBob_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C.Location = new System.Drawing.Point(31, 311);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(747, 20);
            this.C.TabIndex = 32;
            this.C.Visible = false;
            // 
            // OpenText
            // 
            this.OpenText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OpenText.Location = new System.Drawing.Point(31, 337);
            this.OpenText.Name = "OpenText";
            this.OpenText.Size = new System.Drawing.Size(747, 20);
            this.OpenText.TabIndex = 33;
            this.OpenText.Visible = false;
            // 
            // decryptBob
            // 
            this.decryptBob.Location = new System.Drawing.Point(784, 335);
            this.decryptBob.Name = "decryptBob";
            this.decryptBob.Size = new System.Drawing.Size(75, 23);
            this.decryptBob.TabIndex = 35;
            this.decryptBob.Text = "Bob Decrypt";
            this.decryptBob.UseVisualStyleBackColor = true;
            this.decryptBob.Visible = false;
            this.decryptBob.Click += new System.EventHandler(this.decryptBob_Click);
            // 
            // decryptAlice
            // 
            this.decryptAlice.Location = new System.Drawing.Point(865, 335);
            this.decryptAlice.Name = "decryptAlice";
            this.decryptAlice.Size = new System.Drawing.Size(88, 23);
            this.decryptAlice.TabIndex = 36;
            this.decryptAlice.Text = "Alice Decrypt";
            this.decryptAlice.UseVisualStyleBackColor = true;
            this.decryptAlice.Visible = false;
            this.decryptAlice.Click += new System.EventHandler(this.decryptAlice_Click);
            // 
            // MForSignature
            // 
            this.MForSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MForSignature.Location = new System.Drawing.Point(31, 385);
            this.MForSignature.Name = "MForSignature";
            this.MForSignature.Size = new System.Drawing.Size(747, 20);
            this.MForSignature.TabIndex = 37;
            this.MForSignature.Visible = false;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.S.Location = new System.Drawing.Point(31, 411);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(747, 20);
            this.S.TabIndex = 38;
            this.S.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(9, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "M";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(9, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(9, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "M";
            // 
            // signBob
            // 
            this.signBob.Location = new System.Drawing.Point(784, 409);
            this.signBob.Name = "signBob";
            this.signBob.Size = new System.Drawing.Size(75, 23);
            this.signBob.TabIndex = 43;
            this.signBob.Text = "Bob Sign";
            this.signBob.UseVisualStyleBackColor = true;
            this.signBob.Visible = false;
            this.signBob.Click += new System.EventHandler(this.singBob_Click);
            // 
            // signAlice
            // 
            this.signAlice.Location = new System.Drawing.Point(865, 409);
            this.signAlice.Name = "signAlice";
            this.signAlice.Size = new System.Drawing.Size(88, 23);
            this.signAlice.TabIndex = 44;
            this.signAlice.Text = "Alice Sign";
            this.signAlice.UseVisualStyleBackColor = true;
            this.signAlice.Visible = false;
            this.signAlice.Click += new System.EventHandler(this.signAlice_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(9, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "M";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(9, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "S";
            // 
            // verifyBob
            // 
            this.verifyBob.Location = new System.Drawing.Point(31, 437);
            this.verifyBob.Name = "verifyBob";
            this.verifyBob.Size = new System.Drawing.Size(75, 23);
            this.verifyBob.TabIndex = 47;
            this.verifyBob.Text = "Bob Verify";
            this.verifyBob.UseVisualStyleBackColor = true;
            this.verifyBob.Visible = false;
            this.verifyBob.Click += new System.EventHandler(this.verifyBob_Click);
            // 
            // verifyAlice
            // 
            this.verifyAlice.Location = new System.Drawing.Point(197, 437);
            this.verifyAlice.Name = "verifyAlice";
            this.verifyAlice.Size = new System.Drawing.Size(88, 23);
            this.verifyAlice.TabIndex = 48;
            this.verifyAlice.Text = "Alice Verify";
            this.verifyAlice.UseVisualStyleBackColor = true;
            this.verifyAlice.Visible = false;
            this.verifyAlice.Click += new System.EventHandler(this.verifyAlice_Click);
            // 
            // verificationBob
            // 
            this.verificationBob.AutoSize = true;
            this.verificationBob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verificationBob.ForeColor = System.Drawing.Color.Blue;
            this.verificationBob.Location = new System.Drawing.Point(112, 442);
            this.verificationBob.Name = "verificationBob";
            this.verificationBob.Size = new System.Drawing.Size(31, 15);
            this.verificationBob.TabIndex = 49;
            this.verificationBob.Text = "True";
            this.verificationBob.Visible = false;
            // 
            // verificationAlice
            // 
            this.verificationAlice.AutoSize = true;
            this.verificationAlice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verificationAlice.ForeColor = System.Drawing.Color.Blue;
            this.verificationAlice.Location = new System.Drawing.Point(303, 445);
            this.verificationAlice.Name = "verificationAlice";
            this.verificationAlice.Size = new System.Drawing.Size(31, 15);
            this.verificationAlice.TabIndex = 50;
            this.verificationAlice.Text = "True";
            this.verificationAlice.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Location = new System.Drawing.Point(112, 488);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "Protocol confidential distribution of keys";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.A.ForeColor = System.Drawing.Color.Blue;
            this.A.Location = new System.Drawing.Point(341, 488);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 52;
            this.A.Text = "A";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.B.Location = new System.Drawing.Point(430, 490);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 13);
            this.B.TabIndex = 53;
            this.B.Text = "B";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(385, 490);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "-->";
            // 
            // kBox
            // 
            this.kBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kBox.Location = new System.Drawing.Point(28, 515);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(747, 20);
            this.kBox.TabIndex = 55;
            this.kBox.Visible = false;
            // 
            // k1Box
            // 
            this.k1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.k1Box.Location = new System.Drawing.Point(28, 567);
            this.k1Box.Name = "k1Box";
            this.k1Box.Size = new System.Drawing.Size(747, 20);
            this.k1Box.TabIndex = 56;
            this.k1Box.Visible = false;
            // 
            // SBox
            // 
            this.SBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SBox.Location = new System.Drawing.Point(28, 541);
            this.SBox.Name = "SBox";
            this.SBox.Size = new System.Drawing.Size(747, 20);
            this.SBox.TabIndex = 57;
            this.SBox.Visible = false;
            // 
            // generateK
            // 
            this.generateK.Location = new System.Drawing.Point(478, 485);
            this.generateK.Name = "generateK";
            this.generateK.Size = new System.Drawing.Size(169, 23);
            this.generateK.TabIndex = 58;
            this.generateK.Text = "Generate k ";
            this.generateK.UseVisualStyleBackColor = true;
            this.generateK.Visible = false;
            this.generateK.Click += new System.EventHandler(this.generateK_Click);
            // 
            // S1Box
            // 
            this.S1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.S1Box.Location = new System.Drawing.Point(28, 593);
            this.S1Box.Name = "S1Box";
            this.S1Box.Size = new System.Drawing.Size(747, 20);
            this.S1Box.TabIndex = 60;
            this.S1Box.Visible = false;
            // 
            // kBox1
            // 
            this.kBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kBox1.Location = new System.Drawing.Point(28, 619);
            this.kBox1.Name = "kBox1";
            this.kBox1.Size = new System.Drawing.Size(747, 20);
            this.kBox1.TabIndex = 61;
            this.kBox1.Visible = false;
            // 
            // SBox1
            // 
            this.SBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SBox1.Location = new System.Drawing.Point(28, 645);
            this.SBox1.Name = "SBox1";
            this.SBox1.Size = new System.Drawing.Size(747, 20);
            this.SBox1.TabIndex = 62;
            this.SBox1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(9, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "k";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(8, 545);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "S";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(8, 567);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "k1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(8, 596);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "S1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(12, 622);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 67;
            this.label22.Text = "k";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(12, 645);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "S";
            // 
            // kBox2
            // 
            this.kBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kBox2.Location = new System.Drawing.Point(28, 671);
            this.kBox2.Name = "kBox2";
            this.kBox2.Size = new System.Drawing.Size(747, 20);
            this.kBox2.TabIndex = 69;
            this.kBox2.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(12, 671);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 70;
            this.label24.Text = "k";
            // 
            // sendK
            // 
            this.sendK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sendK.Location = new System.Drawing.Point(491, 485);
            this.sendK.Name = "sendK";
            this.sendK.Size = new System.Drawing.Size(105, 23);
            this.sendK.TabIndex = 71;
            this.sendK.Text = "Send k";
            this.sendK.UseVisualStyleBackColor = false;
            this.sendK.Visible = false;
            this.sendK.Click += new System.EventHandler(this.sendK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 750);
            this.Controls.Add(this.sendK);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.kBox2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SBox1);
            this.Controls.Add(this.kBox1);
            this.Controls.Add(this.S1Box);
            this.Controls.Add(this.generateK);
            this.Controls.Add(this.SBox);
            this.Controls.Add(this.k1Box);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.verificationAlice);
            this.Controls.Add(this.verificationBob);
            this.Controls.Add(this.verifyAlice);
            this.Controls.Add(this.verifyBob);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.signAlice);
            this.Controls.Add(this.signBob);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.S);
            this.Controls.Add(this.MForSignature);
            this.Controls.Add(this.decryptAlice);
            this.Controls.Add(this.decryptBob);
            this.Controls.Add(this.OpenText);
            this.Controls.Add(this.C);
            this.Controls.Add(this.encryptBob);
            this.Controls.Add(this.encryptAlice);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.getM);
            this.Controls.Add(this.M);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.lenghtLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bobE);
            this.Controls.Add(this.bobD);
            this.Controls.Add(this.aliceE);
            this.Controls.Add(this.aliceD);
            this.Controls.Add(this.aliceN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bobN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bobN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aliceD;
        private System.Windows.Forms.TextBox aliceE;
        private System.Windows.Forms.TextBox bobD;
        private System.Windows.Forms.TextBox bobE;
        private System.Windows.Forms.TextBox aliceN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lenghtLabel;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Button getM;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.Button encryptAlice;
        private System.Windows.Forms.Button encryptBob;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox OpenText;
        private System.Windows.Forms.Button decryptBob;
        private System.Windows.Forms.Button decryptAlice;
        private System.Windows.Forms.TextBox MForSignature;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button signBob;
        private System.Windows.Forms.Button signAlice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button verifyBob;
        private System.Windows.Forms.Button verifyAlice;
        private System.Windows.Forms.Label verificationBob;
        private System.Windows.Forms.Label verificationAlice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox kBox;
        private System.Windows.Forms.TextBox k1Box;
        private System.Windows.Forms.TextBox SBox;
        private System.Windows.Forms.Button generateK;
        private System.Windows.Forms.TextBox S1Box;
        private System.Windows.Forms.TextBox kBox1;
        private System.Windows.Forms.TextBox SBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox kBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button sendK;
    }
}

