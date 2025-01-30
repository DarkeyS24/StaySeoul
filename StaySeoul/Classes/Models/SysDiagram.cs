using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class SysDiagram
    {
        public string Name { get; set; }
        public int PrincipalId { get; set; }
        public int DiagramId { get; set; }
        public int Version { get; set; }
        public byte[] Definition { get; set; }
    }
}
