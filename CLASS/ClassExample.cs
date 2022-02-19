using System.Net.Mail;

namespace CLASS
{
    public partial class ClassExample : Form
    {
        public ClassExample()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            //Using the class we created, we create a new object from this class.
            //classname + variable + = + new + classname();
            // " = " : The " = " operator that points to and refers to.
            // "new" : It means create a new object from this class.
            // "classname();" : If there is no constructor in the constructor.Class, which is directly activated in the first run of the class, this constructor comes as default
            Bike bike1 = new Bike();

            //We gave the values ​​to the fields created in the class of our object.
            //objectname +"."+field  
            // When we make a point, public class elements are automatically added.

            bike1.Brand = textBrand.Text;
            bike1.RimSize = Convert.ToInt32(textRimSize.Text);
            bike1.Material = textMaterial.Text;  
            bike1.Type = textType.Text;  
            bike1.Gender = textGender.Text;
            bike1.Price = Convert.ToInt32(textPrice.Text);
            bike1.color = textColor.Text;
            bike1.Gear = Convert.ToInt32(textGear.Text);
         
           


            MessageBox.Show($"Brand : {bike1.Brand }\nRim Size : {bike1.RimSize}\nMaterial : {bike1.Material}\nColor : {bike1.color}\nGender : {bike1.Gender}\nType : {bike1.Type}\nGear : {bike1.Gear}\nPrice : {bike1.Price}  ");


          
        }

       
    }
}
