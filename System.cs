using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class System
    {
        bool done;
        int input;
        public Adopter adopters = new Adopter();
        public AnimalShelter animalShelter = new AnimalShelter();
        public System()
        {

        }
        public void NavigateShelter()
        {
            animalShelter.adopterSpawner();
           
            while (!done) {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("press 1 to add a new dog, press 2 to let a person adopt a dog.");
                Console.WriteLine("press 3 to check if the animal has had their shot, or press 4 to administer a shot to the animal.");
                Console.WriteLine("press 5 to check if the animal has been fed today, or press 6 to give an animal some food.");
                Console.WriteLine("press 7 to print out the current animals in the shelter.");
                Console.WriteLine("--------------------------------------");
                input = Convert.ToInt32(Console.ReadLine());
       
                switch (input)
                {

                    case 1:
                        animalShelter.addAnimal();
                        break;
                    case 2:
                        animalShelter.adoptAnimal();
                        break;
                    case 3:
                        animalShelter.checkShot();
                        break;
                    case 4:
                        animalShelter.giveShot();
                        break;
                    case 5:
                        animalShelter.checkAnimalHunger();
                        break;
                    case 6:
                        animalShelter.giveFood();
                        break;
                    case 7:
                        animalShelter.printCages();
                        break;
                    default:
                        done = true;
                        break;
                }
            }
        }
    }
}
