﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            double myInt = 125.00; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER

            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE

            NumberConv();
        }

        static void NumberConv()
        {
            Console.Write("number: ");
            string binaryNum = "";
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                
                if (num % 2 == 0)
                {
                    binaryNum = "0" + binaryNum;
                }
                else
                {
                    binaryNum = "1" + binaryNum;
                }
                num = num / 2;
            }
            Console.WriteLine(binaryNum);
        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static int numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            string binaryNum = "";
            int num = number;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    return Convert.ToInt32("0" + binaryNum);
                }
                else
                {
                    return Convert.ToInt32("1" + binaryNum);
                }

            }
            return Convert.ToInt32(binaryNum);
            //return result; //REMOVE THE RED LINE!
        }
    }
}
