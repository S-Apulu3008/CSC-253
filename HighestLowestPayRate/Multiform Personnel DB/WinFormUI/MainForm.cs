using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * S. A.
 * 11.22.2020
 * Multiform DB Application
 * 
 */

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm(); //creates details form object.
            details.ShowDialog();
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }

        private void highestPayButton_Click(object sender, EventArgs e)
        {
            decimal highestPay = (decimal) this.employeeTableAdapter.HighestPay();
            MessageBox.Show($"The highest pay is {highestPay}");
        }

        private void lowestPayButton_Click(object sender, EventArgs e)
        {
            decimal lowestPay = (decimal)this.employeeTableAdapter.LowestPay();
            MessageBox.Show($"The lowest pay is {lowestPay}");
        }
    }
}
