using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySportSimulator
{
    class ListViewTeam : ListViewItem   // класс для отображения итемов в ЛистВью
    {
        Team currentTeam;             // текущая команда

        public ListViewTeam(Team T)
        {
            this.currentTeam = T;
            this.Text = currentTeam.Name;  // подпись - имя команды
            this.ImageKey = currentTeam.Name;     // текущая картинка по ключу имени кманды
        }

        public Team Team
        {
            get { return currentTeam; }
            set { currentTeam = value; }
        }
    }
}
