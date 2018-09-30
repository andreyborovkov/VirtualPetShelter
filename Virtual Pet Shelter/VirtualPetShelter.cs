using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    static class VirtualPetShelter
    {
        //instantiates objects of the class VirtualPet and sets all the properties
        static VirtualPet virtualPet1 = new VirtualPet("Fluffy","Dog",45,12,65,43);
        static VirtualPet virtualPet2 = new VirtualPet("Spot","Dog",65,11,55,87);
        static VirtualPet virtualPet3 = new VirtualPet("Bambi","Deer",76,43,32,65);
        static VirtualPet virtualPet4 = new VirtualPet("Simba", "Lion",0,0,32,15);

        static List<string> pets = new List<string> {  virtualPet1.Name, virtualPet2.Name, virtualPet3.Name, virtualPet4.Name }; // List of pets
        static List<string> volunteers = new List<string> { "Chuck", "Bob", "Bill" };
        static List<string> managers = new List<string> { "Richard", "James", "Tomas" };



        public static void DisplayPets()//Displays the values in pets
        {
            for (int i = 0; i<pets.Count;i++)
            {
                Console.WriteLine(i+1 + " " + pets[i]);
            }
        }

        public static void DisplayVolunteers()//Displays the values in volunteers
        {
            for (int i = 0; i < volunteers.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + volunteers[i]);
            }
        }

        public static void DisplayManagers()//Displays the values in managers
        {
            for (int i = 0; i < managers.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + managers[i]);
            }
        }

        public static void PetsStatus()//calls a status method for every single pet
        {
            virtualPet1.Status();
            virtualPet2.Status();
            virtualPet3.Status();
            virtualPet4.Status();
        }


    }
}
