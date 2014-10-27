using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class AlarmClock
    {

        private int _alarmHour;

        private int _alarmMinute;

        private int _hour;

        private int _minute;

        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (value > 23 && value < 0)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute
            {
                get
                {
                    return _alarmMinute;
                }
                set
                {
                    if (value > 59 && value < 0)
                    {
                        throw new ArgumentException();
                    }
                    _alarmMinute = value;
                }

            }


            public int Hour
            {
                get
                {
                    return _hour;
                }
                set
                {
                    if (value > 23 && value < 0)
                    {
                        throw new ArgumentException();
                    }
                    _hour = value;
                }

            }




            public int Minute
            {
                get
                {
                    return _minute;
                }
                set
                {
                    if (value > 59 && value < 0)
                    {
                        throw new ArgumentException();
                    }
                    _minute = value;
                }

            }

        public AlarmClock() : this (00, 00)
        {
        }

        public AlarmClock(int hour, int minute) : this (hour, minute, 00, 00)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
           if (hour > 23 && hour < 0)
           {
               throw new ArgumentException();
           }
           if (minute > 59 && minute < 0)
           {
               throw new ArgumentException();
           }
           if (alarmHour > 23 && alarmHour < 0)
           {
               throw new ArgumentException();
           }
           if (alarmMinute > 59 && alarmMinute < 0)
           {
               throw new ArgumentException();
           }

           Hour = hour;
           Minute = minute;
           AlarmHour = alarmHour;
           AlarmMinute = alarmMinute;

        }

        public bool TickTock()
        {
            if (Minute == 59)
            {
                Minute = 00;


                if (Hour == 23)
                {
                    Hour = 00;
                }
                else
                {
                    ++Hour;
                }
            }
            else
            {
                ++Minute;
            }
           

            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }

            return false;
        }


        public override string ToString()
        {


            string time = string.Join(":", Hour, Minute);
            string alarmtime = string.Join(":", AlarmHour, AlarmMinute);

            DateTime convertedTime = DateTime.Parse(time);
            DateTime convertedalarmTime = DateTime.Parse(alarmtime);



            if (convertedalarmTime.ToString("H:mm") == "0:00")
            {
                return convertedTime.ToString("H:mm");
            }
            else
            {
                return string.Format("{0} <{1}>", convertedTime.ToString("H:mm"), convertedalarmTime.ToString("H:mm"));
            }

        }
    }
}
