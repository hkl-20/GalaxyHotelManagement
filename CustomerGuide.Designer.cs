
namespace GalaxyHotelManagement
{
    partial class CustomerGuide
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
            this.buttonReserveRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelEditReservation = new System.Windows.Forms.Label();
            this.labelDeleteReservation = new System.Windows.Forms.Label();
            this.buttonEditReservation = new System.Windows.Forms.Button();
            this.buttonDeleteReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReserveRoom
            // 
            this.buttonReserveRoom.Location = new System.Drawing.Point(200, 136);
            this.buttonReserveRoom.Name = "buttonReserveRoom";
            this.buttonReserveRoom.Size = new System.Drawing.Size(75, 23);
            this.buttonReserveRoom.TabIndex = 2;
            this.buttonReserveRoom.Text = "Here";
            this.buttonReserveRoom.UseVisualStyleBackColor = true;
            this.buttonReserveRoom.Click += new System.EventHandler(this.buttonReserveRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "What do you want to do?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reservation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 277);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelEditReservation
            // 
            this.labelEditReservation.AutoSize = true;
            this.labelEditReservation.Location = new System.Drawing.Point(76, 181);
            this.labelEditReservation.Name = "labelEditReservation";
            this.labelEditReservation.Size = new System.Drawing.Size(91, 15);
            this.labelEditReservation.TabIndex = 6;
            this.labelEditReservation.Text = "Edit Reservation";
            // 
            // labelDeleteReservation
            // 
            this.labelDeleteReservation.AutoSize = true;
            this.labelDeleteReservation.Location = new System.Drawing.Point(76, 221);
            this.labelDeleteReservation.Name = "labelDeleteReservation";
            this.labelDeleteReservation.Size = new System.Drawing.Size(104, 15);
            this.labelDeleteReservation.TabIndex = 7;
            this.labelDeleteReservation.Text = "Delete Reservation";
            // 
            // buttonEditReservation
            // 
            this.buttonEditReservation.Location = new System.Drawing.Point(200, 177);
            this.buttonEditReservation.Name = "buttonEditReservation";
            this.buttonEditReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonEditReservation.TabIndex = 8;
            this.buttonEditReservation.Text = "Here";
            this.buttonEditReservation.UseVisualStyleBackColor = true;
            this.buttonEditReservation.Click += new System.EventHandler(this.buttonEditReservation_Click);
            // 
            // buttonDeleteReservation
            // 
            this.buttonDeleteReservation.Location = new System.Drawing.Point(200, 217);
            this.buttonDeleteReservation.Name = "buttonDeleteReservation";
            this.buttonDeleteReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteReservation.TabIndex = 9;
            this.buttonDeleteReservation.Text = "Here";
            this.buttonDeleteReservation.UseVisualStyleBackColor = true;
            this.buttonDeleteReservation.Click += new System.EventHandler(this.buttonDeleteReservation_Click);
            // 
            // CustomerGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 312);
            this.Controls.Add(this.buttonDeleteReservation);
            this.Controls.Add(this.buttonEditReservation);
            this.Controls.Add(this.labelDeleteReservation);
            this.Controls.Add(this.labelEditReservation);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReserveRoom);
            this.Name = "CustomerGuide";
            this.Text = "Customer Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReserveRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelEditReservation;
        private System.Windows.Forms.Label labelDeleteReservation;
        private System.Windows.Forms.Button buttonEditReservation;
        private System.Windows.Forms.Button buttonDeleteReservation;
    }
}