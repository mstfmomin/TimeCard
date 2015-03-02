using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeCard.Models
{
    public class ClockInClass
    {
        public int ID { get; set; }

        private DateTime _ClockIn = DateTime.Now;

        public DateTime ClockIn
        {
            get
            {
                return _ClockIn;
            }
            set
            {
                _ClockIn = value;
            }
        }

        public string WorkOrder { get; set; }
        public string JobType { get; set; }
        public string Location { get; set; }
    }

    public class ClockOutClass
    {
        public int ID { get; set; }
        private DateTime _ClockOut = DateTime.Now;

        public DateTime ClockOut
        {
            get
            {
                return _ClockOut;
            }
            set
            {
                _ClockOut = value;
            }
        }


    }


    public class TotalTimeClass
    {
        public int ID { get; set; }
        public TimeSpan TotalHours { get; set; }
    }

    public class CourseChangeModalClass
    {
        public int ID { get; set; }
        public DateTime ChangeTime { get; set; }
        public string WorkOrder { get; set; }
        public string JobType { get; set; }
        public string Location { get; set; }
    }
}