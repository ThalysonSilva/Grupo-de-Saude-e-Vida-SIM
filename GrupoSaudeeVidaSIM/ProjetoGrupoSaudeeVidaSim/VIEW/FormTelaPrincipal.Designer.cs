namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.painelSideMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelUsuarios = new System.Windows.Forms.Panel();
            this.BtnControleDeUsuarios = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.painelSubMenuMedicos = new System.Windows.Forms.Panel();
            this.btnAtendimentos = new System.Windows.Forms.Button();
            this.btnConsultarAgenda = new System.Windows.Forms.Button();
            this.btnCadastrarMedicos = new System.Windows.Forms.Button();
            this.BtnMenuMedicos = new System.Windows.Forms.Button();
            this.painelSubMenuPaciente = new System.Windows.Forms.Panel();
            this.btnConsultasMarcadas = new System.Windows.Forms.Button();
            this.btnConsultarDados = new System.Windows.Forms.Button();
            this.btnCadastrarPacientes = new System.Windows.Forms.Button();
            this.BtnMenuPacientes = new System.Windows.Forms.Button();
            this.painelSubMenuConsulta = new System.Windows.Forms.Panel();
            this.BtnConsultaPorTipo = new System.Windows.Forms.Button();
            this.btnAgendaEDisponibilidade = new System.Windows.Forms.Button();
            this.btnMarcarConsulta = new System.Windows.Forms.Button();
            this.BtnMenuConsulta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.painelSideMenu.SuspendLayout();
            this.PanelUsuarios.SuspendLayout();
            this.painelSubMenuMedicos.SuspendLayout();
            this.painelSubMenuPaciente.SuspendLayout();
            this.painelSubMenuConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelSideMenu
            // 
            this.painelSideMenu.AutoScroll = true;
            this.painelSideMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.painelSideMenu.Controls.Add(this.btnSair);
            this.painelSideMenu.Controls.Add(this.PanelUsuarios);
            this.painelSideMenu.Controls.Add(this.btnMenuUsuario);
            this.painelSideMenu.Controls.Add(this.painelSubMenuMedicos);
            this.painelSideMenu.Controls.Add(this.BtnMenuMedicos);
            this.painelSideMenu.Controls.Add(this.painelSubMenuPaciente);
            this.painelSideMenu.Controls.Add(this.BtnMenuPacientes);
            this.painelSideMenu.Controls.Add(this.painelSubMenuConsulta);
            this.painelSideMenu.Controls.Add(this.BtnMenuConsulta);
            this.painelSideMenu.Controls.Add(this.panelLogo);
            this.painelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.painelSideMenu.Name = "painelSideMenu";
            this.painelSideMenu.Size = new System.Drawing.Size(250, 711);
            this.painelSideMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(0, 635);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 37);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // PanelUsuarios
            // 
            this.PanelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelUsuarios.Controls.Add(this.BtnControleDeUsuarios);
            this.PanelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUsuarios.Location = new System.Drawing.Point(0, 584);
            this.PanelUsuarios.Name = "PanelUsuarios";
            this.PanelUsuarios.Size = new System.Drawing.Size(250, 51);
            this.PanelUsuarios.TabIndex = 8;
            // 
            // BtnControleDeUsuarios
            // 
            this.BtnControleDeUsuarios.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnControleDeUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnControleDeUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnControleDeUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControleDeUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnControleDeUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BtnControleDeUsuarios.Name = "BtnControleDeUsuarios";
            this.BtnControleDeUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnControleDeUsuarios.Size = new System.Drawing.Size(250, 51);
            this.BtnControleDeUsuarios.TabIndex = 1;
            this.BtnControleDeUsuarios.Text = "Controle de Usuários";
            this.BtnControleDeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnControleDeUsuarios.UseVisualStyleBackColor = false;
            this.BtnControleDeUsuarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenuUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 544);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuUsuario.Size = new System.Drawing.Size(250, 40);
            this.btnMenuUsuario.TabIndex = 7;
            this.btnMenuUsuario.Text = "Usuários";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.UseVisualStyleBackColor = true;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // painelSubMenuMedicos
            // 
            this.painelSubMenuMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.painelSubMenuMedicos.Controls.Add(this.btnAtendimentos);
            this.painelSubMenuMedicos.Controls.Add(this.btnConsultarAgenda);
            this.painelSubMenuMedicos.Controls.Add(this.btnCadastrarMedicos);
            this.painelSubMenuMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSubMenuMedicos.Location = new System.Drawing.Point(0, 425);
            this.painelSubMenuMedicos.Name = "painelSubMenuMedicos";
            this.painelSubMenuMedicos.Size = new System.Drawing.Size(250, 119);
            this.painelSubMenuMedicos.TabIndex = 6;
            // 
            // btnAtendimentos
            // 
            this.btnAtendimentos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAtendimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtendimentos.FlatAppearance.BorderSize = 0;
            this.btnAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendimentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtendimentos.Location = new System.Drawing.Point(0, 80);
            this.btnAtendimentos.Name = "btnAtendimentos";
            this.btnAtendimentos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAtendimentos.Size = new System.Drawing.Size(250, 39);
            this.btnAtendimentos.TabIndex = 2;
            this.btnAtendimentos.Text = "Atendimentos";
            this.btnAtendimentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimentos.UseVisualStyleBackColor = false;
            this.btnAtendimentos.Click += new System.EventHandler(this.btnAtendimentos_Click);
            // 
            // btnConsultarAgenda
            // 
            this.btnConsultarAgenda.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConsultarAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarAgenda.FlatAppearance.BorderSize = 0;
            this.btnConsultarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarAgenda.Location = new System.Drawing.Point(0, 40);
            this.btnConsultarAgenda.Name = "btnConsultarAgenda";
            this.btnConsultarAgenda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarAgenda.Size = new System.Drawing.Size(250, 40);
            this.btnConsultarAgenda.TabIndex = 1;
            this.btnConsultarAgenda.Text = "Consultar Agenda";
            this.btnConsultarAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAgenda.UseVisualStyleBackColor = false;
            this.btnConsultarAgenda.Click += new System.EventHandler(this.btnConsultarAgenda_Click);
            // 
            // btnCadastrarMedicos
            // 
            this.btnCadastrarMedicos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCadastrarMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarMedicos.FlatAppearance.BorderSize = 0;
            this.btnCadastrarMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMedicos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarMedicos.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarMedicos.Name = "btnCadastrarMedicos";
            this.btnCadastrarMedicos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastrarMedicos.Size = new System.Drawing.Size(250, 40);
            this.btnCadastrarMedicos.TabIndex = 0;
            this.btnCadastrarMedicos.Text = "Cadastrar Médico";
            this.btnCadastrarMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarMedicos.UseVisualStyleBackColor = false;
            this.btnCadastrarMedicos.Click += new System.EventHandler(this.btnCadastrarMedicos_Click_1);
            // 
            // BtnMenuMedicos
            // 
            this.BtnMenuMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenuMedicos.FlatAppearance.BorderSize = 0;
            this.BtnMenuMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuMedicos.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMenuMedicos.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuMedicos.Image")));
            this.BtnMenuMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenuMedicos.Location = new System.Drawing.Point(0, 380);
            this.BtnMenuMedicos.Name = "BtnMenuMedicos";
            this.BtnMenuMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnMenuMedicos.Size = new System.Drawing.Size(250, 45);
            this.BtnMenuMedicos.TabIndex = 5;
            this.BtnMenuMedicos.Text = "Médicos";
            this.BtnMenuMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuMedicos.UseVisualStyleBackColor = true;
            this.BtnMenuMedicos.Click += new System.EventHandler(this.BtnMenuMedicos_Click);
            // 
            // painelSubMenuPaciente
            // 
            this.painelSubMenuPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.painelSubMenuPaciente.Controls.Add(this.btnConsultasMarcadas);
            this.painelSubMenuPaciente.Controls.Add(this.btnConsultarDados);
            this.painelSubMenuPaciente.Controls.Add(this.btnCadastrarPacientes);
            this.painelSubMenuPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSubMenuPaciente.Location = new System.Drawing.Point(0, 254);
            this.painelSubMenuPaciente.Name = "painelSubMenuPaciente";
            this.painelSubMenuPaciente.Size = new System.Drawing.Size(250, 126);
            this.painelSubMenuPaciente.TabIndex = 4;
            this.painelSubMenuPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.painelSubMenuPaciente_Paint);
            // 
            // btnConsultasMarcadas
            // 
            this.btnConsultasMarcadas.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConsultasMarcadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultasMarcadas.FlatAppearance.BorderSize = 0;
            this.btnConsultasMarcadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasMarcadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultasMarcadas.Location = new System.Drawing.Point(0, 80);
            this.btnConsultasMarcadas.Name = "btnConsultasMarcadas";
            this.btnConsultasMarcadas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultasMarcadas.Size = new System.Drawing.Size(250, 46);
            this.btnConsultasMarcadas.TabIndex = 2;
            this.btnConsultasMarcadas.Text = "Consultas Marcadas";
            this.btnConsultasMarcadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultasMarcadas.UseVisualStyleBackColor = false;
            this.btnConsultasMarcadas.Click += new System.EventHandler(this.btnConsultasMarcadas_Click);
            // 
            // btnConsultarDados
            // 
            this.btnConsultarDados.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConsultarDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarDados.FlatAppearance.BorderSize = 0;
            this.btnConsultarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarDados.Location = new System.Drawing.Point(0, 40);
            this.btnConsultarDados.Name = "btnConsultarDados";
            this.btnConsultarDados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarDados.Size = new System.Drawing.Size(250, 40);
            this.btnConsultarDados.TabIndex = 1;
            this.btnConsultarDados.Text = "Consultar Dados";
            this.btnConsultarDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarDados.UseVisualStyleBackColor = false;
            this.btnConsultarDados.Click += new System.EventHandler(this.btnConsultarDados_Click);
            // 
            // btnCadastrarPacientes
            // 
            this.btnCadastrarPacientes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCadastrarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarPacientes.FlatAppearance.BorderSize = 0;
            this.btnCadastrarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarPacientes.Name = "btnCadastrarPacientes";
            this.btnCadastrarPacientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastrarPacientes.Size = new System.Drawing.Size(250, 40);
            this.btnCadastrarPacientes.TabIndex = 0;
            this.btnCadastrarPacientes.Text = "Cadastrar Paciente";
            this.btnCadastrarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarPacientes.UseVisualStyleBackColor = false;
            this.btnCadastrarPacientes.Click += new System.EventHandler(this.btnCadastrarPacientes_Click_1);
            // 
            // BtnMenuPacientes
            // 
            this.BtnMenuPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenuPacientes.FlatAppearance.BorderSize = 0;
            this.BtnMenuPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuPacientes.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMenuPacientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuPacientes.Image")));
            this.BtnMenuPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenuPacientes.Location = new System.Drawing.Point(0, 209);
            this.BtnMenuPacientes.Name = "BtnMenuPacientes";
            this.BtnMenuPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnMenuPacientes.Size = new System.Drawing.Size(250, 45);
            this.BtnMenuPacientes.TabIndex = 3;
            this.BtnMenuPacientes.Text = "Pacientes";
            this.BtnMenuPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuPacientes.UseVisualStyleBackColor = true;
            this.BtnMenuPacientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // painelSubMenuConsulta
            // 
            this.painelSubMenuConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.painelSubMenuConsulta.Controls.Add(this.BtnConsultaPorTipo);
            this.painelSubMenuConsulta.Controls.Add(this.btnAgendaEDisponibilidade);
            this.painelSubMenuConsulta.Controls.Add(this.btnMarcarConsulta);
            this.painelSubMenuConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSubMenuConsulta.Location = new System.Drawing.Point(0, 90);
            this.painelSubMenuConsulta.Name = "painelSubMenuConsulta";
            this.painelSubMenuConsulta.Size = new System.Drawing.Size(250, 119);
            this.painelSubMenuConsulta.TabIndex = 2;
            this.painelSubMenuConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.painelSubMenuConsulta_Paint);
            // 
            // BtnConsultaPorTipo
            // 
            this.BtnConsultaPorTipo.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnConsultaPorTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultaPorTipo.FlatAppearance.BorderSize = 0;
            this.BtnConsultaPorTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaPorTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConsultaPorTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaPorTipo.Location = new System.Drawing.Point(0, 80);
            this.BtnConsultaPorTipo.Name = "BtnConsultaPorTipo";
            this.BtnConsultaPorTipo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnConsultaPorTipo.Size = new System.Drawing.Size(250, 39);
            this.BtnConsultaPorTipo.TabIndex = 2;
            this.BtnConsultaPorTipo.Text = "Consulta por Tipo";
            this.BtnConsultaPorTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaPorTipo.UseVisualStyleBackColor = false;
            this.BtnConsultaPorTipo.Click += new System.EventHandler(this.BtnConsultaPorTipo_Click);
            // 
            // btnAgendaEDisponibilidade
            // 
            this.btnAgendaEDisponibilidade.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAgendaEDisponibilidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendaEDisponibilidade.FlatAppearance.BorderSize = 0;
            this.btnAgendaEDisponibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaEDisponibilidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendaEDisponibilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgendaEDisponibilidade.Location = new System.Drawing.Point(0, 40);
            this.btnAgendaEDisponibilidade.Name = "btnAgendaEDisponibilidade";
            this.btnAgendaEDisponibilidade.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgendaEDisponibilidade.Size = new System.Drawing.Size(250, 40);
            this.btnAgendaEDisponibilidade.TabIndex = 1;
            this.btnAgendaEDisponibilidade.Text = "Agenda";
            this.btnAgendaEDisponibilidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendaEDisponibilidade.UseVisualStyleBackColor = false;
            this.btnAgendaEDisponibilidade.Click += new System.EventHandler(this.btnAgendaEDisponibilidade_Click_1);
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMarcarConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcarConsulta.FlatAppearance.BorderSize = 0;
            this.btnMarcarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMarcarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcarConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMarcarConsulta.Size = new System.Drawing.Size(250, 40);
            this.btnMarcarConsulta.TabIndex = 0;
            this.btnMarcarConsulta.Text = "Marcar Consultas";
            this.btnMarcarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarConsulta.UseVisualStyleBackColor = false;
            this.btnMarcarConsulta.Click += new System.EventHandler(this.btnMarcarConsulta_Click_1);
            // 
            // BtnMenuConsulta
            // 
            this.BtnMenuConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenuConsulta.FlatAppearance.BorderSize = 0;
            this.BtnMenuConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuConsulta.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMenuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuConsulta.Image")));
            this.BtnMenuConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenuConsulta.Location = new System.Drawing.Point(0, 45);
            this.BtnMenuConsulta.Name = "BtnMenuConsulta";
            this.BtnMenuConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnMenuConsulta.Size = new System.Drawing.Size(250, 45);
            this.BtnMenuConsulta.TabIndex = 1;
            this.BtnMenuConsulta.Text = "Consulta";
            this.BtnMenuConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuConsulta.UseVisualStyleBackColor = true;
            this.BtnMenuConsulta.Click += new System.EventHandler(this.BtnMenuConsulta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 45);
            this.panelLogo.TabIndex = 0;
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.painelSideMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "FormTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormTelaPrincipal_Load);
            this.painelSideMenu.ResumeLayout(false);
            this.PanelUsuarios.ResumeLayout(false);
            this.painelSubMenuMedicos.ResumeLayout(false);
            this.painelSubMenuPaciente.ResumeLayout(false);
            this.painelSubMenuConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel painelSideMenu;
        private System.Windows.Forms.Panel painelSubMenuConsulta;
        private System.Windows.Forms.Button BtnMenuConsulta;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button BtnConsultaPorTipo;
        private System.Windows.Forms.Button btnAgendaEDisponibilidade;
        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button BtnMenuPacientes;
        private System.Windows.Forms.Panel painelSubMenuPaciente;
        private System.Windows.Forms.Button btnConsultasMarcadas;
        private System.Windows.Forms.Button btnConsultarDados;
        private System.Windows.Forms.Button btnCadastrarPacientes;
        private System.Windows.Forms.Panel painelSubMenuMedicos;
        private System.Windows.Forms.Button btnAtendimentos;
        private System.Windows.Forms.Button btnConsultarAgenda;
        private System.Windows.Forms.Button btnCadastrarMedicos;
        private System.Windows.Forms.Button BtnMenuMedicos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel PanelUsuarios;
        private System.Windows.Forms.Button BtnControleDeUsuarios;
        private System.Windows.Forms.Button btnMenuUsuario;
    }
}

