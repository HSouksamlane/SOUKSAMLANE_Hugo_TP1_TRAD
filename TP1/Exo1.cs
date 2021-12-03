using System;

namespace TP1
{
    public class Exo1
    {


        public void multiplication(int question)
        {
            int parameter = question;
            

            for (int factor1 = 1; factor1 <= 10; factor1++)
            {
                for (int factor2 = 1; factor2 <= 10; factor2++)
                {
                    if (parameter == 1)
                    {
                        Console.Write(factor1 + "*" + factor2 + " = " + factor1 * factor2 + "\n");
                    }

                    if (parameter == 2)
                    {
                        if ((factor1 * factor2) % 2 == 1)
                        {
                            Console.Write(factor1 + "*" + factor2 + " = " + factor1 * factor2 + "\n");
                        }

                    }

                }

                Console.Write("\n");
            }

        }

        public void multiplication_3(int number)
        {
            int table = number;
            
                for (int i = 1; i <= 10; i++)
                {
                    
                    Console.Write(table + "*" + i + " = " + table * i + "\n");
                    
                    
                }
        

            

        }
    }
}    