using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    class Exo2
    {
        public void Prime()
        {
          
            for (int i = 0; i < 1000; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                    isPrime = false;
                }
            }
        }


        public void fibo()
        {
            Console.WriteLine("Question 2.2 : Please enter a N value for the maximum iteration of the fibonacci function : ");
            int max = Convert.ToInt32(Console.ReadLine());
            //énoncé
            int n0 = 1, n1 = 1;
            Console.WriteLine("\nHere below the " + max + " iteration of the Fibonacci function :");
            Console.WriteLine("F(0) = " + n0);
            Console.WriteLine("F(1) = " + n1);

            for (int i = 2; i < max; i++)
            {
                int nmax = n0 + n1;
                Console.WriteLine("F("+i+") = " + nmax);
                n0 = n1;
                n1 = nmax;
            }
            
        }
        public double factorial(int n)
        {
            //the if condition below stops the callback, it means that we have reached the last factor (1)
            if (n == 1)
                
                return 1;

            else
                return n * factorial(n - 1); 
        }

    }
}
