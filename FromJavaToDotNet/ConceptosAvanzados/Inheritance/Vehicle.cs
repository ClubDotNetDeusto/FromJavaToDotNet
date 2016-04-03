using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.Inheritance
{
    public abstract class Vehicle
    {
        public string Enrollment { get; set; }

        protected Vehicle(string e)
        {
            Enrollment = e;
        }

        public virtual void Walk()
        {
            Console.WriteLine("I moved :)");
        }

        public abstract void DoStuff();
    }
}
