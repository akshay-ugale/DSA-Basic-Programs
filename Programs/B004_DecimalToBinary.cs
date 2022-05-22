using System;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        public static void B004_DecimalToBinary(){
            Problemstatement = "Convert the given number to Binary";
            LectureNumber = "One";
            AssignementNumber = "one";
            printProblemStatement(Problemstatement,LectureNumber,AssignementNumber);

            Console.WriteLine("Enter the number for Decimal to binary conversion");

            // n -> 23
            // 23/2 - 1
            // 11/2 -1
            // 5/2 - 1
            // 2/2 - 0
            // 1/2 - 1

            int n = Convert.ToInt32(Console.ReadLine());
            int binaryRepresentation = 0;
            int p = 0;
            while(n > 0){
                binaryRepresentation = (n%2)* (int)Math.Pow(10,p) + binaryRepresentation;
                n = n/2;
                p++;
            }
            Console.WriteLine(binaryRepresentation);

            
        }
    }
}