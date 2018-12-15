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
            dgvProduct.Columns["PRICE"].HeaderText = "Preço";
            dgvProduct.Columns["ACTIVE"].HeaderText = "Ativo";
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

        #region buttons
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            LittleSearch();
           
        }
    
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            ProductDetailsForm pdf = new ProductDetailsForm();
            pdf.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());
            ProductDetailsForm pdf = new ProductDetailsForm(idProduct);
            pdf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idProduct));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();
                ShowData();
                MessageBox.Show("Produto inativo!");
                Log.SaveLog("Produto Desativado", DateTime.Now, "Excluir");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        #endregion

        #region images
        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = Resources.SearchChanged;
        }

        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = Resources.Search;
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.BackColor;
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.Back;
        }

        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = Resources.AddChanged;
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = Resources.Add;
        }

        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = Resources.EditChanged;
        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = Resources.Edit;
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete;
        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete_Close;
        }

      

        private void pbxClean1_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
           
        }

        private void pbxClean1_MouseEnter(object sender, EventArgs e)
        {
            pbxClean1.BackgroundImage = Resources.CleanChanged;
        }

        private void pbxClean1_MouseLeave(object sender, EventArgs e)
        {
            pbxClean1.BackgroundImage = Resources.Clean;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }
        #endregion
    }
}
