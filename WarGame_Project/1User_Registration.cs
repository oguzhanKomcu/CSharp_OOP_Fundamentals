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
    public partial class _1User_Registration : Form
    {
        WarCharacterRepository characterRepository = new WarCharacterRepository();
        User user1 = new User();
        UserRepository userRepository = new UserRepository();
        WarCharacter character = new WarCharacter();    
        List<WarCharacter> character1 = FakeDatas.warCharacters.ToList();


        public _1User_Registration()
        {
            InitializeComponent();
        }

        

     
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUserProfile) == false)
            {
                 
                user1.Id = 2; 
                user1.FirstName = textFirstName.Text;
                user1.LastName = textLastName.Text; 
                user1.NickName = textNickName.Text;

                foreach (User tim in FakeDatas.users)
                {

                    if (tim.NickName == textNickName.Text)
                    {
                        MessageBox.Show("This username is a compliment.");
                        textNickName.Text = String.Empty;   

                    }
                    else
                    {
                        user1.NickName = textNickName.Text;
                    }


                }

                DateTime now = DateTime.Now;
                user1.Age = now.Year - int.Parse(textBirtyear.Text);
                if (user1.Age > 18)
                {
                    groupBoxUserMilitary.Visible = true;
                }


                userRepository.Create(user1);

                dataGridViewUserProfil.DataSource = userRepository.GetAll();
            }

        
 
        }

        
       
      
        private void btnSelected1_Click(object sender, EventArgs e)
        {

            if (Utilities.TextControl(grpUserProfile) == false)
            {
                character.Id =2;    
                character.Rank = comboBoxRank.Text;
                character.Weapon = comboBoxWeapon.Text;
                character.Physic = comboBoxPhysics.Text;
                character.Talent = comboBoxTalent.Text;
                character.Diffucality_Level = comboBoxDL.Text;

                characterRepository.Create(character);
                dataGridViewMilitary.DataSource = characterRepository.GetAll();

            }
            

        }
        UserRepository repository = new UserRepository();
        private void _1User_Registration_Load(object sender, EventArgs e)
        {
            dataGridViewUserProfil.DataSource = repository.GetAll();
            dataGridViewMilitary.DataSource = repository.GetAll();
        }

        private void btnStartFighting_Click(object sender, EventArgs e)
        {
            OnePlayerWar  one_Player_War = new OnePlayerWar();     
            one_Player_War.Show();
            this.Hide();
        }

        private void btnREGULATİON1_Click(object sender, EventArgs e)
        {
            User_Settings user_Settings = new User_Settings();
            user_Settings.Show();
            this.Hide();
        }

        private void btnREGULATİON2_Click(object sender, EventArgs e)
        {
            Character_Settings settings = new Character_Settings(); 
            settings.Show();
            this.Hide();
        }

        private void _1User_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
