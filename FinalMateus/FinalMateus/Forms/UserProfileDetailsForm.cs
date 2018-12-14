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
    public partial class UserProfileDetailsForm : Form
    {
        string name = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserProfileDetailsForm()
        {
            InitializeComponent();
        }

        public UserProfileDetailsForm(int idCategory)
        {

            InitializeComponent();

            lblId.Text = idCategory.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                   
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE WHERE ID = @id", sqlConnect);
                    

                    cmd.Parameters.Add(new SqlParameter("@id", idCategory));

                    UserProfile userprofile = new UserProfile(); 

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            userprofile.Id = Int32.Parse(reader["ID"].ToString());
                            userprofile.Name = reader["NAME"].ToString();
                            userprofile.Active = bool.Parse(reader["ACTIVE"].ToString());
                        }
                    }

                    tbxName.Text = userprofile.Name;
                    cbxActive.Checked = userprofile.Active;


                }
                catch (Exception EX)
                {
                   
                    throw;
                }
                finally
                {
                    
                    sqlConnect.Close();
                }
            }
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
            if (string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                try
                {
                    GetData();

                    sqlConnect.Open();
                    string sql = "INSERT INTO USER_PROFILE(NAME, ACTIVE) VALUES (@name, @active)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@active", active));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog("Perfil Adicionado", DateTime.Now, "Adição");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar perfil!" + ex.Message);
                    ClearData();
                }
                finally
                {
                    ClearData();
                    sqlConnect.Close();
                }
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    GetData();

                    sqlConnect.Open();

                    string sql = "UPDATE USER_PROFILE SET NAME = @name, ACTIVE = @active WHERE ID = @id";


                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SaveLog("Perfil Editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este perfil" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                    this.Close();
                }
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text)) 
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE USER_PROFILE SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Perfil inativo!");
                    Log.SaveLog("Perfil Desativadao", DateTime.Now, "Excluir");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este perfil!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = Resources.Save_Changed;
        }

        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = Resources.Save;
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
