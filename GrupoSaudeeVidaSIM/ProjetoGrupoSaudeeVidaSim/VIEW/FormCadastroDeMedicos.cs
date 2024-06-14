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
            FecharCampos();
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
                    DialogResult conf = MessageBox.Show($"Deseja salvar o médico {txtNomeFormCadastroDeMedico.Text} com o CRM {txtNCrmFormCadastroDeMedico.Text}?", 
                                    "Confirmação de Cadastramento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (conf == DialogResult.Yes)
                    {
                        // Todos os campos estão preenchidos corretamente, então podemos prosseguir com o salvamento
                        cadastrarMedico();
                        LimparCampos();
                        FecharCampos();
                    }
                    
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
            int crm = Convert.ToInt32(txtNCrmFormCadastroDeMedico.Text);
            string especialidade = cbtEspMedicaFormCadastroDeMedico.Text.ToUpper();
            string diaAtendimento = cbDiaAtendimentoFormCadastroDeMedico.Text.ToUpper();
            string horaAtendimento = cbhorarioFormCadastroDeMedico.Text.ToUpper();


            Medico medico = new Medico(0, nome, crm, especialidade, diaAtendimento, horaAtendimento);
            conexaoMedicoDAO = new MedicoDAO();
            
            try
            {
                //criação do bool para verificar se já existe algum médico com o mesmo crm, se não existir cai no if, se já existir, retorna o erro e não salva
                //objetivo dessa condição é ele n armazenar dados duplicados, e não cadastrar médico com o mesmo crm
                bool validarSeUsuarioJaExiste = conexaoMedicoDAO.SalvarMedico(medico); 

                if (validarSeUsuarioJaExiste)
                {
                    MessageBox.Show("Contato inserido com sucesso!", "Sucesso"
                                                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Já existe médico com este CRM cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch ( Exception ex )
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*try
            {
                conexaoMedicoDAO.SalvarMedico(medico); //chama a classe ConexaoDB. VAI EXECUTAR O METODO
                MessageBox.Show("Contato inserido com sucesso!", "Sucesso"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }*/
        }

        //Método para validar campos para que estejam todos preenchidos corretamente
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

            if (txtNCrmFormCadastroDeMedico.Text.Length != 4)
            {
                mensagemErro = "O CRM é composto por 4 números.";
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

        //método para iniciar conexão com o MySQL
        private void IniciarConexao()
        {
            Conexao = new MySqlConnection(linkdb);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(); //montagem de objeto no mysql

            cmd.Connection = Conexao;
        }

        //Botão Consultar médico
        private void btnConsultarFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoDAO medicoDAO = new MedicoDAO();
                string nome = txtNomeFormCadastroDeMedico.Text.Trim();
                string crm = txtNCrmFormCadastroDeMedico.Text;

                Medico medicon = medicoDAO.BuscarMedicoNome(nome);
                Medico medico = medicoDAO.BuscarMedicoCrm(crm);

                if (medico != null)
                {
                    txtNomeFormCadastroDeMedico.Text = medico.Nome;
                    txtNCrmFormCadastroDeMedico.Text = medico.Crm.ToString();
                    cbtEspMedicaFormCadastroDeMedico.Text = medico.Especialidade; 
                    cbDiaAtendimentoFormCadastroDeMedico.Text = medico.DataAtendimento; 
                    cbhorarioFormCadastroDeMedico.Text = medico.HorarioAtendimento;

                    AbrirCampos();
                }
                else if (medicon != null)
                {
                    txtNomeFormCadastroDeMedico.Text = medicon.Nome;
                    txtNCrmFormCadastroDeMedico.Text = medicon.Crm.ToString();
                    cbtEspMedicaFormCadastroDeMedico.Text = medicon.Especialidade;
                    cbDiaAtendimentoFormCadastroDeMedico.Text = medicon.DataAtendimento;
                    cbhorarioFormCadastroDeMedico.Text = medicon.HorarioAtendimento;

                    AbrirCampos();
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

        //Botão Editar médico
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
                    FecharCampos();
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

        //Botão Excluir médico
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
                    FecharCampos();
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

        //Botão Novo Médico
        private void btnNovoFormCadastroDeMedico_Click(object sender, EventArgs e)
        {
            
            LimparCampos();
            AbrirCampos();
            txtNomeFormCadastroDeMedico.Focus();
        }

        //método para abrir todos os campos 
        private void AbrirCampos()
        {
            txtNomeFormCadastroDeMedico.Enabled = true;
            txtNCrmFormCadastroDeMedico.Enabled= true;
            cbtEspMedicaFormCadastroDeMedico.Enabled = true;
            cbDiaAtendimentoFormCadastroDeMedico.Enabled = true;
            cbhorarioFormCadastroDeMedico.Enabled = true;

            btnConsultarFormCadastroDeMedico.Enabled = true;
            btnNovoFormCadastroDeMedico.Enabled = true;
            btnSalvarFormCadastroDeMedico.Enabled = true;
            btnEditarFormCadastroDeMedico.Enabled = true;
            btnExcluirFormCadastroDeMedico.Enabled = true;
        }

        //método para fechar alguns campos 
        private void FecharCampos()
        {
            txtNomeFormCadastroDeMedico.Enabled = true;
            txtNCrmFormCadastroDeMedico.Enabled = true;
            cbtEspMedicaFormCadastroDeMedico.Enabled = false;
            cbDiaAtendimentoFormCadastroDeMedico.Enabled = false;
            cbhorarioFormCadastroDeMedico.Enabled = false;

            btnConsultarFormCadastroDeMedico.Enabled = true;
            btnNovoFormCadastroDeMedico.Enabled = true;
            btnSalvarFormCadastroDeMedico.Enabled = false;
            btnEditarFormCadastroDeMedico.Enabled = false;
            btnExcluirFormCadastroDeMedico.Enabled = false;
        }

        //método limpar todo o conteúdo dos campos
        private void LimparCampos()
        {

            txtNomeFormCadastroDeMedico.Text = String.Empty;
            txtNCrmFormCadastroDeMedico.Text = String.Empty;
            cbtEspMedicaFormCadastroDeMedico.Text = String.Empty;
            cbDiaAtendimentoFormCadastroDeMedico.Text = String.Empty;
            cbhorarioFormCadastroDeMedico.Text = String.Empty;
        }

        //Para que o campo do CRM aceite apenas as teclas de números e backspace
        private void txtNCrmFormCadastroDeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número ou backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
