using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Service
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger ServiTypeId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public BigInteger Duration { get; set; }
        public string Description { get; set; }
        public string DayOfWeek { get; set; }
        public string DayOfMonth { get; set; }
        public BigInteger DailyCap { get; set; }
        public BigInteger BookingCap { get; set; }
    }
}
