using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Interface : AnimalShelter
    {
        bool done;
        int input;
        public Interface()
        {

        }
        public void NavigateShelter()
        {

           
            while (!done) {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("press 1 to add a testDog, press 2 to remove a testDog.");
                Console.WriteLine("press 3 to check if the animal has had their shot, or press 4 to administer a shot to the animal.");
                Console.WriteLine("press 5 to check if the animal has been fed today, or press 6 to give an animal some food.");
                Console.WriteLine("press 7 to print out the current animals in the shelter.");
                Console.WriteLine("--------------------------------------");
                input = Convert.ToInt32(Console.ReadLine());
       
                switch (input)
                {

                    case 1:
                        addAnimal();
                        break;
                    case 2:
                        removeAnimal();
                        break;
                    case 3:
                        checkShot();
                        break;
                    case 4:
                        giveShot();
                        break;
                    case 5:
                        checkAnimalHunger();
                        break;
                    case 6:
                        giveFood();
                        break;
                    case 7:
                        printCages();
                        break;
                    default:
                        done = true;
                        break;
                }
            }
        }
    }
}
