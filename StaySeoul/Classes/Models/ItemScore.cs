using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class ItemScore
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger UserId { get; set; }
        public BigInteger ItemId { get; set; }
        public BigInteger ScoreId { get; set; }
        public BigInteger Value { get; set; }
    }
}
