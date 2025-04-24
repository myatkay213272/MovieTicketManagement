namespace MovieTicketBookingSystem
{
    partial class Signup
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
            this.label5 = new System.Windows.Forms.Label();
            this.reg_cPassword = new System.Windows.Forms.TextBox();
            this.reg_signInbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_showPass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Confirm Password";
            // 
            // reg_cPassword
            // 
            this.reg_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cPassword.Location = new System.Drawing.Point(32, 291);
            this.reg_cPassword.Name = "reg_cPassword";
            this.reg_cPassword.PasswordChar = '*';
            this.reg_cPassword.Size = new System.Drawing.Size(271, 30);
            this.reg_cPassword.TabIndex = 34;
            // 
            // reg_signInbtn
            // 
            this.reg_signInbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_signInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_signInbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_signInbtn.ForeColor = System.Drawing.Color.White;
            this.reg_signInbtn.Location = new System.Drawing.Point(35, 548);
            this.reg_signInbtn.Name = "reg_signInbtn";
            this.reg_signInbtn.Size = new System.Drawing.Size(290, 39);
            this.reg_signInbtn.TabIndex = 33;
            this.reg_signInbtn.Text = "Sign in";
            this.reg_signInbtn.UseVisualStyleBackColor = false;
            this.reg_signInbtn.Click += new System.EventHandler(this.reg_signInbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Create an account?";
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(32, 365);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(271, 49);
            this.reg_btn.TabIndex = 31;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_showPass
            // 
            this.reg_showPass.AutoSize = true;
            this.reg_showPass.Location = new System.Drawing.Point(32, 339);
            this.reg_showPass.Name = "reg_showPass";
            this.reg_showPass.Size = new System.Drawing.Size(125, 20);
            this.reg_showPass.TabIndex = 30;
            this.reg_showPass.Text = "Show Password";
            this.reg_showPass.UseVisualStyleBackColor = true;
            this.reg_showPass.CheckedChanged += new System.EventHandler(this.reg_showPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(32, 224);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(271, 30);
            this.reg_password.TabIndex = 28;
            this.reg_password.TextChanged += new System.EventHandler(this.reg_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(32, 156);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(271, 30);
            this.reg_username.TabIndex = 25;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(358, 14);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(32, 23);
            this.clear.TabIndex = 24;
            this.clear.Text = "X";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_cPassword);
            this.Controls.Add(this.reg_signInbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_showPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_cPassword;
        private System.Windows.Forms.Button reg_signInbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Button clear;
    }
}