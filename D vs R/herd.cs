using System;
using System.Collections.Generic;
using System.Text;

namespace D_vs_R
{
    public class herd
    {
        //this will look similar to the fleet class but will have Dino instead
            public List<dino> herdtFleet = new List<dino>();

        public void Populateherd()
        {
            //instantiate three robot objects
            //for loop or just create them on three separate lines
            //list add method

            //when instantiating a new object: 
            //assign values to your robot member variables
            dino newdino1 = new dino ();
            dino newdino2 = new dino();
            dino newdino3 = new dino();

            herdtFleet.Add(newdino1);
            herdtFleet.Add(newdino2);
            herdtFleet.Add(newdino3);
        }

    }
}
