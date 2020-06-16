using System;
using System.Collections.Generic;
using System.Text;

namespace D_vs_R
{
    public class robot
    // I want to instantiate three Robot objects and three Dinosaur objects and assign the appropriate values to all the objects
    {
        public string name;
        public int health;
        public int powerlevel;
        public int attackPower;
        public int  weapon weapon = new weaponchoice();

        //constructor
        public robot(string name)
        {
            this.name = name;
            attackPower = 10;
            powerlevel = 2;
            health = 3;
                    
        }

        //attack method
        public void attack(dino dinoBeingAttacked)
           
        {
            // lower the 'health'
            dinoBeingAttacked.health -= 10;
 
            powerlevel--;
            dino health--;
           dino attackPower--;

            string DinoAttack = 5;
           dino attackPower = 10;
          dino energy = 2;
           dino health = 3;
        }
        
    }

}
