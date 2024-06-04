using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormCadastroDePacientes : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=clinica";
        private ConexaoDB conexao;
        //private int? idContatoSelecionado = null;


        public FormCadastroDePacientes()
        {
            InitializeComponent();
        }

        private void labCPFFormCadPaciente_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogradouroFormCadPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFormCadPaciente_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;

            //idContatoSelecionado = Convert.ToInt32(txtCodFormCadPaciente.Text);

            try
            {
                string mensagemErro;
                if (ValidarCampos(out mensagemErro))
                {
                    // Todos os campos estão preenchidos corretamente, então podemos prosseguir com o salvamento
                    cadastrarPaciente();
                    LimparCampos();
                    
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
        private void cadastrarPaciente()
        {
            string nome = txtNomeFormCadPaciente.Text.Trim();
            string cpf = maskedTextBoxCPFFormCadPaciente.Text; ;
            string contato = maskedTextBoxContatoFormCadPaciente.Text;
            DateTime dataNasc = DateTime.Parse(maskedTextBoxDataNascFormCadPaciente.Text);
            dataNasc = dataNasc.Date;
            string cep = maskedTextBoxCepFormCadPaciente.Text;
            string endereco = txtLogradouroFormCadPaciente.Text.Trim();
            int numCasa = Convert.ToInt32(txtNumFormCadPaciente.Text.Trim());
            string bairro = txtBairroFormCadPaciente.Text.Trim();
            string cidade = txtCidadeFormCadPaciente.Text.Trim();
            string uf = txtUFFormCadPaciente.Text;


            Paciente paciente = new Paciente(0, nome, cpf, contato, dataNasc.Date, cep, endereco, numCasa, bairro, cidade, uf);
            conexao = new ConexaoDB();
            try
            {
                conexao.SalvarPaciente(paciente); //chama a classe conexao DB. VAI EXECUTAR O METODO
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
            txtNomeFormCadPaciente.Clear();
            maskedTextBoxCPFFormCadPaciente.Clear();
            maskedTextBoxContatoFormCadPaciente.Clear();
            maskedTextBoxDataNascFormCadPaciente.Clear();
            maskedTextBoxCepFormCadPaciente.Clear();
            txtLogradouroFormCadPaciente.Clear();
            txtNumFormCadPaciente.Clear();
            txtBairroFormCadPaciente.Clear();
            txtCidadeFormCadPaciente.Clear();
            txtUFFormCadPaciente.Clear();
        }

        private bool ValidarCampos(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNomeFormCadPaciente.Text))
            {
                mensagemErro = "O nome é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBoxCPFFormCadPaciente.Text) || !maskedTextBoxCPFFormCadPaciente.MaskCompleted)
            {
                mensagemErro = "O CPF é obrigatório e deve estar completo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBoxContatoFormCadPaciente.Text) || !maskedTextBoxContatoFormCadPaciente.MaskCompleted)
            {
                mensagemErro = "O contato é obrigatório e deve estar completo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBoxDataNascFormCadPaciente.Text) || !maskedTextBoxDataNascFormCadPaciente.MaskCompleted)
            {
                mensagemErro = "A data de nascimento é obrigatória e deve estar completa.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBoxCepFormCadPaciente.Text))
            {
                mensagemErro = "O CEP é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogradouroFormCadPaciente.Text))
            {
                mensagemErro = "O endereço é obrigatório.";
                return false;
            }

            if (!int.TryParse(txtNumFormCadPaciente.Text, out _))
            {
                mensagemErro = "O número da casa é obrigatório e deve ser um número válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairroFormCadPaciente.Text))
            {
                mensagemErro = "O bairro é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidadeFormCadPaciente.Text))
            {
                mensagemErro = "A cidade é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUFFormCadPaciente.Text))
            {
                mensagemErro = "A UF é obrigatória.";
                return false;
            }

            return true;
        }
    }
}
