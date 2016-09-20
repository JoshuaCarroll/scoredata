namespace csharp_forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblScoreHome = new System.Windows.Forms.Label();
            this.lblHomeTimeOutsLeft = new System.Windows.Forms.Label();
            this.lblHomePassing = new System.Windows.Forms.Label();
            this.lblHomeRushing = new System.Windows.Forms.Label();
            this.lblHomeTotalYards = new System.Windows.Forms.Label();
            this.lblHomeTimeOfPoss = new System.Windows.Forms.Label();
            this.lblGuestScore = new System.Windows.Forms.Label();
            this.lblGuestTimeOutsLeft = new System.Windows.Forms.Label();
            this.lblGuestPassing = new System.Windows.Forms.Label();
            this.lblGuestRushing = new System.Windows.Forms.Label();
            this.lblGuestTotalYards = new System.Windows.Forms.Label();
            this.lblGuestTimeOfPoss = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblToGo = new System.Windows.Forms.Label();
            this.lblBallOn = new System.Windows.Forms.Label();
            this.lblGuestFirstDowns = new System.Windows.Forms.Label();
            this.lblHomeFirstDowns = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard connected on ";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(152, 6);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(279, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(49, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(362, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 19200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time outs left";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quarter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Down";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "To go";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ball on";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Passing";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Rushing";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total yards";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Time of possession";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Time of possession";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total yards";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Rushing";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(271, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Passing";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(245, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Time outs left";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(279, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Score";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScoreHome
            // 
            this.lblScoreHome.AutoSize = true;
            this.lblScoreHome.Location = new System.Drawing.Point(137, 107);
            this.lblScoreHome.Name = "lblScoreHome";
            this.lblScoreHome.Size = new System.Drawing.Size(41, 13);
            this.lblScoreHome.TabIndex = 22;
            this.lblScoreHome.Text = "label19";
            // 
            // lblHomeTimeOutsLeft
            // 
            this.lblHomeTimeOutsLeft.AutoSize = true;
            this.lblHomeTimeOutsLeft.Location = new System.Drawing.Point(137, 120);
            this.lblHomeTimeOutsLeft.Name = "lblHomeTimeOutsLeft";
            this.lblHomeTimeOutsLeft.Size = new System.Drawing.Size(41, 13);
            this.lblHomeTimeOutsLeft.TabIndex = 23;
            this.lblHomeTimeOutsLeft.Text = "label20";
            // 
            // lblHomePassing
            // 
            this.lblHomePassing.AutoSize = true;
            this.lblHomePassing.Location = new System.Drawing.Point(137, 133);
            this.lblHomePassing.Name = "lblHomePassing";
            this.lblHomePassing.Size = new System.Drawing.Size(41, 13);
            this.lblHomePassing.TabIndex = 24;
            this.lblHomePassing.Text = "label21";
            // 
            // lblHomeRushing
            // 
            this.lblHomeRushing.AutoSize = true;
            this.lblHomeRushing.Location = new System.Drawing.Point(137, 146);
            this.lblHomeRushing.Name = "lblHomeRushing";
            this.lblHomeRushing.Size = new System.Drawing.Size(41, 13);
            this.lblHomeRushing.TabIndex = 25;
            this.lblHomeRushing.Text = "label22";
            // 
            // lblHomeTotalYards
            // 
            this.lblHomeTotalYards.AutoSize = true;
            this.lblHomeTotalYards.Location = new System.Drawing.Point(136, 159);
            this.lblHomeTotalYards.Name = "lblHomeTotalYards";
            this.lblHomeTotalYards.Size = new System.Drawing.Size(41, 13);
            this.lblHomeTotalYards.TabIndex = 26;
            this.lblHomeTotalYards.Text = "label23";
            // 
            // lblHomeTimeOfPoss
            // 
            this.lblHomeTimeOfPoss.AutoSize = true;
            this.lblHomeTimeOfPoss.Location = new System.Drawing.Point(136, 172);
            this.lblHomeTimeOfPoss.Name = "lblHomeTimeOfPoss";
            this.lblHomeTimeOfPoss.Size = new System.Drawing.Size(41, 13);
            this.lblHomeTimeOfPoss.TabIndex = 27;
            this.lblHomeTimeOfPoss.Text = "label24";
            // 
            // lblGuestScore
            // 
            this.lblGuestScore.AutoSize = true;
            this.lblGuestScore.Location = new System.Drawing.Point(320, 107);
            this.lblGuestScore.Name = "lblGuestScore";
            this.lblGuestScore.Size = new System.Drawing.Size(41, 13);
            this.lblGuestScore.TabIndex = 28;
            this.lblGuestScore.Text = "label25";
            // 
            // lblGuestTimeOutsLeft
            // 
            this.lblGuestTimeOutsLeft.AutoSize = true;
            this.lblGuestTimeOutsLeft.Location = new System.Drawing.Point(321, 120);
            this.lblGuestTimeOutsLeft.Name = "lblGuestTimeOutsLeft";
            this.lblGuestTimeOutsLeft.Size = new System.Drawing.Size(41, 13);
            this.lblGuestTimeOutsLeft.TabIndex = 29;
            this.lblGuestTimeOutsLeft.Text = "label26";
            // 
            // lblGuestPassing
            // 
            this.lblGuestPassing.AutoSize = true;
            this.lblGuestPassing.Location = new System.Drawing.Point(321, 133);
            this.lblGuestPassing.Name = "lblGuestPassing";
            this.lblGuestPassing.Size = new System.Drawing.Size(41, 13);
            this.lblGuestPassing.TabIndex = 30;
            this.lblGuestPassing.Text = "label27";
            // 
            // lblGuestRushing
            // 
            this.lblGuestRushing.AutoSize = true;
            this.lblGuestRushing.Location = new System.Drawing.Point(321, 146);
            this.lblGuestRushing.Name = "lblGuestRushing";
            this.lblGuestRushing.Size = new System.Drawing.Size(41, 13);
            this.lblGuestRushing.TabIndex = 31;
            this.lblGuestRushing.Text = "label28";
            // 
            // lblGuestTotalYards
            // 
            this.lblGuestTotalYards.AutoSize = true;
            this.lblGuestTotalYards.Location = new System.Drawing.Point(320, 159);
            this.lblGuestTotalYards.Name = "lblGuestTotalYards";
            this.lblGuestTotalYards.Size = new System.Drawing.Size(41, 13);
            this.lblGuestTotalYards.TabIndex = 32;
            this.lblGuestTotalYards.Text = "label29";
            // 
            // lblGuestTimeOfPoss
            // 
            this.lblGuestTimeOfPoss.AutoSize = true;
            this.lblGuestTimeOfPoss.Location = new System.Drawing.Point(321, 172);
            this.lblGuestTimeOfPoss.Name = "lblGuestTimeOfPoss";
            this.lblGuestTimeOfPoss.Size = new System.Drawing.Size(41, 13);
            this.lblGuestTimeOfPoss.TabIndex = 33;
            this.lblGuestTimeOfPoss.Text = "label30";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(218, 230);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(41, 13);
            this.lblClock.TabIndex = 34;
            this.lblClock.Text = "label31";
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(218, 243);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(41, 13);
            this.lblQuarter.TabIndex = 35;
            this.lblQuarter.Text = "label32";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(218, 276);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(41, 13);
            this.lblDown.TabIndex = 36;
            this.lblDown.Text = "label33";
            // 
            // lblToGo
            // 
            this.lblToGo.AutoSize = true;
            this.lblToGo.Location = new System.Drawing.Point(218, 289);
            this.lblToGo.Name = "lblToGo";
            this.lblToGo.Size = new System.Drawing.Size(41, 13);
            this.lblToGo.TabIndex = 37;
            this.lblToGo.Text = "label34";
            // 
            // lblBallOn
            // 
            this.lblBallOn.AutoSize = true;
            this.lblBallOn.Location = new System.Drawing.Point(218, 302);
            this.lblBallOn.Name = "lblBallOn";
            this.lblBallOn.Size = new System.Drawing.Size(41, 13);
            this.lblBallOn.TabIndex = 38;
            this.lblBallOn.Text = "label35";
            // 
            // lblGuestFirstDowns
            // 
            this.lblGuestFirstDowns.AutoSize = true;
            this.lblGuestFirstDowns.Location = new System.Drawing.Point(321, 185);
            this.lblGuestFirstDowns.Name = "lblGuestFirstDowns";
            this.lblGuestFirstDowns.Size = new System.Drawing.Size(41, 13);
            this.lblGuestFirstDowns.TabIndex = 42;
            this.lblGuestFirstDowns.Text = "label30";
            // 
            // lblHomeFirstDowns
            // 
            this.lblHomeFirstDowns.AutoSize = true;
            this.lblHomeFirstDowns.Location = new System.Drawing.Point(136, 185);
            this.lblHomeFirstDowns.Name = "lblHomeFirstDowns";
            this.lblHomeFirstDowns.Size = new System.Drawing.Size(41, 13);
            this.lblHomeFirstDowns.TabIndex = 41;
            this.lblHomeFirstDowns.Text = "label24";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(253, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "First downs";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(68, 185);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "First downs";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 88);
            this.button1.TabIndex = 43;
            this.button1.Text = "Open test file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGuestFirstDowns);
            this.Controls.Add(this.lblHomeFirstDowns);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblBallOn);
            this.Controls.Add(this.lblToGo);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblQuarter);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblGuestTimeOfPoss);
            this.Controls.Add(this.lblGuestTotalYards);
            this.Controls.Add(this.lblGuestRushing);
            this.Controls.Add(this.lblGuestPassing);
            this.Controls.Add(this.lblGuestTimeOutsLeft);
            this.Controls.Add(this.lblGuestScore);
            this.Controls.Add(this.lblHomeTimeOfPoss);
            this.Controls.Add(this.lblHomeTotalYards);
            this.Controls.Add(this.lblHomeRushing);
            this.Controls.Add(this.lblHomePassing);
            this.Controls.Add(this.lblHomeTimeOutsLeft);
            this.Controls.Add(this.lblScoreHome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbComPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Scoredata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRefresh;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblScoreHome;
        private System.Windows.Forms.Label lblHomeTimeOutsLeft;
        private System.Windows.Forms.Label lblHomePassing;
        private System.Windows.Forms.Label lblHomeRushing;
        private System.Windows.Forms.Label lblHomeTotalYards;
        private System.Windows.Forms.Label lblHomeTimeOfPoss;
        private System.Windows.Forms.Label lblGuestScore;
        private System.Windows.Forms.Label lblGuestTimeOutsLeft;
        private System.Windows.Forms.Label lblGuestPassing;
        private System.Windows.Forms.Label lblGuestRushing;
        private System.Windows.Forms.Label lblGuestTotalYards;
        private System.Windows.Forms.Label lblGuestTimeOfPoss;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblToGo;
        private System.Windows.Forms.Label lblBallOn;
        private System.Windows.Forms.Label lblGuestFirstDowns;
        private System.Windows.Forms.Label lblHomeFirstDowns;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;

    }
}

