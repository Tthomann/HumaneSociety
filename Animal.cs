using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Animal
    {
        public bool hadShot;
        public bool hasBeenFed;

        
        public string animalName;

        public Animal()
        {
        List<string> names = new List<string> { "Pennie", "Daisy", "Lacey", "Abby", "Paul", "Mittens", "Boxey", "Barf", "Angsty", "Bartok" };
            Random randomName = new Random();
            animalName = names[randomName.Next(0, names.Count)];
            hadShot = false;
            hasBeenFed = false;
           
           
        }
    
    }
}
