﻿namespace MI6
{
    partial class frmSignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSignUp = new Button();
            txtAgentName = new TextBox();
            txtAgentSurname = new TextBox();
            txtAgentSignUpCode = new TextBox();
            txtAgentSignUpPassword = new TextBox();
            txtAgentSignUpPasswordConfirmation = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 51);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Please fill in all fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 105);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 155);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 206);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Agent Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 255);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 307);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password:";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(248, 361);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtAgentName
            // 
            txtAgentName.Location = new Point(248, 102);
            txtAgentName.Name = "txtAgentName";
            txtAgentName.Size = new Size(125, 27);
            txtAgentName.TabIndex = 8;
            txtAgentName.Tag = "Name";
            // 
            // txtAgentSurname
            // 
            txtAgentSurname.Location = new Point(248, 152);
            txtAgentSurname.Name = "txtAgentSurname";
            txtAgentSurname.Size = new Size(125, 27);
            txtAgentSurname.TabIndex = 9;
            txtAgentSurname.Tag = "Surname";
            // 
            // txtAgentSignUpCode
            // 
            txtAgentSignUpCode.Location = new Point(248, 203);
            txtAgentSignUpCode.Name = "txtAgentSignUpCode";
            txtAgentSignUpCode.Size = new Size(125, 27);
            txtAgentSignUpCode.TabIndex = 10;
            txtAgentSignUpCode.Tag = "Agent Code";
            // 
            // txtAgentSignUpPassword
            // 
            txtAgentSignUpPassword.Location = new Point(248, 252);
            txtAgentSignUpPassword.Name = "txtAgentSignUpPassword";
            txtAgentSignUpPassword.Size = new Size(125, 27);
            txtAgentSignUpPassword.TabIndex = 11;
            txtAgentSignUpPassword.Tag = "Password";
            // 
            // txtAgentSignUpPasswordConfirmation
            // 
            txtAgentSignUpPasswordConfirmation.Location = new Point(248, 304);
            txtAgentSignUpPasswordConfirmation.Name = "txtAgentSignUpPasswordConfirmation";
            txtAgentSignUpPasswordConfirmation.Size = new Size(125, 27);
            txtAgentSignUpPasswordConfirmation.TabIndex = 12;
            txtAgentSignUpPasswordConfirmation.Tag = "Password";
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(txtAgentSignUpPasswordConfirmation);
            Controls.Add(txtAgentSignUpPassword);
            Controls.Add(txtAgentSignUpCode);
            Controls.Add(txtAgentSurname);
            Controls.Add(txtAgentName);
            Controls.Add(btnSignUp);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmSignUp";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSignUp;
        private TextBox txtAgentName;
        private TextBox txtAgentSurname;
        private TextBox txtAgentSignUpCode;
        private TextBox txtAgentSignUpPassword;
        private TextBox txtAgentSignUpPasswordConfirmation;
    }
}