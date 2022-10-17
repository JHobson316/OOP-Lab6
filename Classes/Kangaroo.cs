using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public abstract class Kangaroo : Mammal{
        public override string Eats {get; set;} = "Grass, Flowers, Moss";
        public override string Sound {get; set;} = "Coughing or barking calls";
    }
}