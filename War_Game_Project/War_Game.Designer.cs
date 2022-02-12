﻿namespace War_Game_Project
{
    partial class War_Game
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
            this.panelLoading = new System.Windows.Forms.Panel();
            this.timer1SplashScreen = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelLoading.Location = new System.Drawing.Point(129, 127);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(10, 44);
            this.panelLoading.TabIndex = 0;
            // 
            // timer1SplashScreen
            // 
            this.timer1SplashScreen.Enabled = true;
            this.timer1SplashScreen.Interval = 3;
            this.timer1SplashScreen.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.button1);
            this.groupBoxStart.Controls.Add(this.btnTwoPlayer);
            this.groupBoxStart.Controls.Add(this.btnOnePlayer);
            this.groupBoxStart.Location = new System.Drawing.Point(152, 240);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(326, 283);
            this.groupBoxStart.TabIndex = 1;
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
            this.button1.Text = "NEW GAME";
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
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading..";
            // 
            // War_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.panelLoading);
            this.Name = "War_Game";
            this.Text = "Splash Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.War_Game_FormClosing);
            this.Load += new System.EventHandler(this.War_Game_Load);
            this.groupBoxStart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelLoading;
        private System.Windows.Forms.Timer timer1SplashScreen;
        private GroupBox groupBoxStart;
        private Label label1;
        private Button btnTwoPlayer;
        private Button btnOnePlayer;
        private Button button1;
    }
}