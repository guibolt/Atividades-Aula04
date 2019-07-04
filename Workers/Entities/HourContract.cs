using System;
using System.Collections.Generic;
using System.Text;

namespace Workers.Entities
{
    class HourContract
    {

        double valor;
        public DateTime Date { get; set; }
        public double ValuePorHour { get; set; }
        public int Hours { get; set; }
          
        public HourContract(DateTime date,double value, int hour)
        {
            Date = date;
            ValuePorHour = value;
            Hours = hour;

        }
        public double Total()
        {
            return Hours * ValuePorHour;
        }

      


    }
}
