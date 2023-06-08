using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;


namespace Task_4
{
    internal class MyClass2
    {


        public void Draw2()
        {
            MyClass myClass = new MyClass();
            myClass.Draw();
        }


    }
}


namespace MyNamespace  //буде пыдключено до Task_2-dop
{
    public class MyClass
    {
        public void Draw()
        {
            Console.WriteLine("MyNamespace void Main");
        }
    }
}
