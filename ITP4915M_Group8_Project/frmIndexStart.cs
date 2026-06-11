namespace ITP4915M_Group8_Project
{
    public partial class frmIndexStart : Form
    {
        public frmIndexStart()
        {
            InitializeComponent();
            //LoadSystem();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadSystem();
        }

        private void LoadSystem()
        {
            Login.CustomerLogIn Form = new Login.CustomerLogIn();
            Form.Show();
            this.Hide();
        }
    }
}
