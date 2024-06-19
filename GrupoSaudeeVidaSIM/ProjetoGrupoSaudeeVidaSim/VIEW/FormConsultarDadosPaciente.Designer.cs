namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormConsultarDadosPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarDadosPaciente));
            this.labIdFormConsultarDados = new System.Windows.Forms.Label();
            this.PainelFormConsultarDados = new System.Windows.Forms.Panel();
            this.btnConsultarFormConsultarDados = new System.Windows.Forms.Button();
            this.listViewFormConsultarDados = new System.Windows.Forms.ListView();
            this.txtNomeFormConsultarDados = new System.Windows.Forms.TextBox();
            this.labNomeFormConsultarDados = new System.Windows.Forms.Label();
            this.btnConsultarFormLimparDados = new System.Windows.Forms.Button();
            this.PainelFormConsultarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // labIdFormConsultarDados
            // 
            this.labIdFormConsultarDados.AutoSize = true;
            this.labIdFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdFormConsultarDados.Location = new System.Drawing.Point(227, 9);
            this.labIdFormConsultarDados.Name = "labIdFormConsultarDados";
            this.labIdFormConsultarDados.Size = new System.Drawing.Size(508, 29);
            this.labIdFormConsultarDados.TabIndex = 0;
            this.labIdFormConsultarDados.Text = "Formulário Para Consulta de Dados Pacientes";
            // 
            // PainelFormConsultarDados
            // 
            this.PainelFormConsultarDados.Controls.Add(this.btnConsultarFormLimparDados);
            this.PainelFormConsultarDados.Controls.Add(this.btnConsultarFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.listViewFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.txtNomeFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.labNomeFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.labIdFormConsultarDados);
            this.PainelFormConsultarDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelFormConsultarDados.Location = new System.Drawing.Point(0, 0);
            this.PainelFormConsultarDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelFormConsultarDados.Name = "PainelFormConsultarDados";
            this.PainelFormConsultarDados.Size = new System.Drawing.Size(835, 562);
            this.PainelFormConsultarDados.TabIndex = 0;
            // 
            // btnConsultarFormConsultarDados
            // 
            this.btnConsultarFormConsultarDados.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFormConsultarDados.Location = new System.Drawing.Point(155, 482);
            this.btnConsultarFormConsultarDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarFormConsultarDados.Name = "btnConsultarFormConsultarDados";
            this.btnConsultarFormConsultarDados.Size = new System.Drawing.Size(183, 46);
            this.btnConsultarFormConsultarDados.TabIndex = 7;
            this.btnConsultarFormConsultarDados.Text = "Consultar Dados";
            this.btnConsultarFormConsultarDados.UseVisualStyleBackColor = false;
            this.btnConsultarFormConsultarDados.Click += new System.EventHandler(this.btnConsultarFormConsultarDados_Click);
            // 
            // listViewFormConsultarDados
            // 
            this.listViewFormConsultarDados.HideSelection = false;
            this.listViewFormConsultarDados.Location = new System.Drawing.Point(22, 127);
            this.listViewFormConsultarDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewFormConsultarDados.Name = "listViewFormConsultarDados";
            this.listViewFormConsultarDados.Size = new System.Drawing.Size(781, 341);
            this.listViewFormConsultarDados.TabIndex = 6;
            this.listViewFormConsultarDados.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomeFormConsultarDados
            // 
            this.txtNomeFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFormConsultarDados.Location = new System.Drawing.Point(85, 74);
            this.txtNomeFormConsultarDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFormConsultarDados.Name = "txtNomeFormConsultarDados";
            this.txtNomeFormConsultarDados.Size = new System.Drawing.Size(718, 26);
            this.txtNomeFormConsultarDados.TabIndex = 5;
            // 
            // labNomeFormConsultarDados
            // 
            this.labNomeFormConsultarDados.AutoSize = true;
            this.labNomeFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeFormConsultarDados.Location = new System.Drawing.Point(18, 78);
            this.labNomeFormConsultarDados.Name = "labNomeFormConsultarDados";
            this.labNomeFormConsultarDados.Size = new System.Drawing.Size(58, 20);
            this.labNomeFormConsultarDados.TabIndex = 4;
            this.labNomeFormConsultarDados.Text = "Nome:";
            // 
            // btnConsultarFormLimparDados
            // 
            this.btnConsultarFormLimparDados.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFormLimparDados.Location = new System.Drawing.Point(420, 482);
            this.btnConsultarFormLimparDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarFormLimparDados.Name = "btnConsultarFormLimparDados";
            this.btnConsultarFormLimparDados.Size = new System.Drawing.Size(183, 46);
            this.btnConsultarFormLimparDados.TabIndex = 8;
            this.btnConsultarFormLimparDados.Text = "Limpar dados";
            this.btnConsultarFormLimparDados.UseVisualStyleBackColor = false;
            this.btnConsultarFormLimparDados.Click += new System.EventHandler(this.btnConsultarFormLimparDados_Click);
            // 
            // FormConsultarDadosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 562);
            this.Controls.Add(this.PainelFormConsultarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(849, 596);
            this.Name = "FormConsultarDadosPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Consulta de Dados Pacientes";
            this.Load += new System.EventHandler(this.FormConsultarDadosPaciente_Load);
            this.PainelFormConsultarDados.ResumeLayout(false);
            this.PainelFormConsultarDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labIdFormConsultarDados;
        private System.Windows.Forms.Panel PainelFormConsultarDados;
        private System.Windows.Forms.TextBox txtNomeFormConsultarDados;
        private System.Windows.Forms.Label labNomeFormConsultarDados;
        private System.Windows.Forms.ListView listViewFormConsultarDados;
        private System.Windows.Forms.Button btnConsultarFormConsultarDados;
        private System.Windows.Forms.Button btnConsultarFormLimparDados;
    }
}