using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{

    public enum TYPE_EVENT              // типы событий
    {
        PENALTY,
        GOAL,
        CORNER,
        PENALTY11,
        NOTHINHG
    }

    class MatchEvent                    //  класс для описания конкретного события
    {
        TYPE_EVENT type;                // тип события
        int weight;                     // относительный вес события
        float possibility;              // абсолютная вероятность выпадения
        string message;                 // сообщение к этому событию

        public MatchEvent()
        {
            message = "";
            weight = 200;
            possibility = 0;
            type = TYPE_EVENT.NOTHINHG;
        }

        public MatchEvent(TYPE_EVENT type, int weight, string msg)
        {
            this.type = type;
            this.weight = weight;
            this.message = msg;
        }
        // свойства
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public TYPE_EVENT Type
        {
            get { return type; }
            set { type = value; }
        }
        public float Possibility
        {
            get { return possibility; }
            set { possibility = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
