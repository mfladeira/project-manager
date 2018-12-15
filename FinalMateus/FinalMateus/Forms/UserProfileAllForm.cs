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
    public partial class UserProfileAllForm : Form
    {
        string search = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserProfileAllForm()
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);
                

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUserProfile.DataSource = dt;

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
            dgvUserProfile.Columns["ID"].Visible = false;
            dgvUserProfile.Columns["NAME"].HeaderText = "Nome";
            dgvUserProfile.Columns["ACTIVE"].HeaderText = "Ativo";


            foreach (DataGridViewColumn col in dgvUserProfile.Columns)
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
        private void LittleSearch()
        {
            string optionForm = "UserProfileForm";
            string optionString = "name";

            Search search = new Search();
            dgvUserProfile.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);
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
           
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserProfileDetailsForm updf = new UserProfileDetailsForm();
            updf.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUserProfile = Int32.Parse(dgvUserProfile.SelectedRows[0].Cells[0].Value.ToString());
            UserProfileDetailsForm updf = new UserProfileDetailsForm(idUserProfile);
            updf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUserProfile = Int32.Parse(dgvUserProfile.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE USER_PROFILE SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUserProfile));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();
                ShowData();
                MessageBox.Show("Perfil inativo!");
                Log.SaveLog(sqlConnect,"Perfil Desativado", DateTime.Now, "Excluir");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este perfil!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
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

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                ShowData();
            }
        }
    }
}
