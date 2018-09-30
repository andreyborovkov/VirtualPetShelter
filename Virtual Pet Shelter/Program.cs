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
            while (isPositionNotAppropriate)
            {
                Console.WriteLine("Welcome to Big Al's Virtual Pet Shelter. What employee type are you?\n1.Manager\n2.Volunteer");
                position = Console.ReadLine();

                if (position == "1")
                {
                    Console.WriteLine("Thank you for working at Big Al's Virtual Pet Shelter!\nHere is the status of your pets");
                    manager.PetsStatus();//when this line of code ran with debugger values are unique for each pet
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
                else
                {
                    Console.WriteLine("Try again.");
                }
            }

        }
    }
}
