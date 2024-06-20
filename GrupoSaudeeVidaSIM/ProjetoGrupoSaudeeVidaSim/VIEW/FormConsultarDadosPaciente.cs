using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormConsultarDadosPaciente : Form
    {
        private PacienteDAO pacienteDAO;

        public FormConsultarDadosPaciente()
        {
            InitializeComponent();
            pacienteDAO = new PacienteDAO();
            organizarLST();
        }

        #region btn consultar paciente
        private void btnConsultarFormConsultarDados_Click(object sender, EventArgs e)
        {
            
            string nome = txtNomeFormConsultarDados.Text.Trim();

            try
            {
                List<Paciente> pacientes = pacienteDAO.BuscarPacienteEListar(nome);
                ExibirResultados(pacientes);
            }
            catch (Exception ex)
            {
                // Mostrando mensagem de erro detalhada
                MessageBox.Show("Erro ao consultar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }
        #endregion

        #region Método para organizar a list view
        private void organizarLST()
        {
            // Estrutura de visualização no campo listViewFormConsultarDados
            // Define o modo de exibição da listView para exibir detalhes em colunas
            listViewFormConsultarDados.View = View.Details;

            // Permite que os rótulos das colunas sejam editados pelo usuário
            listViewFormConsultarDados.LabelEdit = true;

            // Permite que as colunas sejam reorganizadas pelo usuário
            listViewFormConsultarDados.AllowColumnReorder = true;

            // Habilita a seleção da linha inteira quando um item é clicado
            listViewFormConsultarDados.FullRowSelect = true;

            // Adiciona linhas de grade para melhorar a visualização
            listViewFormConsultarDados.GridLines = true;

            // Adiciona as colunas à listView e define o texto do cabeçalho e a largura de cada coluna
            listViewFormConsultarDados.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Contato", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Data Nasc", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("CEP", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Endereço", 150, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Num Casa", 70, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Bairro", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listViewFormConsultarDados.Columns.Add("UF", 50, HorizontalAlignment.Left);
        }
        #endregion
        #region Método exibir informações na liss view
        private void ExibirResultados(List<Paciente> pacientes)
        {
            listViewFormConsultarDados.Items.Clear();

            foreach (Paciente paciente in pacientes)
            {
                ListViewItem item = new ListViewItem(paciente.Id.ToString());
                item.SubItems.Add(paciente.Nome);
                item.SubItems.Add(paciente.Cpf);
                item.SubItems.Add(paciente.Contato);
                item.SubItems.Add(paciente.DataNascimento.ToString("dd/MM/yyyy"));
                item.SubItems.Add(paciente.Cep);
                item.SubItems.Add(paciente.Endereco);
                item.SubItems.Add(paciente.NumCasa.ToString());
                item.SubItems.Add(paciente.Bairro);
                item.SubItems.Add(paciente.Cidade);
                item.SubItems.Add(paciente.UF);
                listViewFormConsultarDados.Items.Add(item);
            }
        }
        #endregion
        #region Método para limpar as informações na list view
        private void btnConsultarFormLimparDados_Click(object sender, EventArgs e)
        {
            listViewFormConsultarDados.Items.Clear();
        }
        #endregion

                
    }
}
