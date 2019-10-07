using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySportSimulator
{
    public partial class StartForm : Form
    {
        League league;                      // объект для хранения  лиги (набора команд)

        public StartForm()
        {
            InitializeComponent();

            league = new League();

            saveFileDialog.InitialDirectory = 
                openFileDialog.InitialDirectory = Application.StartupPath;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьЛигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выбор файла для сохранения
            DialogResult save = saveFileDialog.ShowDialog();

            if (save != System.Windows.Forms.DialogResult.Cancel)
            {
                if (saveFileDialog.FileName != "")
                {
                    league.SaveToFile(saveFileDialog.FileName);                 // вызов сохранения матча
                }
                else
                {
                    MessageBox.Show("Невозможно сохранить лигу в файл с таким именем!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьЛигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выбор файла с данными
            DialogResult load = openFileDialog.ShowDialog();

            if (load != System.Windows.Forms.DialogResult.Cancel)
            {
                league = League.LoadFromFile(openFileDialog.FileName);      // загрузка из выбраного файла
            }

            imglst_TeamLogos_L.Images.Clear();                              // очистка списка логотипов для команд

            // новое составление списка логотипа и имени
            foreach (Team T in league)
            {
                imglst_TeamLogos_L.Images.Add(T.Name, T.Logo);
            }

            RefreshTeams();  // новый релоад лист вью 
            RereshRefereeList();
        }

        private void добавитьКомандуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team newTeam = new Team();

            TeamForm.DisplayTeam(ref newTeam);   // отображение формы с новой командой 

            league.AddTeam(newTeam);  // добавление новой команды в список
            imglst_TeamLogos_L.Images.Add(newTeam.Name, newTeam.Logo); // добавление новой команды в коллекцию Итемов для ЛистВью
            RefreshTeams(); // Обновление лист вью
        }

        void RefreshTeams()
        {
            lvLeague.Items.Clear();   // очистка лист вью 
            foreach (Team T in league)
            {
                lvLeague.Items.Add(new ListViewTeam(T));   // добавление всех команд в лист вью 
            }
        }

        private void lvLeague_MouseDoubleClick(object sender, MouseEventArgs e)  // на двойной щелчек по элементу лист вью
        {
            //подробнееToolStripMenuItem_Click(this, new EventArgs());   // вызов события аналогичного нажатию на пункт меню "Подробнее"
        }
        private void lvLeague_MouseDoubleClick(object sender, System.EventArgs e)
        {
            подробнееToolStripMenuItem_Click(this, new EventArgs());   // вызов события аналогичного нажатию на пункт меню "Подробнее"
        }

        private void подробнееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvLeague.SelectedItems.Count != 0)
            {
                Team team = ((ListViewTeam)lvLeague.SelectedItems[0]).Team;  // выбераем текущую выбраную команду

                TeamForm.DisplayTeam(ref team);   // отображение данных о команде в форме

                league.RemoveTeam(team);
                league.AddTeam(team);

                if (imglst_TeamLogos_L.Images.ContainsKey(team.Name))
                {
                    imglst_TeamLogos_L.Images.RemoveByKey(team.Name);
                }

                imglst_TeamLogos_L.Images.Add(team.Name, team.Logo);

                RefreshTeams();
            }

        }


        // валидация на выбор больше двух команд для проведения симулции
        private void lvLeague_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvLeague.CheckedItems.Count > 2)
            {
                e.Item.Checked = false;
            }
        }
        // начало симуляции с полной валидацие данных
        private void btStartMatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvLeague.CheckedItems.Count != 2)
                {
                    throw new Exception("Выберите две команды для матча!");
                }

                if (tbFansCountTeam1.Text.Length == 0)
                {
                    throw new Exception("Введите кол-во фанатов первой команды!");
                }

                if (tbFansCountTeam2.Text.Length == 0)
                {
                    throw new Exception("Введите кол-во фанатов второй команды!");
                }

                // Валидация убрана до момента ввода функционала судейства матчей
                if(cbRefereeList.SelectedIndex == -1)
                {
                    throw new Exception("Выберите судью матча!");
                }

                Team t1 = ((ListViewTeam)lvLeague.CheckedItems[0]).Team,
                    t2 = ((ListViewTeam)lvLeague.CheckedItems[1]).Team;

                if(t1.PlayerCount != 11)
                {
                    throw new Exception("Некорректное количество игроко в первой команде!");
                }

                if (t2.PlayerCount != 11)
                {
                    throw new Exception("Некорректное количество игроков во второй команде!");
                }

                MatchForm.StartMatch(new Match((Referee)cbRefereeList.SelectedItem, t1, t2, uint.Parse(tbFansCountTeam1.Text), uint.Parse(tbFansCountTeam2.Text)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // фильтрация на ввод количества фанатов
        private void tbKeyPress(object sender, KeyPressEventArgs e)
        {
            int A;
            if (!int.TryParse(e.KeyChar.ToString(), out A) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var refereeList = league.RefereeList;

            RefereeListForm.DisplayListReferee(ref refereeList);

            RereshRefereeList();
        }


        private void RereshRefereeList()
        {
            if (league.RefereeList == null)
            {
                league.RefereeList = new List<Referee>();
            }

            cbRefereeList.Items.Clear();
            league.RefereeList.ForEach(x => cbRefereeList.Items.Add(x));
        }
    }
}
