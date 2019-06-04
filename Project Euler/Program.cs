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
            else if(num==201){
console.writeline("AM of 50 numbers is 32. AM of 70 #'s is 53. The AM of combined sets is (50*32+70*53)/120={1}",(50*32+70*53)/120);
            
            }
            Console.Read();
        }
    }
}
