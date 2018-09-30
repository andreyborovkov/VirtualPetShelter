using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Shelter
{
    class VirtualPet
    {

        //fields
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private string name;
        private string description;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }


        //constructors
        public VirtualPet()
        {

        }
        public VirtualPet(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public VirtualPet(string name, string description, int hunger, int thirst, int boredom, int tiredness)
        {
            Name = name;
            Description = description;
            Hunger = hunger;
            Thirst = thirst;
            Boredom = boredom;
            Tiredness = tiredness;
        }

        public void Status()//outputs a single pet status
        {
            Console.WriteLine("Hunger: {1} Thirst: {2}, Boredom: {3}, Tiredness: {4} - {0}", Name, Hunger, Thirst, Boredom, Tiredness);          
        }
    }
}
