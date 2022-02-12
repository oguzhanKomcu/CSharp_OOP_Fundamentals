using Abstraction.Buisness.Repositories.Concrate;
using Abstraction.Model.Concrete;

namespace Abstraction
{
    public partial class BooksPage : Form
    {
        public BooksPage()
        {
            InitializeComponent();
        }


        BooksRepository booksRepository = new BooksRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Id = 2;
            books.Name = textName.Text;
            books.Number_Of_Pages =textNumberOfPages.Text;
            books.Stock = int.Parse(textStock.Text);
            books.Price = decimal.Parse(textPrice.Text);
            books.Release_Date = textRelaseDate.Text;
            booksRepository.Create(books);  

            dataGridView1.DataSource = booksRepository.GetAll();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = booksRepository.GetAll(); //  dataGridView1.DataSource = It is an embedded function in C#.
        }
        int id;

        private void btnFind_Click(object sender, EventArgs e)
        {
            id = int.Parse(textID.Text);
            Books books = booksRepository.GetById(id);

            textUpdateNAME.Text = books.Name;
            textUpdatePrice.Text = books.Price.ToString();
            textUpdateStock.Text = books.Stock.ToString();  


        }

        private void textPriceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Books book = new Books();
            book.Id = int.Parse(textID.Text);
            book.Name = textUpdateNAME.Text;
            book.Stock = int.Parse(textUpdateStock.Text);
            book.Price = int.Parse(textUpdatePrice.Text);

            booksRepository.Update(book);

            dataGridView1.DataSource = booksRepository.GetAll();

           
        }

        private void groupUpdate3_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Books books = booksRepository.GetById(int.Parse(textDeleteID.Text));

            booksRepository.Delete(books);

            dataGridView1.DataSource = booksRepository.GetAll();
        }
    }
}