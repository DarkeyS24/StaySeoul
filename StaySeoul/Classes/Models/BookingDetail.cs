using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class BookingDetail
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger BookingId { get; set; }
        public BigInteger ItemPriceId { get; set; }
        public int IsRefund { get; set; }
        public DateTime RefundDate { get; set; }
        public BigInteger RefundCancellationPolicyId { get; set; }
    }
}
