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

        //Botão Salvar
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
                MessageBox.Show("Ocorreu um erro de Sintaxe Mysql." + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o médico." + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        //método cadastrar Médico
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
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        //método limpar campos
        private void LimparCampos()
        {
            
            txtNomeFormCadastroDeMedico.Text = String.Empty;
            txtNCrmFormCadastroDeMedico.Text = String.Empty;
            cbtEspMedicaFormCadastroDeMedico.Text = String.Empty;
            cbDiaAtendimentoFormCadastroDeMedico.Text = String.Empty;
            cbhorarioFormCadastroDeMedico.Text = String.Empty;
        }

        //Método validar campos
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
                mensagemErro = "O CRM é obrigatório e deve estar completo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbtEspMedicaFormCadastroDeMedico.Text))
            {
                mensagemErro = "A especialidade é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbDiaAtendimentoFormCadastroDeMedico.Text))
            {
                mensagemErro = "O dia de atendimento é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbhorarioFormCadastroDeMedico.Text))
            {
                mensagemErro = "O horário de atendimento é obrigatório.";
                return false;
            }

            return true;
        }

        //método iniciar conexão
        private void IniciarConexao()
        {
            Conexao = new MySqlConnection(linkdb);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }

        //Botão Consultar
        private void btnConsultarFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoDAO medicoDAO = new MedicoDAO();
                string nome = txtNomeFormCadastroDeMedico.Text.Trim();

                Medico medico = medicoDAO.BuscarMedico(nome);

                if (medico != null)
                {
                    txtNomeFormCadastroDeMedico.Text = medico.Nome;
                    txtNCrmFormCadastroDeMedico.Text = medico.Crm.ToString();
                    cbtEspMedicaFormCadastroDeMedico.Text = medico.Especialidade; 
                    cbDiaAtendimentoFormCadastroDeMedico.Text = medico.DataAtendimento; 
                    cbhorarioFormCadastroDeMedico.Text = medico.HorarioAtendimento; 

                }
                else
                {
                    MessageBox.Show("Médico não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro de Sintaxe Mysql. " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao procurar o Médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botão Editar
        private void btnEditarFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            int crm = Convert.ToInt32(txtNCrmFormCadastroDeMedico.Text);
            MedicoDAO medicoDAO = new MedicoDAO();

            if(medicoDAO.medicoExiste(crm))
            {
                Medico medico = new Medico()
                {
                    Nome = txtNomeFormCadastroDeMedico.Text,
                    Crm = crm,
                    Especialidade = cbtEspMedicaFormCadastroDeMedico.Text,
                    DataAtendimento = cbDiaAtendimentoFormCadastroDeMedico.Text,
                    HorarioAtendimento = cbhorarioFormCadastroDeMedico.Text,
                };

                try
                {
                    medicoDAO.EditarMedico(medico);
                    MessageBox.Show("Médico atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro de Sintaxe Mysql. " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao editar o Médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Médico com o CRM {crm} não encontrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botão Excluir
        private void btnExcluirFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoDAO medicoDAO = new MedicoDAO();
                int crm = Convert.ToInt32(txtNCrmFormCadastroDeMedico.Text);

                DialogResult conf = MessageBox.Show($"Tem certeza que deseja excluir o médico {txtNomeFormCadastroDeMedico.Text} " +
                                                    $"com CRM {txtNCrmFormCadastroDeMedico.Text} do sistema?",
                                                    "Confirmação de exclusão",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (conf == DialogResult.Yes)
                {
                    Medico medico = medicoDAO.ExcluirMedico(crm);

                    MessageBox.Show("Médico excluído do sistema com sucesso.",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro de Sintaxe Mysql. " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o Médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeFormCadastroDeMedico.Focus();
        }
    }
    }
