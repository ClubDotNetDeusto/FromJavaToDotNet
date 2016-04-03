using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.Interfaces
{
    public class FileParser : IParser
    {
        public string Descriptor { get; set; }

        public FileParser()
        {
            Descriptor = "I parse files :)";
        }
        public string ContentReaded()
        {
            Console.WriteLine(Descriptor);
            return "";
        }
    }
}
