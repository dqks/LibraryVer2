using Library.Models;
using Library.Properties;
using Microsoft.EntityFrameworkCore;   

namespace Library
{
    public partial class FormBooks : Form
    {
        public bool IsGuest { get; private set; }
        public User User { get; private set; }

        public FormBooks(bool isGuest, User user)
        {
            InitializeComponent();

            this.IsGuest = isGuest;
            this.User = user;

            if (user != null)
            {
                labelName.Text = user.LastName + " " + user.FirstName + " " + user.Patronymic;
            }
            else
            {
                labelName.Text = "Гость";
            }

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.Width = 50;
            colPhoto.FillWeight = 30;


            var colText = new DataGridViewTextBoxColumn();
            colText.Name = "colText";
            colText.FillWeight = 70;
            colText.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridViewBooks.Columns.AddRange([colPhoto, colText]);

            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var db = new LibraryShtinContext())
                {

                    var books = db.Books
                        .Include(i => i.IdAuthorNavigation)
                        .Include(i => i.IdGenreNavigation)
                        .Include(i => i.IdPublisherNavigation)
                        .ToList();

                    foreach (var book in books)
                    {
                        var rowIndex = dataGridViewBooks.Rows.Add();
                        var row = dataGridViewBooks.Rows[rowIndex];


                        row.Cells["colPhoto"].Value = Resources.book_placeholder;

                        row.Cells["colText"].Value = LoadColText(book);

                        if (book.Available <= 0)
                        {
                            row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                        }
                        else if (book.Available == 1 || book.Available == 2)
                        {
                            row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF3CD");

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private string LoadColText(Book book)
        {

            return "ISBN: " + book.Isbn + Environment.NewLine +
                "Название книги: " + book.Name + Environment.NewLine +
                "Автор: " + book.IdAuthorNavigation.AuthorName + Environment.NewLine +
                "Жанр: " + book.IdGenreNavigation.GenreName + Environment.NewLine +
                "Издательство: " + book.IdPublisherNavigation.PublisherName + Environment.NewLine +
                "Год издания: " + book.PublicYear + Environment.NewLine +
                "Страниц: " + book.PagesAmount+ Environment.NewLine +
                "Всего экземпляров: " + book.ExamplesAmount+ Environment.NewLine +
                "Доступно экземпляров: " + book.Available + Environment.NewLine +
                "Аннотация: " + book.Annotation + Environment.NewLine;

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }
    }
}
