using System;

namespace HIENTHICACLOAIHINH
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=5; j>=i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
             for (int i = 1; i <= 3; i++)
             {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
             }
        }
    }
}
