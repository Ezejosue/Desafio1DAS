namespace WinFormsApp1
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerwELCOM(object sender, EventArgs e)
        {
            timerWelcome.Stop();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();

        }
    }
}