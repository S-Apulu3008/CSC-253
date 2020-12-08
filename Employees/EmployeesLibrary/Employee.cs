using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Sene Apulu
 * 4.1.2020
 * CSC 153
 * Module 4 Test
 * Employee class
 */
namespace EmployeesLibrary
{
    public class Employee
    {
        //Fields
        private string _name;
        private string _phone;
        private int _age;

        //Constructors
            //Default
        public Employee() 
        {
            _name = "";
            _phone = "";
            _age = 0;
        }
            //Custom
        public Employee(string name, string phone, int age) 
        {
            _name = name;
            _phone = phone;
            _age = age;
        }

        //Properties
        public string Name
        {
            get 
            {
                return _name;
            }

            set 
            {
                _name = value;
            }
        }
        public string Phone
        {
            get 
            {
                return _phone;
            }
            set 
            {
                _phone = value;
            }
        }
        public int Age 
        {
            get 
            {
                return _age;
            }
            set 
            {
                _age = value;
            }
        }

        //Methods
        public static void ShowEmpInfo(Employee Emp) 
        {
            Console.WriteLine(StdMsgs.EmpInfoPrompt(Emp));
        }

    }
}
