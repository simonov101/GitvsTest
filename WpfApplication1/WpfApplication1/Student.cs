using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Student
    {
        private string name;
        private string adress;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adress;

        public override string ToString()
        {
            return "Hello Mr" + name+" you live : " + Adress;
        }
    }
}
