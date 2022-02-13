using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame_Project.Business.Repositories.Concrete;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project
{
    public partial class TwoPlayerWar : Form
    {
        public TwoPlayerWar()
        {
            InitializeComponent();
        }

        private void grpWar2_Enter(object sender, EventArgs e)
        {

        }
        WarCharacterRepository characterRepository = new WarCharacterRepository();
        WarCharacterRepository characterRepository2 = new WarCharacterRepository();

        UserRepository userRepository = new UserRepository();
        int point1;
        int point2;
        int clicknumber1;
        int clicknumber2;

        private void btnFiree1_Click_1(object sender, EventArgs e)
        {
            int idwar = 2;
            int iduser = 2;
            User user1;

            lblstrength1.Text = characterRepository.Totalstrentgh(idwar).ToString();
            labeluUSER2HEALTH.Width -= characterRepository.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);

            clicknumber1 += 1;


            if (labeluUSER2HEALTH.Width <= 0)
            {
                characterRepository2.Totalstrentgh(idwar);

                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund1.Text = user1.NickName;
                point1 += 100;

                groupBoxWAR1.Visible = false;
                grpWar2.Visible = true;
            }





        }

        User user1;
        User user2;

        private void TwoPlayerWar_Load(object sender, EventArgs e)
        {
            int user2id = 3;
            int user1id = 2;
            user1 = userRepository.GetById(user1id);
            user2 = userRepository.GetById(user2id);

            lblHealthUser1.Text = user1.NickName + " " + "HEALTH";
            lblHealthUser2.Text = user2.NickName + " " + "HEALTH";
            lblHealthUser3.Text = user1.NickName + " " + "HEALTH";
            lblHealthUser4.Text = user2.NickName + " " + "HEALTH";
            lblHealthUser5.Text = user1.NickName + " " + "HEALTH";
            lblHealthUser6.Text = user2.NickName + " " + "HEALTH";




        }

        private void btnFiree2_Click(object sender, EventArgs e)
        {

            int iduser = 3;
            int idwar = 3;
            User user1;

            lblstrength2.Text = characterRepository2.Totalstrentgh(idwar).ToString();
            labeluUSER1HEALTH.Width -= characterRepository2.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);


            if (labeluUSER1HEALTH.Width <= 0)
            {

                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund1.Text = user1.NickName;
                point2 += 100;

                groupBoxWAR1.Visible = false;
                grpWar2.Visible = true;

            }


        }

        private void btnFire2_1user_Click(object sender, EventArgs e)
        {
            int idwar = 2;
            int iduser = 2;
            User user1;




            lblWar2StrengthUser1.Text = characterRepository.Totalstrentgh(idwar).ToString();
            lblWar2Health2user.Width -= characterRepository.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);


            if (lblWar2Health2user.Width <= 0)
            {

                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund2.Text = user1.NickName;
                point1 += 100;
                grpWar2.Visible = false;
                grpWar3.Visible = true;


            }




        }

        private void btnFire4_2user_Click(object sender, EventArgs e)
        {
            int iduser = 3;
            int idwar = 3;
            User user1;

            lblWar2StrengthUser2.Text = characterRepository2.Totalstrentgh(idwar).ToString();
            lblWar2Health1user.Width -= characterRepository2.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);


            if (lblWar2Health1user.Width <= 0)
            {

                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund2.Text = user1.NickName;
                point2 += 100;
                grpWar2.Visible = false;
                grpWar3.Visible = true;

            }


        }

        private void btnFire3_User1_Click(object sender, EventArgs e)
        {
            int idwar = 2;
            int iduser = 2;
            User user1;


            lblWar3StrengthUser1.Text = characterRepository.Totalstrentgh(idwar).ToString();
            lblWar3Health2user.Width -= characterRepository.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);



            if (lblWar3Health2user.Width <= 0)
            {
                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund3.Text = user1.NickName;
                point1 += 100;
                grpWar3.Visible = false;
            }


        }

        private void lblWar3_2user_Click(object sender, EventArgs e)
        {
            int iduser = 3;
            int idwar = 3;
            User user1;

            lblWar3StrengthUser2.Text = characterRepository2.Totalstrentgh(idwar).ToString();
            lblWar3Health1user.Width -= characterRepository2.Totalstrentgh(idwar);

            user1 = userRepository.GetById(iduser);



            if (lblWar3Health1user.Width <= 0)
            {
                characterRepository2.Totalstrentgh(idwar);
                lblWar3Health2user.Width -= characterRepository.Totalstrentgh(idwar);
                MessageBox.Show($"{user1.NickName} KİLLED !!. YOU WİNN ");
                lblRaund3.Text = user1.NickName;

                point2 += 100;
                grpWar3.Visible = false;

            }



        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (point1 > 200)
            {
                int user1id = 2;
                user1 = userRepository.GetById(user1id);
                lblwin.Visible = true;
                lblWinner.Text = user1.NickName;
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
                    lblWar3Health2user.Width = with;
                    lblWar3Health1user.Width = with;
                    lblWar2Health1user.Width = with;
                    lblWar2Health2user.Width = with;
                    labeluUSER2HEALTH.Width = with;
                    labeluUSER1HEALTH.Width = with;


                    groupBoxWAR1.Visible = true;
                }

            }
            else if (point2 > 200)
            {
                int user2id = 3;
                user1 = userRepository.GetById(user2id);
                lblwin.Visible = true;
                lblWinner.Text = user1.NickName;
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
                    lblWar3Health2user.Width = with;
                    lblWar3Health1user.Width = with;
                    lblWar2Health1user.Width = with;
                    lblWar2Health2user.Width = with;
                    labeluUSER2HEALTH.Width = with;
                    labeluUSER1HEALTH.Width = with;


                    groupBoxWAR1.Visible = true;
                }


            }
        }

        private void TwoPlayerWar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
