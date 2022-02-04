namespace Static_Class
{
    public partial class Static_Class_Example : Form
    {
        public Static_Class_Example()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            //It is not called like a regular internal class.
            //"class_name"+"."+"member_name" You can access and use it by typing.
            //Then it will be enough to give a value according to the desired parameter in "()".

            lblCM.Text = Unit_converter.KmToCmConverter(double.Parse(textKM.Text)).ToString();


        }

        private void btnConverter2_Click(object sender, EventArgs e)
        {


            lblM2.Text = Unit_converter.DekarToM2Converter(double.Parse(textDekar.Text)).ToString();

        }

        private void btnConverter3_Click(object sender, EventArgs e)
        {


            lblM.Text = Unit_converter.FitToM(double.Parse(textFit.Text)).ToString();

        }
    }
}