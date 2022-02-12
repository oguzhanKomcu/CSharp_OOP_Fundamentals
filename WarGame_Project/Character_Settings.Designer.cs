namespace WarGame_Project
{
    partial class Character_Settings
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
            this.grpDeleteCharacter = new System.Windows.Forms.GroupBox();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.textIdDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpUpdateCharacter = new System.Windows.Forms.GroupBox();
            this.btnUpdateCharacter = new System.Windows.Forms.Button();
            this.textIdUpdate = new System.Windows.Forms.TextBox();
            this.btnFindUpdate = new System.Windows.Forms.Button();
            this.comboBoxTalent = new System.Windows.Forms.ComboBox();
            this.comboBoxPhysics = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBACK = new System.Windows.Forms.Button();
            this.grpDeleteCharacter.SuspendLayout();
            this.grpUpdateCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDeleteCharacter
            // 
            this.grpDeleteCharacter.Controls.Add(this.btnDeleteCharacter);
            this.grpDeleteCharacter.Controls.Add(this.textIdDelete);
            this.grpDeleteCharacter.Controls.Add(this.label6);
            this.grpDeleteCharacter.Location = new System.Drawing.Point(539, 56);
            this.grpDeleteCharacter.Name = "grpDeleteCharacter";
            this.grpDeleteCharacter.Size = new System.Drawing.Size(321, 294);
            this.grpDeleteCharacter.TabIndex = 0;
            this.grpDeleteCharacter.TabStop = false;
            this.grpDeleteCharacter.Text = "DELETE CHARACTER";
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(129, 123);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(140, 48);
            this.btnDeleteCharacter.TabIndex = 13;
            this.btnDeleteCharacter.Text = "DELETE";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            this.btnDeleteCharacter.Click += new System.EventHandler(this.btnDeleteCharacter_Click);
            // 
            // textIdDelete
            // 
            this.textIdDelete.Location = new System.Drawing.Point(129, 72);
            this.textIdDelete.Name = "textIdDelete";
            this.textIdDelete.Size = new System.Drawing.Size(140, 23);
            this.textIdDelete.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID :";
            // 
            // grpUpdateCharacter
            // 
            this.grpUpdateCharacter.Controls.Add(this.btnUpdateCharacter);
            this.grpUpdateCharacter.Controls.Add(this.textIdUpdate);
            this.grpUpdateCharacter.Controls.Add(this.btnFindUpdate);
            this.grpUpdateCharacter.Controls.Add(this.comboBoxTalent);
            this.grpUpdateCharacter.Controls.Add(this.comboBoxPhysics);
            this.grpUpdateCharacter.Controls.Add(this.label5);
            this.grpUpdateCharacter.Controls.Add(this.comboBoxWeapon);
            this.grpUpdateCharacter.Controls.Add(this.label4);
            this.grpUpdateCharacter.Controls.Add(this.comboBoxRank);
            this.grpUpdateCharacter.Controls.Add(this.label3);
            this.grpUpdateCharacter.Controls.Add(this.label1);
            this.grpUpdateCharacter.Controls.Add(this.label2);
            this.grpUpdateCharacter.Location = new System.Drawing.Point(118, 35);
            this.grpUpdateCharacter.Name = "grpUpdateCharacter";
            this.grpUpdateCharacter.Size = new System.Drawing.Size(308, 315);
            this.grpUpdateCharacter.TabIndex = 0;
            this.grpUpdateCharacter.TabStop = false;
            this.grpUpdateCharacter.Text = "UPDATE CHARACTER";
            // 
            // btnUpdateCharacter
            // 
            this.btnUpdateCharacter.Location = new System.Drawing.Point(99, 254);
            this.btnUpdateCharacter.Name = "btnUpdateCharacter";
            this.btnUpdateCharacter.Size = new System.Drawing.Size(159, 40);
            this.btnUpdateCharacter.TabIndex = 13;
            this.btnUpdateCharacter.Text = "UPDATE";
            this.btnUpdateCharacter.UseVisualStyleBackColor = true;
            this.btnUpdateCharacter.Click += new System.EventHandler(this.btnUpdateCharacter_Click);
            // 
            // textIdUpdate
            // 
            this.textIdUpdate.Location = new System.Drawing.Point(136, 57);
            this.textIdUpdate.Name = "textIdUpdate";
            this.textIdUpdate.Size = new System.Drawing.Size(53, 23);
            this.textIdUpdate.TabIndex = 12;
            // 
            // btnFindUpdate
            // 
            this.btnFindUpdate.Location = new System.Drawing.Point(195, 57);
            this.btnFindUpdate.Name = "btnFindUpdate";
            this.btnFindUpdate.Size = new System.Drawing.Size(52, 25);
            this.btnFindUpdate.TabIndex = 11;
            this.btnFindUpdate.Text = "FİND";
            this.btnFindUpdate.UseVisualStyleBackColor = true;
            this.btnFindUpdate.Click += new System.EventHandler(this.btnFindUpdate_Click);
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
            this.comboBoxTalent.Location = new System.Drawing.Point(136, 211);
            this.comboBoxTalent.Name = "comboBoxTalent";
            this.comboBoxTalent.Size = new System.Drawing.Size(112, 23);
            this.comboBoxTalent.TabIndex = 7;
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
            this.comboBoxPhysics.Location = new System.Drawing.Point(136, 171);
            this.comboBoxPhysics.Name = "comboBoxPhysics";
            this.comboBoxPhysics.Size = new System.Drawing.Size(112, 23);
            this.comboBoxPhysics.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 3;
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
            this.comboBoxWeapon.Location = new System.Drawing.Point(135, 133);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(112, 23);
            this.comboBoxWeapon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 4;
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
            this.comboBoxRank.Location = new System.Drawing.Point(136, 93);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(112, 23);
            this.comboBoxRank.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weapon : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rank :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBACK
            // 
            this.btnBACK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBACK.Location = new System.Drawing.Point(907, 270);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(175, 80);
            this.btnBACK.TabIndex = 2;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Character_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 677);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUpdateCharacter);
            this.Controls.Add(this.grpDeleteCharacter);
            this.Name = "Character_Settings";
            this.Text = "Character_Settings";
            this.Load += new System.EventHandler(this.Character_Settings_Load);
            this.grpDeleteCharacter.ResumeLayout(false);
            this.grpDeleteCharacter.PerformLayout();
            this.grpUpdateCharacter.ResumeLayout(false);
            this.grpUpdateCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDeleteCharacter;
        private GroupBox grpUpdateCharacter;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnDeleteCharacter;
        private TextBox textIdDelete;
        private Label label6;
        private Button btnUpdateCharacter;
        private TextBox textIdUpdate;
        private Button btnFindUpdate;
        private ComboBox comboBoxTalent;
        private ComboBox comboBoxPhysics;
        private Label label5;
        private ComboBox comboBoxWeapon;
        private Label label4;
        private ComboBox comboBoxRank;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnBACK;
    }
}