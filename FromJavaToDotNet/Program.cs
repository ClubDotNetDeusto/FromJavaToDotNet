using System;
using System.Collections.Generic;
using FromJavaToDotNet.ConceptosAvanzados.Inheritance;
using FromJavaToDotNet.ConceptosAvanzados.Interfaces;
using FromJavaToDotNet.ConceptosAvanzados.PartialClass;

namespace FromJavaToDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //VariableVar();
            //ControlEstructures();
            //InternalAndRefExamples();
            //UseOfCollections();
            //PartialClasses();
            Inheritance();
            //Interfaces();
            Console.ReadLine();
        }

        private static void Inheritance()
        {
            Vehicle v = new Car("asd", "asd");
            v.DoStuff();
            v.Walk();
        }

        private static void VirtualMethods()
        {
            throw new NotImplementedException();
        }

        private static void Interfaces()
        {
            var f = new FileParser();
            f.ContentReaded();
        }

        private static void PartialClasses()
        {
            var a = new Animal("White");
            a.DoSomething();
        }

        private static void UseOfCollections()
        {
            var lista = new List<string> {"hola"};
            for (var i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            var dict = new Dictionary<string, string> {{"hola", "mundo"}};
            Console.WriteLine(dict["hola"]);
        }

        private static void VariableVar()
        {
            var isPair = false;
            var random = new Random();

            if (random.Next()%2 == 0)
            {
                isPair = true;
            }
            Console.WriteLine(isPair);
        }

        private static void ControlEstructures()
        {
            var lista = new List<string> {"hola", "Mundo"};
            foreach (var word in lista)
            {
                Console.WriteLine(word);
            }
        }

        private static void InternalAndRefExamples()
        {
            var number = 5;
            MethodNormal(number);
            Console.WriteLine(number);
            //El envio de la variable es por REFERENCIA (¿os suenan los punteros de C++?)
            MethodOutModifier(out number);
            Console.WriteLine(number);
        }

        private static void MethodOutModifier(out int number)
        {
            number = 20;
        }

        private static void MethodNormal(int number)
        {
            number = 3;
        }
    }
}
