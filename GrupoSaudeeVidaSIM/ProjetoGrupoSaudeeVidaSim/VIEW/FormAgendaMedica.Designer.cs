namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormAgendaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendaMedica));
            this.PainelFormAgendaMedica = new System.Windows.Forms.Panel();
            this.btnCancelaFormAgendaMedica = new System.Windows.Forms.Button();
            this.btnEditarFormAgendaMedica = new System.Windows.Forms.Button();
            this.btnConsultarFormAgendaMedica = new System.Windows.Forms.Button();
            this.AgendaMedica = new System.Windows.Forms.Label();
            this.listViewFormAgendaMedica = new System.Windows.Forms.ListView();
            this.cbEspecialidadeFormAgendaMedica = new System.Windows.Forms.ComboBox();
            this.labEspecialidadeFormAgendaMedica = new System.Windows.Forms.Label();
            this.txtNomeMedFormAgendaMedica = new System.Windows.Forms.TextBox();
            this.labNomeMedFormAgendaMedica = new System.Windows.Forms.Label();
            this.PainelFormAgendaMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelFormAgendaMedica
            // 
            this.PainelFormAgendaMedica.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PainelFormAgendaMedica.Controls.Add(this.btnCancelaFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.btnEditarFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.btnConsultarFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.AgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.listViewFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.cbEspecialidadeFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.labEspecialidadeFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.txtNomeMedFormAgendaMedica);
            this.PainelFormAgendaMedica.Controls.Add(this.labNomeMedFormAgendaMedica);
            this.PainelFormAgendaMedica.Location = new System.Drawing.Point(5, 2);
            this.PainelFormAgendaMedica.Margin = new System.Windows.Forms.Padding(4);
            this.PainelFormAgendaMedica.Name = "PainelFormAgendaMedica";
            this.PainelFormAgendaMedica.Size = new System.Drawing.Size(822, 563);
            this.PainelFormAgendaMedica.TabIndex = 0;
            this.PainelFormAgendaMedica.Paint += new System.Windows.Forms.PaintEventHandler(this.pndAgenda_Paint);
            // 
            // btnCancelaFormAgendaMedica
            // 
            this.btnCancelaFormAgendaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelaFormAgendaMedica.Location = new System.Drawing.Point(569, 476);
            this.btnCancelaFormAgendaMedica.Name = "btnCancelaFormAgendaMedica";
            this.btnCancelaFormAgendaMedica.Size = new System.Drawing.Size(196, 52);
            this.btnCancelaFormAgendaMedica.TabIndex = 8;
            this.btnCancelaFormAgendaMedica.Text = "Cancelar Consulta";
            this.btnCancelaFormAgendaMedica.UseVisualStyleBackColor = false;
            // 
            // btnEditarFormAgendaMedica
            // 
            this.btnEditarFormAgendaMedica.Location = new System.Drawing.Point(296, 476);
            this.btnEditarFormAgendaMedica.Name = "btnEditarFormAgendaMedica";
            this.btnEditarFormAgendaMedica.Size = new System.Drawing.Size(196, 52);
            this.btnEditarFormAgendaMedica.TabIndex = 7;
            this.btnEditarFormAgendaMedica.Text = "Editar Consulta";
            this.btnEditarFormAgendaMedica.UseVisualStyleBackColor = true;
            // 
            // btnConsultarFormAgendaMedica
            // 
            this.btnConsultarFormAgendaMedica.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConsultarFormAgendaMedica.Location = new System.Drawing.Point(26, 476);
            this.btnConsultarFormAgendaMedica.Name = "btnConsultarFormAgendaMedica";
            this.btnConsultarFormAgendaMedica.Size = new System.Drawing.Size(196, 52);
            this.btnConsultarFormAgendaMedica.TabIndex = 6;
            this.btnConsultarFormAgendaMedica.Text = "Consultar Agenda";
            this.btnConsultarFormAgendaMedica.UseVisualStyleBackColor = false;
            // 
            // AgendaMedica
            // 
            this.AgendaMedica.AutoSize = true;
            this.AgendaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendaMedica.Location = new System.Drawing.Point(303, 7);
            this.AgendaMedica.Name = "AgendaMedica";
            this.AgendaMedica.Size = new System.Drawing.Size(409, 32);
            this.AgendaMedica.TabIndex = 0;
            this.AgendaMedica.Text = "Formulário de Checar - Agenda";
            // 
            // listViewFormAgendaMedica
            // 
            this.listViewFormAgendaMedica.HideSelection = false;
            this.listViewFormAgendaMedica.Location = new System.Drawing.Point(26, 171);
            this.listViewFormAgendaMedica.Name = "listViewFormAgendaMedica";
            this.listViewFormAgendaMedica.Size = new System.Drawing.Size(740, 273);
            this.listViewFormAgendaMedica.TabIndex = 5;
            this.listViewFormAgendaMedica.UseCompatibleStateImageBehavior = false;
            // 
            // cbEspecialidadeFormAgendaMedica
            // 
            this.cbEspecialidadeFormAgendaMedica.FormattingEnabled = true;
            this.cbEspecialidadeFormAgendaMedica.Items.AddRange(new object[] {
            "Cardiologia",
            "Dermatologia",
            "Gastroenterologia",
            "Geriatria",
            "Ginecologia",
            "Hematologia",
            "Infectologia",
            "Nefrologia",
            "Neurologia",
            "Oncologia",
            "Ortopedia",
            "Pediatria",
            "Psiquiatria",
            "Reumatologia",
            "Urologia"});
            this.cbEspecialidadeFormAgendaMedica.Location = new System.Drawing.Point(199, 121);
            this.cbEspecialidadeFormAgendaMedica.Name = "cbEspecialidadeFormAgendaMedica";
            this.cbEspecialidadeFormAgendaMedica.Size = new System.Drawing.Size(566, 33);
            this.cbEspecialidadeFormAgendaMedica.TabIndex = 4;
            this.cbEspecialidadeFormAgendaMedica.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadeFormAgenda_SelectedIndexChanged);
            // 
            // labEspecialidadeFormAgendaMedica
            // 
            this.labEspecialidadeFormAgendaMedica.AutoSize = true;
            this.labEspecialidadeFormAgendaMedica.Location = new System.Drawing.Point(21, 121);
            this.labEspecialidadeFormAgendaMedica.Name = "labEspecialidadeFormAgendaMedica";
            this.labEspecialidadeFormAgendaMedica.Size = new System.Drawing.Size(140, 25);
            this.labEspecialidadeFormAgendaMedica.TabIndex = 3;
            this.labEspecialidadeFormAgendaMedica.Text = "Especialidade:";
            // 
            // txtNomeMedFormAgendaMedica
            // 
            this.txtNomeMedFormAgendaMedica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeMedFormAgendaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMedFormAgendaMedica.Location = new System.Drawing.Point(199, 68);
            this.txtNomeMedFormAgendaMedica.Name = "txtNomeMedFormAgendaMedica";
            this.txtNomeMedFormAgendaMedica.Size = new System.Drawing.Size(566, 25);
            this.txtNomeMedFormAgendaMedica.TabIndex = 2;
            // 
            // labNomeMedFormAgendaMedica
            // 
            this.labNomeMedFormAgendaMedica.AutoSize = true;
            this.labNomeMedFormAgendaMedica.Location = new System.Drawing.Point(21, 68);
            this.labNomeMedFormAgendaMedica.Name = "labNomeMedFormAgendaMedica";
            this.labNomeMedFormAgendaMedica.Size = new System.Drawing.Size(166, 25);
            this.labNomeMedFormAgendaMedica.TabIndex = 1;
            this.labNomeMedFormAgendaMedica.Text = "Nome do Médico:";
            // 
            // FormAgendaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(828, 567);
            this.Controls.Add(this.PainelFormAgendaMedica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormAgendaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Paciente";
            this.PainelFormAgendaMedica.ResumeLayout(false);
            this.PainelFormAgendaMedica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelFormAgendaMedica;
        private System.Windows.Forms.TextBox txtNomeMedFormAgendaMedica;
        private System.Windows.Forms.Label labNomeMedFormAgendaMedica;
        private System.Windows.Forms.ComboBox cbEspecialidadeFormAgendaMedica;
        private System.Windows.Forms.Label labEspecialidadeFormAgendaMedica;
        private System.Windows.Forms.ListView listViewFormAgendaMedica;
        private System.Windows.Forms.Label AgendaMedica;
        private System.Windows.Forms.Button btnConsultarFormAgendaMedica;
        private System.Windows.Forms.Button btnCancelaFormAgendaMedica;
        private System.Windows.Forms.Button btnEditarFormAgendaMedica;
    }
}