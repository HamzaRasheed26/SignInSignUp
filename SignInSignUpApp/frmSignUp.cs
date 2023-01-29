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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form frm = new FrmLoginPage();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            MUser user = new MUser(name, pwd, role);

            MUserDL.addIntoList(user);
            emptyTextBox();

        }

        public void emptyTextBox()
        {
            txtName.Text = "";
            txtPwd.Text = "";
            comboBoxRole.SelectedItem = null ;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
