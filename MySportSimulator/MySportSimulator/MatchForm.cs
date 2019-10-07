using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySportSimulator
{
    public partial class MatchForm : Form
    {
        Match currentMatch;                                         // текущий матч
        int matchTimeMinute = 0,                                    // минуты тайма и секунды тайминга матча
            matchTimeSeconds = 0;  
        bool matchStarted = false;                                  // флан для отслеживания состояния 
        Random r = new Random();                                    // объект рандомизации для отображения секунд матча
        MatchEventCollection eventList =                            // набор событий матча
            new MatchEventCollection();

        public MatchForm()
        {
            InitializeComponent();
        }

        public static void StartMatch(Match match)                  // начало матча
        {
            MatchForm MF = new MatchForm();                         // создание формы матча

            MF.currentMatch = match;                                // назначение текщего матча

            // инициализация компонентов формы данными
            MF.lbNameTeam1.Text = match.Team1.Name;   
            MF.lbNameTeam2.Text = match.Team2.Name;
            MF.pbLogoTeam1.Image = match.Team1.Logo;
            MF.pbLogoTeam2.Image = match.Team2.Logo;
            MF.lbFansCountTeam1.Text = match.FansCountTeam1.ToString();
            MF.lbFansCountTeam2.Text = match.FansCountTeam2.ToString();
            MF.lbReferee.Text = "Главный судья: " + match.MatchReferee.Name + " " + match.MatchReferee.Surname;
            MF.lbScore.Text = match.MatchScore.ToString();
            MF.lbChances.Text = "Прогноз: " + String.Format("{0:0}:{1:0}", match.WinRate_Team1, match.WinRate_Team2);

            MF.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void matchTimer_Tick(object sender, EventArgs e)
        {
            /*
             * Сделать реализацию событий единым списком: во время загрузки матча
             * весь матч забивается в коллекцию событий, запускается таймер и по каждому тику берется одно
             * событие и выводится в лог
             * Плюсы:
             *  1) разгружаем вычисления по тику таймера
             *  2) легкость реализации системы "реплеев"
             * Минусы:
             *  1) реализация доп. хранилища
             *  2) "обман" пользователя
             */

            string currentEventMessage = "";   // текущее сообщение по событию
            string time;                     // текущее время на таймере 

            MatchEvent currentEvent;     // текущее событие 

            Team eventTeam = (r.Next(0, 2) == 0 ? currentMatch.Team1 : currentMatch.Team2);

            if (tbSpeed.Value == 4)
            {
                matchTimeSeconds += 10;
            }
            else
            {
                matchTimeSeconds++;
            }

            // условно 1 тик таймера принимается за 10 сек реального времени матча
            if (matchTimeSeconds >= 60)                                // каждые 60 секунд
            {
                matchTimeSeconds = 0;                                   // сбрасываем текущие секунды
                matchTimeMinute++;                                      // наращиваем минуту

                currentEvent = eventList.GetNewEvent(eventTeam, out currentEventMessage);  // вызов ивента в зависимости от команды , внутренее определение сообщения события
            }
            else
            {
                currentEvent = new MatchEvent();
            }

            // отображение времени таймера на форме
            if (tbSpeed.Value == 4)
            {
                time = lbTime.Text = String.Format("{0:00}:{1}{2}", matchTimeMinute, matchTimeSeconds / 10, r.Next(0, 9));
            }
            else
            {
                time = lbTime.Text = String.Format("{0:00}:{1:00}", matchTimeMinute, matchTimeSeconds);
            }
            // результаты на события
            if(currentEvent.Type != TYPE_EVENT.NOTHINHG)
            {                
                rtbMatchLog.Text += time + " " + currentEventMessage + "\r\n";
            }

            if(currentEvent.Type == TYPE_EVENT.GOAL)
            {
                if(currentMatch.Team1 == eventTeam)
                {
                    currentMatch.MatchScore.Team1++;
                }
                else
                {
                    currentMatch.MatchScore.Team2++;
                }

                lbScore.Text = currentMatch.MatchScore.ToString();
            }

            if (matchTimeMinute == 90)                                  // остановка таймера на 90 минуте
            {
                lbTime.Text = "90:00";
                matchTimer.Stop();
                btStop.Enabled = false;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            matchTimer.Start();
            matchStarted = true;
            btStart.Enabled = false;
        }

        private void btStop_Click(object sender, EventArgs e)           // приостановить матч / продолжить матч
        {
            if (matchStarted)
            {
                matchTimer.Stop();
                btStop.Text = "Продолжить матч";
                matchStarted = false;
            }
            else
            {
                matchTimer.Start();
                btStop.Text = "Приостановить матч";
                matchStarted = true;
            }
        }

        // именение скорости таймера через его интревал вызова функции с помощью трекбол
        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            switch(tbSpeed.Value)
            {
                case 4:
                    {
                        matchTimer.Interval = 18;
                        break;
                    }
                case 3:
                    {
                        matchTimer.Interval = 263;
                        break;
                    }
                case 2:
                    {
                        matchTimer.Interval = 508;
                        break;
                    }
                case 1:
                    {
                        matchTimer.Interval = 753;
                        break;
                    }
                case 0:
                    {
                        matchTimer.Interval = 1000;
                        break;
                    }
            }
        }
    }
}
