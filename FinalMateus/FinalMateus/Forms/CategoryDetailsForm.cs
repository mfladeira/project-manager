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
    public partial class CategoryDetailsForm : Form
    {
        string name = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }
        void GetData()
        {            
            name = tbxName.Text;
            active = cbxActive.Checked ? true : false;                             
        }
        void ClearData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                sqlConnect.Open();
                string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                if(name != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso!");
                }
                else
                {
                       MessageBox.Show("Erro ao adicionar categoria, nome em branco!");
                }   
            }

            catch (Exception ex)
            {                         
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
                ClearData();
            }

            finally
            {
                ClearData();
                sqlConnect.Close();
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete;
            
        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete_Close;

        }
    }
}
