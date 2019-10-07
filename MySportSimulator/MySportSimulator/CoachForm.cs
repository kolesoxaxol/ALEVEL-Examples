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
    public partial class CoachForm : Form
    {
        Coach currentCoach;  // объект для работы с текущим тренером 
        public CoachForm()
        {
            InitializeComponent();
        }

        // отображение формы тренера
        public static void DisplayCoach(ref Coach coach)
        {
            CoachForm coachForm = new CoachForm();

            coachForm.currentCoach = coach;

            coachForm.lbName.Text = coach.Name + " " + coach.Surname;
            coachForm.lbskill.Text = coach.Skill.ToString();
            coachForm.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // изменение имени тренера
        private void btChangeName_Click(object sender, EventArgs e)
        {
            string Tmp = ChangeForm.GetNewValue(currentCoach.Name + " " +currentCoach.Surname, "Имя тренера");
            string[] stmp;

            if ((stmp = Tmp.Split(' ')).Count() >= 2)
            {
                currentCoach.Name = Tmp.Split(' ')[0];
                currentCoach.Surname = Tmp.Split(' ')[1];
            }
            else
            {
               currentCoach.Name = Tmp.Split(' ')[0];
               currentCoach.Surname = "";
            }

            this.lbName.Text = currentCoach.Name + " " + currentCoach.Surname;
        }
        // изменение умения тренера
        private void btChangeSkill_Click(object sender, EventArgs e)
        {
            string tmp;
            byte newSkill;

            do
            {
                try
                {
                    tmp = ChangeForm.GetNewValue(currentCoach.Skill.ToString(), "Скилл Тренера");
                    newSkill = byte.Parse(tmp);
                    currentCoach.Skill = newSkill;
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный скилл тренера! Повторите ввод!");
                    tmp = "s";
                }
            }
            while (!byte.TryParse(tmp, out newSkill));

            lbskill.Text = currentCoach.Skill.ToString();
        }
    }
}
