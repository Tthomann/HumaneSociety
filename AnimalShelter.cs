using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AnimalShelter
    {
        public Adopter adopter = new Adopter();//
        public Animal animal = new Animal();//
        public Cage cage = new Cage();//
        int cageNumber;
        public double shelterMoneyBalance;
        public AnimalShelter()
        {

        }
        public void feedAnimal()
        {

        }
        public void addAnimal()
        {

            cage.dogCage.Add(new Dog());
            Console.WriteLine("you've added " + cage.dogCage[cageNumber].animalName + " to the system.");


        }
        public void removeAnimal()
        {
            Console.WriteLine("please enter the cage number of a dog you'd like to remove and sell.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage.dogCage.Count > 0)
            {
                
                cage.dogCage.Remove(cage.dogCage[cageNumber]);
                shelterMoneyBalance += 240.00;
                Console.WriteLine("");
                Console.WriteLine("you sold a testDog to an " + adopter.adopterName + ", the Humane Society made $240 from selling the testDog.");
                Console.WriteLine("the Animal Shelter now has || $ " + shelterMoneyBalance + " ||");
                Console.WriteLine("the adopter spent $240 and now has " + adopter.adopterMoney + " left over.");
                Console.WriteLine("");
                adopter.adopterMoney -= 240.00;
            }

            else if (adopter.adopterMoney < 0)
            {
                Console.WriteLine("the adopter doesn't have any money to adopt an animal.");
            }
            else if (cage.dogCage.Count <= 0)
            {
                Console.WriteLine("there are no dogs to sell for adoption.");
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
            if (cage.dogCage[cageNumber].hadShot!= true)
            {
                Console.WriteLine("you gave the animal a shot.");
                cage.dogCage[cageNumber].hadShot = true;
            }
            else
            {
                Console.WriteLine("this animal has had a shot already, please stop.");
            }
        }
        public void checkShot()
        {
            Console.WriteLine("select a cage to check if they have had their shot.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage.dogCage[cageNumber].hadShot == true)
            {
                Console.WriteLine("this animal had their shot");
            } else if (cage.dogCage[cageNumber].hadShot == false)
            {
                Console.WriteLine("this animal hasn't had their shot, please administer a shot to this animal.");
            }
        }
        public void checkAnimalHunger()
        {
            Console.WriteLine("select a cage to check if they have been fed or not.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage.dogCage[cageNumber].hasBeenFed == true)
            {
                Console.WriteLine("this animal has been fed");
            }
            else if (cage.dogCage[cageNumber].hasBeenFed == false)
            {
                Console.WriteLine("this animal hasn't hasn't been fed, please give the animal some food!");
            }
        }
        public void giveFood()
        {
            Console.WriteLine("select a cage animal to give food to.");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            if (cage.dogCage[cageNumber].hasBeenFed != true)
            {
                Console.WriteLine("you gave the animal some food.");
                cage.dogCage[cageNumber].hasBeenFed = true;
            }
            else
            {
                Console.WriteLine("this animal has had food already, please stop.");
            }
        }
        public void printCages()
        {
                foreach (Dog dog in cage.dogCage)
                {
                    Console.WriteLine(cage.dogCage[0].animalName);
                }
            }

        }
    }


