using FinalMateus.Classes;
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
    public partial class CategoryAllForm : Form
    {
        string search = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public CategoryAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();

        }
        //Testando esta bagaça
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);

                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";
           

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void LittleSearch()
        {
            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search = new Search();
            dgvCategory.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);
        }

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
            LittleSearch();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            ShowData();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm hm = new HomeForm();
            hm.FormClosed += (s, arg) => this.Close();
            hm.Show();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm cdf = new CategoryDetailsForm();
            cdf.Show();
            cdf.FormClosed += (s, arg) => ShowData();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm cdf = new CategoryDetailsForm();
            cdf.Show();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
        //    if (CanSearch())
        //    {
        //        littleSearch();
        //    }
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }

        //async public bool CanSearch()
        //{
        
        //}

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

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
    }
}
