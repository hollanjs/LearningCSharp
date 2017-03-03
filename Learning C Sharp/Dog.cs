using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        // one line setters and getters
        public string name { get; set; }
        public string owner { get; set; }
        
        // use override in the subclass if overriding original parent function
        public override void move()
        {
            // to call parent function, you can write:
            //base.move();
            Console.WriteLine("{0} is running.", this.name);
        }

        public override void makeNoise()
        {
            // to call parent function, you can write:
            //base.makeNoise();
            Console.WriteLine("Bark bark mutha trucka!");
        }
    }
}
