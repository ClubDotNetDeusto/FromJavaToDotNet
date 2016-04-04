using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromJavaToDotNet.ConceptosAvanzados.OperatorOverload
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Teacher(string n, string d)
        {
            Name = n;
            Desc = d;
        }

        public static bool operator==(Teacher a, Teacher b)
        {
            if (!a.Equals(null) && !b.Equals(null))
            {
                if (a.Name == b.Name)
                {
                    if (a.Desc == b.Desc)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Teacher a, Teacher b)
        {
            return !(a == b);
        }
    }
}
