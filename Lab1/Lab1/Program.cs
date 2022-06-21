using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Start the program press y");
            string n;

            do
            {
                n = Console.ReadLine();
                
                if (n != "n")
                {
                    Console.WriteLine("Enter The Sides of Triangles");
                    int s1 = Convert.ToInt32(Console.ReadLine());
                    int s2 = Convert.ToInt32(Console.ReadLine());
                    int s3 = Convert.ToInt32(Console.ReadLine());

                    
                    if (s1+s2>s3 || s1 + s3 > s2 || s3 + s2 > s1)
                    {
                        if(s1 == s2 || s1 == s3 || s2 == s3)
                        {
                            Console.WriteLine("It is A Triangle");
                            Console.WriteLine("It is An Isoceles Triangle");
                        }

                        if(s1 == s2 && s2 == s3 && s1 == s3 )
                        {
                            Console.WriteLine("It is A Triangle");
                            Console.WriteLine("It is An Equilateral Triangle");
                        }

                        else
                        {
                            Console.WriteLine("It is A Triangle");
                            Console.WriteLine("It is A Scalene Triangle");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Not Even");
                    }
                }

                else
                {
                    Console.WriteLine(" ");
                }

                Console.WriteLine("To Stop Press n if not y");
            } while (n != "n");

        
        }
    }
}
