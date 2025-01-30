using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class AddOnServiceDetails
    {
        public BigInteger Id {  get; set; }
        public string GUID { get; set; }
        public BigInteger AddOnServiceId { get; set; }
        public BigInteger ServiceId { get; set; }
        public double Price { get; set; }
        public DateTime FromDate { get; set; }
        public string Notes { get; set; }
        public BigInteger NumberOfPeople { get; set; }
        public int IsRefund { get; set; }
    }
}
