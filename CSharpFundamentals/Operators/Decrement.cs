using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Operators
{
    public static class Decrement
    {
        public static void Execute()
        {
            int a = 10;

            //since value is decresed after the aparend, below shows 10
            Console.WriteLine("Postfix a-- is : " + a--);

            //Now it will display 9
            Console.WriteLine("after increment a-- :" + a);

            // since decrement happens before the apprend, 8 printed
            Console.WriteLine("Prefix increment --a:" + --a);

            Console.ReadLine();
            /*
             Postfix a-- is : 10
             after increment a-- :9
             Prefix increment --a:8
             */
        }
    }
}
