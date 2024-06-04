namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormConsultarAgendaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarAgendaMedica));
            this.panelFormAgendaMed = new System.Windows.Forms.Panel();
            this.btnConsultarFormAgendaMed = new System.Windows.Forms.Button();
            this.listViewFormAgendaMed = new System.Windows.Forms.ListView();
            this.cbEspMedFormAgendaMed = new System.Windows.Forms.ComboBox();
            this.labEspMedFormAgendaMed = new System.Windows.Forms.Label();
            this.txtNomeFormAgendaMed = new System.Windows.Forms.TextBox();
            this.labNomeFormAgendaMed = new System.Windows.Forms.Label();
            this.LabIdFormAgendaMed = new System.Windows.Forms.Label();
            this.panelFormAgendaMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormAgendaMed
            // 
            this.panelFormAgendaMed.Controls.Add(this.btnConsultarFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.listViewFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.cbEspMedFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.labEspMedFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.txtNomeFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.labNomeFormAgendaMed);
            this.panelFormAgendaMed.Controls.Add(this.LabIdFormAgendaMed);
            this.panelFormAgendaMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormAgendaMed.Location = new System.Drawing.Point(0, 0);
            this.panelFormAgendaMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFormAgendaMed.Name = "panelFormAgendaMed";
            this.panelFormAgendaMed.Size = new System.Drawing.Size(932, 682);
            this.panelFormAgendaMed.TabIndex = 0;
            // 
            // btnConsultarFormAgendaMed
            // 
            this.btnConsultarFormAgendaMed.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormAgendaMed.Location = new System.Drawing.Point(642, 575);
            this.btnConsultarFormAgendaMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarFormAgendaMed.Name = "btnConsultarFormAgendaMed";
            this.btnConsultarFormAgendaMed.Size = new System.Drawing.Size(238, 56);
            this.btnConsultarFormAgendaMed.TabIndex = 10;
            this.btnConsultarFormAgendaMed.Text = "Consultar Médico Disponível";
            this.btnConsultarFormAgendaMed.UseVisualStyleBackColor = false;
            // 
            // listViewFormAgendaMed
            // 
            this.listViewFormAgendaMed.HideSelection = false;
            this.listViewFormAgendaMed.Location = new System.Drawing.Point(212, 249);
            this.listViewFormAgendaMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewFormAgendaMed.Name = "listViewFormAgendaMed";
            this.listViewFormAgendaMed.Size = new System.Drawing.Size(668, 248);
            this.listViewFormAgendaMed.TabIndex = 9;
            this.listViewFormAgendaMed.UseCompatibleStateImageBehavior = false;
            // 
            // cbEspMedFormAgendaMed
            // 
            this.cbEspMedFormAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspMedFormAgendaMed.FormattingEnabled = true;
            this.cbEspMedFormAgendaMed.Items.AddRange(new object[] {
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
            this.cbEspMedFormAgendaMed.Location = new System.Drawing.Point(212, 141);
            this.cbEspMedFormAgendaMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEspMedFormAgendaMed.Name = "cbEspMedFormAgendaMed";
            this.cbEspMedFormAgendaMed.Size = new System.Drawing.Size(470, 33);
            this.cbEspMedFormAgendaMed.TabIndex = 8;
            // 
            // labEspMedFormAgendaMed
            // 
            this.labEspMedFormAgendaMed.AutoSize = true;
            this.labEspMedFormAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspMedFormAgendaMed.Location = new System.Drawing.Point(12, 151);
            this.labEspMedFormAgendaMed.Name = "labEspMedFormAgendaMed";
            this.labEspMedFormAgendaMed.Size = new System.Drawing.Size(140, 25);
            this.labEspMedFormAgendaMed.TabIndex = 7;
            this.labEspMedFormAgendaMed.Text = "Especialidade:";
            // 
            // txtNomeFormAgendaMed
            // 
            this.txtNomeFormAgendaMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeFormAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFormAgendaMed.Location = new System.Drawing.Point(212, 72);
            this.txtNomeFormAgendaMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFormAgendaMed.Name = "txtNomeFormAgendaMed";
            this.txtNomeFormAgendaMed.Size = new System.Drawing.Size(668, 25);
            this.txtNomeFormAgendaMed.TabIndex = 4;
            // 
            // labNomeFormAgendaMed
            // 
            this.labNomeFormAgendaMed.AutoSize = true;
            this.labNomeFormAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeFormAgendaMed.Location = new System.Drawing.Point(12, 72);
            this.labNomeFormAgendaMed.Name = "labNomeFormAgendaMed";
            this.labNomeFormAgendaMed.Size = new System.Drawing.Size(166, 25);
            this.labNomeFormAgendaMed.TabIndex = 3;
            this.labNomeFormAgendaMed.Text = "Nome do Médico:";
            // 
            // LabIdFormAgendaMed
            // 
            this.LabIdFormAgendaMed.AutoSize = true;
            this.LabIdFormAgendaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabIdFormAgendaMed.Location = new System.Drawing.Point(279, 11);
            this.LabIdFormAgendaMed.Name = "LabIdFormAgendaMed";
            this.LabIdFormAgendaMed.Size = new System.Drawing.Size(369, 32);
            this.LabIdFormAgendaMed.TabIndex = 0;
            this.LabIdFormAgendaMed.Text = "Formulário Agenda Médica  ";
            // 
            // FormConsultarAgendaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(932, 680);
            this.Controls.Add(this.panelFormAgendaMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(954, 736);
            this.Name = "FormConsultarAgendaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Agenda Médica - Disponibilidade";
            this.panelFormAgendaMed.ResumeLayout(false);
            this.panelFormAgendaMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormAgendaMed;
        private System.Windows.Forms.Label LabIdFormAgendaMed;
        private System.Windows.Forms.TextBox txtNomeFormAgendaMed;
        private System.Windows.Forms.Label labNomeFormAgendaMed;
        private System.Windows.Forms.Label labEspMedFormAgendaMed;
        private System.Windows.Forms.ComboBox cbEspMedFormAgendaMed;
        private System.Windows.Forms.ListView listViewFormAgendaMed;
        private System.Windows.Forms.Button btnConsultarFormAgendaMed;
    }
}