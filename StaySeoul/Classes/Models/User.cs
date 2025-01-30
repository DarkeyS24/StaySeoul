using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class User
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public BigInteger UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int FamilyCount { get; set; }
    }
}
