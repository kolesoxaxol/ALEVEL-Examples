namespace MySportSimulator
{
    partial class TeamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCoach = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.pbTeamLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.lbRating = new System.Windows.Forms.Label();
            this.btAddPalyer = new System.Windows.Forms.Button();
            this.btRenameTeam = new System.Windows.Forms.Button();
            this.btChangeCoach = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btLoadLogo = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // lbCoach
            // 
            this.lbCoach.AutoSize = true;
            this.lbCoach.Location = new System.Drawing.Point(79, 47);
            this.lbCoach.Name = "lbCoach";
            this.lbCoach.Size = new System.Drawing.Size(81, 13);
            this.lbCoach.TabIndex = 1;
            this.lbCoach.Text = "Фамилия Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Рейтинг";
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(13, 124);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(197, 199);
            this.lstPlayers.Sorted = true;
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.DoubleClick += new System.EventHandler(this.lstPlayers_DoubleClick);
            // 
            // pbTeamLogo
            // 
            this.pbTeamLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeamLogo.Location = new System.Drawing.Point(227, 9);
            this.pbTeamLogo.Name = "pbTeamLogo";
            this.pbTeamLogo.Size = new System.Drawing.Size(114, 111);
            this.pbTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeamLogo.TabIndex = 2;
            this.pbTeamLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Тренер:";
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Location = new System.Drawing.Point(79, 9);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(35, 13);
            this.lbTeamName.TabIndex = 0;
            this.lbTeamName.Text = "label1";
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(79, 82);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(48, 13);
            this.lbRating.TabIndex = 1;
            this.lbRating.Text = "Рейтинг";
            // 
            // btAddPalyer
            // 
            this.btAddPalyer.Location = new System.Drawing.Point(226, 205);
            this.btAddPalyer.Name = "btAddPalyer";
            this.btAddPalyer.Size = new System.Drawing.Size(115, 29);
            this.btAddPalyer.TabIndex = 3;
            this.btAddPalyer.Text = "Добавить игрока";
            this.btAddPalyer.UseVisualStyleBackColor = true;
            this.btAddPalyer.Click += new System.EventHandler(this.btAddPalyer_Click);
            // 
            // btRenameTeam
            // 
            this.btRenameTeam.Location = new System.Drawing.Point(227, 135);
            this.btRenameTeam.Name = "btRenameTeam";
            this.btRenameTeam.Size = new System.Drawing.Size(114, 29);
            this.btRenameTeam.TabIndex = 3;
            this.btRenameTeam.Text = "Переименовать";
            this.btRenameTeam.UseVisualStyleBackColor = true;
            this.btRenameTeam.Click += new System.EventHandler(this.btRenameTeam_Click);
            // 
            // btChangeCoach
            // 
            this.btChangeCoach.Location = new System.Drawing.Point(227, 170);
            this.btChangeCoach.Name = "btChangeCoach";
            this.btChangeCoach.Size = new System.Drawing.Size(114, 29);
            this.btChangeCoach.TabIndex = 3;
            this.btChangeCoach.Text = "Сменить тренера";
            this.btChangeCoach.UseVisualStyleBackColor = true;
            this.btChangeCoach.Click += new System.EventHandler(this.btChangeCoach_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(227, 294);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(114, 29);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btLoadLogo
            // 
            this.btLoadLogo.Location = new System.Drawing.Point(226, 240);
            this.btLoadLogo.Name = "btLoadLogo";
            this.btLoadLogo.Size = new System.Drawing.Size(115, 29);
            this.btLoadLogo.TabIndex = 3;
            this.btLoadLogo.Text = "Загрузить логотип";
            this.btLoadLogo.UseVisualStyleBackColor = true;
            this.btLoadLogo.Click += new System.EventHandler(this.btLoadLogo_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Файлы изображений(*.bmp, *.jpg)|*.bmp;*.jpg";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 337);
            this.Controls.Add(this.btChangeCoach);
            this.Controls.Add(this.btRenameTeam);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btLoadLogo);
            this.Controls.Add(this.btAddPalyer);
            this.Controls.Add(this.pbTeamLogo);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCoach);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCoach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.PictureBox pbTeamLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Button btAddPalyer;
        private System.Windows.Forms.Button btRenameTeam;
        private System.Windows.Forms.Button btChangeCoach;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btLoadLogo;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
    }
}