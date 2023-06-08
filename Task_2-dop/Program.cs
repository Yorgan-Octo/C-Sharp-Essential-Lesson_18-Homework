using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;
using Task_4;
using MyNamespace; //завдання 4

namespace Task_2_dop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseClass baseObj = new BaseClass(); //завдання 2
            baseObj.PublicMethod(); //завдання 2

            DerivedClass derivedObj = new DerivedClass(); //завдання 2
            derivedObj.PublicMethod(); //завдання 2

            MyClass myClass = new MyClass(); //завдання 4

            myClass.Draw(); //завдання 4

            Console.ReadKey();
        }
    }
}
