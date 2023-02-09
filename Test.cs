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
        public void TestForMax()
        {
            Console.WriteLine("enter three value and find maximum ");
            bool run = true;
            while(run)
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        var a = int.Parse(Console.ReadLine());
                        var b = int.Parse(Console.ReadLine());
                        var c = int.Parse(Console.ReadLine());
                        MaxValue<int> obj1 = new MaxValue<int>();
                        Console.WriteLine(obj1.FindMaxValue(5, 5, 6));
                        break;

                    case 2:
                        var a2 = float.Parse(Console.ReadLine());
                        var b2 = float.Parse(Console.ReadLine());
                        var c2 = float.Parse(Console.ReadLine());
                        MaxValue<float> obj2 = new MaxValue<float>();
                        Console.WriteLine(obj2.FindMaxValue(a2, b2, c2));


                        break;

                    case 3:
                        Console.WriteLine("enter name like apple,peach,banana,");
                        var a1 = Console.ReadLine();
                        var b1 = Console.ReadLine();
                        var c1 = Console.ReadLine();
                        MaxValue<string> obj3 = new MaxValue<string>();
                        Console.WriteLine(obj3.FindMaxValue(a1, b1, c1));

                        break;
                    case 4:    Console.WriteLine("Thankyou");
                             run = false;
                        break;

                    default:
                        Console.WriteLine("enter correct option");
                        break;

                }
            }

        }
    }
}
