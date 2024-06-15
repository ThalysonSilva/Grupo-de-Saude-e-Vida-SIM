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

            try
            {
                List<Consulta> consultas = medicoDAO.BuscarConsultasPorNomeMedico(nome);
                ExibirConsulta(consultas);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar consultas: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void organizarList()
        {
            listViewFormDiasAtendMedico.View = View.Details;
            listViewFormDiasAtendMedico.LabelEdit = true;
            listViewFormDiasAtendMedico.AllowColumnReorder = true;
            listViewFormDiasAtendMedico.FullRowSelect = true;
            listViewFormDiasAtendMedico.GridLines = true;

            listViewFormDiasAtendMedico.Columns.Add("CRM", 50, HorizontalAlignment.Left);
            listViewFormDiasAtendMedico.Columns.Add("Data da Consulta", 150, HorizontalAlignment.Left);
            listViewFormDiasAtendMedico.Columns.Add("Nome da Clínica", 200, HorizontalAlignment.Left);
        }

        private void ExibirConsulta(List<Consulta> consultas)
        {
            listViewFormDiasAtendMedico.Items.Clear();

            foreach (Consulta consulta in consultas)
            {

                ListViewItem item = new ListViewItem(consulta.Crm.ToString());
                item.SubItems.Add(consulta.DataDaConsulta.ToString("dd/MM/yyyy"));
                item.SubItems.Add(consulta.NomeDaClinica);
                listViewFormDiasAtendMedico.Items.Add(item);
            }
        }
    }
}
