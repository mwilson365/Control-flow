using System;

namespace Ticketprices
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("age", $"Must be a non-negative value. Received age: {age}");
            }
        }

        static void Main(string[] args)
        {
            bool isStudent = false;
            int age;
            const int normPrice = 14;
            const int senior = 64;
            const int teen = 13;
            const int kidPrice = 8;
            const int seniorPrice = 10;
            int price = normPrice;
            char student;

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());


            try
            {
                checkAge(age);
            }
            catch (ArgumentOutOfRangeException err)
            {

                Console.WriteLine(err.Message);
            }
            Console.WriteLine("Are you a student: enter Y or N");
            student = Convert.ToChar(Console.ReadLine());
            if (student == 'Y' || student == 'y')
            {
                isStudent = true;
            }
            if (isStudent == true || age < teen)
            {
                price = kidPrice;
            }
            if ((age > senior) && (isStudent == false))
            {
                price = seniorPrice;
            }
            Console.WriteLine($"Your ticket price is: ${price} ");

        }
    }
}
