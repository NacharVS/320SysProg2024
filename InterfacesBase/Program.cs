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
            MachineGun machineGun = new MachineGun();

            Gunslinger.SingleShoot(machineGun);
            Gunslinger.SerialShoot(machineGun);
        }
    }
}
