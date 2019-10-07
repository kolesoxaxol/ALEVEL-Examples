namespace MySportSimulator
{
    partial class PlayerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbSkill = new System.Windows.Forms.Label();
            this.lbHealth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btChangeName = new System.Windows.Forms.Button();
            this.btChangeAge = new System.Windows.Forms.Button();
            this.btChangeSkill = new System.Windows.Forms.Button();
            this.btChangeHealth = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Скилл:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Здоровье:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(92, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Вася Пупкин";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(92, 51);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(19, 13);
            this.lbAge.TabIndex = 0;
            this.lbAge.Text = "20";
            // 
            // lbSkill
            // 
            this.lbSkill.AutoSize = true;
            this.lbSkill.Location = new System.Drawing.Point(92, 83);
            this.lbSkill.Name = "lbSkill";
            this.lbSkill.Size = new System.Drawing.Size(19, 13);
            this.lbSkill.TabIndex = 0;
            this.lbSkill.Text = "25";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(92, 115);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(25, 13);
            this.lbHealth.TabIndex = 0;
            this.lbHealth.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Позиция:";
            // 
            // btChangeName
            // 
            this.btChangeName.Location = new System.Drawing.Point(223, 12);
            this.btChangeName.Name = "btChangeName";
            this.btChangeName.Size = new System.Drawing.Size(121, 26);
            this.btChangeName.TabIndex = 1;
            this.btChangeName.Text = "Сменить имя";
            this.btChangeName.UseVisualStyleBackColor = true;
            this.btChangeName.Click += new System.EventHandler(this.btChangeName_Click);
            // 
            // btChangeAge
            // 
            this.btChangeAge.Location = new System.Drawing.Point(222, 44);
            this.btChangeAge.Name = "btChangeAge";
            this.btChangeAge.Size = new System.Drawing.Size(122, 26);
            this.btChangeAge.TabIndex = 1;
            this.btChangeAge.Text = "Изменить возраст";
            this.btChangeAge.UseVisualStyleBackColor = true;
            this.btChangeAge.Click += new System.EventHandler(this.btChangeAge_Click);
            // 
            // btChangeSkill
            // 
            this.btChangeSkill.Location = new System.Drawing.Point(223, 76);
            this.btChangeSkill.Name = "btChangeSkill";
            this.btChangeSkill.Size = new System.Drawing.Size(121, 26);
            this.btChangeSkill.TabIndex = 1;
            this.btChangeSkill.Text = "Изменить скилл";
            this.btChangeSkill.UseVisualStyleBackColor = true;
            this.btChangeSkill.Click += new System.EventHandler(this.btChangeSkill_Click);
            // 
            // btChangeHealth
            // 
            this.btChangeHealth.Location = new System.Drawing.Point(223, 108);
            this.btChangeHealth.Name = "btChangeHealth";
            this.btChangeHealth.Size = new System.Drawing.Size(121, 26);
            this.btChangeHealth.TabIndex = 1;
            this.btChangeHealth.Text = "Изменить здоровье";
            this.btChangeHealth.UseVisualStyleBackColor = true;
            this.btChangeHealth.Click += new System.EventHandler(this.btChangeHealth_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Запасной",
            "Вратарь",
            "Защитник",
            "Полузащитник",
            "Нападющий"});
            this.cbPosition.Location = new System.Drawing.Point(95, 144);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(114, 21);
            this.cbPosition.TabIndex = 2;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(223, 174);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 26);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 212);
            this.ControlBox = false;
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btChangeHealth);
            this.Controls.Add(this.btChangeSkill);
            this.Controls.Add(this.btChangeAge);
            this.Controls.Add(this.btChangeName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHealth);
            this.Controls.Add(this.lbSkill);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbSkill;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btChangeName;
        private System.Windows.Forms.Button btChangeAge;
        private System.Windows.Forms.Button btChangeSkill;
        private System.Windows.Forms.Button btChangeHealth;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btClose;
    }
}