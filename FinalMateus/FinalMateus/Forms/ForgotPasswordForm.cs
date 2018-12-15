using FinalMateus.Classes;
using FinalMateus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        bool updated = false;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        void GetData()
        {
            name = tbxName.Text;
        }

        void UpdatePassword()
        {
            User user = UserHelper.SelectByName(tbxName.Text);

            if (user.Name == null)
            {
                MessageBox.Show("Usuário não encontrado");
                updated = false;
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    EmailHelper.SendEmail(user.Email);

                    GetData();
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET PASSWORD = @password Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash("456")));

                    cmd.Parameters.Add(new SqlParameter("@id", user.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uma nova senha foi enviada para seu e-mail!");
                    Log.SaveLog(sqlConnect,"Usuário Editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao enviar nova senha!" + "\n\n" + Ex.Message);
                    updated = false;
                    throw;
                }
                finally
                {
                    ClearData();
                    sqlConnect.Close();
                }
            }
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
            if (tbxName.Text.Length > 0)
            {
                UpdatePassword();
                
            }
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.BackColor;
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.Back;
        }

        private void pbxSend_MouseEnter(object sender, EventArgs e)
        {
            pbxSend.BackgroundImage = Resources.forgotchanged;
        }

        private void pbxSend_MouseLeave(object sender, EventArgs e)
        {
            pbxSend.BackgroundImage = Resources.forgot;

        }
    }
}
