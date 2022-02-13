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
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project
{
    public partial class _2User_Registration : Form
    {
        public _2User_Registration()
        {
            InitializeComponent();
        }

        private void btnRegister1user_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUser1Profile) == false)
            {
                UserRepository userRepository = new UserRepository();
                User user1 = new User();
                user1.FirstName = textFirstNameUser1.Text;
                user1.Id = 2;
                user1.LastName = textLastNameUser1.Text;

                foreach (User tim in FakeDatas.users)
                {

                    if (tim.NickName == textNickNameUser1.Text)
                    {
                        MessageBox.Show("This username is a compliment.");
                        textNickNameUser1.Text = String.Empty;


                    }
                    else
                    {
                        user1.NickName = textNickNameUser1.Text;

                    }


                    
                }
                DateTime now = DateTime.Now;
                user1.Age = now.Year - int.Parse(textBirtyearUser1.Text);
                if (user1.Age > 18)
                {
                    grpUser1Profile.Visible = true;


                }

                userRepository.Create(user1);
                dataGridView2profile.DataSource = userRepository.GetAll();

            }

        }

        private void btnRegister2user_Click(object sender, EventArgs e)
        {

            if (Utilities.TextControl(grpUser2Profil) == false)
            {
                UserRepository userRepository = new UserRepository();
                User user2 = new User();
                user2.FirstName = textFirstNameUser2.Text;
                user2.Id = 3;
                user2.LastName = textLastNameUser2.Text;
                foreach (User tim in FakeDatas.users)
                {

                    if (tim.NickName == textNickNameUser2.Text)
                    {
                        MessageBox.Show("This username is a compliment.");
                        textNickNameUser2.Text = String.Empty;
                    }
                    else
                    {
                        user2.NickName = textNickNameUser2.Text;
                       
                       
                    }
                }


                DateTime now = DateTime.Now;

                user2.Age = now.Year - int.Parse(textBirtYearUser2.Text);
                if (user2.Age > 18)
                {
                    grpUser1Profile.Visible = true;


                }

                userRepository.Create(user2);
                 dataGridView2profile.DataSource = userRepository.GetAll();
            }
        }

        private void btnCharacterSelected_Click(object sender, EventArgs e)
        {
            _2PLAYERS_SELECTING_A__CHARACTER form = new _2PLAYERS_SELECTING_A__CHARACTER();
            form.Show();
            this.Hide();
        }

        private void btnRegulationUser1_Click(object sender, EventArgs e)
        {
            User_Settings user_Settings = new User_Settings();
            user_Settings.Show();
            this.Hide();
        }

        private void btnRegulation2_Click(object sender, EventArgs e)
        {
            User_Settings user_Settings = new User_Settings();
            user_Settings.Show();
            this.Hide();
        }

        private void _2User_Registration_Load(object sender, EventArgs e)
        {
          UserRepository repository = new UserRepository();
            dataGridView2profile.DataSource = repository.GetAll();
        }

        private void _2User_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
