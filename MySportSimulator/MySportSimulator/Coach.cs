using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    [Serializable]
    public class Coach : Human   // класс Для Тренера команды
    {
        byte skill;    // уровень мастерства тренера

        public Coach()
        {
            skill = 0;
            Surname = "Некий";
            Name = "Тренер";
        }
        public Coach(string Name, string Surname, byte Dkill)
            : base(Name, Surname)
        {
            this.skill = Skill;
        }
        public byte Skill
        {
            get { return skill; }
            set { skill = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " (" + skill + ")";
        }
    }
}
