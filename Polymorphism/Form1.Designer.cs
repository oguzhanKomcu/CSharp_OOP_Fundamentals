namespace Polymorphism
{
    partial class Form1
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
            this.groupRECTANGLE = new System.Windows.Forms.GroupBox();
            this.groupTriangle = new System.Windows.Forms.GroupBox();
            this.groupSQUARE = new System.Windows.Forms.GroupBox();
            this.textBASE = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textShortEdge = new System.Windows.Forms.TextBox();
            this.textLongSide = new System.Windows.Forms.TextBox();
            this.textSIDE_LENGTH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCALCULATE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateSquare = new System.Windows.Forms.Button();
            this.groupRECTANGLE.SuspendLayout();
            this.groupTriangle.SuspendLayout();
            this.groupSQUARE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRECTANGLE
            // 
            this.groupRECTANGLE.Controls.Add(this.btnCALCULATE);
            this.groupRECTANGLE.Controls.Add(this.label2);
            this.groupRECTANGLE.Controls.Add(this.label1);
            this.groupRECTANGLE.Controls.Add(this.textLongSide);
            this.groupRECTANGLE.Controls.Add(this.textShortEdge);
            this.groupRECTANGLE.Location = new System.Drawing.Point(40, 48);
            this.groupRECTANGLE.Name = "groupRECTANGLE";
            this.groupRECTANGLE.Size = new System.Drawing.Size(288, 184);
            this.groupRECTANGLE.TabIndex = 0;
            this.groupRECTANGLE.TabStop = false;
            this.groupRECTANGLE.Text = "RECTANGLE";
            // 
            // groupTriangle
            // 
            this.groupTriangle.Controls.Add(this.btnCalculateTriangle);
            this.groupTriangle.Controls.Add(this.textHeight);
            this.groupTriangle.Controls.Add(this.label5);
            this.groupTriangle.Controls.Add(this.label3);
            this.groupTriangle.Controls.Add(this.textBASE);
            this.groupTriangle.Location = new System.Drawing.Point(384, 48);
            this.groupTriangle.Name = "groupTriangle";
            this.groupTriangle.Size = new System.Drawing.Size(314, 184);
            this.groupTriangle.TabIndex = 1;
            this.groupTriangle.TabStop = false;
            this.groupTriangle.Text = "TRİANGLE";
            // 
            // groupSQUARE
            // 
            this.groupSQUARE.Controls.Add(this.btnCalculateSquare);
            this.groupSQUARE.Controls.Add(this.textSIDE_LENGTH);
            this.groupSQUARE.Controls.Add(this.label4);
            this.groupSQUARE.Location = new System.Drawing.Point(745, 48);
            this.groupSQUARE.Name = "groupSQUARE";
            this.groupSQUARE.Size = new System.Drawing.Size(314, 184);
            this.groupSQUARE.TabIndex = 1;
            this.groupSQUARE.TabStop = false;
            this.groupSQUARE.Text = "SQUARE";
            // 
            // textBASE
            // 
            this.textBASE.Location = new System.Drawing.Point(147, 27);
            this.textBASE.Name = "textBASE";
            this.textBASE.Size = new System.Drawing.Size(119, 23);
            this.textBASE.TabIndex = 0;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(147, 56);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(119, 23);
            this.textHeight.TabIndex = 0;
            // 
            // textShortEdge
            // 
            this.textShortEdge.Location = new System.Drawing.Point(141, 47);
            this.textShortEdge.Name = "textShortEdge";
            this.textShortEdge.Size = new System.Drawing.Size(119, 23);
            this.textShortEdge.TabIndex = 0;
            // 
            // textLongSide
            // 
            this.textLongSide.Location = new System.Drawing.Point(141, 76);
            this.textLongSide.Name = "textLongSide";
            this.textLongSide.Size = new System.Drawing.Size(119, 23);
            this.textLongSide.TabIndex = 0;
            // 
            // textSIDE_LENGTH
            // 
            this.textSIDE_LENGTH.Location = new System.Drawing.Point(139, 47);
            this.textSIDE_LENGTH.Name = "textSIDE_LENGTH";
            this.textSIDE_LENGTH.Size = new System.Drawing.Size(119, 23);
            this.textSIDE_LENGTH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHORT EDGE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LONG SIDE :";
            // 
            // btnCALCULATE
            // 
            this.btnCALCULATE.Location = new System.Drawing.Point(141, 115);
            this.btnCALCULATE.Name = "btnCALCULATE";
            this.btnCALCULATE.Size = new System.Drawing.Size(119, 38);
            this.btnCALCULATE.TabIndex = 2;
            this.btnCALCULATE.Text = "CALCULATE";
            this.btnCALCULATE.UseVisualStyleBackColor = true;
            this.btnCALCULATE.Click += new System.EventHandler(this.btnCALCULATE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "BASE : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "HEİGHT :";
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.Location = new System.Drawing.Point(149, 94);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(117, 48);
            this.btnCalculateTriangle.TabIndex = 2;
            this.btnCalculateTriangle.Text = "CALCULATE";
            this.btnCalculateTriangle.UseVisualStyleBackColor = true;
            this.btnCalculateTriangle.Click += new System.EventHandler(this.btnCalculateTriangle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "SIDE LENGTH :";
            // 
            // btnCalculateSquare
            // 
            this.btnCalculateSquare.Location = new System.Drawing.Point(140, 78);
            this.btnCalculateSquare.Name = "btnCalculateSquare";
            this.btnCalculateSquare.Size = new System.Drawing.Size(118, 47);
            this.btnCalculateSquare.TabIndex = 2;
            this.btnCalculateSquare.Text = "CALCULATE";
            this.btnCalculateSquare.UseVisualStyleBackColor = true;
            this.btnCalculateSquare.Click += new System.EventHandler(this.btnCalculateSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 580);
            this.Controls.Add(this.groupSQUARE);
            this.Controls.Add(this.groupTriangle);
            this.Controls.Add(this.groupRECTANGLE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupRECTANGLE.ResumeLayout(false);
            this.groupRECTANGLE.PerformLayout();
            this.groupTriangle.ResumeLayout(false);
            this.groupTriangle.PerformLayout();
            this.groupSQUARE.ResumeLayout(false);
            this.groupSQUARE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupRECTANGLE;
        private GroupBox groupTriangle;
        private GroupBox groupSQUARE;
        private Button btnCALCULATE;
        private Label label2;
        private Label label1;
        private TextBox textLongSide;
        private TextBox textShortEdge;
        private Button btnCalculateTriangle;
        private TextBox textHeight;
        private Label label5;
        private Label label3;
        private TextBox textBASE;
        private Button btnCalculateSquare;
        private TextBox textSIDE_LENGTH;
        private Label label4;
    }
}