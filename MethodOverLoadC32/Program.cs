using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


namespace MethodOverLoadC32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(10, 10, true);
            Console.WriteLine(answer1);

            var answer2 = Add(7.7m, 2.3m);
            Console.WriteLine(answer2);

            var answer3 = Add(125, 17);





        }

        public static string Add(int num1, int num2, bool isDollars)
        {
            int sum = num1 + num2;
            if (isDollars)
            {
                if (sum < 0)
                    return $"{sum}  dollars";
            }
            else if (sum == 1)
            {
                return $"{sum}  dollar";
            }
            else if (sum > 0)
            {
                return $"{sum} dollars";
            }
            return sum.ToString() ;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        

            public static int Add(int num1, int num2)
            {
            return num1 + num2;


            }




    }


}










