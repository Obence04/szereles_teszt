namespace szereles_teszt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BTN_OS_Click(object sender, EventArgs e)
        {
            Osztott form = new();
            form.Show();
        }
    }
}