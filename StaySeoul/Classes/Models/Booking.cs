using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Booking
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public BigInteger CouponId { get; set; }
        public BigInteger TransactionId { get; set; }
        public double AmountPaid { get; set; }
    }
}
