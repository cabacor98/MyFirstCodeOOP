using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;
            try
            {
                Console.WriteLine("Enter the Year:");
                year = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Month:");
                month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Year:");
                day = int.Parse(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
