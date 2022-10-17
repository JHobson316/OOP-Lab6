using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public abstract class Horse : Mammal{
        public override string Eats {get; set;} = "Hay";
        public override string Sound {get; set;} = "Neigh!";
        public override string LandOrSea {get; set;} = "Land";
        public Horse(string name, string breed){

        }
    }
}