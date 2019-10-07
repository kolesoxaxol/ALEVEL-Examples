using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    [Serializable]
    class League : IEnumerable<Team>, IEnumerator<Team>  // коллекция для хранения команд турнира
    {
        List<Team> teams;            // список команд
        List<Referee> referees;      // список судей

        int CurrentID;               // текущая команда     

        public League()
        {
            teams = new List<Team>();
            referees = new List<Referee>();
            CurrentID = -1;
        }

        public List<Referee> RefereeList
        {
            get { return referees; }
            set { referees = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {

            get { return teams[CurrentID]; }
        }

        public bool MoveNext()
        {
            if (CurrentID < teams.Count - 1)
            {
                CurrentID++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            CurrentID = -1;
        }

        public void AddTeam(Team newTeam)       // добавление новой команды в коллекцию
        {
            teams.Add(newTeam);
        }

        public void RemoveTeam(Team obj)         // удаление команды из коллекции
        {
            teams.Remove(obj);
        }

        public void SaveToFile(string FileName)             // серриализаия коллекции в выбраный файл
        {
            FileStream fileStream = File.Create(FileName);
            try
            {
                BinaryFormatter bformatters = new BinaryFormatter();
                bformatters.Serialize(fileStream, this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fileStream.Close();
            }
        }
         
        public static League LoadFromFile(string FileName)          // загрузка коллекции из файла
        {
            FileStream fileStream = File.OpenRead(FileName);
            try
            {
                BinaryFormatter bformatters = new BinaryFormatter();
                return (League)bformatters.Deserialize(fileStream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fileStream.Close();
            }
        }

        Team IEnumerator<Team>.Current
        {
            get { return (Team)this.Current; }
        }

        public void Dispose()
        {
            return;
        }

        IEnumerator<Team> IEnumerable<Team>.GetEnumerator()
        {
            return (IEnumerator<Team>)GetEnumerator();
        }
    }
}
