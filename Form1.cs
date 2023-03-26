using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W4_Ali_Azhar_D
{
    public partial class Form1 : Form
    {
         List<Class_team> teamlist = new List<Class_team>();



        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List <Class_player> playerlist = new List<Class_player>();
            Class_player player1 = new Class_player("(01)","David De Gea", "GK");
            playerlist.Add(player1);
            Class_player player2 = new Class_player("(02)","Victor Lindelof","DF");
            playerlist.Add(player2);
            Class_player player3 = new Class_player("(04)", "Phill Jones", "DF");
            playerlist.Add(player3);
            Class_player player4 = new Class_player("(05)", "Harry Maguire", "DF");
            playerlist.Add(player4);
            Class_player player5 = new Class_player("(06)", "Lisando Martinez", "DF");
            playerlist.Add(player5);
            Class_player player6 = new Class_player("(08)", "Bruno Fernandez", "MF");
            playerlist.Add(player6);
            Class_player player7 = new Class_player("(09)", "Anthony Martial", "FW");
            playerlist.Add(player7);
            Class_player player8 = new Class_player("(10)", "Marcus Rashford", "FW");
            playerlist.Add(player8);
            Class_player player9 = new Class_player("(12)", "Tyrell Malacia", "DF");
            playerlist.Add(player9);
            Class_player player10 = new Class_player("(14)", "Christian Eriksen", "MF");
            playerlist.Add(player10);
            Class_player player11 = new Class_player("(18)", "Casemiro", "MF");
            playerlist.Add(player11);



            
            Class_team MU = new Class_team(playerlist, "Manchester United", "England", "Manchester");
           
            teamlist.Add(MU);

            List<Class_player> playerlist1 = new List<Class_player>();


            Class_player playerA = new Class_player("(01)", "Kepa Arrizabalaga", "GK");
            playerlist1.Add(playerA);
            Class_player playerB = new Class_player("(04)", "Benoit Badiashile", "DF");
            playerlist1.Add(playerB);
            Class_player playerC = new Class_player("(05)", "Enzo Fernandez", "MF");
            playerlist1.Add(playerC);
            Class_player playerD = new Class_player("(06)", "Thiago Silva", "DF");
            playerlist1.Add(playerD);
            Class_player playerE = new Class_player("(07)", "N'Golo Kante'", "MF");
            playerlist1.Add(playerE);
            Class_player playerF = new Class_player("(08)", "Mateo Kovavic", "MF");
            playerlist1.Add(playerF);
            Class_player playerG = new Class_player("(09)", "Pierre-Emerick Aubameyang", "FW");
            playerlist1.Add(playerG);
            Class_player playerH = new Class_player("(10)", "Christian Pulisic", "MF");
            playerlist1.Add(playerH);
            Class_player playerI = new Class_player("(11)", "Joao Felix", "FW");
            playerlist1.Add(playerI);
            Class_player playerJ = new Class_player("(12)", "Ruben Loftus-Cheek", "MF");
            playerlist1.Add(playerJ);
            Class_player playerK = new Class_player("(17)", "Raheem Sterling", "MF");
            playerlist1.Add(playerK);


            Class_team Chealsea = new Class_team(playerlist1, "Chealsea", "England", "Britania Raya");

            teamlist.Add(Chealsea);
            List<Class_player> playerlist2 = new List<Class_player>();

            Class_player playerA1 = new Class_player("(01)", "Manuel Neuer", "GK");
            playerlist2.Add(playerA1);
            Class_player playerA2 = new Class_player("(02)", "Dayot Upamecano", "DF");
            playerlist2.Add(playerA2);
            Class_player playerA3 = new Class_player("(04)", "Matthijs de Ligt", "DF");
            playerlist2.Add(playerA3);
            Class_player playerA4 = new Class_player("(05)", "Benjamin Pavard", "Df");
            playerlist2.Add(playerA4);
            Class_player playerA5 = new Class_player("(06)", "Josua Kimmich", "MF");
            playerlist2.Add(playerA5);
            Class_player playerA6 = new Class_player("(07)", "Serge Gnabry", "FW");
            playerlist2.Add(playerA6); 
            Class_player playerA7 = new Class_player("(08)", "Leon Goretzka", "MF");
            playerlist2.Add(playerA7);
            Class_player playerA8 = new Class_player("(10)", "Leroy Sane", "FW");
            playerlist2.Add(playerA8);
            Class_player playerA9 = new Class_player("(14)", "Paul Wanner", "MF");
            playerlist2.Add(playerA9);
            Class_player playerA10 = new Class_player("(21)", "Lucas Hemandez", "DF");
            playerlist2.Add(playerA10);
            Class_player playerA11 = new Class_player("(25)", "Thomas Muller", "FW");
            playerlist2.Add(playerA11);


            Class_team BayernMunich = new Class_team(playerlist2, "Bayern Munich", "Germany", "Munchen");



            teamlist.Add(BayernMunich);
            

            foreach (var team in teamlist)
            {
                if (!comboBox_Country.Items.Contains(team.getTeamCountry()))
                {
                    comboBox_Country.Items.Add(team.getTeamCountry());

                }

                
                
                
                
            }


        }

        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_SoccerTeamList.Items.Clear();
            foreach (var team in teamlist)
            {
                if (team.getTeamName() == comboBox_Team.Text)
                {
                    foreach (var player in team.getAllPlayer())
                    {
                        
                        listBox_SoccerTeamList.Items.Add("(" + player.getplayerNumber()+") "+ player.getplayerName()+", "+ player.getplayerPosition());

                    }
                }
            }
            
        }

        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Team.Items.Clear();
            foreach (var team in teamlist)
            {
                if (team.getTeamCountry() == comboBox_Country.Text)
                {
                    comboBox_Team.Items.Add(team.getTeamName());
                }
            }
        }

        private void button_RemoveBttn_Click(object sender, EventArgs e)
        {
            if(listBox_SoccerTeamList.Items.Count > 11)
            {
                if (listBox_SoccerTeamList.SelectedItem != null)
                {
                    foreach (var team in teamlist)
                    {
                        if (team.getTeamName() == comboBox_Team.Text)
                        {
                            team.removePlayer(listBox_SoccerTeamList.SelectedIndex);
                        }
                    }
                    listBox_SoccerTeamList.Items.Remove(listBox_SoccerTeamList.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Player Number Cannot Less Then 11");
            }
            
        }

        private void button_AddTeam_Click(object sender, EventArgs e)
        {
            double value;


            if ((!double.TryParse(textBox_TeamName.Text, out value))&& (!double.TryParse(textBox_TeamCountry.Text, out value)) &&(!double.TryParse(textBox_TeamCity.Text, out value)))
            {
                // The value is not a number, handle the error
                bool uniq = true;
                foreach (var team in teamlist)
                {
                    if(team.getTeamName() == textBox_TeamName.Text)
                    {
                        uniq = false;
                    }
                }
                if (uniq)
                {
                    List<Class_player> list = new List<Class_player>();
                    Class_team TeamBaru = new Class_team(list, textBox_TeamName.Text, textBox_TeamCountry.Text, textBox_TeamCity.Text);
                    teamlist.Add(TeamBaru);
                    foreach (var team in teamlist)
                    {
                        if (!comboBox_Country.Items.Contains(team.getTeamCountry()))
                        {
                            comboBox_Country.Items.Add(team.getTeamCountry());
                        }
                    }
                    textBox_TeamName.Clear();
                    textBox_TeamCountry.Clear();
                    textBox_TeamCity.Clear();
                }
                else
                {
                    MessageBox.Show("The Team Name Was Added");
                }
               

            }
            else
            {
                // The value is a valid number, continue with the operation
                // ...
                MessageBox.Show("Please enter a valid data.");
            }
            

        }

        private void button_AddPlayers_Click(object sender, EventArgs e)
        {
            double value;

            if ((!double.TryParse(textBox_PlayerName.Text, out value))&& (double.TryParse(textBox_PlayerNumber.Text, out value)))
            {

                // The value is not a number, handle the error
                foreach (var team in teamlist)
                {
                    if (comboBox_Team.Text == team.getTeamName())
                    {
                        bool uniq = true;
                        foreach (var player in team.getAllPlayer())
                        {
                            if(player.getplayerName() == textBox_PlayerName.Text)
                            {
                                uniq = false;

                            }
                        }
                        if (uniq)
                        {
                            Class_player PemainBaru = new Class_player(textBox_PlayerName.Text, textBox_PlayerNumber.Text, comboBox_PlayerPosition.Text);
                            team.addPlayer(PemainBaru);
                            listBox_SoccerTeamList.Items.Clear();


                            if (team.getTeamName() == comboBox_Team.Text)
                            {
                                foreach (var player in team.getAllPlayer())
                                {

                                    listBox_SoccerTeamList.Items.Add("(" + player.getplayerNumber() + ") " + player.getplayerName() + ", " + player.getplayerPosition());

                                }
                            }
                            textBox_PlayerName.Clear();
                            textBox_PlayerNumber.Clear();
                            comboBox_PlayerPosition.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Player Was Added");
                        }
                        


                    }
                }
                MessageBox.Show("Adding Player is Succesful");
            }
            else
            {

                // The value is a valid number, continue with the operation
                // ...
                MessageBox.Show("Please enter a valid data.");
            }

           
        }

        private void comboBox_PlayerPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
