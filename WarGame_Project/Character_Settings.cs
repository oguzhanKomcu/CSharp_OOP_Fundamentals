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
using WarGame_Project.Business.Utilities;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project
{
    public partial class Character_Settings : Form
    {
        public Character_Settings()
        {
            InitializeComponent();
        }

        WarCharacter warCharacter = new WarCharacter();
        WarCharacterRepository characterRepository = new WarCharacterRepository();

        private void btnFindUpdate_Click(object sender, EventArgs e)
        {
        
            int warCharacterid = int.Parse(textIdUpdate.Text);
            warCharacter = characterRepository.GetById(warCharacterid);

            comboBoxRank.Text = warCharacter.Rank;
            comboBoxWeapon.Text = warCharacter.Weapon;
            comboBoxPhysics.Text = warCharacter.Physic;
            comboBoxTalent.Text = warCharacter.Talent;





        }

        private void Character_Settings_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = characterRepository.GetAll();
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUpdateCharacter) == false)
            {
                warCharacter.Id = int.Parse(textIdUpdate.Text);
                warCharacter.Rank = comboBoxRank.Text;
                warCharacter.Weapon = comboBoxWeapon.Text;
                warCharacter.Physic = comboBoxPhysics.Text;
                warCharacter.Talent = comboBoxTalent.Text;
                characterRepository.Update(warCharacter);
                dataGridView1.DataSource = characterRepository.GetAll();


            }
        }

        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (Utilities.TextControl(grpUpdateCharacter) == false)
            {

                int characterid = int.Parse(textIdDelete.Text);
                WarCharacter character = characterRepository.GetById(characterid);
                characterRepository.Delete(character);

            }
                
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            Start_Screen start_Screen = new Start_Screen();
            start_Screen.Show();
            this.Hide();
        }

        private void Character_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
