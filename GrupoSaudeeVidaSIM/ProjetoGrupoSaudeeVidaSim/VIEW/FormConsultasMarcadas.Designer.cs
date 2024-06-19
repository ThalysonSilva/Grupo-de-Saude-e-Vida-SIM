namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormConsultasMarcadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultasMarcadas));
            this.PanelConsultasMarcadas = new System.Windows.Forms.Panel();
            this.btnConsultarFormConsultasMarcadasPac = new System.Windows.Forms.Button();
            this.listViewFormConsultasMarcadasPac = new System.Windows.Forms.ListView();
            this.txtNomePacFormConsultasMarcadas = new System.Windows.Forms.TextBox();
            this.labNomePacFormConsultasMarcadas = new System.Windows.Forms.Label();
            this.labidFormConsultasMarcadas = new System.Windows.Forms.Label();
            this.PanelConsultasMarcadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelConsultasMarcadas
            // 
            this.PanelConsultasMarcadas.Controls.Add(this.btnConsultarFormConsultasMarcadasPac);
            this.PanelConsultasMarcadas.Controls.Add(this.listViewFormConsultasMarcadasPac);
            this.PanelConsultasMarcadas.Controls.Add(this.txtNomePacFormConsultasMarcadas);
            this.PanelConsultasMarcadas.Controls.Add(this.labNomePacFormConsultasMarcadas);
            this.PanelConsultasMarcadas.Controls.Add(this.labidFormConsultasMarcadas);
            this.PanelConsultasMarcadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConsultasMarcadas.Location = new System.Drawing.Point(0, 0);
            this.PanelConsultasMarcadas.Name = "PanelConsultasMarcadas";
            this.PanelConsultasMarcadas.Size = new System.Drawing.Size(832, 545);
            this.PanelConsultasMarcadas.TabIndex = 0;
            // 
            // btnConsultarFormConsultasMarcadasPac
            // 
            this.btnConsultarFormConsultasMarcadasPac.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormConsultasMarcadasPac.Location = new System.Drawing.Point(300, 473);
            this.btnConsultarFormConsultasMarcadasPac.Name = "btnConsultarFormConsultasMarcadasPac";
            this.btnConsultarFormConsultasMarcadasPac.Size = new System.Drawing.Size(191, 45);
            this.btnConsultarFormConsultasMarcadasPac.TabIndex = 6;
            this.btnConsultarFormConsultasMarcadasPac.Text = "Consultar";
            this.btnConsultarFormConsultasMarcadasPac.UseVisualStyleBackColor = false;
            this.btnConsultarFormConsultasMarcadasPac.Click += new System.EventHandler(this.btnConsultarFormConsultasMarcadasPac_Click);
            // 
            // listViewFormConsultasMarcadasPac
            // 
            this.listViewFormConsultasMarcadasPac.HideSelection = false;
            this.listViewFormConsultasMarcadasPac.Location = new System.Drawing.Point(16, 114);
            this.listViewFormConsultasMarcadasPac.Name = "listViewFormConsultasMarcadasPac";
            this.listViewFormConsultasMarcadasPac.Size = new System.Drawing.Size(795, 338);
            this.listViewFormConsultasMarcadasPac.TabIndex = 5;
            this.listViewFormConsultasMarcadasPac.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomePacFormConsultasMarcadas
            // 
            this.txtNomePacFormConsultasMarcadas.Location = new System.Drawing.Point(201, 72);
            this.txtNomePacFormConsultasMarcadas.Name = "txtNomePacFormConsultasMarcadas";
            this.txtNomePacFormConsultasMarcadas.Size = new System.Drawing.Size(610, 26);
            this.txtNomePacFormConsultasMarcadas.TabIndex = 4;
            // 
            // labNomePacFormConsultasMarcadas
            // 
            this.labNomePacFormConsultasMarcadas.AutoSize = true;
            this.labNomePacFormConsultasMarcadas.Location = new System.Drawing.Point(12, 72);
            this.labNomePacFormConsultasMarcadas.Name = "labNomePacFormConsultasMarcadas";
            this.labNomePacFormConsultasMarcadas.Size = new System.Drawing.Size(151, 20);
            this.labNomePacFormConsultasMarcadas.TabIndex = 3;
            this.labNomePacFormConsultasMarcadas.Text = "Nome do Paciente:";
            // 
            // labidFormConsultasMarcadas
            // 
            this.labidFormConsultasMarcadas.AutoSize = true;
            this.labidFormConsultasMarcadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labidFormConsultasMarcadas.Location = new System.Drawing.Point(155, 9);
            this.labidFormConsultasMarcadas.Name = "labidFormConsultasMarcadas";
            this.labidFormConsultasMarcadas.Size = new System.Drawing.Size(518, 29);
            this.labidFormConsultasMarcadas.TabIndex = 0;
            this.labidFormConsultasMarcadas.Text = "Formulário de Consultas Agendadas - Paciente";
            // 
            // FormConsultasMarcadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.PanelConsultasMarcadas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormConsultasMarcadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Consultas Agendadas - Paciente";
            this.PanelConsultasMarcadas.ResumeLayout(false);
            this.PanelConsultasMarcadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConsultasMarcadas;
        private System.Windows.Forms.Label labidFormConsultasMarcadas;
        private System.Windows.Forms.TextBox txtNomePacFormConsultasMarcadas;
        private System.Windows.Forms.Label labNomePacFormConsultasMarcadas;
        private System.Windows.Forms.Button btnConsultarFormConsultasMarcadasPac;
        private System.Windows.Forms.ListView listViewFormConsultasMarcadasPac;
    }
}