using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethodDemo
{
    internal static class ExtenssionClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method 3\n");
        }

        public static void Test4(this Program p,int i)
        {
            Console.WriteLine("Method 4 = "+i);
        }

        //will ignore this method
        public static void Test1(this Program p)
        {
            Console.WriteLine("Method with same name and signature\n");
        }


    }
}
