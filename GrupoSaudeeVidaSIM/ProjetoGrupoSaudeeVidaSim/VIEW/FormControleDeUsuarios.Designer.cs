namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormControleDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleDeUsuarios));
            this.labIdentFormControleUser = new System.Windows.Forms.Label();
            this.labUsuarioFormControleUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnConsultarFormControleUser = new System.Windows.Forms.Button();
            this.btnEntrarFormControleUser = new System.Windows.Forms.Button();
            this.btnExcluirFormControleUser = new System.Windows.Forms.Button();
            this.ListViewFormControleUser = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuário = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelControleDeUsuario = new System.Windows.Forms.Panel();
            this.PanelControleDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labIdentFormControleUser
            // 
            this.labIdentFormControleUser.AutoSize = true;
            this.labIdentFormControleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdentFormControleUser.Location = new System.Drawing.Point(295, 24);
            this.labIdentFormControleUser.Name = "labIdentFormControleUser";
            this.labIdentFormControleUser.Size = new System.Drawing.Size(280, 32);
            this.labIdentFormControleUser.TabIndex = 0;
            this.labIdentFormControleUser.Text = "Controle de Usuários";
            // 
            // labUsuarioFormControleUser
            // 
            this.labUsuarioFormControleUser.AutoSize = true;
            this.labUsuarioFormControleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioFormControleUser.Location = new System.Drawing.Point(85, 106);
            this.labUsuarioFormControleUser.Name = "labUsuarioFormControleUser";
            this.labUsuarioFormControleUser.Size = new System.Drawing.Size(85, 25);
            this.labUsuarioFormControleUser.TabIndex = 3;
            this.labUsuarioFormControleUser.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(176, 103);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(509, 28);
            this.txtUsuario.TabIndex = 4;
            // 
            // btnConsultarFormControleUser
            // 
            this.btnConsultarFormControleUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormControleUser.Location = new System.Drawing.Point(691, 98);
            this.btnConsultarFormControleUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarFormControleUser.Name = "btnConsultarFormControleUser";
            this.btnConsultarFormControleUser.Size = new System.Drawing.Size(176, 41);
            this.btnConsultarFormControleUser.TabIndex = 9;
            this.btnConsultarFormControleUser.Text = "Consultar";
            this.btnConsultarFormControleUser.UseVisualStyleBackColor = false;
            this.btnConsultarFormControleUser.Click += new System.EventHandler(this.btnConsultarFormControleUser_Click);
            // 
            // btnEntrarFormControleUser
            // 
            this.btnEntrarFormControleUser.Location = new System.Drawing.Point(311, 467);
            this.btnEntrarFormControleUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntrarFormControleUser.Name = "btnEntrarFormControleUser";
            this.btnEntrarFormControleUser.Size = new System.Drawing.Size(374, 41);
            this.btnEntrarFormControleUser.TabIndex = 10;
            this.btnEntrarFormControleUser.Text = "Editar Usuário";
            this.btnEntrarFormControleUser.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFormControleUser
            // 
            this.btnExcluirFormControleUser.BackColor = System.Drawing.Color.Red;
            this.btnExcluirFormControleUser.Location = new System.Drawing.Point(311, 544);
            this.btnExcluirFormControleUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirFormControleUser.Name = "btnExcluirFormControleUser";
            this.btnExcluirFormControleUser.Size = new System.Drawing.Size(374, 41);
            this.btnExcluirFormControleUser.TabIndex = 11;
            this.btnExcluirFormControleUser.Text = "Excluir Excluir";
            this.btnExcluirFormControleUser.UseVisualStyleBackColor = false;
            // 
            // ListViewFormControleUser
            // 
            this.ListViewFormControleUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Usuário});
            this.ListViewFormControleUser.HideSelection = false;
            this.ListViewFormControleUser.Location = new System.Drawing.Point(176, 175);
            this.ListViewFormControleUser.Name = "ListViewFormControleUser";
            this.ListViewFormControleUser.Size = new System.Drawing.Size(509, 200);
            this.ListViewFormControleUser.TabIndex = 12;
            this.ListViewFormControleUser.UseCompatibleStateImageBehavior = false;
            this.ListViewFormControleUser.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Usuário
            // 
            this.Usuário.Text = "Usuário";
            this.Usuário.Width = 175;
            // 
            // PanelControleDeUsuario
            // 
            this.PanelControleDeUsuario.Controls.Add(this.ListViewFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnExcluirFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnEntrarFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnConsultarFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.txtUsuario);
            this.PanelControleDeUsuario.Controls.Add(this.labUsuarioFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.labIdentFormControleUser);
            this.PanelControleDeUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControleDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelControleDeUsuario.Location = new System.Drawing.Point(0, 0);
            this.PanelControleDeUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControleDeUsuario.Name = "PanelControleDeUsuario";
            this.PanelControleDeUsuario.Size = new System.Drawing.Size(900, 692);
            this.PanelControleDeUsuario.TabIndex = 0;
            // 
            // FormControleDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 694);
            this.Controls.Add(this.PanelControleDeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormControleDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Controle de Usuários";
            this.PanelControleDeUsuario.ResumeLayout(false);
            this.PanelControleDeUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labIdentFormControleUser;
        private System.Windows.Forms.Label labUsuarioFormControleUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnConsultarFormControleUser;
        private System.Windows.Forms.Button btnEntrarFormControleUser;
        private System.Windows.Forms.Button btnExcluirFormControleUser;
        private System.Windows.Forms.ListView ListViewFormControleUser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Usuário;
        private System.Windows.Forms.Panel PanelControleDeUsuario;
    }
}