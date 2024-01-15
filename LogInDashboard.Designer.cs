namespace MI6
{
    partial class LogInDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInDashboard));
            lblWelcome = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvAllAgents = new DataGridView();
            btnViewAllAgents = new Button();
            btnViewYourHistory = new Button();
            ViewHighscores = new Button();
            richTextBox1 = new RichTextBox();
            bntStartShootingGame = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAllAgents).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(356, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(71, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvAllAgents
            // 
            dgvAllAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAgents.Location = new Point(12, 325);
            dgvAllAgents.Name = "dgvAllAgents";
            dgvAllAgents.RowHeadersWidth = 51;
            dgvAllAgents.RowTemplate.Height = 29;
            dgvAllAgents.Size = new Size(776, 248);
            dgvAllAgents.TabIndex = 2;
            // 
            // btnViewAllAgents
            // 
            btnViewAllAgents.Location = new Point(12, 290);
            btnViewAllAgents.Name = "btnViewAllAgents";
            btnViewAllAgents.Size = new Size(135, 29);
            btnViewAllAgents.TabIndex = 3;
            btnViewAllAgents.Text = "View All Agents";
            btnViewAllAgents.UseVisualStyleBackColor = true;
            btnViewAllAgents.Click += btnViewAllAgents_Click;
            // 
            // btnViewYourHistory
            // 
            btnViewYourHistory.Location = new Point(153, 290);
            btnViewYourHistory.Name = "btnViewYourHistory";
            btnViewYourHistory.Size = new Size(140, 29);
            btnViewYourHistory.TabIndex = 4;
            btnViewYourHistory.Text = "View Your History";
            btnViewYourHistory.UseVisualStyleBackColor = true;
            btnViewYourHistory.Click += btnViewYourHistory_Click;
            // 
            // ViewHighscores
            // 
            ViewHighscores.Location = new Point(299, 290);
            ViewHighscores.Name = "ViewHighscores";
            ViewHighscores.Size = new Size(138, 29);
            ViewHighscores.TabIndex = 5;
            ViewHighscores.Text = "View Highscores";
            ViewHighscores.UseVisualStyleBackColor = true;
            ViewHighscores.Click += ViewHighscores_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(407, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 194);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // bntStartShootingGame
            // 
            bntStartShootingGame.Location = new Point(299, 230);
            bntStartShootingGame.Name = "bntStartShootingGame";
            bntStartShootingGame.Size = new Size(94, 29);
            bntStartShootingGame.TabIndex = 7;
            bntStartShootingGame.Text = "Start";
            bntStartShootingGame.UseVisualStyleBackColor = true;
            bntStartShootingGame.Click += bntStartShootingGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(309, 80);
            label1.TabIndex = 8;
            label1.Text = "Welcome Agent,\r\nYour mission is to show the world!\r\nTo start your mission, read the instruction and\r\nthen press the start button.";
            // 
            // LogInDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 585);
            Controls.Add(label1);
            Controls.Add(bntStartShootingGame);
            Controls.Add(richTextBox1);
            Controls.Add(ViewHighscores);
            Controls.Add(btnViewYourHistory);
            Controls.Add(btnViewAllAgents);
            Controls.Add(dgvAllAgents);
            Controls.Add(lblWelcome);
            Name = "LogInDashboard";
            Text = "LogInDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvAllAgents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvAllAgents;
        private Button btnViewAllAgents;
        private Button btnViewYourHistory;
        private Button ViewHighscores;
        private RichTextBox richTextBox1;
        private Button bntStartShootingGame;
        private Label label1;
    }
}