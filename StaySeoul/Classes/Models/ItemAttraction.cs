using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class ItemAttraction
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger ItemId { get; set; }
        public BigInteger AttractionId { get; set; }
        public double Distance { get; set; }
        public BigInteger DurationOnFoot { get; set; }
        public BigInteger DurationByCar { get; set; }
    }
}
