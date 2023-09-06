using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObjectDataProvider
{
    public class MainViewModel
    {
        
            public List<StudentTest> list { get; set; }
            public MainViewModel()
            {
                list = new List<StudentTest> { new StudentTest("zangsan", "13"), new StudentTest("wangwu", "34") };

            }
        
    }
}
