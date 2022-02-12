namespace WarGame_Project
{
    partial class Start_Screen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.timer1SplashScreen = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loading..";
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.button1);
            this.groupBoxStart.Controls.Add(this.btnTwoPlayer);
            this.groupBoxStart.Controls.Add(this.btnOnePlayer);
            this.groupBoxStart.Location = new System.Drawing.Point(125, 209);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(326, 283);
            this.groupBoxStart.TabIndex = 4;
            this.groupBoxStart.TabStop = false;
            this.groupBoxStart.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(65, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.BackColor = System.Drawing.Color.Salmon;
            this.btnTwoPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwoPlayer.Location = new System.Drawing.Point(62, 115);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(194, 48);
            this.btnTwoPlayer.TabIndex = 2;
            this.btnTwoPlayer.Text = "TWO PLAYER";
            this.btnTwoPlayer.UseVisualStyleBackColor = false;
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.BackColor = System.Drawing.Color.Salmon;
            this.btnOnePlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnePlayer.Location = new System.Drawing.Point(62, 52);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(194, 44);
            this.btnOnePlayer.TabIndex = 1;
            this.btnOnePlayer.Text = "ONE PLAYER";
            this.btnOnePlayer.UseVisualStyleBackColor = false;
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelLoading.Location = new System.Drawing.Point(102, 96);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(10, 44);
            this.panelLoading.TabIndex = 3;
            // 
            // timer1SplashScreen
            // 
            this.timer1SplashScreen.Enabled = true;
            this.timer1SplashScreen.Interval = 3;
            this.timer1SplashScreen.Tick += new System.EventHandler(this.timer1SplashScreen_Tick);
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.panelLoading);
            this.Name = "Start_Screen";
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.groupBoxStart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBoxStart;
        private Button button1;
        private Button btnTwoPlayer;
        private Button btnOnePlayer;
        private Panel panelLoading;
        private System.Windows.Forms.Timer timer1SplashScreen;
    }
}