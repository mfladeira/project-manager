using FinalMateus.Classes;
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
        bool aux = true;
        User userAux;
        public HomeForm(User user)
        {
            InitializeComponent();
            userAux = user;

            if (user.UserProfile.Name != "Gerente")
            {
                aux = false;
                pbxLog.Enabled = false;
                pbxUser.Enabled = false;
                pbxUserProfile.Enabled = false;

            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.FormClosed += (s, args) => this.Close();
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

            CategoryAllForm caf = new CategoryAllForm(userAux);
            caf.Show();

        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {

            ProductAllForm paf = new ProductAllForm(userAux);
            paf.Show();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm uaf = new UserAllForm();
            uaf.Show();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm upaf = new UserProfileAllForm();
            upaf.Show();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm();
            lf.Show();
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackgroundImage = Resources.CategoryChanged;
        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackgroundImage = Resources.Category;
        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackgroundImage = Resources.ProductChanged;
        }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackgroundImage = Resources.Product;
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxUser.BackgroundImage = Resources.UserChanged;
            }
            else
            {
                pbxUser.Cursor = Cursors.Arrow;
            }
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxUser.BackgroundImage = Resources.User;
            }
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxUserProfile.BackgroundImage = Resources.User_profileChanged;
            }
            else
            {
                pbxUserProfile.Cursor = Cursors.Arrow;
            }
        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxUserProfile.BackgroundImage = Resources.User_profile;
            }
        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxLog.BackgroundImage = Resources.logChanged;
            }
            else
            {
                pbxLog.Cursor = Cursors.Arrow;
            }

        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            if (aux)
            {
                pbxLog.BackgroundImage = Resources.log;
            }
        }


    }
}
