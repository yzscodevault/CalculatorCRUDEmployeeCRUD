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
    public partial class Employee : Form
    {
        EmployeeClass emp = new EmployeeClass();
        ArrayList empArray=new ArrayList();
        DateTimeConverter DateTimeConverter = new DateTimeConverter();
        public Employee()
        {
            InitializeComponent();
        }
        //datagrid.hide
        private void Employee_Load(object sender, EventArgs e)
        {
            empArray.Add(new EmployeeClass() { Eid=100, FName="Alex", LName="Smith",Age=22,DOB=DateTime.Parse("01/02/2000"),Phone= "(123) 456-7890", Email="alex.s@Comp.com",Department=Department.IT,Title=Title.Manger});
            empArray.Add(new EmployeeClass() { Eid=201, FName="David", LName="Jackson",Age=25,DOB=DateTime.Parse("01/05/1997"),Phone= "(307) 654-8921", Email="david.j@Comp.com",Department=Department.HR,Title=Title.ViceManager});
            empArray.Add(new EmployeeClass() { Eid=302, FName="Jack", LName="Clark",Age=30,DOB=DateTime.Parse("01/02/1992"),Phone= "(786) 466-8970", Email="jack.c@Comp.com",Department=Department.RD,Title=Title.TeamLeader});
            dtaGridEmpMngSys.DataSource = empArray;
            cmbxEmpDept.DataSource = Enum.GetValues(typeof(Department));
            cmbxEmpTitle.DataSource = Enum.GetValues(typeof(Title));
            grpbxAddEmp.Visible = false;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            emp = new EmployeeClass();//need to create a new instance, otherwise, data will be overwritten
            grpbxAddEmp.Visible = true;
            string eidPattern = @"^[0-9]*$";
            bool validateEid = Regex.IsMatch(txbxEid.Text, eidPattern);
            string emailPattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            bool validateEmail = Regex.IsMatch(txbxEmpEmail.Text, emailPattern);
            string phonenumPattern = @"^\d{10}$";
            bool validatePhone = Regex.IsMatch(txbxEmpPhone.Text, phonenumPattern);
            string namePattern = @"^[a-zA-Z]+$";
            bool validName = (Regex.IsMatch(txbxFName.Text, namePattern)) && (Regex.IsMatch(txbxLName.Text, namePattern));
            if (txbxEid.Text != string.Empty && txbxFName.Text != string.Empty && txbxLName.Text != string.Empty && txbxEmpEmail.Text != string.Empty && txbxEmpPhone.Text != string.Empty)
            {
                emp.DOB = dtpickerDOB.Value.Date;
                emp.Department = (Department)cmbxEmpDept.SelectedIndex;
                emp.Title = (Title)cmbxEmpTitle.SelectedIndex;
                emp.Note = txbxNotes.Text;
                if (validateEid)
                {
                    if (validName)
                    {
                        if (emp.DOB.Year + 18 <= DateTime.Now.Year)
                        {
                            if (validateEmail)
                            {
                                if (validatePhone)
                                {
                                    emp.Eid = Convert.ToUInt64(txbxEid.Text);
                                    emp.FName = txbxFName.Text;
                                    emp.LName = txbxLName.Text;
                                    emp.Age = (byte)(DateTime.Now.Year - emp.DOB.Year);
                                    emp.Email = txbxEmpEmail.Text;
                                    emp.Phone = String.Format("{0:(###) ###-####}", Convert.ToUInt64(txbxEmpPhone.Text));
                                    empArray.Add(emp);
                                }
                                else { MessageBox.Show("Phone numbers format: 10 digits", "Invalid Input on Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else { MessageBox.Show("Email address format should follow convention i.e. \'someone@domain.com\'", "Invalid Input on Email", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else { MessageBox.Show("Underage employment is prohibited by federal and/or state child labor laws", "Invalid Input on Age", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Please check employee's name that only letters are allowed", "Invalid Input on Name", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Employee ID only contains digits", "Invalid Input on Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            //else { MessageBox.Show("Please enter information for all blank fields", "Input Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshData();
        }
        public void RefreshData()
        {
            txbxEid.Clear();
            txbxEmpEmail.Clear();
            txbxEmpPhone.Clear();
            txbxFName.Clear();
            txbxLName.Clear();
            txbxNotes.Clear();
            dtaGridEmpMngSys.DataSource = null;
            dtaGridEmpMngSys.DataSource = empArray;
        }
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            empArray.RemoveAt(dtaGridEmpMngSys.CurrentRow.Index);
            RefreshData();
        }

        private void txbxLName_TextChanged(object sender, EventArgs e)
        {

        }

        //another way to validate data, also keep current focus
        private void txbxLName_Validating(object sender, CancelEventArgs e)
        {
            if (txbxLName.Text.Length > 50)
            {
                MessageBox.Show("too long");
                e.Cancel = true;//stay focus on this textbox
                txbxLName.Clear();
            }
        }
    }
}

