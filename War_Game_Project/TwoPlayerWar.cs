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
    public partial class TwoPlayerWar : Form
    {
        public TwoPlayerWar()
        {
            InitializeComponent();
        }

        private void TwoPlayerWar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }
        Warrior userwrr1 = new Warrior();
        Warrior userwrr2 = new Warrior();
        int warrior1bell;
        int warrior2bell;
        private void btnSelected1_Click(object sender, EventArgs e)
        {

            warrior1bell = labeluUSER1HEALTH.Width;
            userwrr1.rank = comboBoxRank.Text;
            userwrr1.weapon = comboBoxWeapon.Text;
            userwrr1.physic = comboBoxPhysics.Text;
            userwrr1.talent = comboBoxTalent.Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }


        private void btnSelect2_Click(object sender, EventArgs e)
        {
            warrior2bell = labeluUSER2HEALTH.Width;
            userwrr2.rank = comboBoxRank2.Text;
            userwrr2.weapon = comboBoxWeapon2.Text;
            userwrr2.physic = comboBoxPhysics2.Text;
            userwrr2.talent = comboBoxTalent2.Text;

        }

        private void btnFiree1_Click(object sender, EventArgs e)
        {
            int totalstrength = (userwrr1.PS() + userwrr1.RS() + userwrr1.WS() + userwrr1.TS()) / 4;
            lblstrength1.Text = totalstrength.ToString();
            warrior2bell -= totalstrength;
            labeluUSER2HEALTH.Width = warrior2bell;
            if (warrior1bell <= 0)
            {

                MessageBox.Show($"{_2playerUser.user1NickName.ToString()} KİLLED !!. YOU WİNN ");
                this.Hide();
                Application.Exit();
            }
        }

        private void btnFiree2_Click(object sender, EventArgs e)
        {
            int totalstrength = (userwrr2.PS() + userwrr2.RS() + userwrr2.WS() + userwrr2.TS()) / 4;
            lblstrength2.Text = totalstrength.ToString();
            warrior1bell -= totalstrength;
            labeluUSER1HEALTH.Width = warrior1bell;
            if (warrior1bell <= 0)
            {
                MessageBox.Show($"{_2playerUser.user2NickName.ToString()} KİLLED !!. YOU WİNN ");
                this.Hide();
                Application.Exit();
            }
        }
    }
}
