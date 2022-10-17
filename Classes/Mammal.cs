using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public abstract class Mammal : Animal{
        public override string Eats {get; set;} = " ";
        public override string Sound {get; set;} = " ";
        public abstract string LandOrSea {get; set;}
    }
}