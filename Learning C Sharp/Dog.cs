using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Dog : Animal
    {
        public string Name { get; set; }

        public void move()
        {
            Console.WriteLine("{0} moved.", this.Name);
        }
    }
}
