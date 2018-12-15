using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMateus.Classes
{
    public  class Search
    {
        public DataTable SearchFilter(string connectionString, string parameter, string query, string optionForm)
        {

            string optionString = query;

            if (optionForm == "LogForm")
            {
                switch (optionString)
                {
                    case "description":
                        optionString = "SELECT * FROM LOG WHERE DESCRIPTION LIKE @value";
                        break;

                    case "date":
                        optionString = "SELECT * FROM LOG WHERE DATE LIKE @value";
                        break;
                }
            }

            else if (optionForm == "CategoryForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM CATEGORY  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM CATEGORY WHERE ACTIVE LIKE @value";
                        break;
                }
            }

            

            else if (optionForm == "ProductForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM PRODUCT WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM PRODUCT WHERE ACTIVE LIKE @value";
                        break;

                    case "price":
                        optionString = "SELECT * FROM PRODUCT WHERE PRICE LIKE @value";
                        break;
                }
            }

            

            else if (optionForm == "UserForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM [USER]  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM [USER] WHERE ACTIVE LIKE @value";
                        break;

                    case "email":
                        optionString = "SELECT * FROM [USER] WHERE EMAIL LIKE @value";
                        break;
                }
            }

            else if (optionForm == "UserProfileForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM USER_PROFILE  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM USER_PROFILE WHERE ACTIVE LIKE @value";
                        break;
                }
            }

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand(optionString, sqlConnect);




                cmd.Parameters.Add(new SqlParameter("@value", "%" + parameter + "%")); 

                DataTable dt = new DataTable();
                
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                return dt;
            }
            catch (Exception EX)
            {
              
                return null;
            }
            finally
            {

                sqlConnect.Close();
            }
        }
    }
}
