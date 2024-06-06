using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormCadastroDeMedicos : Form
    {
        private MySqlConnection Conexao;
        private string linkdb = "datasource=localhost;username=root;password=;database=clinica";
        private MedicoDAO conexaoMedicoDAO;
        

        public FormCadastroDeMedicos()
        {
            InitializeComponent();
        }

        private void btnCadastrarFormCadastroDeMedico_Click(object sender, System.EventArgs e)
        {
            IniciarConexao();

            try
            {
                string mensagemErro;
                if (ValidarCampos(out mensagemErro))
                {
                    // Todos os campos estão preenchidos corretamente, então podemos prosseguir com o salvamento
                    cadastrarMedico();
                    //LimparCampos();

                }
                else
                {
                    // Exibir mensagem de erro informando ao usuário sobre os campos não preenchidos
                    MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                Conexao.Close();
            }
        }

        private void cadastrarMedico()
        {
            string nome = txtNomeFormCadastroDeMedico.Text.ToUpper();
            int crm = Convert.ToInt32(txtNCrmFormCadastroDeMedico.Text.Trim());
            string especialidade = cbtEspMedicaFormCadastroDeMedico.Text.ToUpper();
            string diaAtendimento = cbDiaAtendimentoFormCadastroDeMedico.Text.ToUpper();
            string horaAtendimento = cbhorarioFormCadastroDeMedico.Text.ToUpper();


            Medico medico = new Medico(0, nome, crm, especialidade, diaAtendimento, horaAtendimento);
            conexaoMedicoDAO = new MedicoDAO();
            try
            {
                conexaoMedicoDAO.SalvarMedico(medico); //chama a classe ConexaoDB. VAI EXECUTAR O METODO
                MessageBox.Show("Contato inserido com sucesso!", "Sucesso"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            /*
            txtNomeFormCadastroDeMedico.Clear();
            txtNCrmFormCadastroDeMedico.Clear();
            cbtEspMedicaFormCadastroDeMedico.Clear();
            cbDiaAtendimentoFormCadastroDeMedico.Clear();
            cbhorarioFormCadastroDeMedico.Clear();
            */
            
        }

        private bool ValidarCampos(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNomeFormCadastroDeMedico.Text))
            {
                mensagemErro = "O nome é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNCrmFormCadastroDeMedico.Text))
            {
                mensagemErro = "O CPF é obrigatório e deve estar completo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbtEspMedicaFormCadastroDeMedico.Text))
            {
                mensagemErro = "O contato é obrigatório e deve estar completo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbDiaAtendimentoFormCadastroDeMedico.Text))
            {
                mensagemErro = "A data de nascimento é obrigatória e deve estar completa.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbhorarioFormCadastroDeMedico.Text))
            {
                mensagemErro = "O CEP é obrigatório.";
                return false;
            }

            return true;
        }

        private void IniciarConexao()
        {
            Conexao = new MySqlConnection(linkdb);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }

    }
}
