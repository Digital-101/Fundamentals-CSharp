using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class Solution
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Console.WriteLine("Debug: Calculating Average Age");
            var dict = new Dictionary<string, int>();
            var grouped = employees.GroupBy(e => e.Company);

            foreach (var group in grouped)
            {
                int sum = group.Sum(e => e.Age);
                int count = group.Count();
                int avg = sum / count;
                dict[group.Key] = avg;

                // Debug log
                Console.WriteLine($"Company: {group.Key}, Sum: {sum}, Count: {count}, Avg: {avg}");
            }
            return dict;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Console.WriteLine("Debug: Counting Employees");
            var dict = new Dictionary<string, int>();
            var grouped = employees.GroupBy(e => e.Company);

            foreach (var group in grouped)
            {
                int count = group.Count();
                dict[group.Key] = count;

                // Debug log
                Console.WriteLine($"Company: {group.Key}, Count: {count}");
            }
            return dict;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Console.WriteLine("Debug: Finding Oldest Employees");
            var dict = new Dictionary<string, Employee>();
            var grouped = employees.GroupBy(e => e.Company);

            foreach (var group in grouped)
            {
                var oldest = group.OrderByDescending(e => e.Age).First();
                dict[group.Key] = oldest;

                // Debug log
                Console.WriteLine($"Company: {group.Key}, Oldest: {oldest.FirstName} {oldest.LastName}, Age: {oldest.Age}");
            }
            return dict;
        }

        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            Console.WriteLine("\n--- Average Age ---");
            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            Console.WriteLine("\n--- Count of Employees ---");
            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            Console.WriteLine("\n--- Oldest Employees ---");
            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
