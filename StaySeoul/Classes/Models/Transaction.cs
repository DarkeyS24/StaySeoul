using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Transaction
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger UserId { get; set; }
        public BigInteger TransactionTypeId { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string GatewayReturnId { get; set; }
    }
}
