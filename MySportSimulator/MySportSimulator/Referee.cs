
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    public class Referee : Human
    {
       
        byte affectionTeam1;                // привязаность к первой команде
        byte affectionTeam2;                // привязаность к второй команде
        byte aggression;                    // агрессия судьи

        public Referee() : base("Иван", "Иванов")
        {
            affectionTeam1 = 1;
            affectionTeam2 = 1;
            aggression = 1;
        }

        public Referee(string Name, string Surname, byte Affection1, 
            byte Affection2, byte Agression)
            : base(Name, Surname)
        {
            affectionTeam1 = Affection1;
            affectionTeam2 = Affection2;
            this.aggression = Agression;
        }
       
        public byte AffectionTeam1
        {
            get
            {
                return affectionTeam1;
            }
            set
            {
                affectionTeam1 = value;
            }
        }

        public byte AffectionTeam2
        {
            get
            {
                return affectionTeam2;
            }
            set
            {
                affectionTeam2 = value;
            }
        }
        public byte Agression
        {
            get
            {
                return aggression;
            }
            set
            {
                aggression = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "(степень агрессии " + aggression + ")";
        }
    }
}
