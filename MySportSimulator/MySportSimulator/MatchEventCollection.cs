using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    class MatchEventCollection
    {
        List<MatchEvent> eventList;   // список событий

        public MatchEventCollection()
        {
            eventList = new List<MatchEvent>();
            // инициализация списка событий
            eventList.Add(new MatchEvent());
            eventList.Add(new MatchEvent(TYPE_EVENT.GOAL, 5, "Гол!"));
            eventList.Add(new MatchEvent(TYPE_EVENT.CORNER, 15, "Угловой"));
            eventList.Add(new MatchEvent(TYPE_EVENT.PENALTY, 15, "Штрафной"));
            eventList.Add(new MatchEvent(TYPE_EVENT.PENALTY11, 3, "Пенальти"));
            // пересчет вероятности выпадения
            RecountPossibility();
        }

        // пересчет вероятности выпадения в зависимости от веса события ( математическая пропорция)
        void RecountPossibility()
        {
            int MaxWeight = eventList.Select(x => x.Weight).Sum();    // нахождение максимального веса 

            eventList.ForEach(e => e.Possibility = (float)(e.Weight * 100) / MaxWeight);  // для каждого события высчитать вероятность вес события * 100 / максимальный вес из списка событий
        }

        // взять событие из коллекции 
        public MatchEvent GetNewEvent(Team eventTeam, out string Message)
        {
            Random r = new Random();
            int Number = r.Next(1, 100);
            float nearest = 0;

            foreach (MatchEvent e in eventList)
            {
                if (Number <= nearest + e.Possibility)
                {
                    if(e.Type != TYPE_EVENT.NOTHINHG)
                    {
                        Message = e.Message + " : (" + getAppropriatePlayer(e, eventTeam) + ", " + eventTeam.Name + ")";
                        return e;
                    }
                    else
                    {
                        Message = "";
                        return e;
                    }
                }
                else
                {
                    nearest += e.Possibility;
                }
            }

            throw new Exception("Отсутствие подходящих событий в коллекции");
        }

        // взять игрока из команды для события 
        Player getAppropriatePlayer(MatchEvent e, Team team)
        {
            Random r = new Random(); 
            var playerMatchUp = new Dictionary<Player, double>();  // игрок/вероятность  список игроков
            // по аналогии с вероятностью событий высчитываем максимальный Рейтинг
            double MaxWeight = team.Select(x => x.Rating).Sum();

            foreach(Player p in team)
            {
                playerMatchUp.Add(p, ((p.Rating * 100) / MaxWeight));  // по мат. пропорции записываем игрока и его вероятность в список
            }

            int Number = r.Next(1, 100);
            double nearest = 0;

            foreach (var kvp in playerMatchUp)
            {
                if ((Number <= nearest + kvp.Value) 
                    && (kvp.Key.Position != PLAYER_POSITION.BENCHWARMER))
                // проверка на запасного игрока (запасные не могут забивать)
                    {
                    return kvp.Key;
                }
                else
                {
                    nearest += kvp.Value;
                }
            }

            throw new Exception("Подходящего игрока не найдено!");
        }
    }
}
