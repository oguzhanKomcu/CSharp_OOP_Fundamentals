namespace WarGame_Project
{
    partial class User_Settings
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
            this.grpUserUpdate = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textNickNameUpdate = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textIdFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.grpUserDelete = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindDELETE = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUserUpdate.SuspendLayout();
            this.grpUserDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUserUpdate
            // 
            this.grpUserUpdate.Controls.Add(this.btnUpdateUser);
            this.grpUserUpdate.Controls.Add(this.textIdFind);
            this.grpUserUpdate.Controls.Add(this.btnFind);
            this.grpUserUpdate.Controls.Add(this.label1);
            this.grpUserUpdate.Controls.Add(this.label10);
            this.grpUserUpdate.Controls.Add(this.textNickNameUpdate);
            this.grpUserUpdate.Location = new System.Drawing.Point(22, 30);
            this.grpUserUpdate.Name = "grpUserUpdate";
            this.grpUserUpdate.Size = new System.Drawing.Size(328, 209);
            this.grpUserUpdate.TabIndex = 0;
            this.grpUserUpdate.TabStop = false;
            this.grpUserUpdate.Text = "UPDATE USER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nick Name : ";
            // 
            // textNickNameUpdate
            // 
            this.textNickNameUpdate.Location = new System.Drawing.Point(128, 101);
            this.textNickNameUpdate.Name = "textNickNameUpdate";
            this.textNickNameUpdate.Size = new System.Drawing.Size(145, 23);
            this.textNickNameUpdate.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(209, 61);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 24);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "FİND";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textIdFind
            // 
            this.textIdFind.Location = new System.Drawing.Point(130, 62);
            this.textIdFind.Name = "textIdFind";
            this.textIdFind.Size = new System.Drawing.Size(73, 23);
            this.textIdFind.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID : ";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(129, 145);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(144, 39);
            this.btnUpdateUser.TabIndex = 13;
            this.btnUpdateUser.Text = "UPDATE";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // grpUserDelete
            // 
            this.grpUserDelete.Controls.Add(this.btnDeleteUser);
            this.grpUserDelete.Controls.Add(this.btnFindDELETE);
            this.grpUserDelete.Controls.Add(this.textBox1);
            this.grpUserDelete.Controls.Add(this.label2);
            this.grpUserDelete.Location = new System.Drawing.Point(412, 39);
            this.grpUserDelete.Name = "grpUserDelete";
            this.grpUserDelete.Size = new System.Drawing.Size(288, 200);
            this.grpUserDelete.TabIndex = 1;
            this.grpUserDelete.TabStop = false;
            this.grpUserDelete.Text = "DELETE USER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnFindDELETE
            // 
            this.btnFindDELETE.Location = new System.Drawing.Point(181, 45);
            this.btnFindDELETE.Name = "btnFindDELETE";
            this.btnFindDELETE.Size = new System.Drawing.Size(56, 23);
            this.btnFindDELETE.TabIndex = 1;
            this.btnFindDELETE.Text = "FİND";
            this.btnFindDELETE.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(97, 85);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(140, 42);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(678, 236);
            this.dataGridView1.TabIndex = 2;
            // 
            // User_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUserDelete);
            this.Controls.Add(this.grpUserUpdate);
            this.Name = "User_Settings";
            this.Text = "User_Settings";
            this.grpUserUpdate.ResumeLayout(false);
            this.grpUserUpdate.PerformLayout();
            this.grpUserDelete.ResumeLayout(false);
            this.grpUserDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpUserUpdate;
        private Button btnFind;
        private Label label10;
        private TextBox textNickNameUpdate;
        private TextBox textIdFind;
        private Button btnUpdateUser;
        private Label label1;
        private GroupBox grpUserDelete;
        private Button btnDeleteUser;
        private Button btnFindDELETE;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}