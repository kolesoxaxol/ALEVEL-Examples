namespace MySportSimulator
{
    partial class RefereeListForm
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
            this.lbxReffereeList = new System.Windows.Forms.ListBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAgression = new System.Windows.Forms.Label();
            this.lbReffereeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAgression = new System.Windows.Forms.Button();
            this.btRenameRefferee = new System.Windows.Forms.Button();
            this.gbReferee = new System.Windows.Forms.GroupBox();
            this.btAddNewReferee = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.gbReferee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxReffereeList
            // 
            this.lbxReffereeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxReffereeList.FormattingEnabled = true;
            this.lbxReffereeList.Location = new System.Drawing.Point(12, 12);
            this.lbxReffereeList.Name = "lbxReffereeList";
            this.lbxReffereeList.Size = new System.Drawing.Size(287, 160);
            this.lbxReffereeList.TabIndex = 0;
            this.lbxReffereeList.SelectedIndexChanged += new System.EventHandler(this.lbxReffereeList_SelectedIndexChanged);
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(75, 82);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(0, 13);
            this.lbRating.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Агрессия:";
            // 
            // lbAgression
            // 
            this.lbAgression.AutoSize = true;
            this.lbAgression.Location = new System.Drawing.Point(78, 58);
            this.lbAgression.Name = "lbAgression";
            this.lbAgression.Size = new System.Drawing.Size(0, 13);
            this.lbAgression.TabIndex = 7;
            // 
            // lbReffereeName
            // 
            this.lbReffereeName.AutoSize = true;
            this.lbReffereeName.Location = new System.Drawing.Point(78, 23);
            this.lbReffereeName.Name = "lbReffereeName";
            this.lbReffereeName.Size = new System.Drawing.Size(0, 13);
            this.lbReffereeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя:";
            // 
            // btAgression
            // 
            this.btAgression.Location = new System.Drawing.Point(219, 50);
            this.btAgression.Name = "btAgression";
            this.btAgression.Size = new System.Drawing.Size(114, 29);
            this.btAgression.TabIndex = 8;
            this.btAgression.Text = "Сменить агрессию";
            this.btAgression.UseVisualStyleBackColor = true;
            this.btAgression.Click += new System.EventHandler(this.btAgression_Click);
            // 
            // btRenameRefferee
            // 
            this.btRenameRefferee.Location = new System.Drawing.Point(219, 15);
            this.btRenameRefferee.Name = "btRenameRefferee";
            this.btRenameRefferee.Size = new System.Drawing.Size(114, 29);
            this.btRenameRefferee.TabIndex = 9;
            this.btRenameRefferee.Text = "Переименовать";
            this.btRenameRefferee.UseVisualStyleBackColor = true;
            this.btRenameRefferee.Click += new System.EventHandler(this.btRenameRefferee_Click);
            // 
            // gbReferee
            // 
            this.gbReferee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReferee.Controls.Add(this.btAddNewReferee);
            this.gbReferee.Controls.Add(this.btRenameRefferee);
            this.gbReferee.Controls.Add(this.btAgression);
            this.gbReferee.Controls.Add(this.label1);
            this.gbReferee.Controls.Add(this.lbReffereeName);
            this.gbReferee.Controls.Add(this.lbAgression);
            this.gbReferee.Controls.Add(this.label4);
            this.gbReferee.Location = new System.Drawing.Point(305, 12);
            this.gbReferee.Name = "gbReferee";
            this.gbReferee.Size = new System.Drawing.Size(348, 126);
            this.gbReferee.TabIndex = 10;
            this.gbReferee.TabStop = false;
            this.gbReferee.Text = "Судья";
            // 
            // btAddNewReferee
            // 
            this.btAddNewReferee.Location = new System.Drawing.Point(219, 85);
            this.btAddNewReferee.Name = "btAddNewReferee";
            this.btAddNewReferee.Size = new System.Drawing.Size(114, 29);
            this.btAddNewReferee.TabIndex = 10;
            this.btAddNewReferee.Text = "Добавить судью";
            this.btAddNewReferee.UseVisualStyleBackColor = true;
            this.btAddNewReferee.Click += new System.EventHandler(this.btAddNewReferee_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(524, 147);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(114, 29);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // RefereeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 188);
            this.ControlBox = false;
            this.Controls.Add(this.gbReferee);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxReffereeList);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(677, 227);
            this.Name = "RefereeListForm";
            this.Text = "Список судей";
            this.gbReferee.ResumeLayout(false);
            this.gbReferee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxReffereeList;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAgression;
        private System.Windows.Forms.Label lbReffereeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgression;
        private System.Windows.Forms.Button btRenameRefferee;
        private System.Windows.Forms.GroupBox gbReferee;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAddNewReferee;
    }
}