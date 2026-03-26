using Library.Models;

namespace Library
{
    public partial class FormLogin : Form
    {
        public bool IsGuest { get; private set; }
        public User User { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textBoxPassword.Text) || String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new LibraryShtinContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == textBoxLogin.Text && u.Password== textBoxPassword.Text);

                if (user != null)
                {
                    this.IsGuest = false;
                    this.User = user;

                    FormBooks form = new FormBooks(this.IsGuest, this.User);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            this.IsGuest = true;
            this.User = null;

            FormBooks form = new FormBooks(this.IsGuest, this.User);
            form.Show();
            this.Hide();
        }
    }
}
