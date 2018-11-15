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
    public partial class ProductAllForm : Form
    {
        string search = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public ProductAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

               SqlCommand cmd = new SqlCommand("SELECT PRODUCT.ID, PRODUCT.NAME, PRODUCT.ACTIVE, PRODUCT.PRICE, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY ON PRODUCT.FK_PRODUCT = CATEGORY.ID;", sqlConnect);
                

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvProduct.DataSource = dt;

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

        private void LittleSearch()
        {
            string optionForm = "ProductForm";
            string optionString = "name";

            Search search = new Search();
            dgvProduct.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);
        }

        private void ResizeDataGridView()
        {
            dgvProduct.Columns["ID"].Visible = false;
            dgvProduct.Columns["NAME"].HeaderText = "Nome";
            dgvProduct.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvProduct.Columns["PRICE"].HeaderText = "Preço";               
            dgvProduct.Columns["ACTIVE"].DisplayIndex = 4;
            dgvProduct.Columns["NAME1"].HeaderText = "Categoria";
            dgvProduct.Columns["NAME1"].DisplayIndex = 3;

            foreach (DataGridViewColumn col in dgvProduct.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
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

     

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm hm = new HomeForm();
            hm.FormClosed += (s, arg) => this.Close();
            hm.Show();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            ProductDetailsForm pdf = new ProductDetailsForm();
            pdf.Show();
            pdf.FormClosed += (s, arg) => ShowData();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            ProductDetailsForm pdf = new ProductDetailsForm();
            pdf.Show();
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
            pbxDelete.BackgroundImage = Resources.Delete;
        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete_Close;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void pbxClean1_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
           
        }

        private void pbxClean1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxClean1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }
    }
}
