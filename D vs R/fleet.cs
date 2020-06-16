using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace D_vs_R
{
    public class fleet
    {
        // member variable
        public List<robot> robotFleet = new List<robot>();

        // constructor


        public void PopulateFleet()
        {
            //instantiate three robot objects
            //for loop or just create them on three separate lines
            //list add method

            //when instantiating a new object: 
            //assign values to your robot member variables
            robot newrobot1 = new robot("Ruby");
            robot newrobot2 = new robot("Sky");
            robot newrobot3 = new robot("Ted");

            robotFleet.Add(newrobot1);
            robotFleet.Add(newrobot2);
            robotFleet.Add(newrobot3);

           
        }
    }
}
