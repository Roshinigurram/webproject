using project1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.di
{
    public class Example: IExample
    {
        public void MyMethod()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
