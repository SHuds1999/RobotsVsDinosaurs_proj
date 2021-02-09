using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Herd Dinoherd;
        public Fleet Robofleet;
        //member variables



        //constructor
        public Battlefield()
        {

            Dinoherd = new Herd();
            Robofleet = new Fleet();           




        }



        //member methods

        // Build a Battle method 
        // Battle method should have a while loop
        // While loop condition should check and only continue if both list still have a count of one or more
        // Within the loop have index 0 of dinos list attack index 0 of robots list and vise versa
        // After each attack, check the attacked objects health
        // If the health is less than or eqaul to zero, remove that object from the list

        public void BattlefieldAttack()
        {

            while (Dinoherd.Dinos.Count > 1 || Robofleet.RoboticFleet.Count > 1 )
            {
                do Dinoherd[0] 
               




            }






        }












    }
}
