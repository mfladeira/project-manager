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


        #region functions

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);

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
        #endregion
        #region buttons
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            LittleSearch();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Hide();          
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            
            CategoryDetailsForm cdf = new CategoryDetailsForm();
            cdf.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());
            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory);
            categoryDetails.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();
                ShowData();
                MessageBox.Show("Categoria inativa!");
                Log.SaveLog("Categoria Desativada", DateTime.Now, "Excluir");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar esta categoria!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        #endregion
        #region images
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = Resources.SearchChanged;
        }

        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = Resources.Search;
        }

        private void pbxClean_MouseEnter(object sender, EventArgs e)
        {
            pbxClean.BackgroundImage = Resources.CleanChanged;
        }

        private void pbxClean_MouseLeave(object sender, EventArgs e)
        {
            pbxClean.BackgroundImage = Resources.Clean;
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
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

        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = Resources.AddChanged;
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = Resources.Add;
        }
        #endregion
    }
}