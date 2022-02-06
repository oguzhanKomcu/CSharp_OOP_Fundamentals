using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using War_Game_Project.model;

namespace War_Game_Project 
{
    public partial class One_Player_War : Form
    {
        public One_Player_War()
        {
            InitializeComponent();
        }

        private void One_Player_War_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        User user1 = new User();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textFirstName.Text) || String.IsNullOrWhiteSpace(textLastName.Text) || String.IsNullOrWhiteSpace(textNickName.Text) || String.IsNullOrWhiteSpace(textBirtyear.Text))
            {
                MessageBox.Show("Please enter information..!");
            }
            else
            {
                user1.FirstName = textFirstName.Text;
                user1.LastName = textLastName.Text;
                user1.NickName = textNickName.Text;
                DateTime now = DateTime.Now;
                user1.Age = now.Year - int.Parse(textBirtyear.Text);
                if(user1.Age > 18)
                {
                    groupBoxUserMilitary.Visible = true;
                    grpUserProfile.Visible = false;
                    Clears.Eraser(grpUserProfile);
                }
                
            }




        }
        Warrior userwrr = new Warrior();
        int warrior1bell;
        int warrior2bell;
        private void btnSelected1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxRank.Text) || String.IsNullOrWhiteSpace(comboBoxWeapon.Text) || String.IsNullOrWhiteSpace(comboBoxPhysics.Text) || String.IsNullOrWhiteSpace(comboBoxTalent.Text) || String.IsNullOrWhiteSpace(comboBoxDL.Text)) 
            {
                MessageBox.Show("Please enter warrior information..!");
            }

            userwrr.rank = comboBoxRank.Text;
            userwrr.weapon = comboBoxWeapon.Text;
            userwrr.physic = comboBoxPhysics.Text;
            userwrr.talent = comboBoxTalent.Text;
            userwrr.Diffucality_Level = comboBoxDL.Text;
            groupBoxUserMilitary.Visible = false;
            Clears.Eraser(grpUserProfile);
        }

        private void btnFire1_Click(object sender, EventArgs e)
        {
            int totalstrength = (userwrr.PS() + userwrr.RS() + userwrr.WS() + userwrr.TS() ) / 4;
            lblstrength1.Text = totalstrength.ToString();
            lblstrength2.Text = userwrr.DL().ToString();
            warrior2bell -= totalstrength;
            labelWarrior2health.Width = warrior2bell;
            

            warrior1bell -= userwrr.DL();
            labelWarrior1Health.Width = warrior1bell;
           
            if (labelWarrior2health.Width <= 0)
            {
                MessageBox.Show($"{user1.NickName.ToString()} KİLLED !!. YOU WİNN ");
                this.Hide();
                Application.Exit();

            }
            else if (labelWarrior1Health.Width <= 0)
            {
                MessageBox.Show($"{user1.NickName.ToString()} YOU DID AND LOSE !! ");
                this.Hide();
                Application.Exit();
            }
        }



        private void One_Player_War_Load(object sender, EventArgs e)
        {
            warrior2bell = labelWarrior2health.Width;
            warrior1bell = labelWarrior1Health.Width;
        }

        
    }
}
