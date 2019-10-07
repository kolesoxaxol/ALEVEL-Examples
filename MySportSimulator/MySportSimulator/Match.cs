using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportSimulator
{
    public class Match  // класс дял игры
    {
        Team team1, team2;                          // команды, которые будут участвовать в матче
        Score score;                                // объект для хранения счета матча
        Referee referee;                            // судья матча
        UInt32 fansCountTeam1,                      // количество болельщиков первой команды
            fansCountTeam2;                         // количество болельщиокв второй команды
        double winRateTeam1,                        // шансы на победу первой команды
           winRateTeam2;                            // шансы на победу второй команды

        public Match()
        { }

        // конструктр класса с параметрами для создания новой игры
        public Match(Referee referee, Team team1, Team team2,
            UInt32 fansTeam1, UInt32 fansTeam2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.fansCountTeam1 = fansTeam1;
            this.fansCountTeam2 = fansTeam2;
            this.referee = referee;

            score = new Score();

            CountTeamsWinRate();
        }

        #region Свойства для доступа к полям
        public Team Team1
        {
            get { return team1; }
            set { team1 = value; }
        }

        public Team Team2
        {
            get
            { return team2; }
            set
            { team2 = value; }
        }

        public Score MatchScore
        {
            get { return score;}
            set { score.Team1 = value.Team1;
            score.Team2 = value.Team2;
            }
        }

        public double WinRate_Team1
        {
            get { return winRateTeam1; }
        }

        public double WinRate_Team2
        {
            get { return winRateTeam2; }
        }

        public Referee MatchReferee
        {
            get
            { return referee; }
            set
            { referee = value; }
        }

        public UInt32 FansCountTeam1
        {
            get { return fansCountTeam1; }
            set { fansCountTeam1 = value; }
        }

        public UInt32 FansCountTeam2
        {
            get { return fansCountTeam2; }
            set { fansCountTeam2 = value; }
        }
        #endregion

        private void CountTeamsWinRate()
        {
            double Rate1, Rate2;
            double x = 1, y = 1, z = 1;                 // понижающие коефициенты для рейтинга команд

            Rate1 = team1.Rating * x + referee.AffectionTeam1 * y + fansCountTeam1 * z;
            Rate2 = team2.Rating * x + referee.AffectionTeam2 * y + fansCountTeam2 * z;

            winRateTeam1 = (Rate1 * 100) / (Rate1 + Rate2);
            winRateTeam2 = (Rate2 * 100) / (Rate1 + Rate2);
        }
    }

    public class Score                                    // структура для хранения счета матча
    {
        public byte Team1;
        public byte Team2;

        public Score()
        {
            Team1 = 0;
            Team2 = 0;
        }

        public override string ToString()
        {
            return Team1.ToString() + ":" + Team2.ToString();
        }
        
    }
}
