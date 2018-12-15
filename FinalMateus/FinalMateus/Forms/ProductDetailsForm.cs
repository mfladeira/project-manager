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
    public partial class ProductDetailsForm : Form
    {
        string name = "";
        bool active = false;
        float price = 0;
        string category = "";
        List<Category> categories = new List<Category>();
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public ProductDetailsForm()
        {
            InitializeComponent();
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();
            if (string.IsNullOrEmpty(lblId.Text))
            {
                pbxDelete.Visible = false;
                pbxSave.Location = new Point(pbxSave.Location.X + 140, pbxSave.Location.Y);

            }

        }

        public ProductDetailsForm(int idProduct)
        {

            InitializeComponent();
            cmbCategory.DisplayMember = "Name";
            lblId.Text = idProduct.ToString(); 

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @id", sqlConnect);
               

                    cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                    Product product = new Product(); 

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            product.Id = Int32.Parse(reader["ID"].ToString());
                            product.Name = reader["NAME"].ToString();
                            product.Active = bool.Parse(reader["ACTIVE"].ToString());
                            product.Price = float.Parse(reader["PRICE"].ToString());
                            product.Category = new Category()
                            {
                                Id = Int32.Parse(reader["FK_PRODUCT"].ToString())
                            };

                        }
                    }

                    tbxName.Text = product.Name;
                    cbxActive.Checked = product.Active;
                    tbxPrice.Text = product.Price.ToString();
                    int indexCombo = 0;
                    if (product.Category != null)
                    {
                        indexCombo = product.Category.Id;
                    }
                    InitializeComboBox(cmbCategory, indexCombo);


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

        private void InitializeComboBox(ComboBox cbxProduct, int indexCombo)
        {
            cbxProduct.Items.Add("Selecione.. ");
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
               
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);

                using (SqlDataReader reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        Category c = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                        cmbCategory.Items.Add(c);
                    }
                }

                cmbCategory.SelectedItem = cmbCategory.Items[indexCombo];
            }
            catch (Exception EX)
            {
                MessageBox.Show("Erro de acesso ao banco de dados. " + EX.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            category = cmbCategory.Text;
            active = cbxActive.Checked ? true : false;
        }
        void ClearData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            cmbCategory.Text = "";
            cbxActive.Checked = false;
        }


        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm paf = new ProductAllForm();
            paf.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                try
                {
                    GetData();
                    Category c = (Category)cmbCategory.SelectedItem;
                    Product p = new Product(name, price, c, active);
                    sqlConnect.Open();
                    string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", p.Name));
                    cmd.Parameters.Add(new SqlParameter("@price", p.Price));
                    cmd.Parameters.Add(new SqlParameter("@active", p.Active));
                    cmd.Parameters.Add(new SqlParameter("@category", p.Category.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog("Produto Adicionado", DateTime.Now, "Adição");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto!" + ex.Message);
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
                    Category c = (Category)cmbCategory.SelectedItem;
                    sqlConnect.Open();

                    string sql = "UPDATE PRODUCT SET NAME = @name, PRICE = @price, ACTIVE = @active, FK_PRODUCT = @category WHERE ID= @id";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    
                    cmd.Parameters.Add(new SqlParameter("@category", c.Id));


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SaveLog("Produto Adicionado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                    ProductAllForm paf = new ProductAllForm();
                    paf.Show();
                    this.Close();
                }
            }
        }

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(Int32.Parse(reader["ID"].ToString()),reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    categories.Add(c);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (Category c in categories)
            {
                cmbCategory.Items.Add(c);
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
                    string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto inativo!");
                    Log.SaveLog("Produto Desativado", DateTime.Now, "Excluir");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este produto!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    ClearData();
                    sqlConnect.Close();
                }
            }
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.BackColor;
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = Resources.Back;
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
