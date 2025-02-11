using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class ItemAmenity
    {
        public BigInteger Id { get; set; }
        public Guid GUID = Guid.NewGuid();
        public BigInteger ItemId { get; set; }
        public BigInteger AmenityId { get; set; }

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
