using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    class Manager:Employee
    {
        //properties
        public int NumberOfRelativesInTheCompany { get; set; }

        //methods
        public override void Menu()
        {
            bool isExitNotActivated = true;
            string option;

            while (isExitNotActivated)
            {
                Console.WriteLine("1.Feed the pets\n2.Adopt a pet\n3.Play with a pet\n4.Pay the bills\n5.Quit");
                option = Console.ReadLine();

                switch (option)//displays the menu for managers and depending on the option picked
                    //calls different methods
                {
                    case "1":
                        Console.WriteLine("That's not your job...");
                        break;
                    case "2":
                        Adopt();
                        break;
                    case "3":
                        Console.WriteLine("What pet do you want to play with?");
                        VirtualPetShelter.DisplayPets();
                        string numberOfPet = Console.ReadLine();
                        Console.WriteLine("Both of you had a lot of fun");
                        break;
                    case "4":
                        Console.WriteLine("You paid the bills");
                        break;
                    case "5":
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
            Console.WriteLine("Send a volunteer to get food from a restaurant");
        }

        public void Adopt()//displays a list of pets and simply says that the documents needs to be reviewed
            //after the user inputs anything
        {
            Console.WriteLine("What pet would you like to be adopted?");
            VirtualPetShelter.DisplayPets();
            string input = Console.ReadLine();
            Console.WriteLine("The adoption documents need to be reviewed.");
        }

        public void PetsStatus()//displays the status of every pet (the real method is in VirtualpetShelter class)
        {
            VirtualPetShelter.PetsStatus();
        }

    }
}
