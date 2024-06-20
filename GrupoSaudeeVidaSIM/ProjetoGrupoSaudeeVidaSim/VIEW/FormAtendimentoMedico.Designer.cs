namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormAtendimentoMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtendimentoMedico));
            this.panelFormAtendMed = new System.Windows.Forms.Panel();
            this.btnLimparFormDiasAtendMedico = new System.Windows.Forms.Button();
            this.btnConsultarFormDiasAtendMedico = new System.Windows.Forms.Button();
            this.listViewFormDiasAtendMedico = new System.Windows.Forms.ListView();
            this.txtFormDiasAtendMedico = new System.Windows.Forms.TextBox();
            this.labFormDiasAtendMedico = new System.Windows.Forms.Label();
            this.LabIdFormAtendMed = new System.Windows.Forms.Label();
            this.panelFormAtendMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormAtendMed
            // 
            this.panelFormAtendMed.Controls.Add(this.btnLimparFormDiasAtendMedico);
            this.panelFormAtendMed.Controls.Add(this.btnConsultarFormDiasAtendMedico);
            this.panelFormAtendMed.Controls.Add(this.listViewFormDiasAtendMedico);
            this.panelFormAtendMed.Controls.Add(this.txtFormDiasAtendMedico);
            this.panelFormAtendMed.Controls.Add(this.labFormDiasAtendMedico);
            this.panelFormAtendMed.Controls.Add(this.LabIdFormAtendMed);
            this.panelFormAtendMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormAtendMed.Location = new System.Drawing.Point(0, 0);
            this.panelFormAtendMed.Name = "panelFormAtendMed";
            this.panelFormAtendMed.Size = new System.Drawing.Size(834, 544);
            this.panelFormAtendMed.TabIndex = 0;
            // 
            // btnLimparFormDiasAtendMedico
            // 
            this.btnLimparFormDiasAtendMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimparFormDiasAtendMedico.Location = new System.Drawing.Point(458, 471);
            this.btnLimparFormDiasAtendMedico.Name = "btnLimparFormDiasAtendMedico";
            this.btnLimparFormDiasAtendMedico.Size = new System.Drawing.Size(137, 45);
            this.btnLimparFormDiasAtendMedico.TabIndex = 8;
            this.btnLimparFormDiasAtendMedico.Text = "Limpar";
            this.btnLimparFormDiasAtendMedico.UseVisualStyleBackColor = false;
            this.btnLimparFormDiasAtendMedico.Click += new System.EventHandler(this.btnLimparFormDiasAtendMedico_Click);
            // 
            // btnConsultarFormDiasAtendMedico
            // 
            this.btnConsultarFormDiasAtendMedico.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormDiasAtendMedico.Location = new System.Drawing.Point(196, 471);
            this.btnConsultarFormDiasAtendMedico.Name = "btnConsultarFormDiasAtendMedico";
            this.btnConsultarFormDiasAtendMedico.Size = new System.Drawing.Size(137, 45);
            this.btnConsultarFormDiasAtendMedico.TabIndex = 8;
            this.btnConsultarFormDiasAtendMedico.Text = "Consultar";
            this.btnConsultarFormDiasAtendMedico.UseVisualStyleBackColor = false;
            this.btnConsultarFormDiasAtendMedico.Click += new System.EventHandler(this.btnConsultarFormDiasAtendMedico_Click);
            // 
            // listViewFormDiasAtendMedico
            // 
            this.listViewFormDiasAtendMedico.HideSelection = false;
            this.listViewFormDiasAtendMedico.Location = new System.Drawing.Point(16, 126);
            this.listViewFormDiasAtendMedico.Name = "listViewFormDiasAtendMedico";
            this.listViewFormDiasAtendMedico.Size = new System.Drawing.Size(784, 329);
            this.listViewFormDiasAtendMedico.TabIndex = 7;
            this.listViewFormDiasAtendMedico.UseCompatibleStateImageBehavior = false;
            // 
            // txtFormDiasAtendMedico
            // 
            this.txtFormDiasAtendMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormDiasAtendMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormDiasAtendMedico.Location = new System.Drawing.Point(158, 80);
            this.txtFormDiasAtendMedico.Name = "txtFormDiasAtendMedico";
            this.txtFormDiasAtendMedico.Size = new System.Drawing.Size(642, 25);
            this.txtFormDiasAtendMedico.TabIndex = 4;
            // 
            // labFormDiasAtendMedico
            // 
            this.labFormDiasAtendMedico.AutoSize = true;
            this.labFormDiasAtendMedico.Location = new System.Drawing.Point(12, 80);
            this.labFormDiasAtendMedico.Name = "labFormDiasAtendMedico";
            this.labFormDiasAtendMedico.Size = new System.Drawing.Size(166, 25);
            this.labFormDiasAtendMedico.TabIndex = 3;
            this.labFormDiasAtendMedico.Text = "Nome do Médico:";
            // 
            // LabIdFormAtendMed
            // 
            this.LabIdFormAtendMed.AutoSize = true;
            this.LabIdFormAtendMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabIdFormAtendMed.Location = new System.Drawing.Point(192, 9);
            this.LabIdFormAtendMed.Name = "LabIdFormAtendMed";
            this.LabIdFormAtendMed.Size = new System.Drawing.Size(572, 32);
            this.LabIdFormAtendMed.TabIndex = 0;
            this.LabIdFormAtendMed.Text = "Formulário de Checar Dias de Atendimentos";
            // 
            // FormAtendimentoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panelFormAtendMed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormAtendimentoMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Dias de Atendimentos";
            this.panelFormAtendMed.ResumeLayout(false);
            this.panelFormAtendMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormAtendMed;
        private System.Windows.Forms.Label LabIdFormAtendMed;
        private System.Windows.Forms.TextBox txtFormDiasAtendMedico;
        private System.Windows.Forms.Label labFormDiasAtendMedico;
        private System.Windows.Forms.ListView listViewFormDiasAtendMedico;
        private System.Windows.Forms.Button btnConsultarFormDiasAtendMedico;
        private System.Windows.Forms.Button btnLimparFormDiasAtendMedico;
    }
}