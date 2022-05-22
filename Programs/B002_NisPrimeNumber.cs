using System;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        public static void B002_NisPrimeNumber(){
            Problemstatement = "Find if the given number is a prime number or Not";
            LectureNumber = "One";
            AssignementNumber = "one";
            printProblemStatement(Problemstatement,LectureNumber,AssignementNumber);

            Console.WriteLine("Enter the number to check if its prime");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i*i >= n; i++){
                if(n%i==0){
                    Console.WriteLine("{0} is not a prime number", n);
                    isPrime = false;
                    break;
                }
            }
            if(isPrime){
                Console.WriteLine("{0} is a prime number", n);
            }
            

        }
    }
}