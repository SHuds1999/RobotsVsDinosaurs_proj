using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public int Health;
        public int Powerlevel;
       

        public Robot(int health, int powerlevel)
        {
            Health = health;
            Powerlevel = powerlevel;
           
        }


        //member methods (CAN DO)


        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.Health -= Powerlevel;





        }















    }




}
