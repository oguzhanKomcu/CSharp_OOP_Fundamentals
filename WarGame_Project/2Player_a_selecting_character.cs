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
    public partial class _2PLAYERS_SELECTING_A__CHARACTER : Form
    {
        public _2PLAYERS_SELECTING_A__CHARACTER()
        {
            InitializeComponent();
        }

        private void _2PLAYERS_SELECTING_A__CHARACTER_Load(object sender, EventArgs e)
        {

        }

        private void btnSelected1_Click(object sender, EventArgs e)
        {
            WarCharacterRepository characterRepository1 = new WarCharacterRepository();
            WarCharacter character1 = new WarCharacter();
            character1.Id = 2;
            character1.Rank = comboBoxRank1user.Text;
            character1.Weapon = comboBoxWeapon1user.Text;
            character1.Physic = comboBoxPhysics1user.Text;
            character1.Talent = comboBoxTalent1user.Text;

            characterRepository1.Create(character1);



        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            WarCharacterRepository characterRepository2 = new WarCharacterRepository();
            WarCharacter character2 = new WarCharacter();
            character2.Id = 3;
            character2.Rank = comboBoxRank2user.Text;
            character2.Weapon = comboBoxWeapon2user.Text;
            character2.Physic = comboBoxPhysics2user.Text;
            character2.Talent = comboBoxTalent2user.Text;

            characterRepository2.Create(character2);
            dataGridView2usercharacter.DataSource = characterRepository2.GetAll();
        }

        private void btnWar_Click(object sender, EventArgs e)
        {
            TwoPlayerWar form = new TwoPlayerWar();
            form.Show();
            this.Hide();
        }
    }
}
