﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal interface IRangeWeapon
    {
        int Range { get; }

        void Shoot();
    }
}
