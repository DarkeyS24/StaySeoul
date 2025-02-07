using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Attraction
    {
        public BigInteger Id { get; set; }
        public Guid GUID = new Guid();
        public BigInteger AreaId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Guid GetGuid()
        {
            return GUID;
        }
        public void SetGuid(Guid guid)
        {
            GUID = guid;
        }
    }
}
