
namespace GalaxyHotelManagement
{
    partial class InitialSignIn
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
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.Location = new System.Drawing.Point(110, 108);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(75, 23);
            this.buttonVisitor.TabIndex = 1;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = true;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(110, 154);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployee.TabIndex = 2;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSignIn.Location = new System.Drawing.Point(29, 50);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(240, 25);
            this.labelSignIn.TabIndex = 3;
            this.labelSignIn.Text = "Who are you signing in as?";
            this.labelSignIn.Click += new System.EventHandler(this.labelSignIn_Click);
            // 
            // InitialSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 248);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonVisitor);
            this.Name = "InitialSignIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FormLogInAs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Label labelSignIn;
    }
}