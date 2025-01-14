using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePractice
{
    internal class Manager : IManager
    {

        ArrayList EmployeeList = new ArrayList();
        public int Count()
        {
            int count = 0;
            foreach(Employee emp in EmployeeList)
            {
                if (emp.gender.Equals("female"))
                {
                    count++;
                }
            }
            return count;
        }

        public void Delete(int n)
        {
            foreach(Employee emp in EmployeeList)
            {
                if (emp.numberOfChildren == n )
                {
                    EmployeeList.Remove(emp);
                }
            }
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i ++)
            {
                Console.Write("Enter Code: ");
                string code = Console.ReadLine();

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter date of birth (yyyy-MM-dd): ");
                DateTime doB = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter gender: ");
                string gender = Console.ReadLine();

                Console.Write("Enter number of children: ");
                int numberOfChildren = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter salary: ");
                double salary = double.Parse(Console.ReadLine());


                EmployeeList.Add(new Employee(code, name, doB, gender, numberOfChildren, salary));

            }


        }

        public void ShowByName(string name)
        {
           foreach(Employee emp in EmployeeList)
            {
                if (emp.name.ToLower().Equals(name.ToLower()))
                {
                    emp.show();
                }
            }
        }

        public void ShowList()
        {
            foreach (Employee emp in EmployeeList)
            {
                emp.show();
            }
        }

        public void ShowSoCon(int n)
        {
            ArrayList soConNhoHonN = new ArrayList();
            foreach (Employee emp in EmployeeList)
            {
                if(emp.numberOfChildren < n)
                {
                    soConNhoHonN.Add(emp);
                }
            }
            foreach (Employee emp in soConNhoHonN)
            {
                emp.show();
            }
        }

        public void SortBySalary()
        {
            
        }

        public void UpdateSalary()
        {
            foreach (Employee emp in EmployeeList)
            {
                if (2025 - emp.doB.Year < 30)
                {
                    emp.salary += emp.salary * 0.05;
                }else if (2025 - emp.doB.Year >= 30 && 2025 - emp.doB.Year < 40)
                {
                    emp.salary += emp.salary * 0.1;
                }
                else
                {
                    emp.salary += emp.salary * 0.15;
                }
            }
        }
    }
}
