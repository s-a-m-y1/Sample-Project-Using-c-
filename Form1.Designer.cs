namespace Bank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUT_Login = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.LB_Username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.greetings_Admain = new System.Windows.Forms.Label();
            this.lLB_WEL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BUT_Login);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LB_Password);
            this.panel1.Controls.Add(this.LB_Username);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(204, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 470);
            this.panel1.TabIndex = 0;
            // 
            // BUT_Login
            // 
            this.BUT_Login.BackColor = System.Drawing.Color.Black;
            this.BUT_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Login.ForeColor = System.Drawing.Color.Khaki;
            this.BUT_Login.Location = new System.Drawing.Point(304, 348);
            this.BUT_Login.Name = "BUT_Login";
            this.BUT_Login.Size = new System.Drawing.Size(153, 69);
            this.BUT_Login.TabIndex = 6;
            this.BUT_Login.Text = "Login";
            this.BUT_Login.UseVisualStyleBackColor = false;
            this.BUT_Login.Click += new System.EventHandler(this.BUT_Login_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(214, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(214, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 4;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.Transparent;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.Khaki;
            this.LB_Password.Location = new System.Drawing.Point(57, 215);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(151, 33);
            this.LB_Password.TabIndex = 3;
            this.LB_Password.Text = "Password";
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.BackColor = System.Drawing.Color.Transparent;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.Khaki;
            this.LB_Username.Location = new System.Drawing.Point(57, 141);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(158, 33);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Username";
            this.LB_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.greetings_Admain);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 84);
            this.panel2.TabIndex = 1;
            // 
            // greetings_Admain
            // 
            this.greetings_Admain.AutoSize = true;
            this.greetings_Admain.BackColor = System.Drawing.Color.Transparent;
            this.greetings_Admain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetings_Admain.ForeColor = System.Drawing.Color.Gold;
            this.greetings_Admain.Location = new System.Drawing.Point(286, 23);
            this.greetings_Admain.Name = "greetings_Admain";
            this.greetings_Admain.Size = new System.Drawing.Size(166, 33);
            this.greetings_Admain.TabIndex = 0;
            this.greetings_Admain.Text = "Login User";
            // 
            // lLB_WEL
            // 
            this.lLB_WEL.AutoSize = true;
            this.lLB_WEL.BackColor = System.Drawing.Color.Transparent;
            this.lLB_WEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLB_WEL.ForeColor = System.Drawing.Color.Gold;
            this.lLB_WEL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lLB_WEL.Location = new System.Drawing.Point(439, 9);
            this.lLB_WEL.Name = "lLB_WEL";
            this.lLB_WEL.Size = new System.Drawing.Size(276, 55);
            this.lLB_WEL.TabIndex = 1;
            this.lLB_WEL.Text = "Welcome :)";
            this.lLB_WEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(25, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1159, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lLB_WEL);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greetings_Admain;
        private System.Windows.Forms.Label lLB_WEL;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BUT_Login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

