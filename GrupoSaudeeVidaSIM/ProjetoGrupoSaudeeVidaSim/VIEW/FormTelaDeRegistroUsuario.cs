using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Windows.Forms;


namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormTelaDeRegistroUsuario : Form
    {
        #region Conexão

        private MySqlConnection Conexao;
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        private AutenticacaoDAO conexaoAutenticacaoDAO;

        #endregion

        public FormTelaDeRegistroUsuario()
        {
            
            InitializeComponent();

        }

        #region btn Salvar Novo Registro
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            IniciarConexao();

            try
            {
                // Chama a função de cadastro de usuário
                Cadastrarusuario();
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
        #endregion

        #region Método Cadastrar Usuário
        private void Cadastrarusuario()
        {  //método é responsável por cadastrar um novo usuário no sistema

           // Obtém os dados dos campos de texto
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string confsenha = txtConfSenha.Text;

            // Verifica se as senhas coincidem
            if (senha != confsenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria um objeto de autenticação com os dados fornecidos
            Autenticacao autenticacao = new Autenticacao(0, usuario, senha, confsenha);
            conexaoAutenticacaoDAO = new AutenticacaoDAO();
            try
            {
                // Salva o usuário no banco de dados
                conexaoAutenticacaoDAO.SalvarUsuario(autenticacao); 
                MessageBox.Show("Usuário foi inserido com sucesso!", "Sucesso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro se ocorrer uma exceção
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void IniciarConexao()
        {
            // Cria e abre uma conexão com o banco de dados MySQL
            Conexao = new MySqlConnection(linkDB);

            Conexao.Open();

            // Cria um comando MySQL e associa a conexão a ele
            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }
        #endregion
    }

}




