using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Operators
{
    public static class Increment
    {
        public static void Execute()
        {
            int a = 10;
           
            //since value is increased after the aparend, below shows 10
            Console.WriteLine("Postfix a++ is : " + a++);

            //Now it will display 11
            Console.WriteLine("after increment a++ :" + a);

            // since increment happens before the apprend, 12 printed
            Console.WriteLine("Prefix increment ++a:" + ++a);

            Console.ReadLine();

            /*
            Output :
            Postfix a++ is : 10
            after increment a++ :11
            Prefix increment ++a:12
             
             */


        }
    }
}
