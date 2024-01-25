using InterfacesBase;

Pistol pistol = new Pistol();
Machinegun pp = new Machinegun();
Knife knife = new Knife();
Bazooka bazooka = new Bazooka();
LaserRifle laserRifle = new LaserRifle();
PlasmaGrenade plasmaGrenade = new PlasmaGrenade();
ImpulseRifle impulseRifle = new ImpulseRifle();

Gunslinger.SingleShoot(pistol);
Gunslinger.SingleShoot(pp);
Gunslinger.MultiShoot(pp);
Gunslinger.Hit(knife);
Gunslinger.SingleShoot(bazooka);
Gunslinger.SingleShoot(laserRifle);
Gunslinger.Throw(plasmaGrenade);
Gunslinger.SingleShoot(impulseRifle);


// 1. Реализовать Нож, Базуку, Лазерную винтовку, Плазменная граната, Импульсная винтовка
// 2. IMeleeWeapon, IExplosiveWeapon, IEnergyWeapon
