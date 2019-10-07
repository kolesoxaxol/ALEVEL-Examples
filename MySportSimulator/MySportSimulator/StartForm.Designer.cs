namespace MySportSimulator
{
    partial class StartForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЛигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЛигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробнееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судьиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLeague = new System.Windows.Forms.ListView();
            this.imglst_TeamLogos_L = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btStartMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFansCountTeam1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFansCountTeam2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRefereeList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.командыToolStripMenuItem,
            this.судьиToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(594, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьЛигуToolStripMenuItem,
            this.сохранитьЛигуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьЛигуToolStripMenuItem
            // 
            this.загрузитьЛигуToolStripMenuItem.Name = "загрузитьЛигуToolStripMenuItem";
            this.загрузитьЛигуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.загрузитьЛигуToolStripMenuItem.Text = "Загрузить лигу";
            this.загрузитьЛигуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЛигуToolStripMenuItem_Click);
            // 
            // сохранитьЛигуToolStripMenuItem
            // 
            this.сохранитьЛигуToolStripMenuItem.Name = "сохранитьЛигуToolStripMenuItem";
            this.сохранитьЛигуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сохранитьЛигуToolStripMenuItem.Text = "Сохранить лигу";
            this.сохранитьЛигуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЛигуToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // командыToolStripMenuItem
            // 
            this.командыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКомандуToolStripMenuItem,
            this.удалитьКомандуToolStripMenuItem,
            this.подробнееToolStripMenuItem});
            this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
            this.командыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.командыToolStripMenuItem.Text = "Команды";
            // 
            // добавитьКомандуToolStripMenuItem
            // 
            this.добавитьКомандуToolStripMenuItem.Name = "добавитьКомандуToolStripMenuItem";
            this.добавитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьКомандуToolStripMenuItem.Text = "Добавить команду";
            this.добавитьКомандуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКомандуToolStripMenuItem_Click);
            // 
            // удалитьКомандуToolStripMenuItem
            // 
            this.удалитьКомандуToolStripMenuItem.Name = "удалитьКомандуToolStripMenuItem";
            this.удалитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.удалитьКомандуToolStripMenuItem.Text = "Удалить команду";
            // 
            // подробнееToolStripMenuItem
            // 
            this.подробнееToolStripMenuItem.Name = "подробнееToolStripMenuItem";
            this.подробнееToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.подробнееToolStripMenuItem.Text = "Подробнее";
            this.подробнееToolStripMenuItem.Click += new System.EventHandler(this.подробнееToolStripMenuItem_Click);
            // 
            // судьиToolStripMenuItem
            // 
            this.судьиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.судьиToolStripMenuItem.Name = "судьиToolStripMenuItem";
            this.судьиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.судьиToolStripMenuItem.Text = "Судьи";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Список судей";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // lvLeague
            // 
            this.lvLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLeague.CheckBoxes = true;
            this.lvLeague.LargeImageList = this.imglst_TeamLogos_L;
            this.lvLeague.Location = new System.Drawing.Point(0, 27);
            this.lvLeague.MultiSelect = false;
            this.lvLeague.Name = "lvLeague";
            this.lvLeague.Size = new System.Drawing.Size(375, 233);
            this.lvLeague.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvLeague.TabIndex = 1;
            this.lvLeague.UseCompatibleStateImageBehavior = false;
            this.lvLeague.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvLeague_ItemChecked);
            this.lvLeague.DoubleClick += new System.EventHandler(this.lvLeague_MouseDoubleClick);
            // 
            // imglst_TeamLogos_L
            // 
            this.imglst_TeamLogos_L.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglst_TeamLogos_L.ImageSize = new System.Drawing.Size(60, 60);
            this.imglst_TeamLogos_L.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lg";
            this.saveFileDialog.Filter = "Файлы лиг|*.lg|Все файлы|*.*";
            this.saveFileDialog.Title = "Сохранить лигу....";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы лиг|*.lg|Все файлы|*.*";
            this.openFileDialog.Title = "Загрузить лигу...";
            // 
            // btStartMatch
            // 
            this.btStartMatch.Location = new System.Drawing.Point(45, 184);
            this.btStartMatch.Name = "btStartMatch";
            this.btStartMatch.Size = new System.Drawing.Size(114, 34);
            this.btStartMatch.TabIndex = 2;
            this.btStartMatch.Text = "Начать матч!";
            this.btStartMatch.UseVisualStyleBackColor = true;
            this.btStartMatch.Click += new System.EventHandler(this.btStartMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во зрителей первой команды:";
            // 
            // tbFansCountTeam1
            // 
            this.tbFansCountTeam1.Location = new System.Drawing.Point(9, 42);
            this.tbFansCountTeam1.Name = "tbFansCountTeam1";
            this.tbFansCountTeam1.Size = new System.Drawing.Size(98, 20);
            this.tbFansCountTeam1.TabIndex = 4;
            this.tbFansCountTeam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во зрителей второй команды:";
            // 
            // tbFansCountTeam2
            // 
            this.tbFansCountTeam2.Location = new System.Drawing.Point(9, 94);
            this.tbFansCountTeam2.Name = "tbFansCountTeam2";
            this.tbFansCountTeam2.Size = new System.Drawing.Size(98, 20);
            this.tbFansCountTeam2.TabIndex = 4;
            this.tbFansCountTeam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbRefereeList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btStartMatch);
            this.groupBox1.Controls.Add(this.tbFansCountTeam2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFansCountTeam1);
            this.groupBox1.Location = new System.Drawing.Point(381, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры матча";
            // 
            // cbRefereeList
            // 
            this.cbRefereeList.FormattingEnabled = true;
            this.cbRefereeList.Location = new System.Drawing.Point(9, 146);
            this.cbRefereeList.Name = "cbRefereeList";
            this.cbRefereeList.Size = new System.Drawing.Size(179, 21);
            this.cbRefereeList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Судья:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvLeague);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(300, 308);
            this.Name = "StartForm";
            this.Text = "Спорт симулятор";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
        private System.Windows.Forms.ListView lvLeague;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЛигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЛигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подробнееToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ImageList imglst_TeamLogos_L;
        private System.Windows.Forms.Button btStartMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFansCountTeam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFansCountTeam2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRefereeList;
        private System.Windows.Forms.ToolStripMenuItem судьиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;

    }
}

