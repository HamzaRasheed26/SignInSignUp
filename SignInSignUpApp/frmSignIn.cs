using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInSignUpApp.BL;
using SignInSignUpApp.DL;

namespace SignInSignUpApp
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;

            MUser user = new MUser(name, pwd);

            if(MUserDL.isExist(user))
            {
                lblCheck.Text = "Valid User";
                lblCheck.ForeColor = Color.Green;
            }
            else
            {
                lblCheck.Text = "Invalid User";
                lblCheck.ForeColor = Color.Red;
            }
            lblCheck.Visible = true; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form frm = new FrmLoginPage();
            frm.Show();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            lblCheck.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblCheck_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPwd_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
