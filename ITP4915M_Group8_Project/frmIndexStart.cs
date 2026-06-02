namespace ITP4915M_Group8_Project
{
    public partial class frmIndexStart : Form
    {
        public frmIndexStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Login.CustomerLogIn Form = new Login.CustomerLogIn();
            Form.Show();
        }
    }
}
