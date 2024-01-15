using System.Data;

namespace MI6
{
    public partial class LogInDashboard : Form
    {
        // declare private field to store the agent code
        private string AgentCode;

        // create a new instance of the DatabaseController class with connection string
        DatabaseController databaseController = new DatabaseController("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CodingProjects\\Dot Net\\MI6\\MI6.mdf;Integrated Security=True");

        // constructor that takes in the agent code as a parameter
        public LogInDashboard(string agentCode)
        {
            InitializeComponent();
            AgentCode = agentCode;
            lblWelcome.Text = $"Welcome Agent {AgentCode}";
        }

        // event handler for the Start Shooting Game button
        private void bntStartShootingGame_Click(object sender, EventArgs e)
        {
            // set the DialogResult to Retry and close the form
            DialogResult = DialogResult.Retry;
            this.Close();
        }

        // event handler for the View All Agents button
        private void btnViewAllAgents_Click(object sender, EventArgs e)
        {
            // call the GetAllAgents method from the DatabaseController and store the result in a DataTable
            DataTable agentsDataTable = databaseController.GetAllAgents();

            // set the DataSource of the DataGridView to the DataTable
            dgvAllAgents.DataSource = agentsDataTable;
        }

        // event handler for the View Your History button
        private void btnViewYourHistory_Click(object sender, EventArgs e)
        {
            // convert the AgentCode string to an int and store it in agentID
            int agentID = int.Parse(AgentCode);

            // call the GetAgentScoreHistory method from the DatabaseController with the agentID parameter and store the result in a DataTable
            DataTable agentHistoryDataTable = databaseController.GetAgentScoreHistory(agentID);

            // set the DataSource of the DataGridView to the DataTable
            dgvAllAgents.DataSource = agentHistoryDataTable;
        }

        // event handler for the View Highscores button
        private void ViewHighscores_Click(object sender, EventArgs e)
        {
            // call the GetHighScores method from the DatabaseController and store the result in a DataTable
            DataTable highScoresDataTable = databaseController.GetHighScores();

            // set the DataSource of the DataGridView to the DataTable
            dgvAllAgents.DataSource = highScoresDataTable;
        }

    }
}
