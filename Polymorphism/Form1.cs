namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
         
              
             MessageBox.Show($"AREA : {rectangle.AREA_ACCOUNT(double.Parse(textShortEdge.Text), double.Parse(textLongSide.Text))} ");
          

        }

        private void btnCalculateTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();

            MessageBox.Show($"AREA : {triangle.AREA_ACCOUNT(double.Parse(textBASE.Text), double.Parse(textHeight.Text))} ");
        }

        private void btnCalculateSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square();


            MessageBox.Show($"AREA : {square.AREA_ACCOUNT(double.Parse(textSIDE_LENGTH.Text), 0)}");
        }
    }
}