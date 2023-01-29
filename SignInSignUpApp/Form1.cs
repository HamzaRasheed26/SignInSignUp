namespace SignInSignUpApp
{
    public partial class FrmLoginPage : Form
    {
        public FrmLoginPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            this.Hide();

            if(checkBox1.Checked)
            {
                Form frm1 = new frmSignIn();
                frm1.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            if (checkBox2.Checked)
            {
                Form frm1 = new frmSignUp();
                frm1.Show();
            }
        }

        private void FrmLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}