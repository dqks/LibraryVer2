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

                using (var db = new LibraryShtinContext())
                {
                    var role = db.Roles.FirstOrDefault(r => r.Id == user.IdRole);

                    if (role.RoleName == "Читатель")
                    {
                        flowLayoutPanelTop.Visible = false;
                    }
                }


            }
            else
            {
                flowLayoutPanelTop.Visible = false;
                labelName.Text = "Гость";
            }

            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.Visible = false;

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.Width = 50;
            colPhoto.FillWeight = 30;


            var colText = new DataGridViewTextBoxColumn();
            colText.Name = "colText";
            colText.FillWeight = 70;
            colText.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridViewBooks.Columns.AddRange([colId, colPhoto, colText]);

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

                    dataGridViewBooks.Rows.Clear();

                    foreach (var book in books)
                    {
                        var rowIndex = dataGridViewBooks.Rows.Add();
                        var row = dataGridViewBooks.Rows[rowIndex];


                        row.Cells["colId"].Value = book.Id;

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
                "Страниц: " + book.PagesAmount + Environment.NewLine +
                "Всего экземпляров: " + book.ExamplesAmount + Environment.NewLine +
                "Доступно экземпляров: " + book.Available + Environment.NewLine +
                "Аннотация: " + book.Annotation + Environment.NewLine;

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            FormBookManage form = new FormBookManage();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewBooks.SelectedRows[0].Cells["colId"].Value;

            using (var db = new LibraryShtinContext())
            {
                try
                {
                    var book = db.Books.FirstOrDefault(b => b.Id == id);

                    FormBookManage form = new FormBookManage(book);

                    DialogResult result = form.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }



                    //comboBoxAuthor.SelectedValue = Book.IdAuthor;
                    //comboBoxGenre.SelectedValue = Book.IdGenre;
                    //comboBoxPublisher.SelectedValue = Book.IdPublisher;

                    //textBoxIsbn.Text = Book.Isbn;
                    //richTextBoxAnnotation.Text = Book.Annotation;
                    //textBoxName.Text = Book.Name;
                    //textBoxPageAmount.Text = Book.PagesAmount.ToString();
                    //textBoxPublicYear.Text = Book.PublicYear.ToString();
                    //textBoxExamplesAmount.Text = Book.ExamplesAmount.ToString();
                    //textBoxAvailableExamples.Text = Book.Available.ToString();

                    if (
                            form.comboBoxPublisher.SelectedValue == null ||
                            form.comboBoxGenre.SelectedValue == null ||
                            form.comboBoxAuthor.SelectedValue == null ||
                            String.IsNullOrEmpty(form.textBoxPageAmount.Text) ||
                            String.IsNullOrEmpty(form.textBoxName.Text) ||
                            String.IsNullOrEmpty(form.richTextBoxAnnotation.Text) ||
                            String.IsNullOrEmpty(form.textBoxIsbn.Text) ||
                            String.IsNullOrEmpty(form.textBoxPublicYear.Text) ||
                            String.IsNullOrEmpty(form.textBoxExamplesAmount.Text) ||
                            String.IsNullOrEmpty(form.textBoxAvailableExamples.Text)
                        )
                    {

                    }

                    book.Name = form.textBoxName.Text;
                    book.Annotation = form.richTextBoxAnnotation.Text;
                    book.Isbn = form.textBoxIsbn.Text;
                    book.PagesAmount = Int32.Parse(form.textBoxPageAmount.Text);
                    book.PublicYear = Int32.Parse(form.textBoxPublicYear.Text);
                    book.ExamplesAmount = Int32.Parse(form.textBoxExamplesAmount.Text);
                    book.Available = Int32.Parse(form.textBoxAvailableExamples.Text);
                    book.IdPublisher = (int)(form.comboBoxPublisher.SelectedValue);
                    book.IdGenre = (int)(form.comboBoxGenre.SelectedValue);
                    book.IdAuthor = (int)(form.comboBoxAuthor.SelectedValue);

                    db.SaveChanges();
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
