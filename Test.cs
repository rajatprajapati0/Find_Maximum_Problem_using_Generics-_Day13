using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Find_Maximum_By_Genric
{
   public class Test
   {
        public void testForMax()
        {
            Console.WriteLine("enter three no. to find maximum number TC1.1");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());    
            int c=int.Parse(Console.ReadLine());
            IntMaxValue obj=new IntMaxValue();
            int max=obj.MaxValue(a,b,c);
            Console.WriteLine(max);
        }
   }
}
