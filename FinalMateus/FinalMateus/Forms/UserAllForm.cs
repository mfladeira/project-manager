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
    public partial class UserAllForm : Form
    {
        string search = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public UserAllForm()
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

                
                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].PASSWORD, [USER].EMAIL, [USER].ACTIVE, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE = USER_PROFILE.ID;", sqlConnect);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

               dgvUser.DataSource = dt;

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
            string optionForm = "UserForm";
            string optionString = "name";

            Search search = new Search();
            dgvUser.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);
        }

        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["PASSWORD"].HeaderText = "Senha";
            dgvUser.Columns["EMAIL"].HeaderText = "Email";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvUser.Columns["ACTIVE"].DisplayIndex = 4;
            dgvUser.Columns["NAME1"].HeaderText = "Usuario";
            dgvUser.Columns["NAME1"].DisplayIndex = 3;

            foreach (DataGridViewColumn col in dgvUser.Columns)
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

        private void pbxClean_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
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
            udf.FormClosed += (s, arg) => ShowData();
            
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());
            UserDetailsForm udf = new UserDetailsForm(idUser);
            udf.Show();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();
                ShowData();
                MessageBox.Show("usuario inativo!");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este usuario!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
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
            pbxAdd.BackgroundImage = Resources.AddChanged;
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = Resources.Add;
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

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }
    }
}
