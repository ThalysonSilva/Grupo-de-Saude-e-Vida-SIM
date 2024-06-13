using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormConsultasMarcadas : Form
    {

        private PacienteDAO pacienteDAO;

        public FormConsultasMarcadas()
        {
            InitializeComponent();
            pacienteDAO = new PacienteDAO();
            organizarLST();

        }

        private void organizarLST()
        {
            // Estrutura de visualização no campo listViewConsultas
            listViewFormConsultasMarcadasPac.View = View.Details;
            listViewFormConsultasMarcadasPac.LabelEdit = true;
            listViewFormConsultasMarcadasPac.AllowColumnReorder = true;
            listViewFormConsultasMarcadasPac.FullRowSelect = true;
            listViewFormConsultasMarcadasPac.GridLines = true;

            // Configuração das colunas da lista
            listViewFormConsultasMarcadasPac.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Nome do Paciente", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Data da Consulta", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Tipo da Consulta", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Nome do Médico", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Especialidade", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("CRM", 100, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Nome da Clínica", 150, HorizontalAlignment.Center);
            listViewFormConsultasMarcadasPac.Columns.Add("Valor da Consulta", 150, HorizontalAlignment.Center);
        }

        private void btnConsultarFormConsultasMarcadasPac_Click(object sender, EventArgs e)
        {

            string cpf = maskedTextBoxCpfPacFormConsultasMarcadas.Text.Replace(".", "").Replace("-", "");
            string nome = txtNomePacFormConsultasMarcadas.Text.Trim();

            try
            {
                List<Consulta> consultas = pacienteDAO.BuscarConsultasPorNomeOuCpf(nome, cpf);
                ExibirResultados(consultas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ExibirResultados(List<Consulta> consultas)
        {
            listViewFormConsultasMarcadasPac.Items.Clear();

            foreach (Consulta consulta in consultas)
            {
                ListViewItem item = new ListViewItem(consulta.Id.ToString());
                item.SubItems.Add(consulta.Nome);
                item.SubItems.Add(consulta.DataDaConsulta.ToString("dd/MM/yyyy"));
                item.SubItems.Add(consulta.TipoDaConsulta);
                item.SubItems.Add(consulta.NomeDoMedico);
                item.SubItems.Add(consulta.Especialidade);
                item.SubItems.Add(consulta.Crm.ToString());
                item.SubItems.Add(consulta.NomeDaClinica);
                item.SubItems.Add(consulta.ValorDaConsulta.ToString("C"));

                listViewFormConsultasMarcadasPac.Items.Add(item);
            }
        }
    }
}
