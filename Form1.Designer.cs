namespace THA_W4_Ali_Azhar_D
{
    partial class Form1
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
            this.label_JudulSoccerTeamList = new System.Windows.Forms.Label();
            this.label_ChooseCountry = new System.Windows.Forms.Label();
            this.label_ChooseTeam = new System.Windows.Forms.Label();
            this.label_AddingTeam = new System.Windows.Forms.Label();
            this.label_TeamName = new System.Windows.Forms.Label();
            this.label_TeamCountry = new System.Windows.Forms.Label();
            this.label_TeamCity = new System.Windows.Forms.Label();
            this.label_AddingPlayer = new System.Windows.Forms.Label();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.label_PlayerNumber = new System.Windows.Forms.Label();
            this.label_PlayerPosition = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.textBox_TeamName = new System.Windows.Forms.TextBox();
            this.textBox_TeamCountry = new System.Windows.Forms.TextBox();
            this.textBox_TeamCity = new System.Windows.Forms.TextBox();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.textBox_PlayerNumber = new System.Windows.Forms.TextBox();
            this.comboBox_PlayerPosition = new System.Windows.Forms.ComboBox();
            this.button_AddTeam = new System.Windows.Forms.Button();
            this.button_AddPlayers = new System.Windows.Forms.Button();
            this.listBox_SoccerTeamList = new System.Windows.Forms.ListBox();
            this.button_RemoveBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_JudulSoccerTeamList
            // 
            this.label_JudulSoccerTeamList.AutoSize = true;
            this.label_JudulSoccerTeamList.Location = new System.Drawing.Point(40, 49);
            this.label_JudulSoccerTeamList.Name = "label_JudulSoccerTeamList";
            this.label_JudulSoccerTeamList.Size = new System.Drawing.Size(112, 16);
            this.label_JudulSoccerTeamList.TabIndex = 0;
            this.label_JudulSoccerTeamList.Text = "Soccer Team List";
            // 
            // label_ChooseCountry
            // 
            this.label_ChooseCountry.AutoSize = true;
            this.label_ChooseCountry.Location = new System.Drawing.Point(12, 89);
            this.label_ChooseCountry.Name = "label_ChooseCountry";
            this.label_ChooseCountry.Size = new System.Drawing.Size(102, 16);
            this.label_ChooseCountry.TabIndex = 1;
            this.label_ChooseCountry.Text = "Choose Country";
            this.label_ChooseCountry.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_ChooseTeam
            // 
            this.label_ChooseTeam.AutoSize = true;
            this.label_ChooseTeam.Location = new System.Drawing.Point(12, 123);
            this.label_ChooseTeam.Name = "label_ChooseTeam";
            this.label_ChooseTeam.Size = new System.Drawing.Size(93, 16);
            this.label_ChooseTeam.TabIndex = 2;
            this.label_ChooseTeam.Text = "Choose Team";
            // 
            // label_AddingTeam
            // 
            this.label_AddingTeam.AutoSize = true;
            this.label_AddingTeam.Location = new System.Drawing.Point(267, 35);
            this.label_AddingTeam.Name = "label_AddingTeam";
            this.label_AddingTeam.Size = new System.Drawing.Size(89, 16);
            this.label_AddingTeam.TabIndex = 3;
            this.label_AddingTeam.Text = "Adding Team";
            // 
            // label_TeamName
            // 
            this.label_TeamName.AutoSize = true;
            this.label_TeamName.Location = new System.Drawing.Point(248, 92);
            this.label_TeamName.Name = "label_TeamName";
            this.label_TeamName.Size = new System.Drawing.Size(83, 16);
            this.label_TeamName.TabIndex = 4;
            this.label_TeamName.Text = "Team Name";
            // 
            // label_TeamCountry
            // 
            this.label_TeamCountry.AutoSize = true;
            this.label_TeamCountry.Location = new System.Drawing.Point(248, 145);
            this.label_TeamCountry.Name = "label_TeamCountry";
            this.label_TeamCountry.Size = new System.Drawing.Size(91, 16);
            this.label_TeamCountry.TabIndex = 5;
            this.label_TeamCountry.Text = "Team Country";
            this.label_TeamCountry.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_TeamCity
            // 
            this.label_TeamCity.AutoSize = true;
            this.label_TeamCity.Location = new System.Drawing.Point(248, 191);
            this.label_TeamCity.Name = "label_TeamCity";
            this.label_TeamCity.Size = new System.Drawing.Size(68, 16);
            this.label_TeamCity.TabIndex = 6;
            this.label_TeamCity.Text = "Team City";
            this.label_TeamCity.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_AddingPlayer
            // 
            this.label_AddingPlayer.AutoSize = true;
            this.label_AddingPlayer.Location = new System.Drawing.Point(487, 34);
            this.label_AddingPlayer.Name = "label_AddingPlayer";
            this.label_AddingPlayer.Size = new System.Drawing.Size(99, 16);
            this.label_AddingPlayer.TabIndex = 7;
            this.label_AddingPlayer.Text = "Adding Players";
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.Location = new System.Drawing.Point(449, 95);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(86, 16);
            this.label_PlayerName.TabIndex = 8;
            this.label_PlayerName.Text = "Player Name";
            // 
            // label_PlayerNumber
            // 
            this.label_PlayerNumber.AutoSize = true;
            this.label_PlayerNumber.Location = new System.Drawing.Point(449, 145);
            this.label_PlayerNumber.Name = "label_PlayerNumber";
            this.label_PlayerNumber.Size = new System.Drawing.Size(97, 16);
            this.label_PlayerNumber.TabIndex = 9;
            this.label_PlayerNumber.Text = "Player Number";
            // 
            // label_PlayerPosition
            // 
            this.label_PlayerPosition.AutoSize = true;
            this.label_PlayerPosition.Location = new System.Drawing.Point(449, 197);
            this.label_PlayerPosition.Name = "label_PlayerPosition";
            this.label_PlayerPosition.Size = new System.Drawing.Size(97, 16);
            this.label_PlayerPosition.TabIndex = 10;
            this.label_PlayerPosition.Text = "Player Position";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(121, 89);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Country.TabIndex = 11;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.comboBox_Country_SelectedIndexChanged);
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(121, 123);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Team.TabIndex = 12;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            // 
            // textBox_TeamName
            // 
            this.textBox_TeamName.Location = new System.Drawing.Point(338, 92);
            this.textBox_TeamName.Name = "textBox_TeamName";
            this.textBox_TeamName.Size = new System.Drawing.Size(100, 22);
            this.textBox_TeamName.TabIndex = 13;
            // 
            // textBox_TeamCountry
            // 
            this.textBox_TeamCountry.Location = new System.Drawing.Point(338, 145);
            this.textBox_TeamCountry.Name = "textBox_TeamCountry";
            this.textBox_TeamCountry.Size = new System.Drawing.Size(100, 22);
            this.textBox_TeamCountry.TabIndex = 14;
            // 
            // textBox_TeamCity
            // 
            this.textBox_TeamCity.Location = new System.Drawing.Point(338, 191);
            this.textBox_TeamCity.Name = "textBox_TeamCity";
            this.textBox_TeamCity.Size = new System.Drawing.Size(100, 22);
            this.textBox_TeamCity.TabIndex = 15;
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(552, 95);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(100, 22);
            this.textBox_PlayerName.TabIndex = 16;
            this.textBox_PlayerName.TextChanged += new System.EventHandler(this.textBox_PlayerName_TextChanged);
            // 
            // textBox_PlayerNumber
            // 
            this.textBox_PlayerNumber.Location = new System.Drawing.Point(552, 145);
            this.textBox_PlayerNumber.Name = "textBox_PlayerNumber";
            this.textBox_PlayerNumber.Size = new System.Drawing.Size(100, 22);
            this.textBox_PlayerNumber.TabIndex = 17;
            // 
            // comboBox_PlayerPosition
            // 
            this.comboBox_PlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PlayerPosition.FormattingEnabled = true;
            this.comboBox_PlayerPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_PlayerPosition.Location = new System.Drawing.Point(552, 197);
            this.comboBox_PlayerPosition.Name = "comboBox_PlayerPosition";
            this.comboBox_PlayerPosition.Size = new System.Drawing.Size(121, 24);
            this.comboBox_PlayerPosition.TabIndex = 18;
            this.comboBox_PlayerPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlayerPosition_SelectedIndexChanged);
            // 
            // button_AddTeam
            // 
            this.button_AddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_AddTeam.Location = new System.Drawing.Point(338, 230);
            this.button_AddTeam.Name = "button_AddTeam";
            this.button_AddTeam.Size = new System.Drawing.Size(75, 23);
            this.button_AddTeam.TabIndex = 19;
            this.button_AddTeam.Text = "Add";
            this.button_AddTeam.UseVisualStyleBackColor = false;
            this.button_AddTeam.Click += new System.EventHandler(this.button_AddTeam_Click);
            // 
            // button_AddPlayers
            // 
            this.button_AddPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_AddPlayers.Location = new System.Drawing.Point(552, 229);
            this.button_AddPlayers.Name = "button_AddPlayers";
            this.button_AddPlayers.Size = new System.Drawing.Size(75, 23);
            this.button_AddPlayers.TabIndex = 20;
            this.button_AddPlayers.Text = "Add";
            this.button_AddPlayers.UseVisualStyleBackColor = false;
            this.button_AddPlayers.Click += new System.EventHandler(this.button_AddPlayers_Click);
            // 
            // listBox_SoccerTeamList
            // 
            this.listBox_SoccerTeamList.FormattingEnabled = true;
            this.listBox_SoccerTeamList.ItemHeight = 16;
            this.listBox_SoccerTeamList.Location = new System.Drawing.Point(32, 169);
            this.listBox_SoccerTeamList.Name = "listBox_SoccerTeamList";
            this.listBox_SoccerTeamList.Size = new System.Drawing.Size(210, 180);
            this.listBox_SoccerTeamList.TabIndex = 21;
            // 
            // button_RemoveBttn
            // 
            this.button_RemoveBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_RemoveBttn.Location = new System.Drawing.Point(43, 368);
            this.button_RemoveBttn.Name = "button_RemoveBttn";
            this.button_RemoveBttn.Size = new System.Drawing.Size(75, 23);
            this.button_RemoveBttn.TabIndex = 22;
            this.button_RemoveBttn.Text = "Remove";
            this.button_RemoveBttn.UseVisualStyleBackColor = false;
            this.button_RemoveBttn.Click += new System.EventHandler(this.button_RemoveBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RemoveBttn);
            this.Controls.Add(this.listBox_SoccerTeamList);
            this.Controls.Add(this.button_AddPlayers);
            this.Controls.Add(this.button_AddTeam);
            this.Controls.Add(this.comboBox_PlayerPosition);
            this.Controls.Add(this.textBox_PlayerNumber);
            this.Controls.Add(this.textBox_PlayerName);
            this.Controls.Add(this.textBox_TeamCity);
            this.Controls.Add(this.textBox_TeamCountry);
            this.Controls.Add(this.textBox_TeamName);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label_PlayerPosition);
            this.Controls.Add(this.label_PlayerNumber);
            this.Controls.Add(this.label_PlayerName);
            this.Controls.Add(this.label_AddingPlayer);
            this.Controls.Add(this.label_TeamCity);
            this.Controls.Add(this.label_TeamCountry);
            this.Controls.Add(this.label_TeamName);
            this.Controls.Add(this.label_AddingTeam);
            this.Controls.Add(this.label_ChooseTeam);
            this.Controls.Add(this.label_ChooseCountry);
            this.Controls.Add(this.label_JudulSoccerTeamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_JudulSoccerTeamList;
        private System.Windows.Forms.Label label_ChooseCountry;
        private System.Windows.Forms.Label label_ChooseTeam;
        private System.Windows.Forms.Label label_AddingTeam;
        private System.Windows.Forms.Label label_TeamName;
        private System.Windows.Forms.Label label_TeamCountry;
        private System.Windows.Forms.Label label_TeamCity;
        private System.Windows.Forms.Label label_AddingPlayer;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.Label label_PlayerNumber;
        private System.Windows.Forms.Label label_PlayerPosition;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.TextBox textBox_TeamName;
        private System.Windows.Forms.TextBox textBox_TeamCountry;
        private System.Windows.Forms.TextBox textBox_TeamCity;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.TextBox textBox_PlayerNumber;
        private System.Windows.Forms.ComboBox comboBox_PlayerPosition;
        private System.Windows.Forms.Button button_AddTeam;
        private System.Windows.Forms.Button button_AddPlayers;
        private System.Windows.Forms.ListBox listBox_SoccerTeamList;
        private System.Windows.Forms.Button button_RemoveBttn;
    }
}

