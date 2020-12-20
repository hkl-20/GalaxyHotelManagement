
namespace GalaxyHotelManagement
{
    partial class ActivityPortal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRoomAdditionRemoval = new System.Windows.Forms.Button();
            this.buttonEmployeeShifts = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonCustomerCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Customer Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Employee Addition/Removal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRoomAdditionRemoval
            // 
            this.buttonRoomAdditionRemoval.Location = new System.Drawing.Point(65, 186);
            this.buttonRoomAdditionRemoval.Name = "buttonRoomAdditionRemoval";
            this.buttonRoomAdditionRemoval.Size = new System.Drawing.Size(122, 66);
            this.buttonRoomAdditionRemoval.TabIndex = 2;
            this.buttonRoomAdditionRemoval.Text = "Room Addition/Removal";
            this.buttonRoomAdditionRemoval.UseVisualStyleBackColor = true;
            this.buttonRoomAdditionRemoval.Click += new System.EventHandler(this.buttonRoomAdditionRemoval_Click);
            // 
            // buttonEmployeeShifts
            // 
            this.buttonEmployeeShifts.Location = new System.Drawing.Point(325, 186);
            this.buttonEmployeeShifts.Name = "buttonEmployeeShifts";
            this.buttonEmployeeShifts.Size = new System.Drawing.Size(122, 66);
            this.buttonEmployeeShifts.TabIndex = 3;
            this.buttonEmployeeShifts.Text = "Employee Shifts";
            this.buttonEmployeeShifts.UseVisualStyleBackColor = true;
            this.buttonEmployeeShifts.Click += new System.EventHandler(this.buttonEmployeeShifts_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(413, 287);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 287);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonCustomerCheckOut
            // 
            this.buttonCustomerCheckOut.Location = new System.Drawing.Point(195, 110);
            this.buttonCustomerCheckOut.Name = "buttonCustomerCheckOut";
            this.buttonCustomerCheckOut.Size = new System.Drawing.Size(122, 66);
            this.buttonCustomerCheckOut.TabIndex = 6;
            this.buttonCustomerCheckOut.Text = "Customer Check Out";
            this.buttonCustomerCheckOut.UseVisualStyleBackColor = true;
            this.buttonCustomerCheckOut.Click += new System.EventHandler(this.buttonCustomerCheckOut_Click);
            // 
            // ActivityPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 322);
            this.Controls.Add(this.buttonCustomerCheckOut);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEmployeeShifts);
            this.Controls.Add(this.buttonRoomAdditionRemoval);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityPortal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ActivityPortal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRoomAdditionRemoval;
        private System.Windows.Forms.Button buttonEmployeeShifts;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonCustomerCheckOut;
    }
}