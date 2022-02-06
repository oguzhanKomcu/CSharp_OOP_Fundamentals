namespace War_Game_Project
{
    public partial class War_Game : Form
    {
        public War_Game()
        {
            InitializeComponent();
        }

        private void War_Game_Load(object sender, EventArgs e)
        {
            
        }
        int thisplayer;


        private void timer1_Tick(object sender, EventArgs e)
        {
            //First, we create a loading place with the panel and we determine the amount of increase of this width.
            panelLoading.Width += 1;
            //We condition our width based on a certain number.
            if (panelLoading.Width > 350)
            {
                //After the condition is fulfilled, we stop the clock. If we do not do this, it repeats constantly, the ram fills up and our computer shuts down.
                timer1SplashScreen.Stop(); // <= be careful
                //Then you can type the commands you want.
                groupBoxStart.Visible = true;
                foreach (Button btn in groupBoxStart.Controls)
                {
                    btn.Click += new EventHandler(btn_click);
                }
            }
            

        }

        private void btn_click(object? sender, EventArgs e)
        {
            Button yakalanan = (Button)sender;
            if (yakalanan.Name == "btnOnePlayer")
            {
                yakalanan.BackColor = Color.AliceBlue;
                thisplayer = 1;
                
            }
            else if (yakalanan.Name == "btnTwoPlayer")
            {
                yakalanan.BackColor = Color.AliceBlue;
                thisplayer = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thisplayer == 1)
            {
                One_Player_War one = new One_Player_War();
                one.Show();
                this.Hide();
            }
            else if (thisplayer == 2)
            {
                _2playerUser usertwo = new _2playerUser();
                usertwo.Show();
                this.Hide();
            }

        }

        private void War_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}