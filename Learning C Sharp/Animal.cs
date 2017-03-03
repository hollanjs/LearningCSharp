using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Animal
    {
        // can't change outside of class because of private
        private string type;
        private string color;
        private int weight;
        private int height;
        private int age;
        private int numLegs;
        
        // create methods to access (get, set) private variables
        // use public so that these methods are accessible
        // use uppercase first letter for methods accessing private variables
        public int Age
        {
            get { return this.age; }
            // never trust user input
            // we can break these parts down to insert validation
            // without validation, it looks simple like this:
            // set { this.age = value; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be less than 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public void move()
        {
            Console.WriteLine("moved");
        }

        public void makeNoise()
        {

        }
    }
}
