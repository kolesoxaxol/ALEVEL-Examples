using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    public enum PLAYER_POSITION            // перечисления для позиций игрока
    {
        FORWARD,
        HALFBACK,
        QUOTERBACK,
        GOALKEEPER,
        BENCHWARMER
    }
    [Serializable]
    public class Player : Human                // Класс игрока команды
    {
        Team team;                      // объект команды, к которой принадлежит данный игрок
        int skill,                      // текущий уровень игрока
             health;                    //  здоровье игрока, форма игрока
        PLAYER_POSITION position;       // позиция, тип игры игрока

        public Player()
        {
            this.Name = "Василий";
            this.Surname = "Пупкин";
            this.Age = 23;
            this.skill = 25;
            this.health = 100;
            this.position = PLAYER_POSITION.BENCHWARMER;
        }

        public Player(string name, string Surname, byte Age,
            byte Skill, PLAYER_POSITION Position, Team Team)
            : base(name, Surname)
        {
            this.skill = Skill;
            this.team = Team;
            this.health = 100;                       // значение здоровья по умолчанию
            this.position = Position;
            this.Age = Age;
        }

        #region Свойства
        public int Skill
        {
            get
            {
                return skill;
            }
            set
            {
                skill = value;
            }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public double Rating                // рейтинг игрока
        {
            get
            {
                // расчитывается как значение мастерства
                // минус разница "полной" формы (100) и текущей (health),
                // умноженой на понижающий коеф.
                return skill - (100 - health) * 0.1;
            }
        }

        public byte Age
        {
            get
            {
                return age;
            }

            set
            {
                if ((value > 40) || (value < 15))
                {
                    throw new Exception("Возраст за пределами допустимых значений!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Team Team
        {
            get { return team; }
            set { team = value; }
        }

        public PLAYER_POSITION Position
        {
            get { return position; }
            set { position = value; }
        }
        #endregion

        public override string ToString()
        {
            string tmpPos = "";


            switch (this.Position)
            {
                case PLAYER_POSITION.BENCHWARMER:
                    {
                        tmpPos = "ЗП";
                        break;
                    }
                case PLAYER_POSITION.GOALKEEPER:
                    {
                        tmpPos = "ВР";
                        break;
                    }
                case PLAYER_POSITION.HALFBACK:
                    {
                        tmpPos = "ЗЩ";
                        break;
                    }
                case PLAYER_POSITION.QUOTERBACK:
                    {
                        tmpPos = "ПЗЩ";
                        break;
                    }
                case PLAYER_POSITION.FORWARD:
                    {
                        tmpPos = "НАП";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return base.ToString() + " (" + tmpPos + ", " + age + " лет, " + skill + ")";
        }
    }
}
