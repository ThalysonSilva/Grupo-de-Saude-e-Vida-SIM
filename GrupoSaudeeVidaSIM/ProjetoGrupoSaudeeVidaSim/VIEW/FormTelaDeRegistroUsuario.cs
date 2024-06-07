using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using System;
using System.Windows.Forms;


namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormTelaDeRegistroUsuario : Form
    {
        private MySqlConnection Conexao;
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        private AutenticacaoDAO conexaoAutenticacaoDao;

       

        public FormTelaDeRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Checar Campos Inválidos

            if (txtUsuarioFormTelaRegistroUser.Text.Trim() == "" || 
                txtSenhaFormTelaRegistroUser.Text.Trim() == "" || 
                txtConfSenhaFormTelaRegistroUser.Text.Trim() == "") 
            {
                MessageBox.Show("Campos Inválidos");
                return;
            
            }

                        
        }
        private void cadastrarusuario() 
        {
            string usuario = txtUsuarioFormTelaRegistroUser.Text;
            string senha = txtSenhaFormTelaRegistroUser.Text;
            string confsenha = txtConfSenhaFormTelaRegistroUser.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}    