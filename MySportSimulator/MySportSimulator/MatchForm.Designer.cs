namespace MySportSimulator
{
    partial class MatchForm
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
            this.pbLogoTeam2 = new System.Windows.Forms.PictureBox();
            this.pbLogoTeam1 = new System.Windows.Forms.PictureBox();
            this.lbNameTeam2 = new System.Windows.Forms.Label();
            this.lbNameTeam1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbFansCountTeam2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFansCountTeam1 = new System.Windows.Forms.Label();
            this.lbReferee = new System.Windows.Forms.Label();
            this.lbChances = new System.Windows.Forms.Label();
            this.matchTimer = new System.Windows.Forms.Timer(this.components);
            this.rtbMatchLog = new System.Windows.Forms.RichTextBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoTeam2
            // 
            this.pbLogoTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoTeam2.Location = new System.Drawing.Point(479, 25);
            this.pbLogoTeam2.Name = "pbLogoTeam2";
            this.pbLogoTeam2.Size = new System.Drawing.Size(139, 155);
            this.pbLogoTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoTeam2.TabIndex = 0;
            this.pbLogoTeam2.TabStop = false;
            // 
            // pbLogoTeam1
            // 
            this.pbLogoTeam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoTeam1.Location = new System.Drawing.Point(15, 25);
            this.pbLogoTeam1.Name = "pbLogoTeam1";
            this.pbLogoTeam1.Size = new System.Drawing.Size(139, 155);
            this.pbLogoTeam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoTeam1.TabIndex = 0;
            this.pbLogoTeam1.TabStop = false;
            // 
            // lbNameTeam2
            // 
            this.lbNameTeam2.Location = new System.Drawing.Point(395, 9);
            this.lbNameTeam2.Name = "lbNameTeam2";
            this.lbNameTeam2.Size = new System.Drawing.Size(223, 13);
            this.lbNameTeam2.TabIndex = 1;
            this.lbNameTeam2.Text = "Команда 2";
            this.lbNameTeam2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbNameTeam1
            // 
            this.lbNameTeam1.Location = new System.Drawing.Point(12, 9);
            this.lbNameTeam1.Name = "lbNameTeam1";
            this.lbNameTeam1.Size = new System.Drawing.Size(223, 13);
            this.lbNameTeam1.TabIndex = 1;
            this.lbNameTeam1.Text = "Команда 1";
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.Location = new System.Drawing.Point(163, 35);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(310, 76);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "0 : 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(160, 111);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(313, 31);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(160, 376);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(97, 42);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Начать матч";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(266, 376);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(97, 42);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Приостановить матч";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(375, 376);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(97, 42);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbFansCountTeam2
            // 
            this.lbFansCountTeam2.Location = new System.Drawing.Point(482, 212);
            this.lbFansCountTeam2.Name = "lbFansCountTeam2";
            this.lbFansCountTeam2.Size = new System.Drawing.Size(139, 13);
            this.lbFansCountTeam2.TabIndex = 1;
            this.lbFansCountTeam2.Text = "0000000";
            this.lbFansCountTeam2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(482, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Фанаты:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Фанаты:";
            // 
            // lbFansCountTeam1
            // 
            this.lbFansCountTeam1.Location = new System.Drawing.Point(12, 212);
            this.lbFansCountTeam1.Name = "lbFansCountTeam1";
            this.lbFansCountTeam1.Size = new System.Drawing.Size(142, 13);
            this.lbFansCountTeam1.TabIndex = 1;
            this.lbFansCountTeam1.Text = "000000";
            // 
            // lbReferee
            // 
            this.lbReferee.Location = new System.Drawing.Point(160, 156);
            this.lbReferee.Name = "lbReferee";
            this.lbReferee.Size = new System.Drawing.Size(313, 13);
            this.lbReferee.TabIndex = 6;
            this.lbReferee.Text = "Главный судья: Иванов И.И.";
            this.lbReferee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbChances
            // 
            this.lbChances.Location = new System.Drawing.Point(160, 9);
            this.lbChances.Name = "lbChances";
            this.lbChances.Size = new System.Drawing.Size(313, 13);
            this.lbChances.TabIndex = 6;
            this.lbChances.Text = "Прогноз 50:50";
            this.lbChances.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // matchTimer
            // 
            this.matchTimer.Interval = 18;
            this.matchTimer.Tick += new System.EventHandler(this.matchTimer_Tick);
            // 
            // rtbMatchLog
            // 
            this.rtbMatchLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMatchLog.Location = new System.Drawing.Point(157, 189);
            this.rtbMatchLog.Name = "rtbMatchLog";
            this.rtbMatchLog.ReadOnly = true;
            this.rtbMatchLog.Size = new System.Drawing.Size(319, 181);
            this.rtbMatchLog.TabIndex = 7;
            this.rtbMatchLog.Text = "";
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 1;
            this.tbSpeed.Location = new System.Drawing.Point(427, 41);
            this.tbSpeed.Maximum = 4;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeed.Size = new System.Drawing.Size(45, 139);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbSpeed.Value = 4;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Скорость:";
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.rtbMatchLog);
            this.Controls.Add(this.lbNameTeam1);
            this.Controls.Add(this.lbNameTeam2);
            this.Controls.Add(this.lbChances);
            this.Controls.Add(this.lbReferee);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbFansCountTeam1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFansCountTeam2);
            this.Controls.Add(this.pbLogoTeam1);
            this.Controls.Add(this.pbLogoTeam2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoTeam2;
        private System.Windows.Forms.PictureBox pbLogoTeam1;
        private System.Windows.Forms.Label lbNameTeam2;
        private System.Windows.Forms.Label lbNameTeam1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbFansCountTeam2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFansCountTeam1;
        private System.Windows.Forms.Label lbReferee;
        private System.Windows.Forms.Label lbChances;
        private System.Windows.Forms.Timer matchTimer;
        private System.Windows.Forms.RichTextBox rtbMatchLog;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label1;
    }
}