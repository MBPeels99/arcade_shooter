using MI6;

public partial class MainController : Form
{
    frmLogIn LogInfrm = new frmLogIn();
    frmSignUp signUpForm = new frmSignUp();
    public void SignUpComplete()
    {
        LogInfrm.txtAgentNumber.Text = signUpForm.AgentCode;
        LogInfrm.txtAgentPassword.Text = signUpForm.AgentPassword;
    }

}
