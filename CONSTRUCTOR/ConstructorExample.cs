namespace CONSTRUCTOR
{
    public partial class ConstructorExample : Form
    {
        public ConstructorExample()
        {
            InitializeComponent();
        }

        private void btnExample1_Click(object sender, EventArgs e)
        {
            Television tv1 = new Television();

            tv1.Brand = textBrand.Text;
            tv1.SmartTv = cmbSmarttv.Text; 
            tv1.DisplayTechnology = cmbDisplayTec.Text;
            tv1.Resolution = cmbResolution.Text;
            tv1.ScreenSize = cmbScreenSize.Text;   
            tv1.Price = decimal.Parse(textPrice.Text);

            MessageBox.Show($"Brand: {tv1.Brand}\nSmart TV : {tv1.DisplayTechnology}\nResolution : {tv1.Resolution}\nScreen Size : {tv1.ScreenSize}\nPrice : {tv1.Price}");



        }


        private void btnExample2_Click(object sender, EventArgs e)
        {
            Television tv2= new Television(textBrand.Text, cmbSmarttv.Text, decimal.Parse(textPrice.Text));
            
            if (tv2.Price > 0)
            {
                MessageBox.Show($"Television Price : {tv2.Price} ");
            }
            else
            {
                MessageBox.Show("The entered price cannot be less than 0 !");
            }


        }

        private void btnExample3_Click(object sender, EventArgs e)
        {


            Television tv4 = new Television(cmbResolution.Text,cmbSmarttv.Text,cmbDisplayTec.Text);



        }

        private void btnExample1_Click_1(object sender, EventArgs e)
        {

        }
    }
}