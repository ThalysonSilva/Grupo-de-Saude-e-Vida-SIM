using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormAtendimentoMedico : Form
    {
        private MedicoDAO medicoDAO;

        public FormAtendimentoMedico()
        {
            InitializeComponent();
            medicoDAO = new MedicoDAO();
            organizarList();
        }

        private void btnConsultarFormDiasAtendMedico_Click(object sender, System.EventArgs e)
        {

            string nome = txtFormDiasAtendMedico.Text.Trim();

            // condição para verificar se o campo está Vazio
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira o nome do médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // se passar pela condição vai entrar pelo try: 
            try
            {
                List<Consulta> consultas = medicoDAO.BuscarConsultasPorNomeMedico(nome);

                if (consultas == null || consultas.Count == 0)
                {
                    MessageBox.Show("Médico não encontrado ou não há consultas para o médico especificado.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                ExibirConsulta(consultas);
                }
            }
            catch (Exception erro)
            {
                // Mostrando mensagem de erro detalhada
                MessageBox.Show("Erro ao buscar consultas do médico: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void organizarList()
        {
            listViewFormDiasAtendMedico.View = View.Details;
            listViewFormDiasAtendMedico.LabelEdit = true;
            listViewFormDiasAtendMedico.AllowColumnReorder = true;
            listViewFormDiasAtendMedico.FullRowSelect = true;
            listViewFormDiasAtendMedico.GridLines = true;

            listViewFormDiasAtendMedico.Columns.Add("Nome do Paciente", 150, HorizontalAlignment.Center);
            listViewFormDiasAtendMedico.Columns.Add("Data da Consulta", 120, HorizontalAlignment.Center);
            listViewFormDiasAtendMedico.Columns.Add("Horario Consulta", 130, HorizontalAlignment.Center);
            listViewFormDiasAtendMedico.Columns.Add("Tipo da Consulta", 130, HorizontalAlignment.Center);
            listViewFormDiasAtendMedico.Columns.Add("Especialidade", 120, HorizontalAlignment.Center);
            listViewFormDiasAtendMedico.Columns.Add("Nome da Clínica", 130, HorizontalAlignment.Center);
        }

        private void ExibirConsulta(List<Consulta> consultas)
        {
            listViewFormDiasAtendMedico.Items.Clear();

            foreach (Consulta consulta in consultas)
            {

                ListViewItem item = new ListViewItem(consulta.Nome.ToString());
                item.SubItems.Add(consulta.DataDaConsulta.ToString("dd/MM/yyyy"));
                item.SubItems.Add(consulta.HorarioDaConsulta.ToString());
                item.SubItems.Add(consulta.TipoDaConsulta.ToString());
                item.SubItems.Add(consulta.Especialidade.ToString());
                item.SubItems.Add(consulta.NomeDaClinica);
                listViewFormDiasAtendMedico.Items.Add(item);
            }
        }

        private void btnLimparFormDiasAtendMedico_Click(object sender, EventArgs e)
        {
            listViewFormDiasAtendMedico.Items.Clear();
        }
    }
}
