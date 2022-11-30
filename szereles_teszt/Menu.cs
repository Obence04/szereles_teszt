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

        private void BTN_Nevjegy_Click(object sender, EventArgs e)
        {
            Nevjegy form = new();
            form.Show();
        }
    }
}