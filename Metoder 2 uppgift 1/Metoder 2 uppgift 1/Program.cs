using System;

namespace Metoder_2_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            BytPlats(ref a, ref b); 
            Console.WriteLine(a + " " + b);
        }
        public static void BytPlats(ref int a, ref int b)
        {
            int nummer1 = a;
            int nummer2 = b;
            b = nummer1;
            a = nummer2;
        }
    }
}
