using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployeeEntrance_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Visible = false;
            employee.Show();

        }

        private void btnCalculatorEntrance_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            this.Visible = false;
            calculator.Show();
        }
    }
}
