using İnheritance.Model.Entities;

namespace İnheritance
{
    public partial class InheritanceExampleForm : Form
    {
        public InheritanceExampleForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Telephone  t = new Telephone();

            //When we created an object directly from the phone class, we were able to access the properties in the BaseProduct class.
            //This is thanks to inheritance.

            t.CategoryName = textCategoryName.Text;
            t.ProductName = textProductName.Text;   
            t.Id = int.Parse(textID.Text);
            t.Brand = textBrand.Text;
            t.UnitsStock = int.Parse(textUnitStock.Text);
            t.Price = int.Parse(textPrice.Text);
            t.Camera_Resolution = int.Parse(textCR.Text);
            t.Internal_Memory = int.Parse(textIM.Text);
            t.battery_power = int.Parse(textBateryPower.Text);
            t.Screen_size = textScreenSize.Text;    

            
        }
    }
}