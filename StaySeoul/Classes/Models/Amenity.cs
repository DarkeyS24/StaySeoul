using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class Amenity
    {
        public BigInteger Id { get; set; }
        public Guid GUID = new Guid();
        public string Name { get; set; }
        public string IconName { get; set; }

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
