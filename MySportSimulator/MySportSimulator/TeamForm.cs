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
    public partial class TeamForm : Form
    {
        Team currentTeam;                                           // объект для работы с текущей командой
        public TeamForm()
        {
            InitializeComponent();
        }

        static public void DisplayTeam(ref Team team)               // отображнение данных про команду на форме
        {
            TeamForm teamform = new TeamForm();
            teamform.currentTeam = team;
            teamform.lbCoach.Text = team.TeamCoach.Surname + " " + team.TeamCoach.Name;
            
            teamform.Text = teamform.lbTeamName.Text = team.Name;
            teamform.pbTeamLogo.Image = team.Logo;

            teamform.RefreshPlayers();

            teamform.openImageDialog.InitialDirectory = 
                Application.StartupPath + @"\TeamLogos\";           // установка стандартного пути для загрузки оттуда логотипов
            teamform.ShowDialog();
        }

        private void btRenameTeam_Click(object sender, EventArgs e)
        {
            this.Text = lbTeamName.Text = currentTeam.Name = 
                ChangeForm.GetNewValue(currentTeam.Name, "Название команды");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLoadLogo_Click(object sender, EventArgs e)
        {
            DialogResult result = openImageDialog.ShowDialog();

            if(result != System.Windows.Forms.DialogResult.Cancel)
            {
                pbTeamLogo.Image = currentTeam.Logo = Image.FromFile(openImageDialog.FileName);
            }
        }

        private void btAddPalyer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();

            PlayerForm.DisplayPlayer(ref newPlayer);        // вызов формы отображения игрока

            currentTeam.AddPlayer(newPlayer);               // добавление нового игрока в список 
            RefreshPlayers();                               // обновление списка игроков
        }

        void RefreshPlayers()                               // обновление списка игроков
        {
            lstPlayers.Items.Clear();                       // очистка 

            foreach(Player P in currentTeam)                // и новое отображение 
            {
                lstPlayers.Items.Add(P);
            }

            lbRating.Text = String.Format("{0:0.00}", currentTeam.Rating);
        }

        private void lstPlayers_DoubleClick(object sender, EventArgs e)
        {
            if(lstPlayers.SelectedIndex != -1)
            {
                Player player = (Player)lstPlayers.SelectedItem;

                PlayerForm.DisplayPlayer(ref player);

                RefreshPlayers();
            }
        }

        private void btChangeCoach_Click(object sender, EventArgs e)
        {
            Coach currentCoach = new Coach();  // создание текущего объекта тренера
            // вызов формы тренера 

            CoachForm.DisplayCoach(ref currentCoach);


            lbCoach.Text = (currentTeam.TeamCoach = currentCoach).ToString();
        }
    }
}
