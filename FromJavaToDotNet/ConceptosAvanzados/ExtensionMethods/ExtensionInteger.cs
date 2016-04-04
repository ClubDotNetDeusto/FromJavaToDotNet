using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.ExtensionMethods
{
    public static class ExtensionInteger
    {
        public static int IncreaseByOne(this int number)
        {
            return number + 1;
        }
    }
}
