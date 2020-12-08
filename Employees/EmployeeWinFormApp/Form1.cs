using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesLibrary;

namespace EmployeeWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0 || !int.TryParse(ageTextBox.Text, out int age) || !phoneMaskedTextBox.MaskCompleted)
            {
                MessageBox.Show(StdMsgs.IncompleteForm());
            }
            else
            {
                int.TryParse(ageTextBox.Text, out age);
                Employee newEmployee = new Employee(nameTextBox.Text, phoneMaskedTextBox.Text, age);
                employeeListBox.Items.Add($"{newEmployee.Name}, {newEmployee.Age}, {newEmployee.Phone}");
                nameTextBox.Clear();
                phoneMaskedTextBox.Clear();
                ageTextBox.Clear();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            phoneMaskedTextBox.Clear();
            ageTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(employeeListBox.SelectedItem != null)
            {
                employeeListBox.Items.Remove(employeeListBox.SelectedItem);
            }
        }
    }
}
