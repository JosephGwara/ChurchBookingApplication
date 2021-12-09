namespace ChurchBookingBot
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
            this.components = new System.ComponentModel.Container();
            this.serviceBooking_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.action_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // serviceBooking_ComboBox
            // 
            this.serviceBooking_ComboBox.FormattingEnabled = true;
            this.serviceBooking_ComboBox.Items.AddRange(new object[] {
            "*******HQ Campus*******",
            "1.Morning Service(08:55)",
            "2.Evening Service(16:55)",
            "3.Prayer Night(21:30)",
            "*****Brooklyn Campus*****",
            "4.Morning Service(09:00)",
            "5.Evening Service(17:00)",
            "*****Potch Campus******",
            "6.First Service(16:00)",
            "7.Second Service(18:00)",
            "8.Prayer Night(21:30)"});
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
            this.label1.Font = new System.Drawing.Font("a Astro Space", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a Astro Space", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Details";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(37, 148);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(175, 20);
            this.name_txt.TabIndex = 4;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(248, 148);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(174, 20);
            this.surname_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 11);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 11);
            this.label5.TabIndex = 8;
            this.label5.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 11);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Number(Only Numbers Allowed)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 11);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 11);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contact Number:";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(34, 267);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(177, 20);
            this.ID_txt.TabIndex = 11;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(247, 209);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(175, 20);
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
            this.submit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.submit_btn.FlatAppearance.BorderSize = 2;
            this.submit_btn.Font = new System.Drawing.Font("a Astro Space", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(118, 361);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(212, 33);
            this.submit_btn.TabIndex = 22;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // action_lbl
            // 
            this.action_lbl.AutoSize = true;
            this.action_lbl.Font = new System.Drawing.Font("a Astro Space", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_lbl.ForeColor = System.Drawing.Color.Red;
            this.action_lbl.Location = new System.Drawing.Point(32, 306);
            this.action_lbl.Name = "action_lbl";
            this.action_lbl.Size = new System.Drawing.Size(54, 12);
            this.action_lbl.TabIndex = 23;
            this.action_lbl.Text = "timer";
            this.action_lbl.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 418);
            this.Controls.Add(this.action_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.contact_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceBooking_ComboBox);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox contact_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label action_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

