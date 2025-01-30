using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class ItemPrice
    {
        public BigInteger Id {  get; set; }
        public string GUID { get; set; }
        public BigInteger ItemId { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public BigInteger CancellationPolicyId { get; set; }
    }
}
