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
                //Console.WriteLine("Enter the Year:");
                //year = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter the Month:");
                //month = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter the Day:");
                //day = int.Parse(Console.ReadLine());

                //var dateObject = new Date(year, month, day);
                //Console.WriteLine(dateObject.ToString());

                //Console.WriteLine("-------------------asalary class-----------------");
                

                //Employee salaryEmployee = new SalaryEmployee()
                //{
                //    Id= int.Parse(Console.ReadLine()),
                //    FirstName = "maria",
                //    LastName= "Posada",
                //    BirthDate=new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                //    HiringDate = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                //    IsActive=true,
                //    Salary = decimal.Parse(Console.ReadLine())
                //};
                //Console.WriteLine(salaryEmployee);

                Console.WriteLine("-------------------commission class-----------------");

                Employee CommissionEmployee = new CommissionEmployee()
                {
                    Id = int.Parse(Console.ReadLine()),
                    FirstName = "maria",
                    LastName = "Posada",
                    BirthDate = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                    HiringDate = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                    IsActive = true,
                    Sales = decimal.Parse(Console.ReadLine()),
                    CommissionPercentage = float.Parse(Console.ReadLine()),
                };
                Console.WriteLine(CommissionEmployee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
