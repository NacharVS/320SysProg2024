﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPistol
{
    internal interface IMeleeWeapon : IWeapon
    {
        public int Sharpness { get; }
        public void Stab();
    }
}