using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesLibrary;
/**
 * Sene Apulu
 * 4.1.2020
 * CSC 153
 * Module 4 Test
 * Employees
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool replay = true;
            Employee emp = new Employee();
            List<Employee> empList = new List<Employee>();
            do
            {
                Console.WriteLine(StdMsgs.ShowMenuHeader());//Header
                Console.Write(StdMsgs.ShowMenuPrompt());//Menu Prompt

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        emp = GetEmployeeInfo();//Get Employee Info
                        AddEmpToList(emp, empList);//Add Employee to List
                        break;
                    case "2":
                        Console.WriteLine();
                        DisplayEmpList(empList); //Display Employee List
                        break;
                    case "3":
                        Console.WriteLine();
                        CalcAvgAge(empList); //Calulate Average Age of Employees.
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine(StdMsgs.DisplayExitPrompt());//Exit
                        Console.ReadLine();
                        replay = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(StdMsgs.InvalidChoicePrompt());//Invalid Choice
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine();
            } while (replay == true);//End Do-While

        }//end main

        //Methods
        public static Employee GetEmployeeInfo() //Get Employee Info
        {
            Employee newEmp = new Employee();
            newEmp.Name = GetEmpName();         //Get Employee's Name
            newEmp.Phone = GetEmpPhone();       //Get Employee's Phone
            newEmp.Age = GetEmpAge();           //Get Employee's Age
            return newEmp;
        }
        public static string GetEmpName()//Get Employee's Name
        {
            Console.Write(StdMsgs.GetEmpNamePrompt());
            string name = Console.ReadLine();
            return name;
        }

        public static string GetEmpPhone() //Get Employee's Phone
        {
            Console.Write(StdMsgs.GetEmpPhonePrompt());
            string phone = Console.ReadLine();
            return phone;
        }
        public static int GetEmpAge() //Get Employee's Age
        {
            Console.Write(StdMsgs.GetEmpAgePrompt());
            int.TryParse(Console.ReadLine(), out int age);
            return age;
        }

        public static void CalcAvgAge(List<Employee> empList) //Calculate Average Age of Employees
        {
            double sumAges = 0.0;
            for (int i = 0; i < empList.Count; i++)
            {
                sumAges += empList[i].Age;
            }
            double avgAge = sumAges / empList.Count;
            Console.WriteLine(StdMsgs.ShowAvgAgePrompt(avgAge));
            Console.WriteLine();

        }

        public static void AddEmpToList(Employee emp,List<Employee> empList) //Add Employee to List
        {
            empList.Add(emp);
            Console.WriteLine(StdMsgs.EmpAddedPrompt());
            Console.ReadLine();
        }
        public static void DisplayEmpList(List<Employee> empList) //Iteratte list / display Employee Info
        {
            Console.WriteLine(StdMsgs.ShowEmpInfoHeader());
            for (int i = 0; i < empList.Count; i++) 
            {
                Console.WriteLine(StdMsgs.EmpInfoPrompt(empList[i]));
            }
        }


    }//end class
}
