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
    public partial class ForgotPasswordForm : Form
    {
        string name = "";
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        void GetData()
        {
            name = tbxName.Text;
        }
        void ClearData()
        {
            tbxName.Text = "";
        }

            private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSend_Click(object sender, EventArgs e)
        {

        }
    }
}
