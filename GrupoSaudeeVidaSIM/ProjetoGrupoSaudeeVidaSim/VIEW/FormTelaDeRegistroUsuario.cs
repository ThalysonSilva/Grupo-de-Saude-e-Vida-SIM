using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormTelaDeRegistroUsuario : Form
    {
        private MySqlConnection Conexao;
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        private AutenticacaoDAO conexaoAutenticacaoDAO;


        public FormTelaDeRegistroUsuario()
        {
            InitializeComponent();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IniciarConexao();

            try
            {
                // Chama a função de cadastro de usuário
                cadastrarusuario();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu Sintase Mysql " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu Sintase Programação " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao != null && Conexao.State == System.Data.ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
        private void cadastrarusuario()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string confsenha = txtConfSenha.Text;

            if (senha != confsenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Autenticacao autenticacao = new Autenticacao(0, usuario, senha, confsenha);
            conexaoAutenticacaoDAO = new AutenticacaoDAO();
            try
            {
                conexaoAutenticacaoDAO.SalvarUsuario(autenticacao); // chama a classe ConexaoDB e executa o método
                MessageBox.Show("Contato inserido com sucesso!", "Sucesso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void IniciarConexao()
        {
            Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=clinica");

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }

    }
}



  