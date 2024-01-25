using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pistol pistol = new Pistol();
            MachineGun pp = new MachineGun();

            Gunslinger.SingleShoot(pp);
            Gunslinger.MultiShoot(pp);
        }
    }
}
