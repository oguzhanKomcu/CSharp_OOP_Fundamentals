namespace Struct
{
    partial class Form1
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
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.textPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDirector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMovie
            // 
            this.grpMovie.Controls.Add(this.btnCreate);
            this.grpMovie.Controls.Add(this.label2);
            this.grpMovie.Controls.Add(this.label7);
            this.grpMovie.Controls.Add(this.label5);
            this.grpMovie.Controls.Add(this.label4);
            this.grpMovie.Controls.Add(this.label3);
            this.grpMovie.Controls.Add(this.label1);
            this.grpMovie.Controls.Add(this.textDirector);
            this.grpMovie.Controls.Add(this.textPoint);
            this.grpMovie.Controls.Add(this.textCountry);
            this.grpMovie.Controls.Add(this.textYear);
            this.grpMovie.Controls.Add(this.textGenre);
            this.grpMovie.Controls.Add(this.textName);
            this.grpMovie.Location = new System.Drawing.Point(33, 22);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(318, 269);
            this.grpMovie.TabIndex = 0;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Movie";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(167, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(167, 53);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(100, 20);
            this.textGenre.TabIndex = 0;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(167, 79);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 0;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(167, 105);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(100, 20);
            this.textCountry.TabIndex = 0;
            // 
            // textPoint
            // 
            this.textPoint.Location = new System.Drawing.Point(167, 131);
            this.textPoint.Name = "textPoint";
            this.textPoint.Size = new System.Drawing.Size(100, 20);
            this.textPoint.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year of construction : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Country : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Imdb Point : ";
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(167, 157);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(100, 20);
            this.textDirector.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Director : ";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(167, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 35);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDirector;
        private System.Windows.Forms.TextBox textPoint;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnCreate;
    }
}

