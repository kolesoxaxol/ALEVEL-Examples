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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        public static string GetNewValue(string OldValue, string Header)
        {
            ChangeForm cf = new ChangeForm();
            cf.tbNewValue.Text = OldValue;
            cf.Text = Header;
            cf.ShowDialog();
            return cf.tbNewValue.Text;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
