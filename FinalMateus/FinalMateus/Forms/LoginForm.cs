using FinalMateus.Classes;
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
        User user;
        //string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public LoginForm()
        {
            InitializeComponent();

        }
        private bool CheckLogin(string password, string name)
        {
            User user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                   
                    return true;
                }
            }
            return false;
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

            try
            {
                GetData();
                if (CheckLogin(password, name))
                {
                    HomeForm hf = new HomeForm(user);
                    hf.Show();
                    this.Hide();
                }
                else
                {
                    ClearData();
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
            catch (Exception ex)
            {
                ClearData();
                MessageBox.Show(ex.Message);
            }
        }
            private void pbxSignIn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxSignIn_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}
