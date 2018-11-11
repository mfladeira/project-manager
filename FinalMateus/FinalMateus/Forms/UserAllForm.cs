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
    public partial class UserAllForm : Form
    {
        string search = "";
       // string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserAllForm()
        {
            InitializeComponent();
        }

        //private void ShowData()
        //{
        //    SqlConnection sqlConnect = new SqlConnection(connectionString);

        //    try
        //    {
        //        sqlConnect.Open();

        //        SqlCommand cmd = new SqlCommand("SELECT USER.ID, USER.NAME", sqlConnect);


        //        cmd.ExecuteNonQuery();

        //        DataTable dt = new DataTable();
        //        SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
        //        sqlDtAdapter.Fill(dt);

        //        dgvUser.DataSource = dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao conectar. " + ex.Message);
        //    }
        //    finally
        //    {
        //        sqlConnect.Close();
        //    }
        //}

        void GetData()
        {
            search = tbxSearch.Text;
        }
        void ClearData()
        {
            tbxSearch.Text = "";
        }
        private void pbxSearch_Click(object sender, EventArgs e)
        {

        }

        private void pbxClean_Click(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm hf = new HomeForm();
            hf.FormClosed += (s, arg) => this.Close();
            hf.Show();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxClean_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxClean_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
