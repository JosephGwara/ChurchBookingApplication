﻿namespace ChurchBookingBot
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
            this.serviceBooking_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.newVisitor_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // serviceBooking_ComboBox
            // 
            this.serviceBooking_ComboBox.FormattingEnabled = true;
            this.serviceBooking_ComboBox.Items.AddRange(new object[] {
            "HQ Campus",
            "Morning Service ",
            "Evening Service",
            "Prayer Night",
            "Brooklyn Campus",
            "Morning Service",
            "Evening Service",
            "Potch Campus",
            "First Service",
            "Second Service",
            "Prayer Night"});
            this.serviceBooking_ComboBox.Location = new System.Drawing.Point(34, 59);
            this.serviceBooking_ComboBox.MaxDropDownItems = 15;
            this.serviceBooking_ComboBox.Name = "serviceBooking_ComboBox";
            this.serviceBooking_ComboBox.Size = new System.Drawing.Size(177, 21);
            this.serviceBooking_ComboBox.TabIndex = 0;
            this.serviceBooking_ComboBox.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Details";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(247, 141);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(167, 20);
            this.name_txt.TabIndex = 4;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(37, 276);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(174, 20);
            this.surname_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Are you a new visitor?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Number(Only Numbers Allowed)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contact Number:";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(247, 276);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(167, 20);
            this.ID_txt.TabIndex = 11;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(247, 209);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(167, 20);
            this.email_txt.TabIndex = 10;
            // 
            // contact_txt
            // 
            this.contact_txt.Location = new System.Drawing.Point(35, 209);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.Size = new System.Drawing.Size(177, 20);
            this.contact_txt.TabIndex = 9;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(119, 350);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(212, 23);
            this.submit_btn.TabIndex = 22;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // newVisitor_ComboBox
            // 
            this.newVisitor_ComboBox.FormattingEnabled = true;
            this.newVisitor_ComboBox.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.newVisitor_ComboBox.Location = new System.Drawing.Point(37, 140);
            this.newVisitor_ComboBox.Name = "newVisitor_ComboBox";
            this.newVisitor_ComboBox.Size = new System.Drawing.Size(174, 21);
            this.newVisitor_ComboBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 418);
            this.Controls.Add(this.newVisitor_ComboBox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.contact_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceBooking_ComboBox);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Booking Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serviceBooking_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox contact_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ComboBox newVisitor_ComboBox;
    }
}
