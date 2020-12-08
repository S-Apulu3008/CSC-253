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
 * Employees StdMsgs
 */

namespace EmployeesLibrary
{
    public class StdMsgs
    {
        //Menu Prompts
        public static string ShowMenuHeader() 
        {
            return "Menu" +
                "\n------------------------------";
        }
        public static string ShowMenuPrompt()
        {
            return "1. Enter Employee's Info" +
                 "\n2. Show Employees" +
                 "\n3. Show Average Employee Age" +
                 "\n4. Exit" +
                 "\nChoose: ";
        }

        public static string DisplayExitPrompt()
        {
            return "Exiting Program.";
        }

        public static string InvalidChoicePrompt() 
        {
            return "Not a valid choice.";
        }

        //Get Employee Info Prompts
        public static string GetEmpNamePrompt() 
        {
            return "Enter Employee's Name: ";
        }
        public static string GetEmpPhonePrompt() 
        {
            return "Enter Employee's Phone#: ";
        }
        public static string GetEmpAgePrompt()
        {
            return "Enter Employee's Age: ";
        }
        public static string EmpAddedPrompt() 
        {
            return "Employee Added.";
        }

        //Show Info Prompts
        public static string ShowAvgAgePrompt(double avgAge) 
        {
            return $"Employees' Average Age: {string.Format("{0:0.00}", avgAge)}";
        }

        public static string ShowEmpInfoHeader() 
        {
            return "Name".PadRight(20) + "Phone".PadRight(13) + "Age" +
                   "\n------------------------------------------------";
        }
        public static string EmpInfoPrompt(Employee Emp) 
        {
            return $"{Emp.Name}".PadRight(20) + $"{Emp.Phone}".PadRight(13) + $"{Emp.Age}";
        }

        public static string IncompleteForm()
        {
            return $"Please fill out all the information.";
        }
    }
}
