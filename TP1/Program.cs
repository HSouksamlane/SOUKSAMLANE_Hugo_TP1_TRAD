using System;

namespace TP1
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            

             //Exercise1
             Exo1 test = new Exo1();
            Console.WriteLine("Exercise 1.1 : Here below every multiplication from 1*1 to 10*10\n");
             test.multiplication(1);
            Console.WriteLine("Exercise 1.2 : Below only the odd result :\n");
             test.multiplication(2);
             
             Console.WriteLine("Exercise 1.3 : Which multiplication table do you want to display ? \n");
             
             int table_number = Convert.ToInt32(Console.ReadLine());
             test.multiplication_3(table_number);
             

            //Exercise 2
            Console.WriteLine("\nExercise 2.1 : Here below le list of all prime number between 1 and 1000 \n");
            Exo2 test2 = new Exo2();
            test2.Prime();

            test2.fibo();

            Console.WriteLine("\nExercise 2.3 : Please enter the value for the factorial function :");
            int factorial_input = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The result of the factorial function is : "+ (test2.factorial(factorial_input)));
          


            
            //Exercise3
             Console.WriteLine("Exercise 3 : Please enter a x value between -3 and 3 ? \n");
             var x_input = Console.ReadLine();
             Exo3 test3 = new Exo3();
             test3.try_catch(x_input);
           
            
            //Exercise4
            Console.WriteLine("\nExercise 4.1  \nPlease enter a N value (rectangle height) between 1 and 1000 ? \n");
            var n_input = Console.ReadLine();

            Console.WriteLine("Please enter a M value (rectangle length) between 1 and 1000 ? \n");
            var m_input = Console.ReadLine();

            Exo4 test4 = new Exo4();
            test4.Square(n_input,m_input);

            //Just a fake ReadLine in order to keep the console terminal opened
            Console.ReadLine();
            

        }
    }
    
    
    
    
}