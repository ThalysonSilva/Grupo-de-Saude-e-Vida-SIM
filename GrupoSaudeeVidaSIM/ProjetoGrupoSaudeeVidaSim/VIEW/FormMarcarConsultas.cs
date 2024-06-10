﻿using ProjetoGrupoSaudeeVidaSim.DAO;
using System;
using System.Windows.Forms;
using ProjetoGrupoSaudeeVidaSim.DTO;
using MySql.Data.MySqlClient;
using Mysqlx;
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Text;

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
            int crm = int.Parse(txtCrmMedicoFormMarcarConsultas.Text);

            Consulta consulta = new Consulta(0, nomeDoPaciente, nomeDaClinica, valorDaConsulta, dataDaConsulta, tipoDaConsulta, especialidade, nomeDoMedico, crm);

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
        }

        private void fecharCamposPaciente()
        {
            maskedCPFFormMarcarConsultas.Enabled = false;
            txtNomeFormMarcarConsultas.Enabled = false;
            maskedContatoFormMarcarConsultas.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                PacienteDAO pacienteDAO = new PacienteDAO();
                string nome = txtNomeFormMarcarConsultas.Text.Trim();
                string cpf = maskedCPFFormMarcarConsultas.Text.Replace(",", "").Replace("-", "");
                Paciente paciente = pacienteDAO.BuscarPacientePorNomeOuCpf(nome, cpf);
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

        private void btnNovoFormMarcarConsultas_Click_1(object sender, EventArgs e)
        {
            IniciarConexao();
            try
            {
                string mensagemErro;
                if (ValidarCamposConsulta(out mensagemErro))
                {
                    cadastrarConsulta();
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
                MedicoDAO medicoDAO = new MedicoDAO();
                string nome = txtNomeMedicoFormMarcarConsultas.Text.Trim();

                Medico medico = medicoDAO.BuscarMedico(nome);
                if (medico != null)
                {
                    txtNomeMedicoFormMarcarConsultas.Text = medico.Nome;
                    cbEspecialidadeFormMarcarConsultas.Text = medico.Especialidade;
                    txtCrmMedicoFormMarcarConsultas.Text = medico.Crm.ToString();
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

    }
}