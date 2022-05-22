using System;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        public static void B003_PrimeNumberUptoN()
        {
            Problemstatement = "Find prime numubers upto N";
            LectureNumber = "One";
            AssignementNumber = "Two";

            printProblemStatement(Problemstatement, LectureNumber, AssignementNumber);
            Console.WriteLine("Enter the number to get prime numbers upto N");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2");
            for (int j = 1; j <= n; j++)
            {
                bool isPrime = true;
                for (int i = 2; i * i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        //Console.WriteLine("{0} is not a prime number", j);
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} is a prime number", j);

                }
            }



        }
    }
}