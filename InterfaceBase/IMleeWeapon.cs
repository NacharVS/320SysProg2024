﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal interface IMleeWeapon
    {
        public int Sharpness { get; }
        public void Hit();
    }
}