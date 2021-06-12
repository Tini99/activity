using System;

namespace activity
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, tempnumber;

            Console.WriteLine("Enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered" + Convert.ToString(number1) + "as number1");

            Console.WriteLine("Enter number2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered" + Convert.ToString(number2) + "as number2");

            tempnumber = number1;
            number1 = number2;
            number2 = tempnumber;
        }
    }
}
