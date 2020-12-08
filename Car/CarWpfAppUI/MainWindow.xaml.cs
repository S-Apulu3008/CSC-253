using myClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/*
 * SA
 * 10.30.2020
 * CSC 253
 * Car WPF app
 */

namespace CarWpfAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            Car myCar = new Car();
            myCar.Make = makeTextBox.Text;
            int.TryParse(yearTextBox.Text, out int year);
            myCar.Year = year;
            Garage.myCar = myCar;
            makeTextBox.Clear();
            yearTextBox.Clear();
            Close();
        }
    }
}
