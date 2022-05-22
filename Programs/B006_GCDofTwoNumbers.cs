using System;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        public static void B006_GCDofTwoNumbers(){
            Problemstatement = "Find greatest common divisor of two numbers";
            LectureNumber = "One";
            AssignementNumber = "Six";
            printProblemStatement(Problemstatement,LectureNumber,AssignementNumber);

            Console.WriteLine("Enter the first number to find GCD");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number to find GCD");
            int n = Convert.ToInt32(Console.ReadLine());
            (m,n) = swapMax(m,n);
            
            //8|12 - 4|8 - 0
            //  12|16 - 4|12 - 0 
            // 15|78 - 3|15 - 0
            
            while(m%n != 0)
            {
                int temp = m % n;
                m  = n;
                n = temp;
            }
            Console.WriteLine("GCD : " + n);

        }


        public static (int,int) swapMax(int m, int n){
            if(m>n){ return (m,n); }
            else {return (n,m);}
        }
    }  
}