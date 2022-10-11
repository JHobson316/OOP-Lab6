using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public class Avian : Animal{
        public override string Eats {get; set;} = "Seeds";
        public override string Sound {get; set;} = "Chirp";
        public abstract bool CanFly {get; set;}
        public abstract bool LaysEggs {get; set;}
    }
}