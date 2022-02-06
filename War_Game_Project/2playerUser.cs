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
    public partial class _2playerUser : Form
    {
        public static string user1NickName;
        public static string user2NickName;
        public _2playerUser()
        {
            InitializeComponent();
        }


        private void btnRegister2_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.FirstName = textFirstName.Text;
            user1.LastName = textLastName.Text;
            user1.NickName = textNickName.Text;
            user1NickName = user1.NickName;
            DateTime now = DateTime.Now;
            user1.Age = now.Year - int.Parse(textBirtyear.Text);



            User user2 = new User();
            user2.FirstName = textFirstName.Text;
            user2.LastName = textLastName.Text;
            user2.NickName = textNickName.Text;
            user2NickName = user2NickName;
            DateTime now2 = DateTime.Now;
            user2.Age = now2.Year - int.Parse(textBirtyear.Text);

            if (user1.Age > 18 && user2.Age > 18)
            {
                TwoPlayerWar tp = new TwoPlayerWar();
                tp.Show();
                this.Hide();
            }

   
        }

        private void _2playerUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
