using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Coupon
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public string CouponCode { get; set; }
        public double DiscountPercent { get; set; }
        public double MaximumDiscountAmount{ get; set; }
    }
}
