using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes{
    public abstract class Snake : Reptile, IAnimal{
        public override string Eats {get; set;} = "Meat and bugs";
        public override string Sound {get; set;} = "(Usually Silent)";
        public override string Color {get; set;} = "Green";
        public override string Species{get; set;} = "Viper";
    }
}