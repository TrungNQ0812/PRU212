using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePractice
{
    internal class Employee
    {
 
        public string code {  get; set; }
        public string name { get; set; }
        public DateTime doB { get; set; }
        public string gender { get; set; }
        public int numberOfChildren { get; set; }
        public double salary { get; set; }

        public Employee(string code, string name, DateTime doB, string gender, int numberOfChildren, double salary)
        {
            this.code = code;
            this.name = name;
            this.doB = doB;
            this.gender = gender;
            this.numberOfChildren = numberOfChildren;
            this.salary = salary;
        }

        public void show()
        {
            Console.WriteLine($"Code: {code} " +
                $"\nName: {name} " +
                $"\nDate of birth: {doB} " +
                $"\nGender: {gender} " +
                $"\nNumber of children: {numberOfChildren} " +
                $"\nSalary: {salary}");
        }

        public double IncomeCalculate()
        {
            double allowance = 0;
            if (numberOfChildren  == 0)
            {
                allowance = 0; 
            }
            else if (numberOfChildren <= 2)
            {
                allowance = 1000000;
            }
            else
            {
                allowance = 1500000;
            }

            return salary + allowance;
        }
    }
}
