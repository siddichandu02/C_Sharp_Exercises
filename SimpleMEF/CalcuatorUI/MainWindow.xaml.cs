using CompositionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CalcuatorUI
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

        private void result(string operation)
        {
            var objCompHelper = new CalciCompositionHelper();

            //Assembles the calculator components that will participate in composition
            objCompHelper.AssembleCalculatorComponents();
            //Gets the result
            var result = objCompHelper.GetResult(Convert.ToInt32(txtFirstNumber.Text),
                    Convert.ToInt32(txtSecondNumber.Text), operation);

            //Display the result
            txtResult.Text = result.ToString();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            result("Add");
        }
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            result("Subtract");
        }
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            result("Multiply");
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            result("Divide");
        }
    }
}
