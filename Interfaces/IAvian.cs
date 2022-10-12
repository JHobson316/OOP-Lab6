using System;

namespace OOPLab6.Interfaces{
    public interface IAvian{
        ///<summary>
        ///Flight?
        ///</summary>
        bool CanItFly {get; set;}

        ///<summary>
        ///Average Wingspan
        ///</summary>
        double AvgWingspan {get; set;}
        void Birdsong();
    }
}