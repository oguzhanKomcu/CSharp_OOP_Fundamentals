namespace Delegate_And_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckToText(string id)
        {
            foreach (char character in id )
            {
                if (char.IsDigit(character)== false)
                {
                    // Since my class is cleared from the Exception class when there is a letter in my character, the constructor method of my class will be activated when an error is thrown.
                    throw new Has_A_Letter(id);
                }

            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                CheckToText(textIdNumber.Text);
            }
            catch (Exception ex)  //When I get an Exception error, it will come here and show the error message.
            {
                errorProvider1.SetError(textIdNumber, ex.Message);

            }
        }
    }
}