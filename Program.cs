using ExercicioListas_Aula78;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;

namespace ExerciciosListas_Aula78
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            Employee employee = new Employee();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" +(i+1)+ ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine();
                emp.Add(employee = new Employee(id, name, salary));
            }

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch =int.Parse(Console.ReadLine());

            Employee empl = emp.Find(x => x.Id == idSearch);
            if (empl != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empl.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Employee i in emp)
            {
                Console.WriteLine(i);
            }
           

        }
    }
}
