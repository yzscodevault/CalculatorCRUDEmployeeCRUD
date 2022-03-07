
namespace Assignment5._1
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpMngSys = new System.Windows.Forms.Label();
            this.dtaGridEmpMngSys = new System.Windows.Forms.DataGridView();
            this.lblCurrentEmployee = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.grpbxAddEmp = new System.Windows.Forms.GroupBox();
            this.dtpickerDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbxEmpTitle = new System.Windows.Forms.ComboBox();
            this.cmbxEmpDept = new System.Windows.Forms.ComboBox();
            this.lblEmpDoB = new System.Windows.Forms.Label();
            this.txbxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.txbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.txbxLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txbxFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblEmpTitle = new System.Windows.Forms.Label();
            this.lblEmpDept = new System.Windows.Forms.Label();
            this.txbxEid = new System.Windows.Forms.TextBox();
            this.lblEid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridEmpMngSys)).BeginInit();
            this.grpbxAddEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpMngSys
            // 
            this.lblEmpMngSys.AutoSize = true;
            this.lblEmpMngSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpMngSys.Location = new System.Drawing.Point(35, 26);
            this.lblEmpMngSys.Name = "lblEmpMngSys";
            this.lblEmpMngSys.Size = new System.Drawing.Size(381, 31);
            this.lblEmpMngSys.TabIndex = 0;
            this.lblEmpMngSys.Text = "Employee Managing System";
            // 
            // dtaGridEmpMngSys
            // 
            this.dtaGridEmpMngSys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridEmpMngSys.Location = new System.Drawing.Point(41, 121);
            this.dtaGridEmpMngSys.Name = "dtaGridEmpMngSys";
            this.dtaGridEmpMngSys.Size = new System.Drawing.Size(896, 221);
            this.dtaGridEmpMngSys.TabIndex = 12;
            // 
            // lblCurrentEmployee
            // 
            this.lblCurrentEmployee.AutoSize = true;
            this.lblCurrentEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentEmployee.Location = new System.Drawing.Point(41, 87);
            this.lblCurrentEmployee.Name = "lblCurrentEmployee";
            this.lblCurrentEmployee.Size = new System.Drawing.Size(185, 25);
            this.lblCurrentEmployee.TabIndex = 2;
            this.lblCurrentEmployee.Text = "Current Employee";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddEmp.Location = new System.Drawing.Point(41, 366);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(153, 43);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Record";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteEmp.Location = new System.Drawing.Point(791, 366);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(146, 43);
            this.btnDeleteEmp.TabIndex = 11;
            this.btnDeleteEmp.Text = "Delete Record";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // grpbxAddEmp
            // 
            this.grpbxAddEmp.Controls.Add(this.dtpickerDOB);
            this.grpbxAddEmp.Controls.Add(this.cmbxEmpTitle);
            this.grpbxAddEmp.Controls.Add(this.cmbxEmpDept);
            this.grpbxAddEmp.Controls.Add(this.lblEmpDoB);
            this.grpbxAddEmp.Controls.Add(this.txbxNotes);
            this.grpbxAddEmp.Controls.Add(this.label1);
            this.grpbxAddEmp.Controls.Add(this.txbxEmpEmail);
            this.grpbxAddEmp.Controls.Add(this.lblEmpEmail);
            this.grpbxAddEmp.Controls.Add(this.txbxEmpPhone);
            this.grpbxAddEmp.Controls.Add(this.lblEmpPhone);
            this.grpbxAddEmp.Controls.Add(this.txbxLName);
            this.grpbxAddEmp.Controls.Add(this.lblLName);
            this.grpbxAddEmp.Controls.Add(this.txbxFName);
            this.grpbxAddEmp.Controls.Add(this.lblFName);
            this.grpbxAddEmp.Controls.Add(this.lblEmpTitle);
            this.grpbxAddEmp.Controls.Add(this.lblEmpDept);
            this.grpbxAddEmp.Controls.Add(this.txbxEid);
            this.grpbxAddEmp.Controls.Add(this.lblEid);
            this.grpbxAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpbxAddEmp.Location = new System.Drawing.Point(41, 429);
            this.grpbxAddEmp.Name = "grpbxAddEmp";
            this.grpbxAddEmp.Size = new System.Drawing.Size(896, 181);
            this.grpbxAddEmp.TabIndex = 4;
            this.grpbxAddEmp.TabStop = false;
            this.grpbxAddEmp.Text = "Add Employee Records";
            // 
            // dtpickerDOB
            // 
            this.dtpickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerDOB.Location = new System.Drawing.Point(108, 141);
            this.dtpickerDOB.Name = "dtpickerDOB";
            this.dtpickerDOB.Size = new System.Drawing.Size(166, 23);
            this.dtpickerDOB.TabIndex = 4;
            // 
            // cmbxEmpTitle
            // 
            this.cmbxEmpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmpTitle.FormattingEnabled = true;
            this.cmbxEmpTitle.Location = new System.Drawing.Point(397, 66);
            this.cmbxEmpTitle.Name = "cmbxEmpTitle";
            this.cmbxEmpTitle.Size = new System.Drawing.Size(166, 24);
            this.cmbxEmpTitle.TabIndex = 6;
            // 
            // cmbxEmpDept
            // 
            this.cmbxEmpDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmpDept.FormattingEnabled = true;
            this.cmbxEmpDept.Location = new System.Drawing.Point(397, 27);
            this.cmbxEmpDept.Name = "cmbxEmpDept";
            this.cmbxEmpDept.Size = new System.Drawing.Size(166, 24);
            this.cmbxEmpDept.TabIndex = 5;
            // 
            // lblEmpDoB
            // 
            this.lblEmpDoB.AutoSize = true;
            this.lblEmpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpDoB.Location = new System.Drawing.Point(24, 146);
            this.lblEmpDoB.Name = "lblEmpDoB";
            this.lblEmpDoB.Size = new System.Drawing.Size(79, 13);
            this.lblEmpDoB.TabIndex = 0;
            this.lblEmpDoB.Text = "Date of Birth";
            // 
            // txbxNotes
            // 
            this.txbxNotes.Location = new System.Drawing.Point(670, 28);
            this.txbxNotes.Multiline = true;
            this.txbxNotes.Name = "txbxNotes";
            this.txbxNotes.Size = new System.Drawing.Size(207, 136);
            this.txbxNotes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(603, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Notes";
            // 
            // txbxEmpEmail
            // 
            this.txbxEmpEmail.Location = new System.Drawing.Point(397, 141);
            this.txbxEmpEmail.Name = "txbxEmpEmail";
            this.txbxEmpEmail.Size = new System.Drawing.Size(166, 23);
            this.txbxEmpEmail.TabIndex = 8;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpEmail.Location = new System.Drawing.Point(313, 144);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmpEmail.TabIndex = 0;
            this.lblEmpEmail.Text = "Email";
            // 
            // txbxEmpPhone
            // 
            this.txbxEmpPhone.Location = new System.Drawing.Point(397, 104);
            this.txbxEmpPhone.Name = "txbxEmpPhone";
            this.txbxEmpPhone.Size = new System.Drawing.Size(166, 23);
            this.txbxEmpPhone.TabIndex = 7;
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpPhone.Location = new System.Drawing.Point(313, 109);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(55, 13);
            this.lblEmpPhone.TabIndex = 0;
            this.lblEmpPhone.Text = "Phone #";
            // 
            // txbxLName
            // 
            this.txbxLName.Location = new System.Drawing.Point(108, 104);
            this.txbxLName.Name = "txbxLName";
            this.txbxLName.Size = new System.Drawing.Size(166, 23);
            this.txbxLName.TabIndex = 3;
            this.txbxLName.TextChanged += new System.EventHandler(this.txbxLName_TextChanged);
            this.txbxLName.Validating += new System.ComponentModel.CancelEventHandler(this.txbxLName_Validating);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLName.Location = new System.Drawing.Point(24, 109);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(67, 13);
            this.lblLName.TabIndex = 0;
            this.lblLName.Text = "Last Name";
            // 
            // txbxFName
            // 
            this.txbxFName.Location = new System.Drawing.Point(108, 66);
            this.txbxFName.Name = "txbxFName";
            this.txbxFName.Size = new System.Drawing.Size(166, 23);
            this.txbxFName.TabIndex = 2;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFName.Location = new System.Drawing.Point(24, 71);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // lblEmpTitle
            // 
            this.lblEmpTitle.AutoSize = true;
            this.lblEmpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpTitle.Location = new System.Drawing.Point(313, 72);
            this.lblEmpTitle.Name = "lblEmpTitle";
            this.lblEmpTitle.Size = new System.Drawing.Size(32, 13);
            this.lblEmpTitle.TabIndex = 0;
            this.lblEmpTitle.Text = "Title";
            // 
            // lblEmpDept
            // 
            this.lblEmpDept.AutoSize = true;
            this.lblEmpDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmpDept.Location = new System.Drawing.Point(313, 33);
            this.lblEmpDept.Name = "lblEmpDept";
            this.lblEmpDept.Size = new System.Drawing.Size(72, 13);
            this.lblEmpDept.TabIndex = 0;
            this.lblEmpDept.Text = "Department";
            // 
            // txbxEid
            // 
            this.txbxEid.Location = new System.Drawing.Point(108, 28);
            this.txbxEid.Name = "txbxEid";
            this.txbxEid.Size = new System.Drawing.Size(166, 23);
            this.txbxEid.TabIndex = 1;
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEid.Location = new System.Drawing.Point(24, 33);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(78, 13);
            this.lblEid.TabIndex = 0;
            this.lblEid.Text = "Employee ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 617);
            this.Controls.Add(this.grpbxAddEmp);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.lblCurrentEmployee);
            this.Controls.Add(this.dtaGridEmpMngSys);
            this.Controls.Add(this.lblEmpMngSys);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridEmpMngSys)).EndInit();
            this.grpbxAddEmp.ResumeLayout(false);
            this.grpbxAddEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpMngSys;
        private System.Windows.Forms.DataGridView dtaGridEmpMngSys;
        private System.Windows.Forms.Label lblCurrentEmployee;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.GroupBox grpbxAddEmp;
        private System.Windows.Forms.DateTimePicker dtpickerDOB;
        private System.Windows.Forms.ComboBox cmbxEmpTitle;
        private System.Windows.Forms.ComboBox cmbxEmpDept;
        private System.Windows.Forms.Label lblEmpDoB;
        private System.Windows.Forms.TextBox txbxEmpEmail;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox txbxEmpPhone;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.TextBox txbxLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txbxFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEmpTitle;
        private System.Windows.Forms.Label lblEmpDept;
        private System.Windows.Forms.TextBox txbxEid;
        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.TextBox txbxNotes;
        private System.Windows.Forms.Label label1;
    }
}