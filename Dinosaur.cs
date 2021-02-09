using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {

       public string Type;
       public int Health;
       public  int Energy;
       public  int AttackPower;

        public Dinosaur(string type, int health, int energy, int attackpower )
        {
            Type = type;
            Health = health;
            Energy = energy;
            AttackPower = attackpower;

        }


        //member methods

        public void Dinoattack(Robot robot)
        {
            robot.Health -= AttackPower;
        }




    }
}
