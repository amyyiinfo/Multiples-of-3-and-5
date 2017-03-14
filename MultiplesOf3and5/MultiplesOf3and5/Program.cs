using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3and5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int number;

            while (true)
            {
                Console.WriteLine("Enter the sum you would like to calculate:");
                string strNumber = Console.ReadLine();
                number = Convert.ToInt32(strNumber);

                int multiplesOfThreeFive = 0;


                for (int i = 1; i < number; i++)
                {
                    if ((i % 3 == 0) || (i % 5 == 0))
                    {
                        multiplesOfThreeFive = multiplesOfThreeFive + i;
                    }

                }



                Console.WriteLine(multiplesOfThreeFive);

                 
            }

            Console.Read();

            }
        }
    }

