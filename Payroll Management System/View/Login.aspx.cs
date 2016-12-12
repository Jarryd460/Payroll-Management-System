using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
//using Medo.Security.Cryptography;
using System.Text;
using PWDTK_DOTNET451;

namespace Payroll_Management_System
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            btnSubmit.ServerClick += btnSubmit_Click;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Session["SessionID"] = Session.SessionID;
            //}

            //using built in hash PBKDF2 SHA1
            //byte[] salt = createSalt(24);
            //byte[] hash = createPBKDF2Hash("Jarryd", salt);

            //lblError.InnerText = Convert.ToBase64String(salt) + " " + Convert.ToBase64String(hash);

            //using (HMACSHA512 HMACHSHA512 = new HMACSHA512())
            //{
            //    byte[] salt = createSalt(36);
            //    int iterations = 4096;
            //    byte[] password = Encoding.ASCII.GetBytes(txtPassword.Text.Trim());

                //using Medo.Security.Cryptography hash - need Pbkdf2.cs file
                //Pbkdf2 hash = new Pbkdf2(HMACHSHA512, password, salt, iterations);
                //string strHash = Convert.ToBase64String(hash.GetBytes(64));
                //lblError.InnerText = strHash;
            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()) || string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            //{
            //    lblError.InnerText = "Please enter Username and Password";
            //    lblError.Style.Remove("visibility");
            //    lblError.Style.Add("visibility", "visible");
            //}
            //else
            //{
            //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand("spUserLogin", conn);
            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());               

            //        conn.Open();

            //        using (SqlDataReader dr = cmd.ExecuteReader())
            //        {
            //            if (dr.Read())
            //            {
            //                string dbPasswordHash = dr["Password"].ToString();
            //                string dbSalt = dr["Salt"].ToString();
            //                int iterations = 4096;

            //                Rfc2898 hash = new Rfc2898(txtPassword.Text.Trim(), dbSalt, iterations);
            //                string strHash = Convert.ToBase64String(hash.GetDerivedKeyBytes_PBKDF2_HMACSHA512(64));

            //                if (strHash.Equals(dbPasswordHash))
            //                {
            //                    lblError.InnerText = "A match";
            //                    Response.AddHeader("REFRESH", "10;URL=WebForm1.aspx");
            //                    //Server.Transfer("~/WebForm1.aspx");
            //                }
            //                else
            //                {
            //                    lblError.InnerText = "Not a match";
            //                }                                            
            //            }
            //            else
            //            {
            //                lblError.InnerText = "Username and Password Incorrect";                            
            //            }
            //        }
            //    }
            //    lblError.Style.Remove("visibility");
            //    lblError.Style.Add("visibility", "visible");
            //}
            System.Threading.Thread.Sleep(5000);
            Response.Redirect("~/WebForm1.aspx");
        }

        private byte[] createSalt(int saltSize)
        {
            RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            cryptoProvider.GetBytes(salt);

            return salt;
        }

        private byte[] createPBKDF2Hash(string text, byte[] salt)
        {
            Rfc2898DeriveBytes PBKDF2 = new Rfc2898DeriveBytes(text, salt);
            PBKDF2.IterationCount = 1000;

            return PBKDF2.GetBytes(20);
        }
    }

    //using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
    //{
    //    string salt = Convert.ToBase64String(createSalt(64));
    //    string password = txtPassword.Text.Trim();
    //    int iterations = 4096;

    //    Rfc2898 hash = new Rfc2898(password, salt, iterations);
    //    string strHash = Convert.ToBase64String(hash.GetDerivedKeyBytes_PBKDF2_HMACSHA512(64));

    //    SqlCommand cmd = new SqlCommand("Insert into Employee values ('Jarryd', 'Deane', '" + txtUsername.Text.Trim() + "','" + strHash + "','" + salt + "', 'A');", conn);

    //    conn.Open();
    //    cmd.ExecuteNonQuery();                

    //byte[] salt = createSalt(20);
    //byte[] hash = createPBKDF2Hash(txtPassword.Text.Trim(), salt);

    //SqlCommand cmd = new SqlCommand("Insert into Employee values ('Jarryd', 'Deane', '" + txtUsername.Text.Trim() + "','" + Convert.ToBase64String(hash) + "','" + Convert.ToBase64String(salt) + "', 'A');", conn);
    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
    //cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

    //conn.Open();
    //cmd.ExecuteNonQuery();
    //}

}