using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Find_Maximum_By_Genric
{
   public class Test
   {
        public void intTestForMax()
        {
            Console.WriteLine("enter three no. to find maximum number ");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());    
            int c=int.Parse(Console.ReadLine());
            MaxValue obj=new MaxValue();
            int max=obj.IntMaxValue(a,b,c);
            Console.WriteLine(max);
        }

        public void floatTestForMax()
        {
            Console.WriteLine("enter three no. to find maximum number ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            MaxValue obj = new MaxValue();
            float max = obj.FloatMaxValue(a,b,c);
            Console.WriteLine(max);
        }

        public void stringTestFormax()
        {
            Console.WriteLine(" enter three name like apple,graeps,orenge ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            MaxValue obj = new MaxValue();
            string max=obj.stringMaxvalue(a,b,c);
            Console.WriteLine(max);  

        }
    
    }
}
