using System.Text.RegularExpressions;
using TextBox = System.Windows.Forms.TextBox;

namespace MI6
{
    public partial class frmSignUp : Form
    {
        //Reg expression for names and surnames
        string reg_ex_name_pattern = @"^[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$";
        string reg_ex_code_pattern = @"^\d{1,3}$";

        public string AgentCode { get; private set; }
        public string AgentPassword { get; private set; }
        public string AgentName { get; private set; }
        public string Agentsurname { get; private set; }
        public frmSignUp()
        {
            InitializeComponent();

            // Add these lines after InitializeComponent()
            txtAgentName.Enter += textBox_Enter;
            txtAgentName.Leave += textBox_Leave;
            txtAgentName.Leave += ValidateAgentName;

            txtAgentSurname.Enter += textBox_Enter;
            txtAgentSurname.Leave += textBox_Leave;
            txtAgentSurname.Leave += ValidateAgentSurname;

            txtAgentSignUpCode.Enter += textBox_Enter;
            txtAgentSignUpCode.Leave += textBox_Leave;
            txtAgentSignUpCode.Leave += ValidateAgentSignUpCode;

            txtAgentSignUpPassword.Enter += textBox_Enter;
            txtAgentSignUpPassword.Leave += textBox_Leave;
            txtAgentSignUpPassword.PasswordChar = '*';

            txtAgentSignUpPasswordConfirmation.Enter += textBox_Enter;
            txtAgentSignUpPasswordConfirmation.Leave += textBox_Leave;
            txtAgentSignUpPasswordConfirmation.PasswordChar = '*';
            txtAgentSignUpPasswordConfirmation.Leave += ValidateAgentSignUpPasswordConfirmation;

            //Set Placeholders
            SetPlaceholder(txtAgentName);
            SetPlaceholder(txtAgentSurname);
            SetPlaceholder(txtAgentSignUpCode);
            SetPlaceholder(txtAgentSignUpPassword);
            SetPlaceholder(txtAgentSignUpPasswordConfirmation);

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AgentCode = txtAgentSignUpCode.Text;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CodingProjects\\Dot Net\\MI6\\MI6.mdf;Integrated Security=True";
            DatabaseController dbController = new DatabaseController(connectionString);

            if (txtAgentSignUpCode.Text == txtAgentSignUpCode.Tag.ToString() || string.IsNullOrEmpty(txtAgentSignUpCode.Text) || txtAgentName.Text == txtAgentName.Tag.ToString() || string.IsNullOrEmpty(txtAgentName.Text) || txtAgentSurname.Text == txtAgentSurname.Tag.ToString() || string.IsNullOrEmpty(txtAgentSurname.Text) || txtAgentSignUpPassword.Text == txtAgentSignUpPassword.Tag.ToString() || string.IsNullOrEmpty(txtAgentSignUpPassword.Text) || txtAgentSignUpPasswordConfirmation.Text == txtAgentSignUpPasswordConfirmation.Tag.ToString() || string.IsNullOrEmpty(txtAgentSignUpPasswordConfirmation.Text))
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(txtAgentSignUpCode.Text, out int agentIDToCheck))
                {
                    AgentCode = txtAgentSignUpCode.Text;
                    AgentName = txtAgentName.Text;
                    AgentPassword = txtAgentSignUpPassword.Text;
                    Agentsurname = txtAgentSurname.Text;

                    dbController.InsertAgent(agentIDToCheck, AgentName, Agentsurname, AgentPassword);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid agent sign-up code. Please enter a valid code with up to 3 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAgentSignUpCode.Focus();
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

        private void ValidateAgentName(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (!Regex.IsMatch(currentTextBox.Text, reg_ex_name_pattern))
            {
                MessageBox.Show("Invalid agent name. Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTextBox.Focus();
            }
        }

        private void ValidateAgentSurname(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (!Regex.IsMatch(currentTextBox.Text, reg_ex_name_pattern))
            {
                MessageBox.Show("Invalid agent surname. Please enter a valid surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTextBox.Focus();
            }
        }

        private void ValidateAgentSignUpCode(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            if (!Regex.IsMatch(currentTextBox.Text, reg_ex_code_pattern))
            {
                MessageBox.Show("Invalid agent sign-up code. Please enter a valid code with up to 3 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTextBox.Focus();
            }
            else if (currentTextBox.Text != currentTextBox.Tag.ToString() && !string.IsNullOrEmpty(currentTextBox.Text))
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CodingProjects\\Dot Net\\MI6\\MI6.mdf;Integrated Security=True";
                DatabaseController dbController = new DatabaseController(connectionString);

                if (int.TryParse(currentTextBox.Text, out int agentIDToCheck))
                {
                    bool isAvailable = dbController.IsUsernameAvailable(agentIDToCheck);

                    if (!isAvailable)
                    {
                        MessageBox.Show("Agent code entered is already taken. Please enter a new agent code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentTextBox.Focus();
                    }
                }
            }
        }

        private void ValidateAgentSignUpPasswordConfirmation(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (txtAgentSignUpPassword.Text != currentTextBox.Text)
            {
                MessageBox.Show("Password confirmation does not match. Please re-enter the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTextBox.Focus();
            }
        }
    }
}
