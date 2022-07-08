using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethodDemo
{
    internal class TestExtenssionMethod
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1(); //will call original method
            p.Test2();
            p.Test3();  //extenssion method
            p.Test4(10);

            Console.ReadLine();
        }
    }
}
