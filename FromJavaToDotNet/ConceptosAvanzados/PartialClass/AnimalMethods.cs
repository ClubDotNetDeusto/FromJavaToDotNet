using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.PartialClass
{
    public partial class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
