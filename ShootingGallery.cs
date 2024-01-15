using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace MI6
{
    public partial class ShootingGallery : Form
    {
        private int score;
        private PictureBox[] pictureBoxes;
        private Random random;
        private int timeRemaining;
        int agentCode;
        frmLogIn frmLogIn = new frmLogIn();
        DatabaseController databaseController = new DatabaseController("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CodingProjects\\Dot Net\\MI6\\MI6.mdf;Integrated Security=True");

        public ShootingGallery(int agentCode)
        {
            InitializeComponent();
            score = 0;
            InitializePictureBoxes();
            UpdateScoreLabel();
            random = new Random();
            SetRandomPictureBoxColors();
            lblAgentCode.Text = frmLogIn.AgentCode;
            this.agentCode = agentCode;
            timeRemaining = 60; // Set the initial time remaining to 60 seconds
            UpdateTimeLabel();
        }

        private void InitializePictureBoxes()
        {
            pictureBoxes = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15
            };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Click += PictureBox_Click;
            }
        }

        // Set random colors for the picture boxes
        private void SetRandomPictureBoxColors()
        {
            // Randomly pick 1 to 4 pictureBoxes to be red
            int redCount = random.Next(1, 5);

            // Order pictureBoxes randomly and take redCount of them to be assigned the red color
            var redPictureBoxes = pictureBoxes.OrderBy(x => random.Next()).Take(redCount);

            // Iterate through all pictureBoxes in the array
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                // If the current pictureBox is part of the redPictureBoxes collection, set its color to red
                if (redPictureBoxes.Contains(pictureBox))
                {
                    pictureBox.BackColor = Color.Red;
                }
                // If the current pictureBox is not part of the redPictureBoxes collection, set its color to green
                else
                {
                    pictureBox.BackColor = Color.Green;
                }
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (!gameTimer.Enabled) // Start the timer if it's not running
            {
                gameTimer.Start();
            }

            PictureBox clickedPictureBox = (PictureBox)sender;

            if (clickedPictureBox.BackColor == Color.Red)   //If a red card is clicked the score goes down 5 points
            {
                if (score <= 5)
                {
                    score = 0;
                }
                else
                {
                    score -= 5;
                }
            }
            else
            {
                score++;
            }

            UpdateScoreLabel();
            clickedPictureBox.Visible = false;
        }

        private void UpdateScoreLabel()
        {
            lblScore.Text = $"Score: {score}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = true;
            }

            SetRandomPictureBoxColors();

            // Reset the timer
            if (timeRemaining <= 0)
            {
                gameTimer.Stop();
                timeRemaining = 60;
                UpdateTimeLabel();
            }
        }

        private void btnQuitToLogInDashboard_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;

            if (timeRemaining <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show($"Time's up! Your score is {score}.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                databaseController.InsertScoreLog(agentCode, score);
            }
            else
            {
                UpdateTimeLabel();
            }
        }

        private void UpdateTimeLabel()
        {
            lblTime.Text = $"Time Remaining: {timeRemaining}s";
        }
    }
}
