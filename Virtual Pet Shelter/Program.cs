using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    class Program
    {
        static void Main(string[] args)
        { 
            Volunteer volunteer = new Volunteer();
            Manager manager = new Manager();
            //VirtualPetShelter.DisplayPets();
            string position = "";
            bool isPositionNotAppropriate = true;
            while (isPositionNotAppropriate)//allows user to pick several different options
            {
                Console.WriteLine("Welcome to Big Al's Virtual Pet Shelter. What employee type are you?\n1.Manager\n2.Volunteer");
                position = Console.ReadLine();

                //Displays either volunteer or manager menu
                if (position == "1")
                {
                    Console.WriteLine("Thank you for working at Big Al's Virtual Pet Shelter!\nHere is the status of your pets");
                    manager.PetsStatus();
                    Console.WriteLine("\nWhat would you like to do?");
                    manager.Menu();
                    isPositionNotAppropriate = false;

                }
                else if (position == "2")
                {
                    Console.WriteLine("Thank you for volunteering at Big Al's Virtual Pet Shelter!\n\nWhat would you like to do?");
                    volunteer.Menu();
                    isPositionNotAppropriate = false;
                }
                else//if the user fails to pick an existing option he or she will be asked to try again
                {
                    Console.WriteLine("Try again.");
                }
            }

        }
    }
}
