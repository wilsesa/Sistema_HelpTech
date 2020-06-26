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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=helptech;Data Source=PC\SQLEXPRESS");
            SqlCommand command = new SqlCommand("Insert into usuario(Iduser,Usuario,Logins,Senha,Fone,Perfil) values (@Iduser,@Usuario,@Logins,@Senha,@Fone,@Perfil)", sql);
            command.Parameters.Add("@Iduser", SqlDbType.Int).Value = txtIduser.Text;
            command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtNome.Text;
            command.Parameters.Add("@Logins", SqlDbType.VarChar).Value = txtLogin.Text;
            command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
            command.Parameters.Add("@Fone", SqlDbType.VarChar).Value = txtFone.Text;
            command.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = cbPerfil.Text;

            if (txtIduser.Text != "" & txtNome.Text != "" & txtLogin.Text != "" & txtSenha.Text != "" & cbPerfil.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!!!", "SISTEMA HELP TECH - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIduser.Clear();
                    txtFone.Clear();
                    txtLogin.Clear();
                    txtNome.Clear();
                    txtSenha.Clear();
                    cbPerfil.Text = "";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor digite todas Informações nos campos obrigatorios", "SISTEMA HELP TECH - CAMPOS OBRIGATORIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            
            SqlCommand command = new SqlCommand("select * from usuario where Iduser=@Iduser", sql);

            command.Parameters.Add("@Iduser", SqlDbType.VarChar).Value = txtIduser.Text;
            

            try
            {
                sql.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Id não encontrado!!");
                }
                dr.Read();

                txtIduser.Text = Convert.ToString(dr["Iduser"]);
                txtNome.Text = Convert.ToString(dr["Usuario"]);
                txtLogin.Text = Convert.ToString(dr["Logins"]);
                txtSenha.Text = Convert.ToString(dr["Senha"]);
                txtFone.Text = Convert.ToString(dr["Fone"]);
                cbPerfil.Text = Convert.ToString(dr["Perfil"]);

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIduser.Clear();
            txtFone.Clear();
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            cbPerfil.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=helptech;Data Source=PC\SQLEXPRESS");
            SqlCommand command = new SqlCommand("Update usuario set Usuario=@Usuario,Logins=@Logins,Senha=@Senha,Fone=@Fone,Perfil=@Perfil where Iduser=@Iduser", sql);
            command.Parameters.Add("@Iduser", SqlDbType.Int).Value = txtIduser.Text;
            command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtNome.Text;
            command.Parameters.Add("@Logins", SqlDbType.VarChar).Value = txtLogin.Text;
            command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
            command.Parameters.Add("@Fone", SqlDbType.VarChar).Value = txtFone.Text;
            command.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = cbPerfil.Text;

            if (txtIduser.Text != "" & txtNome.Text != "" & txtLogin.Text != "" & txtSenha.Text != "" & txtFone.Text != "" & cbPerfil.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELP TECH - ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIduser.Clear();
                    txtFone.Clear();
                    txtLogin.Clear();
                    txtNome.Clear();
                    txtSenha.Clear();
                    cbPerfil.Text = "";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor digite todas Informações nos campos obrigatorios", "SISTEMA HELP TECH - CAMPOS OBRIGATORIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
            //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=helptech;Data Source=PC\SQLEXPRESS");
            SqlCommand command = new SqlCommand("delete from usuario where Iduser=@Iduser", sql);
            command.Parameters.Add("@Iduser", SqlDbType.VarChar).Value = txtIduser.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELP TECH - EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIduser.Clear();
                txtFone.Clear();
                txtLogin.Clear();
                txtNome.Clear();
                txtSenha.Clear();
                cbPerfil.Text = "";
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
