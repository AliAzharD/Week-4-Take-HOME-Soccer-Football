using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static THA_W4_Ali_Azhar_D.Form1;

namespace THA_W4_Ali_Azhar_D
{
    internal class Class_player
    {

        private string PlayerName;
        private string PlayerNumber;
        private string PlayerPosition;

        public Class_player (string playerName, string playerNumber, string playerPosition)
        {

            PlayerName = playerName;
            PlayerNumber = playerNumber;
            PlayerPosition = playerPosition;
        }

        public string getplayerName()
        {
            return PlayerName;
        }
        public void setplayerName(string PlayerName)
        {
            this.PlayerName = PlayerName;
        }


        public string getplayerNumber()
        {
            return PlayerNumber;
        }
        public void setplayerNumber(string PlayerNumber)
        {
            this.PlayerNumber = PlayerNumber;
        }


        public string getplayerPosition()
        {
            return PlayerPosition;
        }
        public void setplayerPosition(string PlayerPosition)
        {
            this.PlayerPosition = PlayerPosition;
        }


    }
}
