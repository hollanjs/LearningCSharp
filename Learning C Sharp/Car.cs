using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        
        public virtual void Drive()
        {
            Console.WriteLine("The {0} {1} {2} is driving", this.color, this.make, this.model);
        }

        public virtual void Stop()
        {
            Console.WriteLine("The {0} {1} {2} has stopped", this.color, this.make, this.model);
        }

        public Car()
        {
            this.make = "cheap";
            this.model = "piece of crap";
            this.color = "beige";
        }

        public Car(string mk, string mdl, string clr)
        {
            this.make = mk;
            this.model = mdl;
            this.color = clr;
        }
    }
}
