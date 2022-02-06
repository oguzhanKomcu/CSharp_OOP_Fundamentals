using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project.model
{
     class Warrior : User
    {

        public string rank { get; set; }
        public string weapon { get; set; }
        public string physic { get; set; }
        public string talent { get; set; }
        public string Diffucality_Level  { get; set; }



        public int RS()
        {
            int strength = 0;

            switch (rank)
            {
                case "Private First Class (PFC)":
                    strength = 20;
                    break;
                case "Sergeant(SGT)":
                    strength = 35;
                    break;
                case "Sergeant SV":
                    strength = 50;
                    break;
                case "Second Lieutenant (2LT)":
                    strength = 60;
                    break;
                case "Captain (CPT)":
                    strength = 70;
                    break;
                case "Colonel (COL)":
                    strength = 85;
                    break;
                case "Genel (GEN)":
                    strength = 100;
                    break;
            }
            return strength;
        }
        public int WS()
        {
            int strength = 0;
            switch (weapon)
            {
                case "AK-47":
                    strength = 60;
                    break;
                case "M16":
                    strength = 50;
                    break;
                case "QXR":
                    strength = 40;
                    break;
                case "AWP":
                    strength = 80;
                    break;
                case "UMP-45":
                    strength = 45;
                    break;
                case "M60":
                    strength = 70;
                    break;

            }
            return strength;
        }

        public int PS()
        {
            int strength = 0;
            switch (physic)
            {
                case "LARGE":
                    strength = 85;
                    break;
                case "WEAK":
                    strength = 50;
                    break;
                case "MUSCLE":
                    strength = 75;
                    break;
                case "RICKETY":
                    strength = 40;
                    break;
                case "MIDDLE":
                    strength = 60;
                    break;


            }
            return strength;

        }
        public int TS()
        {
            int strength = 0;

            switch (talent)
            {
                case "FAST":
                    strength = 80;
                    break;
                case "STRONG":
                    strength = 75;
                    break;
                case "INTELLIGENT":
                    strength = 60;
                    break;
                case "AGILE":
                    strength = 65;
                    break;
                case "EXPERT":
                    strength = 85;
                    break;
            }
            return strength;
        }

        public int DL()
        {
            Random random = new Random();

            int strength = 0;

            switch (Diffucality_Level)
            {
                case "HARD":
                    strength = random.Next(70,100);
                    break;
                case "NORMAL":
                    strength = random.Next(40, 70);
                    break;
                case "EASY":
                    strength = random.Next(20, 40);
                    break;
               
            }
            return strength;

        }
    }
}
