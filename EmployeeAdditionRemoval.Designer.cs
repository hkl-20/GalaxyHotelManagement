
namespace GalaxyHotelManagement
{
    partial class EmployeeAdditionRemoval
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(69, 69);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(114, 41);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(69, 125);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(114, 41);
            this.buttonRemoveEmployee.TabIndex = 2;
            this.buttonRemoveEmployee.Text = "Remove Employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 201);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 3;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // EmployeeAdditionRemoval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 236);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeAdditionRemoval";
            this.Text = "Employee Addition/Removal";
            this.Load += new System.EventHandler(this.EmployeeAdditionRemoval_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Button buttonGoBack;
    }
}