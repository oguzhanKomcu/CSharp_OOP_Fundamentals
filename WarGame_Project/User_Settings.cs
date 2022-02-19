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
    public partial class User_Settings : Form
    {
        public User_Settings()
        {
            InitializeComponent();
        }

        UserRepository userrepository = new UserRepository();

        private void btnFind_Click(object sender, EventArgs e)
        {
            User user = new User(); 
            int userid = int.Parse(textIdFind.Text);
            user = userrepository.GetById(userid);  

            textNickNameUpdate.Text = user.NickName;    

        }

        private void User_Settings_Load(object sender, EventArgs e)
        {
            UserRepository userrepository = new UserRepository();
            dataGridView1.DataSource = userrepository.GetAll();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUserUpdate) == false)
            {

                User userupdate = new User();
                userupdate.Id = int.Parse(textIdFind.Text);
                foreach (User tim in FakeDatas.users)
                {

                    if (tim.NickName == textNickNameUpdate.Text)
                    {
                        MessageBox.Show("This username is a compliment.");
                        TextBox textBox = new TextBox();
                        if (textBox.Name == "textNickName")
                        {
                            textBox.Text = String.Empty;
                        }

                    }
                    else
                    {
                        userupdate.NickName = textNickNameUpdate.Text;
                    }


                }
                userrepository.Update(userupdate);


                dataGridView1.DataSource = userrepository.GetAll();
            }
               




        }

    

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start_Screen start_Screen = new Start_Screen();
            start_Screen.Show();
            this.Hide();
        }

        private void User_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUserDelete) == false)
            {
                int userid = int.Parse(textDeleteId.Text);
                User user = userrepository.GetById(userid);

                userrepository.Delete(user);


            }
        }
    }
}
