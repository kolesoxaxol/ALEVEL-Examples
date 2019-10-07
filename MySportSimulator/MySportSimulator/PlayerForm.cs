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
    public partial class PlayerForm : Form
    {
        Player currentPlayer;  // Объект для работы с текущем игроком 

        public PlayerForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void DisplayPlayer(ref Player player)
        {
            PlayerForm pf = new PlayerForm(); 
            // отображение данных игрока на форме
            pf.currentPlayer = player;
            pf.lbName.Text = player.Name + " " + player.Surname;
            pf.lbAge.Text = player.Age.ToString();
            pf.lbSkill.Text = player.Skill.ToString();
            pf.lbHealth.Text = player.Health.ToString();
            // отображение позиции игрока в комбобоксе
            switch (player.Position)
            {
                case PLAYER_POSITION.BENCHWARMER:
                    {
                        pf.cbPosition.SelectedIndex = 0;
                        break;
                    }
                case PLAYER_POSITION.GOALKEEPER:
                    {
                        pf.cbPosition.SelectedIndex = 1;
                        break;
                    }
                case PLAYER_POSITION.HALFBACK:
                    {
                        pf.cbPosition.SelectedIndex = 2;
                        break;
                    }
                case PLAYER_POSITION.QUOTERBACK:
                    {
                        pf.cbPosition.SelectedIndex = 3;
                        break;
                    }
                case PLAYER_POSITION.FORWARD:
                    {
                        pf.cbPosition.SelectedIndex = 4;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            pf.ShowDialog();
        }

        private void btChangeName_Click(object sender, EventArgs e)
        {
            string Tmp = ChangeForm.GetNewValue(currentPlayer.Name + " " + currentPlayer.Surname, "Имя игрока");
            string[] stmp;

            if ((stmp = Tmp.Split(' ')).Count() >= 2)
            {
                currentPlayer.Name = Tmp.Split(' ')[0];
                currentPlayer.Surname = Tmp.Split(' ')[1];
            }
            else
            {
                currentPlayer.Name = Tmp.Split(' ')[0];
                currentPlayer.Surname = "";
            }

            this.lbName.Text = currentPlayer.Name + " " + currentPlayer.Surname;
        }

        private void btChangeAge_Click(object sender, EventArgs e)
        {
            string tmp;
            byte newAge;

            do
            {
                try
                {
                    tmp = ChangeForm.GetNewValue(currentPlayer.Age.ToString(), "Возраст игрока");
                    newAge = byte.Parse(tmp);
                    currentPlayer.Age = newAge;
                }
                catch(Exception)
                {
                    MessageBox.Show("Некорректный возраст игрока! Повторите ввод!");
                    tmp = "s";
                }
            }
            while(!byte.TryParse(tmp, out newAge));

            lbAge.Text = newAge.ToString();
        }

        private void btChangeSkill_Click(object sender, EventArgs e)
        {
            string tmp;
            byte newSkill;

            do
            {
                try
                {
                    tmp = ChangeForm.GetNewValue(currentPlayer.Skill.ToString(), "Скилл игрока");
                    newSkill = byte.Parse(tmp);
                    currentPlayer.Skill = newSkill;
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный скилл игрока! Повторите ввод!");
                    tmp = "s";
                }
            }
            while (!byte.TryParse(tmp, out newSkill));

            lbSkill.Text = newSkill.ToString();
        }

        private void btChangeHealth_Click(object sender, EventArgs e)
        {
            string tmp;
            byte newHealth;

            do
            {
                try
                {
                    tmp = ChangeForm.GetNewValue(currentPlayer.Health.ToString(), "Здоровье игрока");
                    newHealth = byte.Parse(tmp);
                    currentPlayer.Health = newHealth;
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректное здоровье игрока! Повторите ввод!");
                    tmp = "s";
                }
            }
            while (!byte.TryParse(tmp, out newHealth));

            lbHealth.Text = newHealth.ToString();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbPosition.SelectedIndex)  // установка позиции игрока в зависимости от выбраного пункта из ComboBox
            {
                case 0:
                    {
                        currentPlayer.Position = PLAYER_POSITION.BENCHWARMER;
                        break;
                    }
                case 1:
                    {
                        currentPlayer.Position = PLAYER_POSITION.GOALKEEPER;
                        break;
                    }
                case 2:
                    {
                        currentPlayer.Position = PLAYER_POSITION.HALFBACK;
                        break;
                    }
                case 3:
                    {
                        currentPlayer.Position = PLAYER_POSITION.QUOTERBACK;
                        break;
                    }
                case 4:
                    {
                        currentPlayer.Position = PLAYER_POSITION.FORWARD;
                        break;
                    }
            }
        }
    }
}
