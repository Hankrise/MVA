﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoringWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "\a";
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your C:\\drive";
            //string myString = "Go to your C:\drive";
            //string myString = String.Format("{1} = {0}{1}", "First", "Second");

            //string myString = String.Format("{0:C}",123.45);
            //string myString = String.Format("{0:N}",1234567890);
            //string myString = String.Format("Percentage: {0:P}", .123);
            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 1234);
            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 123456789012);

            //string myString = " That summer we took trees across the board  ";
            //myString = myString.Substring(1);
            //myString = myString.Substring(1,14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Length before:{0} -- Length after:{1}",
                myString.Length,
                myString.Trim().Length);
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder(); //stringBuilder相比string更高效
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.WriteLine(string.Format("{0:#,###.##}", 1234.56));
            Console.ReadLine();
        }
    }
}
