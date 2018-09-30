using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    class Volunteer:Employee
    {
        //properties
        public int YearsOfExperience { get; set; }

        //methods
        public override void Menu()
        {
            bool isExitNotActivated = true;
            string option;

            while (isExitNotActivated)//allows the user to pick another option after picking anything
            {
                Console.WriteLine("1.Feed the pets\n2.Water the pets\n3.Play with a pet\n4.Quit");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        FeedAll();
                        break;
                    case "2":
                        WaterAll();
                        break;
                    case "3"://outputs the list of pets, takes in any value from the user, and displays a message
                        Console.WriteLine("What pet do you want to play with?");
                        VirtualPetShelter.DisplayPets();
                        string numberOfPet = Console.ReadLine();
                        Console.WriteLine("Both of you had a lot of fun");
                        break;
                    case "4"://closes the console
                        Environment.Exit(0);
                        isExitNotActivated = false;
                        break;
                    default:
                        Console.WriteLine("Nothing happened");
                        Menu();
                        break;

                }
            }

        }

        public override void LunchTime()
        {
            Console.WriteLine("Eat pasta");
        }

        public void FeedAll()
        {
            Console.WriteLine("All the pets are fed");
        }

        public void WaterAll()
        {
            Console.WriteLine("All the pets are watered");
        }
    }
}
