namespace LIBRARY_PROJECT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ShowWelcomeMessage();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            Form form = new FrmBook();
            form.Show();
            this.Hide();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {

            Form form = new btnBack();
            form.Show();
            this.Hide();
        }

        public static void ShowWelcomeMessage()
        {
            MessageBox.Show("Welcome!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
