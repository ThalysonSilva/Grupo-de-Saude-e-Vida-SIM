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
   
            try
            {
                PacienteDAO pacienteDAO = new PacienteDAO();
                string nome = txtNomeFormCadPaciente.Text.Trim();

                Paciente paciente = pacienteDAO.BuscarPaciente(nome);

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
    }
}
