namespace Abstraction
{
    partial class BooksPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textRelaseDate = new System.Windows.Forms.TextBox();
            this.textNumberOfPages = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textUpdateNAME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textUpdateStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textUpdatePrice = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupUpdate3 = new System.Windows.Forms.GroupBox();
            this.groupDelete = new System.Windows.Forms.GroupBox();
            this.textDeleteID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupUpdate3.SuspendLayout();
            this.groupDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textRelaseDate);
            this.groupBox1.Controls.Add(this.textNumberOfPages);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Books";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 185);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "CREATE ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of pages  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Date : ";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(140, 127);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 23);
            this.textStock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(140, 156);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 23);
            this.textPrice.TabIndex = 0;
            // 
            // textRelaseDate
            // 
            this.textRelaseDate.Location = new System.Drawing.Point(140, 69);
            this.textRelaseDate.Name = "textRelaseDate";
            this.textRelaseDate.Size = new System.Drawing.Size(100, 23);
            this.textRelaseDate.TabIndex = 0;
            // 
            // textNumberOfPages
            // 
            this.textNumberOfPages.Location = new System.Drawing.Point(140, 98);
            this.textNumberOfPages.Name = "textNumberOfPages";
            this.textNumberOfPages.Size = new System.Drawing.Size(100, 23);
            this.textNumberOfPages.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textUpdateNAME
            // 
            this.textUpdateNAME.Location = new System.Drawing.Point(90, 74);
            this.textUpdateNAME.Name = "textUpdateNAME";
            this.textUpdateNAME.Size = new System.Drawing.Size(145, 23);
            this.textUpdateNAME.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stock : ";
            // 
            // textUpdateStock
            // 
            this.textUpdateStock.Location = new System.Drawing.Point(90, 103);
            this.textUpdateStock.Name = "textUpdateStock";
            this.textUpdateStock.Size = new System.Drawing.Size(145, 23);
            this.textUpdateStock.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price : ";
            // 
            // textUpdatePrice
            // 
            this.textUpdatePrice.Location = new System.Drawing.Point(90, 137);
            this.textUpdatePrice.Name = "textUpdatePrice";
            this.textUpdatePrice.Size = new System.Drawing.Size(145, 23);
            this.textUpdatePrice.TabIndex = 2;
            this.textUpdatePrice.TextChanged += new System.EventHandler(this.textPriceName_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(148, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "FİND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(90, 40);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(52, 23);
            this.textID.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name : ";
            // 
            // groupUpdate3
            // 
            this.groupUpdate3.Controls.Add(this.btnUpdate);
            this.groupUpdate3.Controls.Add(this.textUpdateNAME);
            this.groupUpdate3.Controls.Add(this.label11);
            this.groupUpdate3.Controls.Add(this.label8);
            this.groupUpdate3.Controls.Add(this.label10);
            this.groupUpdate3.Controls.Add(this.textUpdateStock);
            this.groupUpdate3.Controls.Add(this.textID);
            this.groupUpdate3.Controls.Add(this.label9);
            this.groupUpdate3.Controls.Add(this.btnFind);
            this.groupUpdate3.Controls.Add(this.textUpdatePrice);
            this.groupUpdate3.Location = new System.Drawing.Point(330, 26);
            this.groupUpdate3.Name = "groupUpdate3";
            this.groupUpdate3.Size = new System.Drawing.Size(261, 237);
            this.groupUpdate3.TabIndex = 3;
            this.groupUpdate3.TabStop = false;
            this.groupUpdate3.Text = "Update";
            this.groupUpdate3.Enter += new System.EventHandler(this.groupUpdate3_Enter);
            // 
            // groupDelete
            // 
            this.groupDelete.Controls.Add(this.btnDelete);
            this.groupDelete.Controls.Add(this.textDeleteID);
            this.groupDelete.Controls.Add(this.label6);
            this.groupDelete.Location = new System.Drawing.Point(636, 33);
            this.groupDelete.Name = "groupDelete";
            this.groupDelete.Size = new System.Drawing.Size(255, 172);
            this.groupDelete.TabIndex = 4;
            this.groupDelete.TabStop = false;
            this.groupDelete.Text = "DELETE";
            // 
            // textDeleteID
            // 
            this.textDeleteID.Location = new System.Drawing.Point(91, 51);
            this.textDeleteID.Name = "textDeleteID";
            this.textDeleteID.Size = new System.Drawing.Size(122, 23);
            this.textDeleteID.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(91, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 49);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stock : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID : ";
            // 
            // BooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 618);
            this.Controls.Add(this.groupDelete);
            this.Controls.Add(this.groupUpdate3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BooksPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupUpdate3.ResumeLayout(false);
            this.groupUpdate3.PerformLayout();
            this.groupDelete.ResumeLayout(false);
            this.groupDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textRelaseDate;
        private TextBox textName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textPrice;
        private TextBox textNumberOfPages;
        private TextBox textStock;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox textUpdateNAME;
        private Label label8;
        private TextBox textUpdateStock;
        private Label label9;
        private TextBox textUpdatePrice;
        private Button btnFind;
        private TextBox textID;
        private Label label10;
        private Label label11;
        private GroupBox groupUpdate3;
        private GroupBox groupDelete;
        private Button btnDelete;
        private TextBox textDeleteID;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}