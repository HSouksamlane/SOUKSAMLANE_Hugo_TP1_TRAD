using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    class Exo4
    {

        public class Wrong_Argument : Exception
        {
            public Wrong_Argument(string message) : base(message)
            {

            }

        }

        public void Square(string N_input, string M_input)
        {
            try
            {
                int numericValue1;
                int numericValue2;
                bool N_isNumber = int.TryParse(N_input, out numericValue1);
                bool M_isNumber = int.TryParse(M_input, out numericValue2);

                //ici on exclut toutes les entrées qui ne sont pas comprises entre 1 et 1000 ou qui ne sont tout simplement pas des entiers
                if (((Convert.ToInt32(N_input)) < 1) || (1000 < (Convert.ToInt32(N_input))) || ((Convert.ToInt32(M_input)) < 1) || ((1000 < (Convert.ToInt32(M_input))) || (N_isNumber == false) || (M_isNumber == false)))
                {
                    throw new Wrong_Argument(String.Format(""));
                }

                int N = (Convert.ToInt32(N_input));
                int M = (Convert.ToInt32(M_input));

                if ((N==1) & (M==1))
                {
                    Console.WriteLine("0");
                }
                else
                {
                    for (int i = 0; i < N; i++ )
                    {
                        if ((i==0) || (i==(N-1)))
                        {
                            Console.Write("0");
                            
                            for (int k = 0; k < (M-2); k++)
                            {
                                Console.Write("-");

                                if (k == (M-3))
                                {
                                    Console.Write("0\n");
                                }

                            }

                        }
                        else
                        {
                            Console.Write("|");
                            for (int j = 0; j<(M-2) ; j++)
                            {
                                Console.Write(" ");

                            }
                            Console.Write("|\n");

                        }
                        


                    }

                    Console.WriteLine("\nQuestion 4.2 : not finished yet\n");

                    for (int l = 0; l < (N - 1); l++)
                    {
                        if ((l == 0) || (l == (N - 2)))
                        {
                            Console.Write("0");

                            for (int o = 0; o < (M - 1); o++)
                            {
                                Console.Write("-");

                                if (o == (M - 2))
                                {
                                    Console.Write("0\n");
                                }

                            }

                        }
                        else
                        {
                            Console.Write("|");

                            //if qui vont permettre de gérer le décalage des astériques d'une ligne à l'autre
                            if ((l % 5) == 2)
                            {
                                Console.Write(" ");
                            }
                            if ((l % 5) == 3)
                            {
                                Console.Write("  ");
                            }

                            for (int p = 0; p < (M - 1); p++)
                            {
                                    if (p<(M-2))
                                    {
                                    Console.Write("*");
                                    }
                                    

                                    if (p < (M - 3))
                                    {
                                        Console.Write("  ");

                                    }
                                    if (p == (M - 2))
                                    {
                                        Console.Write(" ");

                                    }
                            }
                            Console.Write("|\n");





                        }



                    }


                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a CORRECT number between 1 and 1000 for N (rectangle height) value");
                var n_input2 = Console.ReadLine();

                Console.WriteLine("Please enter a CORRECT number between 1 and 1000 for M (rectangle length) value");
                var m_input2 = Console.ReadLine();

                Exo4 test4 = new Exo4();
                test4.Square(n_input2,m_input2);

            }

        }


        


    }
}
