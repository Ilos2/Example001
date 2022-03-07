using System;

namespace Example006_Base
{
    class Program
    {
        static  void Main(string[] args)
        {
            
            int a = 1;
            int b = 7;
            int c = 5;
            int d = 9;

            int max = a;
            {
                if (a > max) max = a;
                if (b > max) max = b;
                if (c > max) max = c;
                if (d > max) max = d;
            }

            Console.Write ("max= ");
            Console.WriteLine(max);
        }
    }
}
