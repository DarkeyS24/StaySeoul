using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class DimDate
    {
        public BigInteger Id { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public string MonthName { get; set; }
        public int DayOfMonth { get; set; }
        public int DayOfWeek { get; set; }
        public int DayName { get; set; }
        public int IsHoliday { get; set; }
    }
}
