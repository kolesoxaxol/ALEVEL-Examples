namespace MySportSimulator
{
    partial class CoachForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbskill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btChangeName = new System.Windows.Forms.Button();
            this.btChangeSkill = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(61, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(77, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Некий тренер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя:";
            // 
            // lbskill
            // 
            this.lbskill.AutoSize = true;
            this.lbskill.Location = new System.Drawing.Point(61, 48);
            this.lbskill.Name = "lbskill";
            this.lbskill.Size = new System.Drawing.Size(19, 13);
            this.lbskill.TabIndex = 3;
            this.lbskill.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Скилл:";
            // 
            // btChangeName
            // 
            this.btChangeName.Location = new System.Drawing.Point(247, 9);
            this.btChangeName.Name = "btChangeName";
            this.btChangeName.Size = new System.Drawing.Size(121, 26);
            this.btChangeName.TabIndex = 5;
            this.btChangeName.Text = "Сменить имя";
            this.btChangeName.UseVisualStyleBackColor = true;
            this.btChangeName.Click += new System.EventHandler(this.btChangeName_Click);
            // 
            // btChangeSkill
            // 
            this.btChangeSkill.Location = new System.Drawing.Point(247, 41);
            this.btChangeSkill.Name = "btChangeSkill";
            this.btChangeSkill.Size = new System.Drawing.Size(121, 26);
            this.btChangeSkill.TabIndex = 6;
            this.btChangeSkill.Text = "Изменить скилл";
            this.btChangeSkill.UseVisualStyleBackColor = true;
            this.btChangeSkill.Click += new System.EventHandler(this.btChangeSkill_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(247, 73);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 26);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // CoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 108);
            this.ControlBox = false;
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btChangeSkill);
            this.Controls.Add(this.btChangeName);
            this.Controls.Add(this.lbskill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CoachForm";
            this.Text = "Тренер команды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbskill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btChangeName;
        private System.Windows.Forms.Button btChangeSkill;
        private System.Windows.Forms.Button btClose;
    }
}