using System;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        public static void B005_BinaryToDecimal(){
            Problemstatement = "Binary to decimal conversion";
            LectureNumber = "One";
            AssignementNumber = "Five";
            printProblemStatement(Problemstatement,LectureNumber,AssignementNumber);

            Console.WriteLine("Enter the binary represantation to convert into decimal");
            int n = Convert.ToInt32(Console.ReadLine());

            // 1011 - 
            // 1011/10 - 1 * 2^0
            // 101/10 - 1 * 2^1
            // 10/10 - 0 * 2^2
            // 1/10 - 1 * 2 ^3
            // 0
            int dec = 0;
            int p = 0;
            while(n > 0){
                dec += n%10 * (int)Math.Pow(2,p);
                p++;
                n = n/10;
            }
            Console.WriteLine(dec);

        }
    }
}