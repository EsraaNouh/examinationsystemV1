﻿
namespace The_Box_v0._1
{
    partial class Login
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Log_In_Button = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.AdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.InsRadioBtn = new System.Windows.Forms.RadioButton();
            this.StuRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(120, 57);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(158, 32);
            this.UserName.TabIndex = 20;
            this.UserName.Text = "User Name :";
            // 
            // UserNameText
            // 
            this.UserNameText.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserNameText.ForeColor = System.Drawing.Color.Black;
            this.UserNameText.Location = new System.Drawing.Point(302, 57);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(304, 59);
            this.UserNameText.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button2.Location = new System.Drawing.Point(386, 688);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.BackColor = System.Drawing.Color.Turquoise;
            this.Log_In_Button.FlatAppearance.BorderSize = 0;
            this.Log_In_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In_Button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Log_In_Button.Location = new System.Drawing.Point(345, 311);
            this.Log_In_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Size = new System.Drawing.Size(200, 88);
            this.Log_In_Button.TabIndex = 15;
            this.Log_In_Button.Text = "Log In";
            this.Log_In_Button.UseVisualStyleBackColor = false;
            this.Log_In_Button.Click += new System.EventHandler(this.Log_In_Button_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(120, 157);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(152, 32);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Passsword :";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.Turquoise;
            this.passwordText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.passwordText.Location = new System.Drawing.Point(302, 152);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(304, 59);
            this.passwordText.TabIndex = 21;
            // 
            // AdminRadioBtn
            // 
            this.AdminRadioBtn.AutoSize = true;
            this.AdminRadioBtn.ForeColor = System.Drawing.Color.White;
            this.AdminRadioBtn.Location = new System.Drawing.Point(302, 260);
            this.AdminRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminRadioBtn.Name = "AdminRadioBtn";
            this.AdminRadioBtn.Size = new System.Drawing.Size(79, 24);
            this.AdminRadioBtn.TabIndex = 23;
            this.AdminRadioBtn.TabStop = true;
            this.AdminRadioBtn.Text = "Admin";
            this.AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // InsRadioBtn
            // 
            this.InsRadioBtn.AutoSize = true;
            this.InsRadioBtn.ForeColor = System.Drawing.Color.White;
            this.InsRadioBtn.Location = new System.Drawing.Point(392, 260);
            this.InsRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsRadioBtn.Name = "InsRadioBtn";
            this.InsRadioBtn.Size = new System.Drawing.Size(102, 24);
            this.InsRadioBtn.TabIndex = 24;
            this.InsRadioBtn.TabStop = true;
            this.InsRadioBtn.Text = "Instructor";
            this.InsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // StuRadioBtn
            // 
            this.StuRadioBtn.AutoSize = true;
            this.StuRadioBtn.ForeColor = System.Drawing.Color.White;
            this.StuRadioBtn.Location = new System.Drawing.Point(504, 260);
            this.StuRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StuRadioBtn.Name = "StuRadioBtn";
            this.StuRadioBtn.Size = new System.Drawing.Size(91, 24);
            this.StuRadioBtn.TabIndex = 25;
            this.StuRadioBtn.TabStop = true;
            this.StuRadioBtn.Text = "Student";
            this.StuRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.Log_In_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(886, 425);
            this.Controls.Add(this.StuRadioBtn);
            this.Controls.Add(this.InsRadioBtn);
            this.Controls.Add(this.AdminRadioBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Log_In_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Log_In_Button;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.RadioButton AdminRadioBtn;
        private System.Windows.Forms.RadioButton InsRadioBtn;
        private System.Windows.Forms.RadioButton StuRadioBtn;
    }
}