using System;
namespace TP1
{
    public class Exo3
    {
        private static int PowerFunction(int x)
        {
            int result = (10/(int)(Math.Pow(x, 2) - 4));
        
          
            Console.WriteLine("The result of the calculation is : " + result);
         
            
            return result;
        }

        public class Wrong_Argument : Exception
        {
            public Wrong_Argument(string message): base(message)
            {

            }    

        }

        public void try_catch(string x_input)
        {
           

            try
            {
                int numericValue;
                bool isNumber = int.TryParse(x_input, out numericValue);
        

                if (((Convert.ToInt32(x_input)) < -3) || (3 < (Convert.ToInt32(x_input))) || (isNumber == false))
                {
                    throw new Wrong_Argument(String.Format(""));
                }

                int x = Convert.ToInt32(x_input);
                PowerFunction(x);
            }
            catch (Exception ex) 
            {   
                Console.WriteLine("Please enter a number between -3 and 3 (except -2 and 2 which are causing a DividedByZeroException");
                var x_input2 = Console.ReadLine();

                Exo3 test3 = new Exo3();
                test3.try_catch(x_input2);
            }    

        }

    }
}