using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormMarcarConsultas : Form
    {
        private MySqlConnection Conexao;
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";

        private void IniciarConexao()
        {

            Conexao = new MySqlConnection(linkDB);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }
        public FormMarcarConsultas()
        {
            InitializeComponent();
            fecharCampos();


        }

        private void FormMarcarConsultas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbNomeClinicasFormMarcarConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValordaConsultaFormMarcarConsultas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovoFormMarcarConsultas_Click(object sender, EventArgs e)
        {

        }


        private void cadastrarConsulta()
        {
            string nomeDaClinica = cbNomeClinicasFormMarcarConsultas.Text;
            float valorDaConsulta = float.Parse(txtValordaConsultaFormMarcarConsultas.Text);
            DateTime dataDaConsulta = DateTime.Parse(maskedDataConsultaFormMarcarConsulta.Text);
            string tipoDaConsulta = cbTipoConsultaFormMarcarConsultas.Text;
            string nomeDoPaciente = txtNomeFormMarcarConsultas.Text;
            string especialidade = cbEspecialidadeFormMarcarConsultas.Text;
            string nomeDoMedico = txtNomeMedicoFormMarcarConsultas.Text;
            string horarioDaConsulta = txtHorarioAtendimento.Text;
            int crm = int.Parse(txtCrmMedicoFormMarcarConsultas.Text);

            Consulta consulta = new Consulta(0, nomeDoPaciente, nomeDaClinica, valorDaConsulta, dataDaConsulta, tipoDaConsulta, especialidade, nomeDoMedico, horarioDaConsulta, crm);

            try
            {
                ConsultaDAO consultaDAO = new ConsultaDAO();
                consultaDAO.SalvarConsulta(consulta);
                MessageBox.Show("Consulta cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu de Sintaxe Mysql " + ex.Message,
                                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar consulta: " + ex.Message,
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fecharCampos()
        {
            cbEspecialidadeFormMarcarConsultas.Enabled = false;
            cbNomeClinicasFormMarcarConsultas.Enabled = false;
            cbTipoConsultaFormMarcarConsultas.Enabled = false;
            maskedDataConsultaFormMarcarConsulta.Enabled = false;
            txtNomeMedicoFormMarcarConsultas.Enabled = false;
            txtCrmMedicoFormMarcarConsultas.Enabled = false;
            txtValordaConsultaFormMarcarConsultas.Enabled = false;
            btnNovoFormMarcarConsultas.Enabled = false;
            btnBuscarMedico.Enabled = false;
            btnEditarConsulta.Enabled = false;
            txtHorarioAtendimento.Enabled = false;

        }
        private void abrirCampos()
        {
            cbEspecialidadeFormMarcarConsultas.Enabled = true;
            cbNomeClinicasFormMarcarConsultas.Enabled = true;
            cbTipoConsultaFormMarcarConsultas.Enabled = true;
            maskedDataConsultaFormMarcarConsulta.Enabled = true;
            txtNomeMedicoFormMarcarConsultas.Enabled = true;
            txtCrmMedicoFormMarcarConsultas.Enabled = true;
            txtValordaConsultaFormMarcarConsultas.Enabled = true;
            btnNovoFormMarcarConsultas.Enabled = true;
            btnBuscarMedico.Enabled = true;
            btnEditarConsulta.Enabled = true;
            txtHorarioAtendimento.Enabled = true;
        }
        private void limparCampos()
        {
            cbEspecialidadeFormMarcarConsultas.Text = string.Empty;
            cbNomeClinicasFormMarcarConsultas.Text = string.Empty;
            cbTipoConsultaFormMarcarConsultas.Text = string.Empty;
            maskedDataConsultaFormMarcarConsulta.Text = string.Empty;
            txtNomeMedicoFormMarcarConsultas.Text = string.Empty;
            txtCrmMedicoFormMarcarConsultas.Text = string.Empty;
            txtValordaConsultaFormMarcarConsultas.Text = string.Empty;
            txtNomeFormMarcarConsultas.Text = string.Empty;
            maskedCPFFormMarcarConsultas.Text = string.Empty;
            maskedContatoFormMarcarConsultas.Text = string.Empty;
            txtHorarioAtendimento.Text = string.Empty;

        }


        private void fecharCamposPaciente()
        {
            maskedCPFFormMarcarConsultas.Enabled = false;
            txtNomeFormMarcarConsultas.Enabled = false;
            maskedContatoFormMarcarConsultas.Enabled = false;
        }
        private void abrirCamposPaciente()
        {
            maskedCPFFormMarcarConsultas.Enabled = true;
            txtNomeFormMarcarConsultas.Enabled = true;
            maskedContatoFormMarcarConsultas.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //método para buscar paciente
            try
            {
                //cria um objeto do tipo PacienteDAO
                PacienteDAO pacienteDAO = new PacienteDAO();
                string nome = txtNomeFormMarcarConsultas.Text.Trim();
                string cpf = maskedCPFFormMarcarConsultas.Text.Replace(",", "").Replace("-", "");
                Paciente paciente = pacienteDAO.BuscarPacientePorNomeOuCpf(nome, cpf);
                //verifica se o paciente foi encontrado
                if (paciente != null)
                {
                    abrirCampos();
                    txtNomeFormMarcarConsultas.Text = paciente.Nome;
                    maskedCPFFormMarcarConsultas.Text = paciente.Cpf;
                    maskedContatoFormMarcarConsultas.Text = paciente.Contato;
                    fecharCamposPaciente();
                }
                else
                {
                    MessageBox.Show("Paciente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu de Sintaxe Mysql " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar paciente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        //método para validar campos da consulta
        private bool ValidarCamposConsulta(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (cbNomeClinicasFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome da clínica é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbTipoConsultaFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tipo da consulta é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (maskedDataConsultaFormMarcarConsulta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Data da consulta é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNomeMedicoFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do médico é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCrmMedicoFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("CRM do médico é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbEspecialidadeFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Especialidade do médico é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHorarioAtendimento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Horário de atendimento do médico é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtValordaConsultaFormMarcarConsultas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Valor da consulta é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cbNomeClinicasFormMarcarConsultas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFormMarcarConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {

        }

        //método para editar consulta
        private void btnNovoFormMarcarConsultas_Click_1(object sender, EventArgs e)
        {
            IniciarConexao();
            try
            {
                string mensagemErro;
                if (ValidarCamposConsulta(out mensagemErro))
                {
                    cadastrarConsulta();
                    limparCampos();
                    abrirCamposPaciente();
                }
                else
                {
                    // Exibir mensagem de erro informando ao usuário sobre os campos não preenchidos
                    MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu Sintaxe Mysql " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a consulta. " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnBuscarMedico_Click_1(object sender, EventArgs e)
        {
            try
            {
                //cria um objeto do tipo MedicoDAO
                MedicoDAO medicoDAO = new MedicoDAO();
                string nome = txtNomeMedicoFormMarcarConsultas.Text.Trim();
                string crm = txtCrmMedicoFormMarcarConsultas.Text;
                //busca o médico pelo nome

                Medico medico = medicoDAO.BuscarMedicoCrm(crm);
                Medico medicon = medicoDAO.BuscarMedicoNome(nome);

                if (medico != null)
                {
                    txtNomeMedicoFormMarcarConsultas.Text = medico.Nome;
                    cbEspecialidadeFormMarcarConsultas.Text = medico.Especialidade;
                    txtHorarioAtendimento.Text = medico.HorarioAtendimento;
                    txtCrmMedicoFormMarcarConsultas.Text = medico.Crm.ToString();


                }
                else if (medicon != null)
                {
                    txtNomeMedicoFormMarcarConsultas.Text = medicon.Nome;
                    cbEspecialidadeFormMarcarConsultas.Text = medicon.Especialidade;
                    txtHorarioAtendimento.Text = medicon.HorarioAtendimento;
                    txtCrmMedicoFormMarcarConsultas.Text = medicon.Crm.ToString();
                }
                else
                {
                    MessageBox.Show("Médico não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ocorreu de Sintaxe Mysql " + ex.Message,
                                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar médico: " + ex.Message,
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFormMarcarConsultas.Text;
            string nomeDaClinica = cbNomeClinicasFormMarcarConsultas.Text;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            if (consultaDAO.consultaExiste(nome, nomeDaClinica))
            {
                Consulta consulta = new Consulta()
                {
                    Nome = txtNomeFormMarcarConsultas.Text,
                    NomeDaClinica = cbNomeClinicasFormMarcarConsultas.Text,
                    ValorDaConsulta = float.Parse(txtValordaConsultaFormMarcarConsultas.Text),
                    DataDaConsulta = DateTime.Parse(maskedDataConsultaFormMarcarConsulta.Text),
                    TipoDaConsulta = cbTipoConsultaFormMarcarConsultas.Text,
                    Especialidade = cbEspecialidadeFormMarcarConsultas.Text,
                    NomeDoMedico = txtNomeMedicoFormMarcarConsultas.Text,
                    Crm = int.Parse(txtCrmMedicoFormMarcarConsultas.Text)

                };
                try
                {
                    consultaDAO.EditarConsulta(consulta);
                    MessageBox.Show("Consulta editada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ocorreu de Sintaxe Mysql " + ex.Message,
                                                                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar consulta: " + ex.Message,
                                                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

    }
}