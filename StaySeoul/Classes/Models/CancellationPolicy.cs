﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StaySeoul.Classes.Models
{
    internal class CancellationPolicy
    {
        public BigInteger Id { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public double Commission { get; set; }
    }
}
