using TextBox = System.Windows.Forms.TextBox;

namespace MI6
{
    public partial class frmLogIn : Form
    {
        public string AgentCode { get; private set; }
        public string AgentPassword { get; private set; }
        public frmLogIn()
        {
            InitializeComponent();

            txtAgentNumber.Enter += textBox_Enter;
            txtAgentNumber.Leave += textBox_Leave;

            txtAgentPassword.Enter += textBox_Enter;
            txtAgentPassword.Leave += textBox_Leave;
            txtAgentPassword.PasswordChar = '*';

            SetPlaceholder(txtAgentNumber);
            SetPlaceholder(txtAgentPassword);
        }

        private void btnShowSignUpForm_Click(object sender, EventArgs e)
        {
            using (frmSignUp signUpForm = new frmSignUp())
            {
                if (signUpForm.ShowDialog() == DialogResult.OK)
                {
                    txtAgentNumber.Text = signUpForm.AgentCode;
                    txtAgentPassword.Text = signUpForm.AgentPassword;
                }
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            string placeholderText = currentTextBox.Tag.ToString();

            if (currentTextBox.Text == placeholderText)
            {
                currentTextBox.Text = string.Empty;
                currentTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            string placeholderText = currentTextBox.Tag.ToString();

            if (currentTextBox.Text == string.Empty)
            {
                currentTextBox.Text = placeholderText;
                currentTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void SetPlaceholder(TextBox textBox)
        {
            textBox.Text = textBox.Tag.ToString();
            textBox.ForeColor = SystemColors.GrayText;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtAgentNumber.Text.Length <= 3)
            {
                DatabaseController dbController = new DatabaseController("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CodingProjects\\Dot Net\\MI6\\MI6.mdf;Integrated Security=True");
                if (dbController.CheckCredentials(txtAgentNumber.Text, txtAgentPassword.Text))
                {
                    AgentCode = txtAgentNumber.Text;
                    AgentPassword = txtAgentPassword.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Agent Code or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Agent Code should be 3 digits or less.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}