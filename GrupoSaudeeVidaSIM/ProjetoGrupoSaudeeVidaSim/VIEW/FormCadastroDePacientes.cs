using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using ProjetoGrupoSaudeeVidaSim.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormCadastroDePacientes : Form
    {

        private const string viaCepUrl = "https://viacep.com.br/ws/{0}/json";

        private MySqlConnection Conexao;
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        private PacienteDAO conexaoPacienteDAO;


        public FormCadastroDePacientes()
        {
            InitializeComponent();
            fecharCampos();
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

            IniciarConexao();

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
            string nome = txtNomeFormCadPaciente.Text.ToUpper();
            string cpf = maskedTextBoxCPFFormCadPaciente.Text.Replace(".", "").Replace("-", "");
            string contato = maskedTextBoxContatoFormCadPaciente.Text;
            DateTime dataNasc = DateTime.Parse(maskedTextBoxDataNascFormCadPaciente.Text);
            dataNasc = dataNasc.Date;
            string cep = maskedTextBoxCepFormCadPaciente.Text;
            string endereco = txtLogradouroFormCadPaciente.Text.ToUpper().Trim();
            int numCasa = Convert.ToInt32(txtNumFormCadPaciente.Text.Trim());
            string bairro = txtBairroFormCadPaciente.Text.ToUpper().Trim();
            string cidade = txtCidadeFormCadPaciente.Text.ToUpper().Trim();
            string uf = txtUFFormCadPaciente.Text.ToUpper();


            Paciente paciente = new Paciente(0, nome, cpf, contato, dataNasc, cep, endereco, numCasa, bairro, cidade, uf);
            conexaoPacienteDAO = new PacienteDAO();
            try
            {
                conexaoPacienteDAO.SalvarPaciente(paciente); //chama a classe ConexaoDB. VAI EXECUTAR O METODO
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

        private void IniciarConexao()
        {

            Conexao = new MySqlConnection(linkDB);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }

        private void FormCadastroDePacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarFormCadPaciente_Click(object sender, EventArgs e)
        {
            abrirCampos();
            btnEditarFormCadPaciente.Enabled = true;
            try
            {
                PacienteDAO pacienteDAO = new PacienteDAO();
                string nome = txtNomeFormCadPaciente.Text.Trim();
                string cpf = maskedTextBoxCPFFormCadPaciente.Text.Trim();

                Paciente paciente = pacienteDAO.BuscarPacientePorNomeOuCpf(nome, cpf);

                if (paciente != null)
                {
                    txtNomeFormCadPaciente.Text = paciente.Nome;
                    maskedTextBoxCPFFormCadPaciente.Text = paciente.Cpf;
                    maskedTextBoxContatoFormCadPaciente.Text = paciente.Contato;
                    maskedTextBoxDataNascFormCadPaciente.Text = paciente.DataNascimento.ToString("dd/MM/yyyy");
                    maskedTextBoxCepFormCadPaciente.Text = paciente.Cep;
                    txtLogradouroFormCadPaciente.Text = paciente.Endereco;
                    txtNumFormCadPaciente.Text = paciente.NumCasa.ToString();
                    txtBairroFormCadPaciente.Text = paciente.Bairro;
                    txtCidadeFormCadPaciente.Text = paciente.Cidade;
                    txtUFFormCadPaciente.Text = paciente.UF;
                }
                else
                {
                    MessageBox.Show("Paciente não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu Sintase Mysql " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao procurar o paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void btnConsultaCepFormCadPaciente_Click(object sender, EventArgs e)
        {
            string cep = maskedTextBoxCepFormCadPaciente.Text.Trim();
            cep = cep.Replace("-", "");
            if (!string.IsNullOrEmpty(cep))
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        string url = string.Format(viaCepUrl, cep);

                        HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
                        httpResponse.EnsureSuccessStatusCode();

                        if (httpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            string responseBody = await httpResponse.Content.ReadAsStringAsync();

                            var endereco = JsonConvert.DeserializeObject<Endereco>(responseBody);

                            txtLogradouroFormCadPaciente.AppendText(endereco.Logradouro);
                            txtBairroFormCadPaciente.AppendText(endereco.Bairro);
                            txtCidadeFormCadPaciente.AppendText(endereco.Localidade);
                            txtUFFormCadPaciente.AppendText(endereco.UF);

                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("O campo CEP está vazio.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnEditarFormCadPaciente(object sender, EventArgs e)
        {
            // Obtenha o CPF do campo de texto correspondente
            //OBS A VARIAVEL DO CPF TEM ESTÁ COM O TRATAMENTO DO REPLACE, SE NÃO VAI PROCURAR COM O PONTO E HIFEM E NÃO VAI ACHAR
            string cpf = maskedTextBoxCPFFormCadPaciente.Text.Replace(".", "").Replace("-", "");

            // Verifique se o paciente com o CPF fornecido existe no banco de dados
            PacienteDAO pacienteDAO = new PacienteDAO();
            if (pacienteDAO.PacienteExiste(cpf))
            {
                // Crie um objeto Paciente com os valores dos campos de texto
                Paciente paciente = new Paciente
                {
                    Nome = txtNomeFormCadPaciente.Text,
                    Cpf = cpf,
                    Contato = maskedTextBoxContatoFormCadPaciente.Text,
                    DataNascimento = DateTime.Parse(maskedTextBoxDataNascFormCadPaciente.Text),
                    Cep = maskedTextBoxCepFormCadPaciente.Text,
                    Endereco = txtLogradouroFormCadPaciente.Text,
                    NumCasa = int.Parse(txtNumFormCadPaciente.Text),
                    Bairro = txtBairroFormCadPaciente.Text,
                    Cidade = txtCidadeFormCadPaciente.Text,
                    UF = txtUFFormCadPaciente.Text
                };

                try
                {
                    // chamando o  método de atualização no DAO
                    pacienteDAO.AtualizarPaciente(paciente);
                    MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem informando que o paciente não foi encontrado
                MessageBox.Show("Paciente não encontrado com o CPF fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fecharCampos()
        {
            txtNomeFormCadPaciente.Enabled = true;
            btnConsultarFormCadPaciente.Enabled = true;
            maskedTextBoxCPFFormCadPaciente.Enabled = false;
            maskedTextBoxContatoFormCadPaciente.Enabled = false;
            maskedTextBoxDataNascFormCadPaciente.Enabled = false;
            maskedTextBoxCepFormCadPaciente.Enabled = false;
            txtLogradouroFormCadPaciente.Enabled = false;
            txtNumFormCadPaciente.Enabled = false;
            txtBairroFormCadPaciente.Enabled = false;
            txtCidadeFormCadPaciente.Enabled = false;
            txtUFFormCadPaciente.Enabled = false;

            btnNovoFormCadPaciente.Enabled = true;
            btnCadastrarFormCadPaciente.Enabled = false;
            btnEditarFormCadPaciente.Enabled = false;
            btnExcluirFormCadPaciente.Enabled = false;
            btnConsultaCepFormCadPaciente.Enabled = false;

        }

        private void abrirCampos()
        {
            txtNomeFormCadPaciente.Enabled = true;
            btnConsultarFormCadPaciente.Enabled = true;
            maskedTextBoxCPFFormCadPaciente.Enabled = true;
            maskedTextBoxContatoFormCadPaciente.Enabled = true;
            maskedTextBoxDataNascFormCadPaciente.Enabled = true;
            maskedTextBoxCepFormCadPaciente.Enabled = true;
            txtLogradouroFormCadPaciente.Enabled = true;
            txtNumFormCadPaciente.Enabled = true;
            txtBairroFormCadPaciente.Enabled = true;
            txtCidadeFormCadPaciente.Enabled = true;
            txtUFFormCadPaciente.Enabled = true;

            btnNovoFormCadPaciente.Enabled = true;
            btnCadastrarFormCadPaciente.Enabled = true;
            btnEditarFormCadPaciente.Enabled = false;
            btnExcluirFormCadPaciente.Enabled = false;
            btnConsultaCepFormCadPaciente.Enabled = true;

        }

        private void btnNovoFormCadPaciente_Click(object sender, EventArgs e)
        {
            abrirCampos();
        }
    }
}
