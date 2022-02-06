namespace War_Game_Project
{
    partial class One_Player_War
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxUserMilitary = new System.Windows.Forms.GroupBox();
            this.comboBoxDL = new System.Windows.Forms.ComboBox();
            this.btnSelected1 = new System.Windows.Forms.Button();
            this.comboBoxTalent = new System.Windows.Forms.ComboBox();
            this.comboBoxPhysics = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxWAR = new System.Windows.Forms.GroupBox();
            this.btnFire1 = new System.Windows.Forms.Button();
            this.label232 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelWarrior2health = new System.Windows.Forms.Label();
            this.labelWarrior1Health = new System.Windows.Forms.Label();
            this.grpUserProfile = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNickName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textBirtyear = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.timerWar1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblstrength1 = new System.Windows.Forms.Label();
            this.lblstrength2 = new System.Windows.Forms.Label();
            this.groupBoxUserMilitary.SuspendLayout();
            this.groupBoxWAR.SuspendLayout();
            this.grpUserProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserMilitary
            // 
            this.groupBoxUserMilitary.Controls.Add(this.comboBoxDL);
            this.groupBoxUserMilitary.Controls.Add(this.btnSelected1);
            this.groupBoxUserMilitary.Controls.Add(this.comboBoxTalent);
            this.groupBoxUserMilitary.Controls.Add(this.comboBoxPhysics);
            this.groupBoxUserMilitary.Controls.Add(this.label6);
            this.groupBoxUserMilitary.Controls.Add(this.label5);
            this.groupBoxUserMilitary.Controls.Add(this.comboBoxWeapon);
            this.groupBoxUserMilitary.Controls.Add(this.label4);
            this.groupBoxUserMilitary.Controls.Add(this.comboBoxRank);
            this.groupBoxUserMilitary.Controls.Add(this.label3);
            this.groupBoxUserMilitary.Controls.Add(this.label2);
            this.groupBoxUserMilitary.Location = new System.Drawing.Point(458, 35);
            this.groupBoxUserMilitary.Name = "groupBoxUserMilitary";
            this.groupBoxUserMilitary.Size = new System.Drawing.Size(329, 341);
            this.groupBoxUserMilitary.TabIndex = 1;
            this.groupBoxUserMilitary.TabStop = false;
            this.groupBoxUserMilitary.Text = "User Military";
            this.groupBoxUserMilitary.Visible = false;
            // 
            // comboBoxDL
            // 
            this.comboBoxDL.FormattingEnabled = true;
            this.comboBoxDL.Items.AddRange(new object[] {
            "EASY",
            "NORMAL",
            "HARD"});
            this.comboBoxDL.Location = new System.Drawing.Point(175, 194);
            this.comboBoxDL.Name = "comboBoxDL";
            this.comboBoxDL.Size = new System.Drawing.Size(110, 23);
            this.comboBoxDL.TabIndex = 4;
            // 
            // btnSelected1
            // 
            this.btnSelected1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelected1.Location = new System.Drawing.Point(138, 249);
            this.btnSelected1.Name = "btnSelected1";
            this.btnSelected1.Size = new System.Drawing.Size(148, 54);
            this.btnSelected1.TabIndex = 3;
            this.btnSelected1.Text = "SELECT";
            this.btnSelected1.UseVisualStyleBackColor = true;
            this.btnSelected1.Click += new System.EventHandler(this.btnSelected1_Click);
            // 
            // comboBoxTalent
            // 
            this.comboBoxTalent.FormattingEnabled = true;
            this.comboBoxTalent.Items.AddRange(new object[] {
            "FAST",
            "STRONG",
            "INTELLIGENT",
            "AGILE",
            "EXPERT"});
            this.comboBoxTalent.Location = new System.Drawing.Point(174, 149);
            this.comboBoxTalent.Name = "comboBoxTalent";
            this.comboBoxTalent.Size = new System.Drawing.Size(112, 23);
            this.comboBoxTalent.TabIndex = 2;
            // 
            // comboBoxPhysics
            // 
            this.comboBoxPhysics.FormattingEnabled = true;
            this.comboBoxPhysics.Items.AddRange(new object[] {
            "LARGE",
            "WEAK",
            "MUSCLE",
            "RICKETY",
            "MIDDLE"});
            this.comboBoxPhysics.Location = new System.Drawing.Point(174, 109);
            this.comboBoxPhysics.Name = "comboBoxPhysics";
            this.comboBoxPhysics.Size = new System.Drawing.Size(112, 23);
            this.comboBoxPhysics.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "DIFFICULTY LEVEL : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Talent :";
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Items.AddRange(new object[] {
            "AK-47",
            "M16",
            "QXR",
            "AWP",
            "UMP-45",
            "M60"});
            this.comboBoxWeapon.Location = new System.Drawing.Point(173, 64);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(113, 23);
            this.comboBoxWeapon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Physics :";
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "Private First Class (PFC)",
            "Sergeant(SGT)",
            "Sergeant SV",
            "Second Lieutenant (2LT)",
            "Captain (CPT)",
            "Colonel (COL)",
            "Genel (GEN)"});
            this.comboBoxRank.Location = new System.Drawing.Point(174, 24);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(113, 23);
            this.comboBoxRank.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Weapon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rank :";
            // 
            // groupBoxWAR
            // 
            this.groupBoxWAR.Controls.Add(this.lblstrength2);
            this.groupBoxWAR.Controls.Add(this.lblstrength1);
            this.groupBoxWAR.Controls.Add(this.label8);
            this.groupBoxWAR.Controls.Add(this.label7);
            this.groupBoxWAR.Controls.Add(this.btnFire1);
            this.groupBoxWAR.Controls.Add(this.label232);
            this.groupBoxWAR.Controls.Add(this.label12);
            this.groupBoxWAR.Controls.Add(this.labelWarrior2health);
            this.groupBoxWAR.Controls.Add(this.labelWarrior1Health);
            this.groupBoxWAR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxWAR.Location = new System.Drawing.Point(23, 422);
            this.groupBoxWAR.Name = "groupBoxWAR";
            this.groupBoxWAR.Size = new System.Drawing.Size(812, 252);
            this.groupBoxWAR.TabIndex = 2;
            this.groupBoxWAR.TabStop = false;
            this.groupBoxWAR.Text = "WAR";
            // 
            // btnFire1
            // 
            this.btnFire1.Location = new System.Drawing.Point(54, 190);
            this.btnFire1.Name = "btnFire1";
            this.btnFire1.Size = new System.Drawing.Size(155, 47);
            this.btnFire1.TabIndex = 2;
            this.btnFire1.Text = "FİRE";
            this.btnFire1.UseVisualStyleBackColor = true;
            this.btnFire1.Click += new System.EventHandler(this.btnFire1_Click);
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(555, 137);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(226, 32);
            this.label232.TabIndex = 1;
            this.label232.Text = "WARRİOR 2 HEALTH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "WARRİOR 1 HEALTH";
            // 
            // labelWarrior2health
            // 
            this.labelWarrior2health.BackColor = System.Drawing.Color.Red;
            this.labelWarrior2health.Location = new System.Drawing.Point(455, 83);
            this.labelWarrior2health.Name = "labelWarrior2health";
            this.labelWarrior2health.Size = new System.Drawing.Size(326, 40);
            this.labelWarrior2health.TabIndex = 0;
            // 
            // labelWarrior1Health
            // 
            this.labelWarrior1Health.BackColor = System.Drawing.Color.Red;
            this.labelWarrior1Health.Location = new System.Drawing.Point(43, 83);
            this.labelWarrior1Health.Name = "labelWarrior1Health";
            this.labelWarrior1Health.Size = new System.Drawing.Size(326, 40);
            this.labelWarrior1Health.TabIndex = 0;
            // 
            // grpUserProfile
            // 
            this.grpUserProfile.Controls.Add(this.btnRegister);
            this.grpUserProfile.Controls.Add(this.label11);
            this.grpUserProfile.Controls.Add(this.label10);
            this.grpUserProfile.Controls.Add(this.label9);
            this.grpUserProfile.Controls.Add(this.label1);
            this.grpUserProfile.Controls.Add(this.textNickName);
            this.grpUserProfile.Controls.Add(this.textLastName);
            this.grpUserProfile.Controls.Add(this.textBirtyear);
            this.grpUserProfile.Controls.Add(this.textFirstName);
            this.grpUserProfile.Location = new System.Drawing.Point(35, 36);
            this.grpUserProfile.Name = "grpUserProfile";
            this.grpUserProfile.Size = new System.Drawing.Size(332, 288);
            this.grpUserProfile.TabIndex = 3;
            this.grpUserProfile.TabStop = false;
            this.grpUserProfile.Text = "User Profile";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(137, 219);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 44);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "REGİSTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Birth Year  : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nick Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Last Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name : ";
            // 
            // textNickName
            // 
            this.textNickName.Location = new System.Drawing.Point(139, 122);
            this.textNickName.Name = "textNickName";
            this.textNickName.Size = new System.Drawing.Size(145, 23);
            this.textNickName.TabIndex = 1;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(139, 83);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(145, 23);
            this.textLastName.TabIndex = 1;
            // 
            // textBirtyear
            // 
            this.textBirtyear.Location = new System.Drawing.Point(139, 164);
            this.textBirtyear.Name = "textBirtyear";
            this.textBirtyear.Size = new System.Drawing.Size(145, 23);
            this.textBirtyear.TabIndex = 0;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(139, 42);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(145, 23);
            this.textFirstName.TabIndex = 0;
            // 
            // timerWar1
            // 
            this.timerWar1.Enabled = true;
            this.timerWar1.Interval = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(589, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "STRENGTH :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "STRENGTH :";
            // 
            // lblstrength1
            // 
            this.lblstrength1.AutoSize = true;
            this.lblstrength1.Location = new System.Drawing.Point(151, 44);
            this.lblstrength1.Name = "lblstrength1";
            this.lblstrength1.Size = new System.Drawing.Size(0, 32);
            this.lblstrength1.TabIndex = 4;
            // 
            // lblstrength2
            // 
            this.lblstrength2.AutoSize = true;
            this.lblstrength2.Location = new System.Drawing.Point(695, 44);
            this.lblstrength2.Name = "lblstrength2";
            this.lblstrength2.Size = new System.Drawing.Size(0, 32);
            this.lblstrength2.TabIndex = 4;
            // 
            // One_Player_War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 686);
            this.Controls.Add(this.grpUserProfile);
            this.Controls.Add(this.groupBoxWAR);
            this.Controls.Add(this.groupBoxUserMilitary);
            this.Name = "One_Player_War";
            this.Text = "One_Player_War";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.One_Player_War_FormClosing);
            this.Load += new System.EventHandler(this.One_Player_War_Load);
            this.groupBoxUserMilitary.ResumeLayout(false);
            this.groupBoxUserMilitary.PerformLayout();
            this.groupBoxWAR.ResumeLayout(false);
            this.groupBoxWAR.PerformLayout();
            this.grpUserProfile.ResumeLayout(false);
            this.grpUserProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxUserMilitary;
        private ComboBox comboBoxDL;
        private Button btnSelected1;
        private ComboBox comboBoxTalent;
        private ComboBox comboBoxPhysics;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxWeapon;
        private Label label4;
        private ComboBox comboBoxRank;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxWAR;
        private Button btnFire1;
        private Label label232;
        private Label label12;
        private Label labelWarrior2health;
        private Label labelWarrior1Health;
        private GroupBox grpUserProfile;
        private Button btnRegister;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textNickName;
        private TextBox textLastName;
        private TextBox textBirtyear;
        private TextBox textFirstName;
        private System.Windows.Forms.Timer timerWar1;
        private Label lblstrength2;
        private Label lblstrength1;
        private Label label8;
        private Label label7;
    }
}