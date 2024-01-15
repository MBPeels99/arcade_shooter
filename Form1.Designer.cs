namespace MI6
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAgentNumber = new TextBox();
            txtAgentPassword = new TextBox();
            btnLogIn = new Button();
            btnShowSignUpForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 21);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "MI6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Agent Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 151);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txtAgentNumber
            // 
            txtAgentNumber.Location = new Point(151, 77);
            txtAgentNumber.Name = "txtAgentNumber";
            txtAgentNumber.Size = new Size(125, 27);
            txtAgentNumber.TabIndex = 3;
            txtAgentNumber.Tag = "Agent Number";
            // 
            // txtAgentPassword
            // 
            txtAgentPassword.Location = new Point(151, 148);
            txtAgentPassword.Name = "txtAgentPassword";
            txtAgentPassword.Size = new Size(125, 27);
            txtAgentPassword.TabIndex = 4;
            txtAgentPassword.Tag = "Password";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(151, 228);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnShowSignUpForm
            // 
            btnShowSignUpForm.Location = new Point(29, 228);
            btnShowSignUpForm.Name = "btnShowSignUpForm";
            btnShowSignUpForm.Size = new Size(94, 29);
            btnShowSignUpForm.TabIndex = 6;
            btnShowSignUpForm.Text = "Sign Up";
            btnShowSignUpForm.UseVisualStyleBackColor = true;
            btnShowSignUpForm.Click += btnShowSignUpForm_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 301);
            Controls.Add(btnShowSignUpForm);
            Controls.Add(btnLogIn);
            Controls.Add(txtAgentPassword);
            Controls.Add(txtAgentNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogIn";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogIn;
        private Button btnShowSignUpForm;
        public TextBox txtAgentNumber;
        public TextBox txtAgentPassword;
    }
}