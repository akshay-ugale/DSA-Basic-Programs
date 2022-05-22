﻿using System.Drawing;
using System;
using System.IO;
using System.Reflection;
using System.Linq;

namespace DSA_Basic_Programs
{
    public partial class Program
    {
        static string Problemstatement = "Please enter the problem statement";
        static string LectureNumber = "Please enter lecture number";
        static string AssignementNumber = "PLease enter assignemnt number";

        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@".\Programs\");
            FileInfo[] files = di.GetFiles("*.cs");
            
            Console.WriteLine("Below are the programm's, please select the corresponding number to call one");
            int cnt = 1;
            foreach (FileInfo file in files)
            {
                Console.WriteLine(cnt.ToString("000") + " : " + file.Name);
                cnt++;
            }
            int inputProg = Convert.ToInt32(Console.ReadLine());
            string method = files[inputProg-1].Name.ToString();
            var methodTrimmed = method.TrimEnd(new char[] { '.', 'c', 's' });
            //string method = args[0]; // get name method
            CallMethod(methodTrimmed);
            Console.WriteLine("Program {0} ended successfully", method);
            Console.ReadKey();
           
        }

        public static void CallMethod(string method)
        {
            try
            {
                
                Type type = typeof(Program);
                MethodInfo methodInfo = type.GetMethod(method);
                methodInfo.Invoke(method, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }

        public static void printProblemStatement(string statement, string lecture, string assignemnt){
            string print = "Lecture : " + lecture + "\nAssignement : " + assignemnt + "\nProblem statment : \n" + statement;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(print);
            Console.WriteLine("---------------------------------------------");

        }

    }
}
