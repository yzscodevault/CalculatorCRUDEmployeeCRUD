
namespace Assignment5._1
{
    partial class Form1
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
            this.lblSelectForm = new System.Windows.Forms.Label();
            this.btnEmployeeEntrance = new System.Windows.Forms.Button();
            this.btnCalculatorEntrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectForm
            // 
            this.lblSelectForm.AutoSize = true;
            this.lblSelectForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelectForm.Location = new System.Drawing.Point(142, 93);
            this.lblSelectForm.Name = "lblSelectForm";
            this.lblSelectForm.Size = new System.Drawing.Size(508, 39);
            this.lblSelectForm.TabIndex = 0;
            this.lblSelectForm.Text = "Select One System to Proceed";
            // 
            // btnEmployeeEntrance
            // 
            this.btnEmployeeEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmployeeEntrance.Location = new System.Drawing.Point(88, 239);
            this.btnEmployeeEntrance.Name = "btnEmployeeEntrance";
            this.btnEmployeeEntrance.Size = new System.Drawing.Size(260, 82);
            this.btnEmployeeEntrance.TabIndex = 1;
            this.btnEmployeeEntrance.Text = "Employee Managing System";
            this.btnEmployeeEntrance.UseVisualStyleBackColor = true;
            this.btnEmployeeEntrance.Click += new System.EventHandler(this.btnEmployeeEntrance_Click);
            // 
            // btnCalculatorEntrance
            // 
            this.btnCalculatorEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculatorEntrance.Location = new System.Drawing.Point(458, 239);
            this.btnCalculatorEntrance.Name = "btnCalculatorEntrance";
            this.btnCalculatorEntrance.Size = new System.Drawing.Size(260, 82);
            this.btnCalculatorEntrance.TabIndex = 1;
            this.btnCalculatorEntrance.Text = "Calculator (Basic)";
            this.btnCalculatorEntrance.UseVisualStyleBackColor = true;
            this.btnCalculatorEntrance.Click += new System.EventHandler(this.btnCalculatorEntrance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculatorEntrance);
            this.Controls.Add(this.btnEmployeeEntrance);
            this.Controls.Add(this.lblSelectForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectForm;
        private System.Windows.Forms.Button btnEmployeeEntrance;
        private System.Windows.Forms.Button btnCalculatorEntrance;
    }
}

