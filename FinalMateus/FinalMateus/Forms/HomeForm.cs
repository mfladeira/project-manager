using FinalMateus.Properties;
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
    public partial class HomeForm : Form
    {
        

        public HomeForm()
        {
            InitializeComponent();
            
        }
        
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.FormClosed += (s, arg) => this.Close();
            lf.Show();
            
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.BackColor;
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.Back;
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryAllForm caf = new CategoryAllForm();
            caf.FormClosed += (s, arg) => this.Close();
            caf.Show();
            
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductAllForm paf = new ProductAllForm();
            paf.FormClosed += (s, arg) => this.Close();
            paf.Show();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAllForm uaf = new UserAllForm();
            uaf.FormClosed += (s, arg) => this.Close();
            uaf.Show();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfileAllForm upaf = new UserProfileAllForm();
            upaf.FormClosed += (s, arg) => this.Close();
            upaf.Show();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm lf = new LogForm();
            lf.FormClosed += (s, arg) => this.Close();
            lf.Show();
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackgroundImage = Resources.User_Changed;
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackgroundImage = Resources.User;
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {

        }

        
    }
}
