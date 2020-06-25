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

namespace Sistema_HelpTech
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=helptech;Data Source=PC\SQLEXPRESS");
            SqlCommand command = new SqlCommand("select * from usuario where Logins=@Logins and Senha=@Senha",sql);

            command.Parameters.Add("@Logins", SqlDbType.VarChar).Value = txtFrmLogin.Text;
            command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtFrmSenha.Text;

            try
            {
                sql.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Usuario ou senha incorrecta!!");
                }
                dr.Read();
                MessageBox.Show("Login com sucesso, Seja bem vindo ao help Tech", "SISTEMA - HELP TECH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal frmPri = new frmPrincipal();
                frmPri.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
