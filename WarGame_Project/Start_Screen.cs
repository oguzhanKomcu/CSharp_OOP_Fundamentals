namespace WarGame_Project
{
    public partial class Start_Screen : Form
    {
        public Start_Screen()
        {
            InitializeComponent();
        }

        int thisplayer;


        private void War_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {

        }

        private void timer1SplashScreen_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 1;

            if (panelLoading.Width > 350)
            {

                timer1SplashScreen.Stop();
                groupBoxStart.Visible = true;
                foreach (Button btn in groupBoxStart.Controls)
                {
                    btn.Click += new EventHandler(btn_click);
                }
            }
        }
        private void btn_click(object? sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            if (btnclick.Name == "btnOnePlayer")
            {
                btnclick.BackColor = Color.AliceBlue;
                thisplayer = 1;
                btnTwoPlayer.BackColor = Color.Salmon;

            }
            else if (btnclick.Name == "btnTwoPlayer")
            {
                btnclick.BackColor = Color.AliceBlue;
                thisplayer = 2;
                btnOnePlayer.BackColor = Color.Salmon;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (thisplayer == 1)
            {
                _1User_Registration one = new _1User_Registration();
                one.Show();
                this.Hide();
            }
            else if (thisplayer == 2)
            {
                _2User_Registration two = new _2User_Registration();
                two.Show();
                this.Hide();
            }

        }
    }
}