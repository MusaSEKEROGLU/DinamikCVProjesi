using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearTexbox();

            }
        }
        private void ClearTexbox()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;           
        }
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        protected void btnRegiter_Click(object sender, EventArgs e)
        {
            try
            {               
                string CS = ConfigurationManager.ConnectionStrings["MyCVProject"].ConnectionString;                    
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRegister", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@AdSoyad", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefon", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Şifre", Encrypt(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    ClearTexbox();
                    lblMessage.Text = "Kayıt olma işlemi başarılıdır.";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Kayıt olma işlemi sırasında hata oluştu.Lütfen bilgilerinizi kontrol ediniz.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}