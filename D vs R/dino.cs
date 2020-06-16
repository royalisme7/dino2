using D_vs_R;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace D_vs_R
{
    // I want a Dinosaur to have a type, health, energy, and attack 
    public class dino
    {//no code above this line
        public string type;
        public int health;
        public int energy;
        public int attackPower;


       

        public dino()
        {
            health = 100;
            attackPower = 100;// SetAttackPower();
            energy = 100;

        
        }

        //methods-what a dino CAN do
        //need an attack method  "What would happen IF this method is called?"

        //inside that method, what variables are we wanting to change?  What happens when a dino attacks?
        public void Attack(robot robotBeingAttacked);

       public void  robotBeingAttacked.powerlevel --10;
           robot attackPower = 10;
           robot energy = 2;
            robot health=3; 
        
        engery--;
            health--;
            attackPower--;
        }


        //public int SetAttackPower()
        //{
        //    int attack = 0;
        //    return attack;
        //}

        //No code below this line
    }
   
       
    

}