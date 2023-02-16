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

                Console.WriteLine("-------------------New class-----------------");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id= 100,
                    FirstName = "Maria",
                    LastName= "Posada",
                    BirthDate= new Date(1950,2,5),
                    HiringDate = new Date(2021, 12, 3),
                    IsActive=true,
                    Salary = 20000.34M
                };
                Console.WriteLine(salaryEmployee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
