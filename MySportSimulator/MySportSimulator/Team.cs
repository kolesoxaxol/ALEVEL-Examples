using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySportSimulator
{
    [Serializable]
    public class Team:IEnumerable<Player>,IEnumerator<Player>
    {
        string name;                // название команды
        Coach coach;                // тренер команды
        Image logo;                 // ЛОГОТИП КОМАНДЫ
        List<Player> players;       // коллекция игроков команды
        int CurrentID = -1;         // текущий номер итерации 
        Coach teamCoach;            // тренер команды
        public Team()
        {
            name = "Команда";
            coach = new Coach("-", "", 0);
            players = new List<Player>();
            logo = Image.FromFile(Application.StartupPath + @"\TeamLogos\default logo.jpg");   // загрузка  логотипа по умолчанию
            teamCoach = new Coach();
        }

        public Team(string name, Coach TeamCoach)
        {
            this.name = name;
            this.coach = TeamCoach;

            players = new List<Player>();
        }
        #region Свойства

        public int PlayerCount
        {
            get
            {
                return players.Where<Player>(x => x.Position != PLAYER_POSITION.BENCHWARMER).Count<Player>();
            }
        }

        public double Rating                        // текущий рейтинг команды
        {
            get 
            {
                // Расчитывается как средний рейтинг игроков + рейтинг тренера
                if (players.Count != 0)
                {
                    return players.Select(x => x.Rating).Average() + coach.Skill;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Coach TeamCoach
        {
            get { return coach; }
            set { coach = value; }
        }

        public Image Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        #endregion
        public void AddPlayer(Player newPlayer)   // добавление игрока в коллекцию игроков команды
        {
            newPlayer.Team = this;
            players.Add(newPlayer);
        }

        public void RemovePlayer(Player obj)
        {
            players.Remove(obj);
        }

        #region Реализация интерфейсов
        public IEnumerator<Player> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (IEnumerator<Player>)GetEnumerator();
        }

        public Player Current
        {
            get { return players[CurrentID]; }
        }

        public void Dispose()
        {
            return;
        }

        object System.Collections.IEnumerator.Current
        {
            get { return players[CurrentID]; }
            
        }

        public bool MoveNext()
        {
            if (CurrentID < players.Count - 1)
            {
                CurrentID++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }

        public void Reset()
        {
            CurrentID = -1;
        }
        #endregion
    }
}
