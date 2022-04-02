using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int myFavNum = 7;
            double myDoubleNum = 5.990;
            char myFirstLetter = 'C';
            bool myBool = true;
            string myName = "Chibuzor";
            float myPi = 10.2f;
            decimal amount = 100.50M;
            dynamic myText = "The boss";

            //IMPLICIT TYPE CONVERSION
            double myPi2 = myPi;

            //EXPLICIT TYPE CONVERSION
            int myamount = (int) amount;

            Console.WriteLine(myFavNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myBool);
            Console.WriteLine(amount);
            Console.WriteLine(myPi);
            Console.WriteLine(myName);
            Console.WriteLine(myText);
            Console.WriteLine(myFirstLetter);
            Console.WriteLine(myPi2);
            Console.WriteLine(myamount);
        }
    }
}
