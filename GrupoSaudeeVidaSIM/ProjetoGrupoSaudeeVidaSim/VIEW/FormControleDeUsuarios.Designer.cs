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
            this.btnEditarFormControleUser = new System.Windows.Forms.Button();
            this.btnExcluirFormControleUser = new System.Windows.Forms.Button();
            this.ListViewFormControleUser = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelControleDeUsuario = new System.Windows.Forms.Panel();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.txtNSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.Label();
            this.PanelControleDeUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labIdentFormControleUser
            // 
            this.labIdentFormControleUser.AutoSize = true;
            this.labIdentFormControleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdentFormControleUser.Location = new System.Drawing.Point(262, 19);
            this.labIdentFormControleUser.Name = "labIdentFormControleUser";
            this.labIdentFormControleUser.Size = new System.Drawing.Size(240, 29);
            this.labIdentFormControleUser.TabIndex = 0;
            this.labIdentFormControleUser.Text = "Controle de Usuários";
            // 
            // labUsuarioFormControleUser
            // 
            this.labUsuarioFormControleUser.AutoSize = true;
            this.labUsuarioFormControleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioFormControleUser.Location = new System.Drawing.Point(263, 63);
            this.labUsuarioFormControleUser.Name = "labUsuarioFormControleUser";
            this.labUsuarioFormControleUser.Size = new System.Drawing.Size(72, 20);
            this.labUsuarioFormControleUser.TabIndex = 1;
            this.labUsuarioFormControleUser.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(344, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(316, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnConsultarFormControleUser
            // 
            this.btnConsultarFormControleUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConsultarFormControleUser.Location = new System.Drawing.Point(193, 429);
            this.btnConsultarFormControleUser.Name = "btnConsultarFormControleUser";
            this.btnConsultarFormControleUser.Size = new System.Drawing.Size(128, 39);
            this.btnConsultarFormControleUser.TabIndex = 8;
            this.btnConsultarFormControleUser.Text = "Consultar";
            this.btnConsultarFormControleUser.UseVisualStyleBackColor = false;
            this.btnConsultarFormControleUser.Click += new System.EventHandler(this.btnConsultarFormControleUser_Click);
            // 
            // btnEditarFormControleUser
            // 
            this.btnEditarFormControleUser.Location = new System.Drawing.Point(360, 429);
            this.btnEditarFormControleUser.Name = "btnEditarFormControleUser";
            this.btnEditarFormControleUser.Size = new System.Drawing.Size(128, 39);
            this.btnEditarFormControleUser.TabIndex = 9;
            this.btnEditarFormControleUser.Text = "Editar Usuário";
            this.btnEditarFormControleUser.UseVisualStyleBackColor = true;
            this.btnEditarFormControleUser.Click += new System.EventHandler(this.btnEditarFormControleUser_Click);
            // 
            // btnExcluirFormControleUser
            // 
            this.btnExcluirFormControleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirFormControleUser.Location = new System.Drawing.Point(532, 429);
            this.btnExcluirFormControleUser.Name = "btnExcluirFormControleUser";
            this.btnExcluirFormControleUser.Size = new System.Drawing.Size(128, 39);
            this.btnExcluirFormControleUser.TabIndex = 10;
            this.btnExcluirFormControleUser.Text = "Excluir Excluir";
            this.btnExcluirFormControleUser.UseVisualStyleBackColor = false;
            this.btnExcluirFormControleUser.Click += new System.EventHandler(this.btnExcluirFormControleUser_Click);
            // 
            // ListViewFormControleUser
            // 
            this.ListViewFormControleUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Usuario});
            this.ListViewFormControleUser.HideSelection = false;
            this.ListViewFormControleUser.Location = new System.Drawing.Point(193, 230);
            this.ListViewFormControleUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewFormControleUser.Name = "ListViewFormControleUser";
            this.ListViewFormControleUser.Size = new System.Drawing.Size(467, 161);
            this.ListViewFormControleUser.TabIndex = 7;
            this.ListViewFormControleUser.UseCompatibleStateImageBehavior = false;
            this.ListViewFormControleUser.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuário";
            this.Usuario.Width = 175;
            // 
            // PanelControleDeUsuario
            // 
            this.PanelControleDeUsuario.Controls.Add(this.ListViewFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnExcluirFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnEditarFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.btnConsultarFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.txtCSenha);
            this.PanelControleDeUsuario.Controls.Add(this.txtNSenha);
            this.PanelControleDeUsuario.Controls.Add(this.txtUsuario);
            this.PanelControleDeUsuario.Controls.Add(this.label2);
            this.PanelControleDeUsuario.Controls.Add(this.txtNovaSenha);
            this.PanelControleDeUsuario.Controls.Add(this.labUsuarioFormControleUser);
            this.PanelControleDeUsuario.Controls.Add(this.labIdentFormControleUser);
            this.PanelControleDeUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControleDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelControleDeUsuario.Location = new System.Drawing.Point(0, 0);
            this.PanelControleDeUsuario.Name = "PanelControleDeUsuario";
            this.PanelControleDeUsuario.Size = new System.Drawing.Size(800, 554);
            this.PanelControleDeUsuario.TabIndex = 0;
            // 
            // txtCSenha
            // 
            this.txtCSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSenha.Location = new System.Drawing.Point(341, 151);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.PasswordChar = '*';
            this.txtCSenha.Size = new System.Drawing.Size(318, 23);
            this.txtCSenha.TabIndex = 6;
            // 
            // txtNSenha
            // 
            this.txtNSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSenha.Location = new System.Drawing.Point(341, 105);
            this.txtNSenha.Name = "txtNSenha";
            this.txtNSenha.PasswordChar = '*';
            this.txtNSenha.Size = new System.Drawing.Size(318, 23);
            this.txtNSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirmar Senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.AutoSize = true;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(223, 107);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(104, 20);
            this.txtNovaSenha.TabIndex = 3;
            this.txtNovaSenha.Text = "Nova Senha:";
            // 
            // FormControleDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.PanelControleDeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnEditarFormControleUser;
        private System.Windows.Forms.Button btnExcluirFormControleUser;
        private System.Windows.Forms.ListView ListViewFormControleUser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.Panel PanelControleDeUsuario;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.TextBox txtNSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNovaSenha;
    }
}