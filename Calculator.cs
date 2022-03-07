using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Assignment5._1
{
    public partial class Calculator : Form
    {
        ArrayList calculationList = new ArrayList();
        CalculatorClass calculatorClass = new CalculatorClass();
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            calculationList.Add(new CalculatorClass() { FstNum = 2m, Operation = Operator.Addition, ScdNum = 3m, Result = 5m });
            calculationList.Add(new CalculatorClass() { FstNum = 6m, Operation = Operator.Substraction, ScdNum = 4m, Result = 2m });
            calculationList.Add(new CalculatorClass() { FstNum = 8m, Operation = Operator.Muplication, ScdNum = 5m, Result = 40m });
            calculationList.Add(new CalculatorClass() { FstNum = 2m, Operation = Operator.Division, ScdNum = 1m, Result = 2m });
            cmbxSelectCalculation.DataSource = Enum.GetValues(typeof(Operator));
            dtaGridCalculator.DataSource = calculationList;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string numberPattern = @"^[0-9.]+$";
            bool validateNumber = ((Regex.IsMatch(txbxFNumber.Text,numberPattern)) && (Regex.IsMatch(txbxSNumber.Text,numberPattern)));
            calculatorClass = new CalculatorClass();//need to create a new instance, otherwise, data will be overwritten
            if (txbxFNumber.Text != String.Empty && txbxSNumber.Text != String.Empty)
            {
                if (validateNumber)
                {
                    calculatorClass.FstNum = Convert.ToDecimal(txbxFNumber.Text);
                    calculatorClass.Operation = (Operator)cmbxSelectCalculation.SelectedIndex;
                    calculatorClass.ScdNum = Decimal.Parse(txbxSNumber.Text);
                    if ((Convert.ToString(calculatorClass.Operation) == "Division") && calculatorClass.ScdNum == 0m)
                    {
                        MessageBox.Show("Cannot devide by zero", "Mathmatical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        switch (calculatorClass.Operation)
                        {
                            case Operator.Addition:
                                calculatorClass.Result = calculatorClass.FstNum + calculatorClass.ScdNum;
                                break;
                            case Operator.Substraction:
                                calculatorClass.Result = calculatorClass.FstNum - calculatorClass.ScdNum;
                                break;
                            case Operator.Muplication:
                                calculatorClass.Result = Math.Round((calculatorClass.FstNum * calculatorClass.ScdNum), 6);
                                break;
                            case Operator.Division:
                                calculatorClass.Result = Math.Round((calculatorClass.FstNum / calculatorClass.ScdNum), 6);
                                break;
                        }
                        calculationList.Add(calculatorClass);
                    }
                }
                else { MessageBox.Show("Only enter digits and dot(.) to make up numbers","Format Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            RefreshData();
        }
        public void RefreshData()
        {
            txbxFNumber.Clear();
            txbxSNumber.Clear();
            dtaGridCalculator.DataSource = null;
            dtaGridCalculator.DataSource = calculationList;
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            calculationList.RemoveAt(dtaGridCalculator.CurrentRow.Index);
            RefreshData();
        }
    }
}
