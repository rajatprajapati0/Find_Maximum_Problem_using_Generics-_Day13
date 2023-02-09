using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Find_Maximum_By_Genric
{

    public class Test
    {
        MaxValue maxValue;
        public Test()
        {
         maxValue=new MaxValue();
        }
        public void TestForMax()
        {
            Console.WriteLine("enter three value and find maximum ");
            
            int option=int.Parse(Console.ReadLine());
            

            switch (option)
            {
                case 1:
                    var a = int.Parse(Console.ReadLine());
                    var b = int.Parse(Console.ReadLine());
                    var c = int.Parse(Console.ReadLine());
                    Console.WriteLine(maxValue.FindMaxValue<int>( a, b , c));
                    break;

                case 2:
                    var a2 = float.Parse(Console.ReadLine());
                    var b2 = float.Parse(Console.ReadLine());
                    var c2 = float.Parse(Console.ReadLine());
                    Console.WriteLine( maxValue.FindMaxValue<float>(a2, b2, c2));
                   
                  
                    break;

                case 3:Console.WriteLine("enter name like apple,peach,banana,");
                    var a1 = Console.ReadLine();
                    var b1 = Console.ReadLine();
                    var c1 = Console.ReadLine();
                    Console.WriteLine(maxValue.FindMaxValue<string>(a1, b1, c1));
                  
                    break;

                default:
                    Console.WriteLine("enter correct option");
                    break;

            }
        }
    }
}
