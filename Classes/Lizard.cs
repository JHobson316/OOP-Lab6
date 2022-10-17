using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public abstract class Lizard : Reptile{
        public override string Eats {get; set;} = "Meat";
        public override string Sound {get; set;} = "Chirp, Squeak, Click";
        public bool HasLegs {get; set;} = true;
    }
}