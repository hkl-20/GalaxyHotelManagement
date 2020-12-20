
namespace GalaxyHotelManagement
{
    partial class RoomAdditionRemoval
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
            this.buttonRoomRemoval = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Room Addition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRoomRemoval
            // 
            this.buttonRoomRemoval.Location = new System.Drawing.Point(120, 150);
            this.buttonRoomRemoval.Name = "buttonRoomRemoval";
            this.buttonRoomRemoval.Size = new System.Drawing.Size(105, 57);
            this.buttonRoomRemoval.TabIndex = 1;
            this.buttonRoomRemoval.Text = "Room Removal";
            this.buttonRoomRemoval.UseVisualStyleBackColor = true;
            this.buttonRoomRemoval.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 251);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RoomAdditionRemoval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 286);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRoomRemoval);
            this.Controls.Add(this.button1);
            this.Name = "RoomAdditionRemoval";
            this.Text = "Hotel Room Addition/Removal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRoomRemoval;
        private System.Windows.Forms.Button buttonBack;
    }
}