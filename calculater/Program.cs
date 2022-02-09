using System;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            string stnumber1, stnumber2;
            string Op;

            stnumber1 = Console.ReadLine(); Op= Console.ReadLine (); stnumber2 =Console.ReadLine () ;
            number1 = double.Parse ( stnumber1);
            number2= double.Parse(stnumber2);

            if (Op == "+" ) 
            {
                double sum = number1 + number2;
                Console.WriteLine(sum);

            }
                          
           if( Op == ".")
            {
                double mutiple = number1 * number2;
                Console.WriteLine(mutiple);

            }
            Console.ReadKey();

        }
    }
}
