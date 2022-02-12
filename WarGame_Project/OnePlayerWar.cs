using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame_Project.Business.Data;
using WarGame_Project.Business.Repositories.Concrete;
using WarGame_Project.Business.Utilities;
using WarGame_Project.Model;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project
{
    public partial class OnePlayerWar : Form
    {
        public OnePlayerWar()
        {
            InitializeComponent();

        }


        WarCharacterRepository characterRepository = new WarCharacterRepository();
        UserRepository userRepository = new UserRepository();
        int point1;
        int point2;
        int clicknumber1;
        int clicknumber2;
        int clicknumber3;


        private void btnFiree1_Click(object sender, EventArgs e)
        {
            int totalstrength;
            int idwar;
            int iduser;
            User user;
            int DL;
            WarCharacter war;
         

           clicknumber1 = clicknumber1+1;

            if(clicknumber1 > 0 && clicknumber1 < 5)
            {
                idwar = 2;
                war = characterRepository.GetById(idwar);
                iduser = 2;
                user = userRepository.GetById(iduser);


                lblstrength1.Text = characterRepository.Totalstrentgh(idwar).ToString();
                DL = characterRepository.DL(war);
                lblstrength2.Text = DL.ToString();
                labeluUSER2HEALTH.Width -= characterRepository.Totalstrentgh(idwar); 
                labeluUSER1HEALTH.Width -= DL;
         

            }
            else if (clicknumber1 >= 5 )
            {
                
                iduser = 2;
                user = userRepository.GetById(iduser);
                if (labeluUSER2HEALTH.Width < labeluUSER1HEALTH.Width  )
                {
                    idwar = 2;
                    war = characterRepository.GetById(idwar);
                    labeluUSER2HEALTH.Width = 0;
                    labeluUSER1HEALTH.Width -= characterRepository.DL(war);
                    MessageBox.Show($"{user.NickName} KİLLED !!. YOU WİNN ");
                    lblRaund1.Text = user.NickName;
                    groupBoxWAR1.Visible = false;
                    grpWar2.Visible = true;
                    point1 += 100;


                }
                else if (labeluUSER2HEALTH.Width > labeluUSER1HEALTH.Width)
                {

                    idwar = 2;
                    war = characterRepository.GetById(idwar);         

                    labeluUSER1HEALTH.Width = 0;
                    labeluUSER2HEALTH.Width -= characterRepository.Totalstrentgh(idwar);
                    MessageBox.Show($"{user.NickName} YOU DID AND LOSE !! ");
                    lblRaund1.Text = "COMPUTER";
                    groupBoxWAR1.Visible = false;
                    grpWar2.Visible = true;
                    point2 += 100;

                }

            }

        }

        private void OnePlayerWar_Load(object sender, EventArgs e)
        {
            int iduser = 2;
            User user = userRepository.GetById(iduser);
            lblwar1health.Text =  user.NickName +" "+"HEALTH"; 
            lblwar2health.Text = user.NickName+" "+"HEALTH";
            lblwar3health.Text = user.NickName +" "+"HEALTH";
        }

      
        private void btnFire1user_Click(object sender, EventArgs e)
        {
            int totalstrength;
            int idwar;
            int iduser;
            User user;
            int DL;
            WarCharacter war;


            clicknumber2 = clicknumber2 + 1;

            if (clicknumber2 > 0 && clicknumber2 < 5)
            {
                idwar = 2;
                war = characterRepository.GetById(idwar);
                iduser = 2;
                user = userRepository.GetById(iduser);


                lblWar2Health1user.Width -= characterRepository.Totalstrentgh(idwar);
                lblWar2Health2user.Width -= characterRepository.DL(war);

                lblstrength3.Text = characterRepository.Totalstrentgh(idwar).ToString();
                lblstrength4.Text = characterRepository.DL(war).ToString();


            }
            else if (clicknumber1 >= 5)
            {
                idwar = 2;
                war = characterRepository.GetById(idwar);
                iduser = 2;
                user = userRepository.GetById(iduser);
                if (lblWar2Health2user.Width < lblWar2Health1user.Width)
                {
                    lblWar2Health2user.Width = 0;
                    lblWar2Health1user.Width -= characterRepository.DL(war);
                    MessageBox.Show($"{user.NickName} KİLLED !!. YOU WİNN ");
                    lblRaund2.Text = user.NickName;
                    grpWar2.Visible = false;
                    grpWar3.Visible = true;
                    point1 += 100;


                }
                else if (lblWar2Health2user.Width > lblWar2Health1user.Width)
                {
                    lblWar2Health1user.Width = 0;
                    lblWar2Health2user.Width -= characterRepository.Totalstrentgh(idwar);
                    MessageBox.Show($"{user.NickName} YOU DID AND LOSE !! ");
                    lblRaund2.Text = "COMPUTER";
                    grpWar2.Visible = false;
                    grpWar3.Visible = true;
                    point2 += 100;

                }

            }

        }
       
        private void btnFireUser1_Click(object sender, EventArgs e)
        {
            int totalstrength;
            int idwar;
            int iduser;
            User user;
            int DL;
            WarCharacter war;

            bool resault = true;
            clicknumber3 = clicknumber3 + 1;

            if (clicknumber3 > 0 && clicknumber3 < 5)
            {
                idwar = 2;
                war = characterRepository.GetById(idwar);
                iduser = 2;
                user = userRepository.GetById(iduser);

               
   
                lblWar3Health2userr.Width -= characterRepository.Totalstrentgh(idwar);
                lblWar3Health1user.Width -= characterRepository.DL(war);
                lblstrength5.Text = characterRepository.Totalstrentgh(idwar).ToString();
                lblstrength6.Text = characterRepository.DL(war).ToString();
            }
            else if (clicknumber3>= 5)
            {
                idwar = 2;
                iduser = 2;
                user = userRepository.GetById(iduser);
                if (lblWar3Health2userr.Width < lblWar3Health1user.Width)
                {
                    lblWar3Health2userr.Width = 0;

                    lblWar3Health1user.Width -= characterRepository.Totalstrentgh(idwar);
                    MessageBox.Show($"{user.NickName} KİLLED !!. YOU WİNN ");
                    lblRaund3.Text = user.NickName;
                    grpWar3.Visible = false;
                    point1 += 100;
                    resault = false;

                }
                else if ( lblWar3Health2userr.Width > lblWar3Health1user.Width)
                {
                    idwar = 2;
                    war = characterRepository.GetById(idwar);
                    lblWar3Health1user.Width = 0;
                    lblWar3Health2userr.Width -= characterRepository.DL(war);
                    MessageBox.Show($"{user.NickName} YOU DID AND LOSE ! ");
                    lblRaund3.Text = "COMPUTER";
                    grpWar3.Visible = false;
                    point2 += 100;
                    resault = false;
                }

            }

           
           

            if (point1 >= 200 && resault == false)
            {
                iduser = 2;
                user = userRepository.GetById(iduser);

                lblWinner.Text = user.NickName + " " + "YOU WİNNER";

                DialogResult dr = MessageBox.Show("PLAY AGAIN ", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {

                    int with = 326;
                    lblRaund1.Text = String.Empty;  
                    lblRaund2.Text = String.Empty;
                    lblRaund3.Text = String.Empty;
                    lblWinner.Text = String.Empty;
                    lblWar3Health2userr.Width = with;
                    lblWar3Health1user.Width = with;
                    lblWar2Health1user.Width = with;
                    lblWar2Health2user.Width = with;
                    labeluUSER2HEALTH.Width = with;
                    labeluUSER1HEALTH.Width = with;
                   clicknumber1 = 0;
                   clicknumber2 = 0;
                   clicknumber3 = 0;   

                    groupBoxWAR1.Visible = true;
                }

            }
            else if (point1 >= 200 && resault == false)
            {
                lblWinner.Text = "COMPUTER";
                DialogResult dr = MessageBox.Show("PLAY AGAIN ", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    int with = 326;
                    lblRaund1.Text = String.Empty;
                    lblRaund2.Text = String.Empty;
                    lblRaund3.Text = String.Empty;
                    lblWinner.Text = String.Empty;
                    lblWar3Health2userr.Width = with;
                    lblWar3Health1user.Width = with;
                    lblWar2Health1user.Width = with;
                    lblWar2Health2user.Width = with;
                    labeluUSER2HEALTH.Width = with;
                    labeluUSER1HEALTH.Width = with;
                    int clicknumber1 = 0;
                    int clicknumber2 = 0;
                    int clicknumber3 = 0;

                    groupBoxWAR1.Visible = true;
                }

            }

           



        }

        private void grpWar2_Enter(object sender, EventArgs e)
        {

        }

        private void OnePlayerWar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
