using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Common.Search
{
    public class DateRange
    {
        DateTime start;
        DateTime end;

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }


        public DateRange(DateTime day)
        {
            start = day.Date;
            end = start.AddDays(1);
        }

        public DateRange(DateTime start, DateTime end)
        {
            if (end <= start)
                throw new Exception("DateRange start must be earlier than end");

            Start = start.Date;
            End = end.Date;
        }

        public bool IsInRange(DateTime date)
        {
            return (date >= start && date < end);
        }

    }
}
