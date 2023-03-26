using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static THA_W4_Ali_Azhar_D.Form1;

namespace THA_W4_Ali_Azhar_D
{
    internal class Class_team
    {
        private List<Class_player> PlayerList = new List<Class_player>();
        private string teamName;
        private string teamCountry;
        private string teamCity;

        public Class_team(List<Class_player> playerList, string teamName, string teamCountry, string teamCity)
        {
            PlayerList = playerList;
            this.teamName = teamName;
            this.teamCountry = teamCountry;
            this.teamCity = teamCity;
        }

        public List <Class_player> getAllPlayer()
        { 
            return this.PlayerList; 
            
        }



        public void addPlayer(Class_player player)
        {
            this.PlayerList.Add(player);
        }
        public void removePlayer(int playerindex)
        {
            this.PlayerList.RemoveAt(playerindex);
        }

        public string getTeamName()
        {
            return teamName;
        }
        public void setTeamName(string teamName)
        {
            this.teamName = teamName;
        }


        public string getTeamCountry()
        {
            return this.teamCountry;
        }
        public void setTeamCountry(string teamCountry)
        {
            this.teamCountry = teamCountry;
        }


        public string getTeamCity()
        {
            return this.teamCity;
        }
        public void setTeamCity(string teamCity)
        {
            this.teamCity = teamCity;
        }
    }
}
