using ProjetoGrupoSaudeeVidaSim.DAO;
using System;
using System.Windows.Forms;


namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormTelaLogin : Form
    {


        public FormTelaLogin()
        {
            InitializeComponent();
        }
        #region btn EfetuarLogin
        private void btnEfetuarLoginFormTelaLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuarioFormTelaLogin.Text.Trim() == "" || txtSenhaFormTelaLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, insira usuário e senha.", "Campos não preenchidos!");
                    return;
                }

                string usuario = txtUsuarioFormTelaLogin.Text;
                string senha = txtSenhaFormTelaLogin.Text;

                AutenticacaoDAO autenticacaoDAO = new AutenticacaoDAO();
                bool autenticado = autenticacaoDAO.AutenticarUsuario(usuario, senha);

                if (autenticado)
                {
                    MessageBox.Show("Login efetuado com Sucesso!", "Sucesso");

                    // Redirecionar para a próxima tela ou funcionalidade do aplicativo

                    FormTelaPrincipal formPrincipal = new FormTelaPrincipal();
                    formPrincipal.Show();
                    this.Hide(); // Oculta o formulário de login
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }


        }
        #endregion

        #region btn Cadastro Novo Usuário
        private void btnNovoFormTelaLogin_Click(object sender, EventArgs e)
        {
            //Abri o formulário de Cadastros de Novos Usuários (Login)
            FormTelaDeRegistroUsuario formTelaDeRegistroUsuario = new FormTelaDeRegistroUsuario();
            formTelaDeRegistroUsuario.ShowDialog();


        }
        #endregion

        #region btn Sair
        private void BtnSairFormTelaLogin_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
       
