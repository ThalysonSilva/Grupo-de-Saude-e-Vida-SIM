using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormAgendaMedica : Form
    {

        public FormAgendaMedica()
        {
            InitializeComponent();
            organizarLstConsultas();

        }

        #region Método organizar lista de consultas
        private void organizarLstConsultas()
        {
            // Estrutura de visualização no campo listViewConsultas
            listViewFormAgendaMedica.View = View.Details;
            listViewFormAgendaMedica.LabelEdit = true;
            listViewFormAgendaMedica.AllowColumnReorder = true;
            listViewFormAgendaMedica.FullRowSelect = true;
            listViewFormAgendaMedica.GridLines = true;

            // Configuração das colunas da lista
            listViewFormAgendaMedica.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listViewFormAgendaMedica.Columns.Add("Nome do Paciente", 150, HorizontalAlignment.Center);
            listViewFormAgendaMedica.Columns.Add("Data da Consulta", 150, HorizontalAlignment.Center);
            listViewFormAgendaMedica.Columns.Add("Tipo da Consulta", 150, HorizontalAlignment.Center);
            listViewFormAgendaMedica.Columns.Add("Nome do Médico", 150, HorizontalAlignment.Center);
            listViewFormAgendaMedica.Columns.Add("Valor da Consulta", 150, HorizontalAlignment.Center);
        }
        #endregion

        #region btn Retornar agenda médica
        private void btnRetornarFormAgendaMedica_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoDAO medicoDAO = new MedicoDAO();
                string nome = txtNomeMedFormAgendaMedica.Text.Trim();
                Medico medicon = medicoDAO.BuscarMedicoNome(nome);
                if (medicon != null)
                {
                    txtNomeMedFormAgendaMedica.Text= medicon.Nome;
                }
                else
                {
                    MessageBox.Show("Médico não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btn Consultar agenda médica
        private void btnConsultarFormAgendaMedica_Click(object sender, EventArgs e)
        {
        string nomeDaClinica = txtNomeMedFormAgendaMedica.Text.Trim();
            try
            {
                List<Consulta> consultas = new ConsultaDAO().BuscarConsultasPorNomeClinica(nomeDaClinica);
                ExibirResultados(consultas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExibirResultados(List<Consulta> consultas)
        {
            listViewFormAgendaMedica.Items.Clear();
            foreach (Consulta consulta in consultas)
            {
                ListViewItem item = new ListViewItem(consulta.Id.ToString());
                item.SubItems.Add(consulta.Nome);
                item.SubItems.Add(consulta.DataDaConsulta.ToString());
                item.SubItems.Add(consulta.TipoDaConsulta);
                item.SubItems.Add(consulta.NomeDoMedico);
                item.SubItems.Add(consulta.ValorDaConsulta.ToString("C"));
                listViewFormAgendaMedica.Items.Add(item);
            }
        }
        #endregion
    }
}
