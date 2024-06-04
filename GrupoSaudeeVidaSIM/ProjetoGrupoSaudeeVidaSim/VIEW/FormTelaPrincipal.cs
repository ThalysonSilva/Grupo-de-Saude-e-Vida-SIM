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
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customizeDesing();
        }
        private void customizeDesing()
        {
            painelSubMenuConsulta.Visible = false;
            painelSubMenuPaciente.Visible = false;
            painelSubMenuMedicos.Visible = false;
            PanelUsuarios.Visible = false;
            // método para personalizar Designer e ocultar os subMenus
        }



        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcarConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendaEDisponibilidade_Click(object sender, EventArgs e)
        {

        }

        private void ConsultasPorTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnconsultarDadosPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultasAgendadas_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMedicos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendaMedica_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaMarcada_Click(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            painelSubMenuPaciente.Visible = !painelSubMenuPaciente.Visible;
            //lógica para alternar a visibilidade dos painéis com base nas interações do usuário,
            //ao clicar nos botões para expandir os submenus
        }

        private void painelSubMenuConsulta_Paint(object sender, PaintEventArgs e)
        {


        }

        private void painelSubMenuPaciente_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnMenuConsulta_Click(object sender, EventArgs e)
        {
            painelSubMenuConsulta.Visible = !painelSubMenuConsulta.Visible;
            //lógica para alternar a visibilidade dos painéis com base nas interações do usuário,
            //ao clicar nos botões para expandir os submenus
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void BtnMenuMedicos_Click(object sender, EventArgs e)
        {
            painelSubMenuMedicos.Visible = !painelSubMenuMedicos.Visible;
            //lógica para alternar a visibilidade dos painéis com base nas interações do usuário,
            //ao clicar nos botões para expandir os submenus
        }

        private void btnMarcarConsulta_Click_1(object sender, EventArgs e)
        {
            //Abri o formulário de Marcar Consultas
            FormMarcarConsultas formMarcarConsultas = new FormMarcarConsultas();
            formMarcarConsultas.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgendaEDisponibilidade_Click_1(object sender, EventArgs e)
        {   //Abri o formulário de Agenada Médica
            FormAgendaMedica formAgendaMedica = new FormAgendaMedica();
            formAgendaMedica.ShowDialog();
        }

        private void BtnConsultaPorTipo_Click(object sender, EventArgs e)
        {   //Abri o formulário de Consultar por Tipo
            FormConsultarPorTipo formConsultarPorTipo = new FormConsultarPorTipo();
            formConsultarPorTipo.ShowDialog();
        }

        private void btnCadastrarPacientes_Click_1(object sender, EventArgs e)
        {   //Abri o formulário de Cadastro de Pacientes
            FormCadastroDePacientes formCadastroDePacientes = new FormCadastroDePacientes();
            formCadastroDePacientes.ShowDialog();
        }

        private void btnConsultarDados_Click(object sender, EventArgs e)
        {   //Abri o formulário de Consultar Dados do Pacientes
            FormConsultarDadosPaciente formConsultarDadosPaciente = new FormConsultarDadosPaciente();
            formConsultarDadosPaciente.ShowDialog();
        }

        private void btnConsultasMarcadas_Click(object sender, EventArgs e)
        {   //Abri o formulário de Consultas Marcadas
            FormConsultasMarcadas formConsultasMarcadas = new FormConsultasMarcadas();
            formConsultasMarcadas.ShowDialog();
        }

        private void btnCadastrarMedicos_Click_1(object sender, EventArgs e)
        {   //Abri o formulário de Cadastro de Médicos
            FormCadastroDeMedicos formCadastroDeMedicos = new FormCadastroDeMedicos();
            formCadastroDeMedicos.ShowDialog();
        }

        private void btnConsultarAgenda_Click(object sender, EventArgs e)
        {   //Abri o formulário de Agenda Médica
            FormAgendaMedica formAgenda = new FormAgendaMedica();
            formAgenda.ShowDialog();
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {   //Abri o formulário de Atendimentos Médicos
            FormAtendimentoMedico formAtendimentoMedico = new FormAtendimentoMedico();
            formAtendimentoMedico.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            PanelUsuarios.Visible = !PanelUsuarios.Visible;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abri o formulário 
            FormControleDeUsuarios formControleDeUsuarios = new FormControleDeUsuarios();
            formControleDeUsuarios.ShowDialog();
        }
    }
}
