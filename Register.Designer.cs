namespace ChurchBookingBot
{
    partial class Register
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 11);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID Number(Only Numbers Allowed)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 11);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 11);
            this.label8.TabIndex = 22;
            this.label8.Text = "Contact Number:";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(101, 213);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(177, 20);
            this.ID_txt.TabIndex = 21;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(314, 155);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(175, 20);
            this.email_txt.TabIndex = 20;
            // 
            // contact_txt
            // 
            this.contact_txt.Location = new System.Drawing.Point(102, 155);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.Size = new System.Drawing.Size(177, 20);
            this.contact_txt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 11);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a Astro Space", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 11);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name:";
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(315, 94);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(174, 20);
            this.surname_txt.TabIndex = 16;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(104, 94);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(175, 20);
            this.name_txt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 451);
            this.Controls.Add(this.button1);
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
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox contact_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button button1;
    }
}