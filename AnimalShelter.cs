using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AnimalShelter
    {


        public List<Adopter> adopterList = new List<Adopter>();
        public List<string> adoptedHistory = new List<string>();
        public Adopter adopter = new Adopter();
        public List<Animal> cage = new List<Animal>();
        public int adopterRecordNumber;
        public int cageNumber;
        public int input;
        public int animalValue;
        public double shelterMoneyBalance;

        public AnimalShelter()
        {
            animalValue = 200;
    }
        public void adopterSpawner()
        {
            Console.WriteLine("5 adopters have become interested in adopting an animal");
            for (int numberOfAdopters = 0; numberOfAdopters < 5; numberOfAdopters++)
            {
                adopterList.Add(new Adopter());
                Thread.Sleep(20);

            }

            for (adopterRecordNumber = 0;adopterRecordNumber< adopterList.Count;adopterRecordNumber++)
            {

                Console.WriteLine(adopterList[adopterRecordNumber].adopterName);

            }
        }
        public void addAnimal()
        {
            Console.WriteLine("press 1 to add a dog or press 2 to add a cat!");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input) {
                case 1:
            cage.Add(new Dog());

            Console.WriteLine("you've added " + cage[cage.Count - 1].animalName + " to the system.");
                    break;
                case 2:
                    cage.Add(new Cat());
                    Console.WriteLine("you've added " + cage[cage.Count - 1].animalName + " to the system.");
                    break;
            }

        }
        public void adoptAnimal()
        {
            Console.WriteLine("please enter the cage number of a animal you'd like to remove and sell.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            
            if (cage.Count > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("the first cage is now populated by the next animal.");
                adoptedHistory.Add(adopterList[adopterRecordNumber - 1].adopterName);
                adoptedHistory.Add(cage[cageNumber - 1].animalName);
                cage.Remove(cage[cageNumber - 1]);
                adopterList.Remove(adopterList[adopterRecordNumber - 1]);
                Console.WriteLine("");
                Console.WriteLine(adoptedHistory[adoptedHistory.Count-2] + " adopted " + adoptedHistory[adoptedHistory.Count-1] + ", ");
                
                Console.WriteLine("");
                shelterMoneyBalance = shelterMoneyBalance + animalValue;
                    Console.WriteLine("the Animal Shelter now has || $ " + shelterMoneyBalance + " ||");
                    Console.WriteLine("the adopter spent $200 and now has " + adopter.adopterMoney + " left over.");
                    Console.WriteLine("");
                
                
            }

            else if (adopter.adopterMoney < 0)
            {
                Console.WriteLine("the adopter doesn't have any money to adopt an animal.");
            }
            else if (cage.Count <= 0)
            {
                Console.WriteLine("there are no animals to sell for adoption.");
            }
            else
            {
                Console.WriteLine("nothing happened.");
            }
        }


        public void giveShot()
        {
            Console.WriteLine("select a cage to give a shot to.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage[cageNumber-1].hadShot!= true)
            {
                Console.WriteLine("you gave " + cage[cageNumber - 1].animalName + " a shot.");
                cage[cageNumber-1].hadShot = true;
            }
            else
            {
                Console.WriteLine(cage[cageNumber-1].animalName + " has had a shot already, please stop.");
            }
        }
        public void checkShot()
        {
            Console.WriteLine("select a cage to check if they have had their shot.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage[cageNumber-1].hadShot == true)
            {
                Console.WriteLine(cage[cageNumber - 1].animalName  + " had their shot already.");
            } else if (cage[cageNumber-1].hadShot == false)
            {
                Console.WriteLine(cage[cageNumber-1].animalName + " hasn't had their shot, please administer a shot to this animal.");
            }
        }
        public void checkAnimalHunger()
        {
            Console.WriteLine("select a cage to check if they have been fed or not.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage[cageNumber-1].hasBeenFed == true)
            {
                Console.WriteLine(cage[cageNumber - 1].animalName + " has been fed");
            }
            else if (cage[cageNumber-1].hasBeenFed == false)
            {
                Console.WriteLine(cage[cageNumber - 1].animalName +" hasn't hasn't been fed, please give the animal some food!");
            }
        }
        public void giveFood()
        {
            Console.WriteLine("select a cage animal to give food to.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage[cageNumber-1].hasBeenFed != true)
            {
                Console.WriteLine("you gave " + cage[cageNumber - 1].animalName + " some food.");
                cage[cageNumber-1].hasBeenFed = true;
            }
            else
            {
                Console.WriteLine(cage[cageNumber - 1].animalName + " has had food already, please stop.");
            }
        }
        public void printCages()
        {
                for(int i = 0; i < cage.Count; i++)
                {
                Thread.Sleep(10);
                    Console.WriteLine(cage[i].animalName);
                }
            }

        }
    }


