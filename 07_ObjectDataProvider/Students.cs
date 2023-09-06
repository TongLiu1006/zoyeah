using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObjectDataProvider
{
    public class StudentTest
    {

        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        
        private string? age;
        public string? Age
        {
            get { return age; }
            set { age = value; }
        }

        public StudentTest(string name,string age)
        {
                this.name = name;
            this.age = age;
        }

        public StudentTest()
        {
            
        }
    }
}
