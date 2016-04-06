using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
        Animal animal = new Animal();
        public string adopterName;
        public double adopterMoney;
        public Dog[] adoptersDog = { };

        public string[] adopterNames = { "Tyler", "Charles", "Greg", "Justin", "Ryan" };
        public Adopter()
        {
         
          Random randomName = new Random();
          adopterName = adopterNames[randomName.Next(0, adopterNames.Length)];
          adopterMoney = 300.00;
        }
     
    }
}
