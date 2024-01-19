using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Akifev320P
{
    internal class Barracs //class factory    {
        public Footman CreateRecruit()
    {
        return new Footman(60, "Recruit", 7);
    }
    public Footman CreateFootman()
    {
        return new Footman(90, "Foorman", 10);
    }
    public Footman CreateBerserker()
    {
        return new Footman(120, "Berserker", 15);
    }
}}