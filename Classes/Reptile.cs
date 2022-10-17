using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab6.Interfaces;

namespace Lab6.Classes{
    public abstract class Reptile : Animal{
        public override string Eats {get; set;} = "Meat and bugs";
        public override string Sound {get; set;} = "(Usually Silent)";
        public abstract string Color {get; set;}
        public abstract string Species {get; set;}
    }
}