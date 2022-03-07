
namespace Assignment5._1
{
    partial class Calculator
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
            this.dtaGridCalculator = new System.Windows.Forms.DataGridView();
            this.lblFNumber = new System.Windows.Forms.Label();
            this.txbxFNumber = new System.Windows.Forms.TextBox();
            this.lblSNumber = new System.Windows.Forms.Label();
            this.txbxSNumber = new System.Windows.Forms.TextBox();
            this.lblSelectCalculation = new System.Windows.Forms.Label();
            this.cmbxSelectCalculation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBasicCalculator = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridCalculator
            // 
            this.dtaGridCalculator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridCalculator.Location = new System.Drawing.Point(30, 39);
            this.dtaGridCalculator.Name = "dtaGridCalculator";
            this.dtaGridCalculator.Size = new System.Drawing.Size(550, 237);
            this.dtaGridCalculator.TabIndex = 0;
            // 
            // lblFNumber
            // 
            this.lblFNumber.AutoSize = true;
            this.lblFNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFNumber.Location = new System.Drawing.Point(26, 299);
            this.lblFNumber.Name = "lblFNumber";
            this.lblFNumber.Size = new System.Drawing.Size(192, 20);
            this.lblFNumber.TabIndex = 1;
            this.lblFNumber.Text = "Enter the First Number";
            // 
            // txbxFNumber
            // 
            this.txbxFNumber.Location = new System.Drawing.Point(263, 299);
            this.txbxFNumber.Name = "txbxFNumber";
            this.txbxFNumber.Size = new System.Drawing.Size(185, 20);
            this.txbxFNumber.TabIndex = 2;
            // 
            // lblSNumber
            // 
            this.lblSNumber.AutoSize = true;
            this.lblSNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSNumber.Location = new System.Drawing.Point(26, 346);
            this.lblSNumber.Name = "lblSNumber";
            this.lblSNumber.Size = new System.Drawing.Size(217, 20);
            this.lblSNumber.TabIndex = 1;
            this.lblSNumber.Text = "Enter the Second Number";
            // 
            // txbxSNumber
            // 
            this.txbxSNumber.Location = new System.Drawing.Point(263, 348);
            this.txbxSNumber.Name = "txbxSNumber";
            this.txbxSNumber.Size = new System.Drawing.Size(185, 20);
            this.txbxSNumber.TabIndex = 2;
            // 
            // lblSelectCalculation
            // 
            this.lblSelectCalculation.AutoSize = true;
            this.lblSelectCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelectCalculation.Location = new System.Drawing.Point(26, 399);
            this.lblSelectCalculation.Name = "lblSelectCalculation";
            this.lblSelectCalculation.Size = new System.Drawing.Size(154, 20);
            this.lblSelectCalculation.TabIndex = 1;
            this.lblSelectCalculation.Text = "Select Calculation";
            // 
            // cmbxSelectCalculation
            // 
            this.cmbxSelectCalculation.FormattingEnabled = true;
            this.cmbxSelectCalculation.Location = new System.Drawing.Point(263, 397);
            this.cmbxSelectCalculation.Name = "cmbxSelectCalculation";
            this.cmbxSelectCalculation.Size = new System.Drawing.Size(185, 21);
            this.cmbxSelectCalculation.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculate.Location = new System.Drawing.Point(485, 299);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 46);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBasicCalculator
            // 
            this.lblBasicCalculator.AutoSize = true;
            this.lblBasicCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBasicCalculator.Location = new System.Drawing.Point(26, 14);
            this.lblBasicCalculator.Name = "lblBasicCalculator";
            this.lblBasicCalculator.Size = new System.Drawing.Size(145, 20);
            this.lblBasicCalculator.TabIndex = 5;
            this.lblBasicCalculator.Text = "Calculation Results";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(485, 378);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(95, 55);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 451);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.lblBasicCalculator);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbxSelectCalculation);
            this.Controls.Add(this.txbxSNumber);
            this.Controls.Add(this.lblSelectCalculation);
            this.Controls.Add(this.lblSNumber);
            this.Controls.Add(this.txbxFNumber);
            this.Controls.Add(this.lblFNumber);
            this.Controls.Add(this.dtaGridCalculator);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridCalculator;
        private System.Windows.Forms.Label lblFNumber;
        private System.Windows.Forms.TextBox txbxFNumber;
        private System.Windows.Forms.Label lblSNumber;
        private System.Windows.Forms.TextBox txbxSNumber;
        private System.Windows.Forms.Label lblSelectCalculation;
        private System.Windows.Forms.ComboBox cmbxSelectCalculation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBasicCalculator;
        private System.Windows.Forms.Button btnDeleteRecord;
    }
}