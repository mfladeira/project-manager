﻿using FinalMateus.Classes;
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
    public partial class UserDetailsForm : Form
    {
        string name = "";
        string email = "";
        string password = "";
        string confirmPass = "";
        string profile = "";
        bool active = false;
        List<UserProfile> users = new List<UserProfile>();
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        public UserDetailsForm(int idUser)
        {

            InitializeComponent();

            lblId.Text = idUser.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["Email"].ToString();
                            user.Password = reader["Password"].ToString();
                        }
                    }

                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;


                }
                catch (Exception EX)
                {
                    //Tratar exce??es
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }

        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password =tbxPassword.Text;
            confirmPass = tbxConfirmPassword.Text;
            profile = cmbProfile.Text;
            active = cbxActive.Checked ? true : false;
        }

        void ClearData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirmPassword.Text = "";
            cmbProfile.Text = "";
            cbxActive.Checked = false;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("usuario inativo!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar usuario!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete;
        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = Resources.Delete_Close;
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                User u = new User(name, email, password, up, active);
                sqlConnect.Open();
                string sql = "INSERT INTO [USER](NAME, EMAIL, PASSWORD, FK_USERPROFILE, ACTIVE) VALUES (@name, @email, @password, @profile, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name",u.Name));
                cmd.Parameters.Add(new SqlParameter("@email",u.Email));
                cmd.Parameters.Add(new SqlParameter("@password",u.Password));
                //cmd.Parameters.Add(new SqlParameter("@confirmpassword",u.ConfirmPassword));
                cmd.Parameters.Add(new SqlParameter("@profile",u.UserProfile.Id));
                cmd.Parameters.Add(new SqlParameter("@active", active));

                if (name != "")
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
        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile up = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    users.Add(up);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile up in users)
            {
                cmbProfile.Items.Add(up);
            }
        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = Resources.Save_Changed;
        }

        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = Resources.Save;
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
