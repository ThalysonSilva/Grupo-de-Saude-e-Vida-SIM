﻿namespace ProjetoGrupoSaudeeVidaSim
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
            this.maskedTextBoxCpfFormConsultarDados = new System.Windows.Forms.MaskedTextBox();
            this.labCpfFormConsultarDados = new System.Windows.Forms.Label();
            this.PainelFormConsultarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // labIdFormConsultarDados
            // 
            this.labIdFormConsultarDados.AutoSize = true;
            this.labIdFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdFormConsultarDados.Location = new System.Drawing.Point(226, 9);
            this.labIdFormConsultarDados.Name = "labIdFormConsultarDados";
            this.labIdFormConsultarDados.Size = new System.Drawing.Size(598, 32);
            this.labIdFormConsultarDados.TabIndex = 0;
            this.labIdFormConsultarDados.Text = "Formulário Para Consulta de Dados Pacientes";
            // 
            // PainelFormConsultarDados
            // 
            this.PainelFormConsultarDados.Controls.Add(this.btnConsultarFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.listViewFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.txtNomeFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.labNomeFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.maskedTextBoxCpfFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.labCpfFormConsultarDados);
            this.PainelFormConsultarDados.Controls.Add(this.labIdFormConsultarDados);
            this.PainelFormConsultarDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelFormConsultarDados.Location = new System.Drawing.Point(0, 0);
            this.PainelFormConsultarDados.Name = "PainelFormConsultarDados";
            this.PainelFormConsultarDados.Size = new System.Drawing.Size(828, 546);
            this.PainelFormConsultarDados.TabIndex = 1;
            // 
            // btnConsultarFormConsultarDados
            // 
            this.btnConsultarFormConsultarDados.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFormConsultarDados.Location = new System.Drawing.Point(542, 476);
            this.btnConsultarFormConsultarDados.Name = "btnConsultarFormConsultarDados";
            this.btnConsultarFormConsultarDados.Size = new System.Drawing.Size(220, 45);
            this.btnConsultarFormConsultarDados.TabIndex = 6;
            this.btnConsultarFormConsultarDados.Text = "Consultar Dados";
            this.btnConsultarFormConsultarDados.UseVisualStyleBackColor = false;
            // 
            // listViewFormConsultarDados
            // 
            this.listViewFormConsultarDados.HideSelection = false;
            this.listViewFormConsultarDados.Location = new System.Drawing.Point(93, 181);
            this.listViewFormConsultarDados.Name = "listViewFormConsultarDados";
            this.listViewFormConsultarDados.Size = new System.Drawing.Size(669, 268);
            this.listViewFormConsultarDados.TabIndex = 5;
            this.listViewFormConsultarDados.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomeFormConsultarDados
            // 
            this.txtNomeFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFormConsultarDados.Location = new System.Drawing.Point(93, 131);
            this.txtNomeFormConsultarDados.Name = "txtNomeFormConsultarDados";
            this.txtNomeFormConsultarDados.Size = new System.Drawing.Size(669, 30);
            this.txtNomeFormConsultarDados.TabIndex = 4;
            // 
            // labNomeFormConsultarDados
            // 
            this.labNomeFormConsultarDados.AutoSize = true;
            this.labNomeFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeFormConsultarDados.Location = new System.Drawing.Point(17, 136);
            this.labNomeFormConsultarDados.Name = "labNomeFormConsultarDados";
            this.labNomeFormConsultarDados.Size = new System.Drawing.Size(70, 25);
            this.labNomeFormConsultarDados.TabIndex = 3;
            this.labNomeFormConsultarDados.Text = "Nome:";
            // 
            // maskedTextBoxCpfFormConsultarDados
            // 
            this.maskedTextBoxCpfFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCpfFormConsultarDados.Location = new System.Drawing.Point(93, 65);
            this.maskedTextBoxCpfFormConsultarDados.Mask = "000.000.000-00";
            this.maskedTextBoxCpfFormConsultarDados.Name = "maskedTextBoxCpfFormConsultarDados";
            this.maskedTextBoxCpfFormConsultarDados.Size = new System.Drawing.Size(152, 30);
            this.maskedTextBoxCpfFormConsultarDados.TabIndex = 2;
            // 
            // labCpfFormConsultarDados
            // 
            this.labCpfFormConsultarDados.AutoSize = true;
            this.labCpfFormConsultarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCpfFormConsultarDados.Location = new System.Drawing.Point(12, 65);
            this.labCpfFormConsultarDados.Name = "labCpfFormConsultarDados";
            this.labCpfFormConsultarDados.Size = new System.Drawing.Size(58, 25);
            this.labCpfFormConsultarDados.TabIndex = 1;
            this.labCpfFormConsultarDados.Text = "CPF:";
            // 
            // FormConsultarDadosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(828, 544);
            this.Controls.Add(this.PainelFormConsultarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormConsultarDadosPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Consulta de Dados Pacientes";
            this.PainelFormConsultarDados.ResumeLayout(false);
            this.PainelFormConsultarDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labIdFormConsultarDados;
        private System.Windows.Forms.Panel PainelFormConsultarDados;
        private System.Windows.Forms.Label labCpfFormConsultarDados;
        private System.Windows.Forms.TextBox txtNomeFormConsultarDados;
        private System.Windows.Forms.Label labNomeFormConsultarDados;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfFormConsultarDados;
        private System.Windows.Forms.ListView listViewFormConsultarDados;
        private System.Windows.Forms.Button btnConsultarFormConsultarDados;
    }
}