using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {

        public List<Robot> RoboticFleet;

        


        public Fleet()
        {

            RoboticFleet = new List<Robot>();

             Robot robot1 = new Robot(1000, 100);
            Robot robot2 = new Robot(500, 50);
            Robot robot3 = new Robot (250, 25);



            RoboticFleet.Add(robot2);
            RoboticFleet.Add(robot1);
            RoboticFleet.Add(robot3);



            




        }















    }
}
