using System;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter problem number");
            var num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                
            }
            else if (num == 2)
            {
                long fibn = 1, pfibn=1,sum=0;
                while (fibn < 4e6)
                {
                    if(fibn % 2 == 0)
                    {
                        sum += fibn;
                    }
                    fibn = fibn + pfibn;
                    pfibn = fibn;
                }
                Console.WriteLine("Programmatic Method: Sum is "+sum);
            }
            Console.Read();
        }
    }
}
