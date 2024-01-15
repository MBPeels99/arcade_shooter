using System.Data;
using System.Data.SqlClient;

public class DatabaseController
{
    private string _connectionString;// = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\CodingProjects\Dot Net\MI6\MI6.mdf;Integrated Security=True";
    public DatabaseController(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool IsUsernameAvailable(int agentID)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM AgentMI6 WHERE AgentID = @AgentID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AgentID", agentID);

                int count = (int)command.ExecuteScalar();

                return count == 0;
            }
        }
    }

    public void InsertAgent(int agentID, string agentName, string agentSurname, string agentPassword)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "INSERT INTO AgentMI6 (AgentID, AgentName, AgentSurname, AgentPassword) VALUES (@AgentID, @AgentName, @AgentSurname, @AgentPassword)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AgentID", agentID);
                command.Parameters.AddWithValue("@AgentName", agentName);
                command.Parameters.AddWithValue("@AgentSurname", agentSurname);
                command.Parameters.AddWithValue("@AgentPassword", agentPassword);

                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertScoreLog(int agentID, int scoreLog)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "INSERT INTO playLogs (Id, Score) VALUES (@agentID, @scoreLog)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@agentID", agentID);
                cmd.Parameters.AddWithValue("@scoreLog", scoreLog);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public bool CheckCredentials(string agentCode, string agentPassword)
    {
        int agentID;
        if (int.TryParse(agentCode, out agentID))
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT AgentPassword FROM AgentMI6 WHERE AgentID = @AgentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AgentID", agentID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString() == agentPassword;
                    }
                }
            }
        }
        return false;
    }

    public DataTable GetAllAgents()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT AgentID,AgentName,AgentSurname FROM AgentMI6";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public DataTable GetAgentScoreHistory(int agentID)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT Id, Score FROM playLogs WHERE Id = @AgentID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AgentID", agentID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public DataTable GetHighScores()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT TOP 10 Id, Score FROM playLogs ORDER BY Score DESC";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

}
