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
    public partial class UserDetailsForm : Form
    {
        string name = "";
        string email = "";
        string password = "";
        string confirmPass = "";
        string profile = "";
        bool active = false;
        public UserDetailsForm()
        {
            InitializeComponent();
        }
        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password =tbxPassword.Text;
            confirmPass = tbxConfirmPassword.Text;
            profile = cmbProfile.Text;
            active = cbxActive.Checked ? true : false;
        }

        void ClearData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirmPassword.Text = "";
            cmbProfile.Text = "";
            cbxActive.Checked = false;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }   

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
