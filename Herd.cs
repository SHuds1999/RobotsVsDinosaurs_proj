using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> Dinos;






        public Herd()
        {

            Dinos = new List<Dinosaur>();

            Dinosaur dino1 = new Dinosaur("Flying", 1000, 1000, 100);
            Dinosaur dino2 = new Dinosaur("Ground", 500, 500, 50);
            Dinosaur dino3 = new Dinosaur("Water", 250, 250, 25);

            Dinos.Add(dino1);
            Dinos.Add(dino2);
            Dinos.Add(dino3);






        }








    }
}
