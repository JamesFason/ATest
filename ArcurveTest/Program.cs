using System;
using System.Collections.Generic;

namespace ArcurveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate salary expenses of company
            // calculate number of direct reports
            // calculate number of indirect reports
            // calculate number of levels from ceo, CEO = 0, CFO = 1
            // calculate average salary by job title

            Console.WriteLine("Hello World!");
        }


        public IEnumerable<Employee> GenerateEmployees() {
            var george = new Employee()
            {
                Name = "George Smith",
                Boss = null,
                Salary = 300000,
                Title = "CEO"
            };

            yield return george;

            var susie = new Employee()
            {
                Name = "Suzie Rodriguez",
                Boss = george,
                Salary = 250000,
                Title = "CFO"
            };
            yield return susie;

            var rodney = new Employee()
            {
                Name = "Rodney Dangerfield",
                Boss = george,
                Salary = 240000,
                Title = "CTO"
            };
            yield return rodney;

            var john = new Employee()
            {
                Name = "John Wright",
                Boss = george,
                Salary = 240000,
                Title = "COO"
            };
            yield return john;

            var hamilton = new Employee()
            {
                Name = "Hamilton Rivera",
                Title = "Director",
                Salary = 147007,
                Boss = john
            };
            yield return hamilton;

            var rush = new Employee()
            {
                Name = "Rush Hamilton",
                Title = "Manager",
                Salary = 135462,
                Boss = hamilton
            };
            yield return rush;

            var suzanne = new Employee()
            {
                Name = "Susanne Guzman",
                Title = "Developer",
                Salary = 197050,
                Boss = rush
            };
            yield return suzanne;

            var serrano = new Employee()
            {
                Name = "Serrano Little",
                Title = "Developer",
                Salary = 136472,
                Boss = rush
            };
            yield return serrano;

            var camacho = new Employee()
            {
                Name = "Camacho Ware",
                Title = "Developer",
                Boss = rush,
                Salary = 226990
            };
            yield return camacho;
        }
    }
}
