using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormBookManage : Form
    {
        private Book Book {  get; set; }


        public FormBookManage()
        {
            InitializeComponent();
        }

        public FormBookManage(Book book)
        {
            InitializeComponent();
            this.Book = book;
            this.Name = "Редактирование книги";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (var db = new LibraryShtinContext())
            {
                var authors = db.Authors.ToList();
                comboBoxAuthor.DataSource = authors;
                comboBoxAuthor.ValueMember = "Id";
                comboBoxAuthor.DisplayMember= "AuthorName";

                var genres = db.Genres.ToList();
                comboBoxGenre.DataSource = genres;
                comboBoxGenre.ValueMember = "Id";
                comboBoxGenre.DisplayMember = "GenreName";

                var publishers = db.Publishers.ToList();
                comboBoxPublisher.DataSource = publishers;
                comboBoxPublisher.ValueMember = "Id";
                comboBoxPublisher.DisplayMember = "PublisherName";

                if (this.Book != null)
                {
                    comboBoxAuthor.SelectedValue = Book.IdAuthor;
                    comboBoxGenre.SelectedValue = Book.IdGenre;
                    comboBoxPublisher.SelectedValue = Book.IdPublisher;

                    textBoxIsbn.Text = Book.Isbn;
                    richTextBoxAnnotation.Text = Book.Annotation;
                    textBoxName.Text = Book.Name;
                    textBoxPageAmount.Text = Book.PagesAmount.ToString();
                    textBoxPublicYear.Text = Book.PublicYear.ToString();
                    textBoxExamplesAmount.Text = Book.ExamplesAmount.ToString();
                    textBoxAvailableExamples.Text = Book.Available.ToString();
                }

            }
        }
    }
}
