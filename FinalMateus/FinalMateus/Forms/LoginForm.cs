using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalMateus.Forms
{
    public partial class LoginForm : Form

    {
        string name = "";
        string password = "";


        public LoginForm()
        {
            InitializeComponent();
            //if (user.UserProfile.Name != "Gerente")
            //{
            //    //n pode acessar user user profile log
            //    pbxSignIn.Enabled = false;
            //}

        }
        void GetData()
        {
            name = tbxName.Text;
            password = tbxPassword.Text;
        }
        void ClearData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
        }

        private void lbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.Show();
        }

        private void pbxSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm hm = new HomeForm();
            hm.FormClosed += (s, args) => this.Close();
            hm.Show();

        }

        private void pbxSignIn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxSignIn_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}
