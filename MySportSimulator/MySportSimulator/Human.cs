using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    [Serializable]
    public abstract class Human
    {
        #region Поля
        string name;   // имя 
        string surname; // фамилия

        protected byte age;
        #endregion
        // конструкторы
        public Human()
        {
            name = "-";
            surname = "-";
        }
        public Human(string name, string Surname, byte Age = 0)
        {
            this.name = name;
            this.surname = Surname;
            this.age = Age;
        }
        public override string ToString()
        {
            return name + " "+ surname;
        }

        #region Свойства полей
        public string Name
        {
            get {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        #endregion
    }
}
