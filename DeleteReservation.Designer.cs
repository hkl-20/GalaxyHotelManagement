namespace GalaxyHotelManagement
{
    partial class DeleteReservation
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
            this.labelReserveeUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxReserveeUsername = new System.Windows.Forms.TextBox();
            this.labelDeleteReservation = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReserveeUsername
            // 
            this.labelReserveeUsername.AutoSize = true;
            this.labelReserveeUsername.Location = new System.Drawing.Point(91, 150);
            this.labelReserveeUsername.Name = "labelReserveeUsername";
            this.labelReserveeUsername.Size = new System.Drawing.Size(109, 15);
            this.labelReserveeUsername.TabIndex = 0;
            this.labelReserveeUsername.Text = "Reservee Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(91, 197);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(217, 194);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(152, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxReserveeUsername
            // 
            this.textBoxReserveeUsername.Location = new System.Drawing.Point(217, 147);
            this.textBoxReserveeUsername.Name = "textBoxReserveeUsername";
            this.textBoxReserveeUsername.Size = new System.Drawing.Size(152, 23);
            this.textBoxReserveeUsername.TabIndex = 3;
            // 
            // labelDeleteReservation
            // 
            this.labelDeleteReservation.AutoSize = true;
            this.labelDeleteReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeleteReservation.Location = new System.Drawing.Point(162, 77);
            this.labelDeleteReservation.Name = "labelDeleteReservation";
            this.labelDeleteReservation.Size = new System.Drawing.Size(149, 21);
            this.labelDeleteReservation.TabIndex = 4;
            this.labelDeleteReservation.Text = "Delete Reservation";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(402, 292);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 292);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 6;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // DeleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 327);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDeleteReservation);
            this.Controls.Add(this.textBoxReserveeUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelReserveeUsername);
            this.Name = "DeleteReservation";
            this.Text = "Delete Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReserveeUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxReserveeUsername;
        private System.Windows.Forms.Label labelDeleteReservation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonGoBack;
    }
}