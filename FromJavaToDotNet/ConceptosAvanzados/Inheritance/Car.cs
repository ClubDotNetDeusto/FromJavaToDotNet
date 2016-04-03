using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.Inheritance
{
    public class Car : Vehicle
    {
        public string Name { get; set; }

        public Car(string e, string n) : base(e)
        {
            Name = n;
        }

        public override void Walk()
        {
            base.Walk();
            Console.WriteLine("I move as a car");
        }

        public override void DoStuff()
        {
            Console.WriteLine("I do things...");
        }
    }
}
