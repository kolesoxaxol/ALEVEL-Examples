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
    public partial class RefereeListForm : Form
    {
        List<Referee> currentRefereeList;

        public RefereeListForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void DisplayListReferee(ref List<Referee> referreeList)
        {
            RefereeListForm rlf = new RefereeListForm();
            rlf.currentRefereeList = referreeList;
            //rlf.lbxReffereeList.Items.AddRange(referreeList.ToArray<Referee>());
            referreeList.ForEach(x => rlf.lbxReffereeList.Items.Add(x));
            rlf.ShowDialog();
        }

        private void btAgression_Click(object sender, EventArgs e)
        {
            Referee selectedReferee = (Referee)lbxReffereeList.SelectedItem;

            if (lbxReffereeList.SelectedIndex != -1)
            {
                string tmp;
                byte Agression;

                do
                {
                    try
                    {
                        tmp = ChangeForm.GetNewValue(selectedReferee.Agression.ToString(), "Агрессия судьи");
                        Agression = byte.Parse(tmp);
                        selectedReferee.Agression = Agression;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Некорректная агрессия для судьи! Повторите ввод!");
                        tmp = "s";
                    }
                }
                while (!byte.TryParse(tmp, out Agression));

                lbAgression.Text = Agression.ToString();
                RefreshRefereeList();
            }
        }

        private void btRenameRefferee_Click(object sender, EventArgs e)
        {
            if (lbxReffereeList.SelectedIndex != -1)
            {
                Referee selectedReferee = (Referee)lbxReffereeList.SelectedItem;
                string Tmp = ChangeForm.GetNewValue(selectedReferee.Name + " " + selectedReferee.Surname, "Имя судьи");
                string[] stmp;

                if ((stmp = Tmp.Split(' ')).Count() >= 2)
                {
                    selectedReferee.Name = Tmp.Split(' ')[0];
                    selectedReferee.Surname = Tmp.Split(' ')[1];
                }
                else
                {
                    selectedReferee.Name = Tmp.Split(' ')[0];
                    selectedReferee.Surname = "";
                }

                this.lbReffereeName.Text = selectedReferee.Name + " " + selectedReferee.Surname;
                RefreshRefereeList();
            }
        }

        private void btAddNewReferee_Click(object sender, EventArgs e)
        {
            currentRefereeList.Add(new Referee());
            RefreshRefereeList();
        }
        private void RefreshRefereeList()
        {
            lbxReffereeList.Items.Clear();
            currentRefereeList.ForEach(x => lbxReffereeList.Items.Add(x));
        }

        private void lbxReffereeList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (lbxReffereeList.SelectedIndex != -1)
            {
                lbAgression.Text = ((Referee)lbxReffereeList.SelectedItem).Agression.ToString();
                lbReffereeName.Text = ((Referee)lbxReffereeList.SelectedItem).Name + " " + ((Referee)lbxReffereeList.SelectedItem).Surname;
            }
        }
    }
}
