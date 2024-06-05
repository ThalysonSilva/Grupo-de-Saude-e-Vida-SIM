namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaLogin));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labIdFormTelaLoginGrupo = new System.Windows.Forms.Label();
            this.btnNovobFormTelaLogin = new System.Windows.Forms.Button();
            this.btnSairFormTelaLogin = new System.Windows.Forms.Button();
            this.btnEntrarFormTelaLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labSenhaFormTelaLogin = new System.Windows.Forms.Label();
            this.txtUsuarioFormTelaLogin = new System.Windows.Forms.TextBox();
            this.labUsuarioFormTelaLogin = new System.Windows.Forms.Label();
            this.labIdFormTelaLogin = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxLogin.Controls.Add(this.labIdFormTelaLoginGrupo);
            this.groupBoxLogin.Controls.Add(this.btnNovobFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.btnSairFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.btnEntrarFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.txtSenha);
            this.groupBoxLogin.Controls.Add(this.labSenhaFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.txtUsuarioFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.labUsuarioFormTelaLogin);
            this.groupBoxLogin.Controls.Add(this.labIdFormTelaLogin);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(3, 10);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxLogin.Size = new System.Drawing.Size(795, 475);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            // 
            // labIdFormTelaLoginGrupo
            // 
            this.labIdFormTelaLoginGrupo.AutoSize = true;
            this.labIdFormTelaLoginGrupo.ForeColor = System.Drawing.Color.Blue;
            this.labIdFormTelaLoginGrupo.Location = new System.Drawing.Point(315, 63);
            this.labIdFormTelaLoginGrupo.Name = "labIdFormTelaLoginGrupo";
            this.labIdFormTelaLoginGrupo.Size = new System.Drawing.Size(231, 25);
            this.labIdFormTelaLoginGrupo.TabIndex = 0;
            this.labIdFormTelaLoginGrupo.Text = "Grupo Vida e Saúde SIM";
            // 
            // btnNovobFormTelaLogin
            // 
            this.btnNovobFormTelaLogin.Location = new System.Drawing.Point(268, 319);
            this.btnNovobFormTelaLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNovobFormTelaLogin.Name = "btnNovobFormTelaLogin";
            this.btnNovobFormTelaLogin.Size = new System.Drawing.Size(312, 43);
            this.btnNovobFormTelaLogin.TabIndex = 6;
            this.btnNovobFormTelaLogin.Text = "Cadastros Novos Usuarios";
            this.btnNovobFormTelaLogin.UseVisualStyleBackColor = true;
            this.btnNovobFormTelaLogin.Click += new System.EventHandler(this.btnNovoFormTelaLogin_Click);
            // 
            // btnSairFormTelaLogin
            // 
            this.btnSairFormTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSairFormTelaLogin.Location = new System.Drawing.Point(268, 399);
            this.btnSairFormTelaLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSairFormTelaLogin.Name = "btnSairFormTelaLogin";
            this.btnSairFormTelaLogin.Size = new System.Drawing.Size(312, 43);
            this.btnSairFormTelaLogin.TabIndex = 7;
            this.btnSairFormTelaLogin.Text = "Sair";
            this.btnSairFormTelaLogin.UseVisualStyleBackColor = false;
            this.btnSairFormTelaLogin.Click += new System.EventHandler(this.btnSairFormTelaLogin_Click);
            // 
            // btnEntrarFormTelaLogin
            // 
            this.btnEntrarFormTelaLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEntrarFormTelaLogin.Location = new System.Drawing.Point(268, 242);
            this.btnEntrarFormTelaLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEntrarFormTelaLogin.Name = "btnEntrarFormTelaLogin";
            this.btnEntrarFormTelaLogin.Size = new System.Drawing.Size(312, 43);
            this.btnEntrarFormTelaLogin.TabIndex = 5;
            this.btnEntrarFormTelaLogin.Text = "Efetuar Login";
            this.btnEntrarFormTelaLogin.UseVisualStyleBackColor = false;
            this.btnEntrarFormTelaLogin.Click += new System.EventHandler(this.btnEntrarFormTelaLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(268, 193);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(312, 32);
            this.txtSenha.TabIndex = 4;
            // 
            // labSenhaFormTelaLogin
            // 
            this.labSenhaFormTelaLogin.AutoSize = true;
            this.labSenhaFormTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSenhaFormTelaLogin.Location = new System.Drawing.Point(389, 196);
            this.labSenhaFormTelaLogin.Name = "labSenhaFormTelaLogin";
            this.labSenhaFormTelaLogin.Size = new System.Drawing.Size(76, 25);
            this.labSenhaFormTelaLogin.TabIndex = 3;
            this.labSenhaFormTelaLogin.Text = "Senha:";
            // 
            // txtUsuarioFormTelaLogin
            // 
            this.txtUsuarioFormTelaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioFormTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioFormTelaLogin.Location = new System.Drawing.Point(268, 121);
            this.txtUsuarioFormTelaLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtUsuarioFormTelaLogin.Name = "txtUsuarioFormTelaLogin";
            this.txtUsuarioFormTelaLogin.Size = new System.Drawing.Size(312, 32);
            this.txtUsuarioFormTelaLogin.TabIndex = 2;
            // 
            // labUsuarioFormTelaLogin
            // 
            this.labUsuarioFormTelaLogin.AutoSize = true;
            this.labUsuarioFormTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioFormTelaLogin.Location = new System.Drawing.Point(384, 121);
            this.labUsuarioFormTelaLogin.Name = "labUsuarioFormTelaLogin";
            this.labUsuarioFormTelaLogin.Size = new System.Drawing.Size(85, 25);
            this.labUsuarioFormTelaLogin.TabIndex = 1;
            this.labUsuarioFormTelaLogin.Text = "Usuário:";
            // 
            // labIdFormTelaLogin
            // 
            this.labIdFormTelaLogin.AutoSize = true;
            this.labIdFormTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdFormTelaLogin.Location = new System.Drawing.Point(351, 25);
            this.labIdFormTelaLogin.Name = "labIdFormTelaLogin";
            this.labIdFormTelaLogin.Size = new System.Drawing.Size(162, 32);
            this.labIdFormTelaLogin.TabIndex = 0;
            this.labIdFormTelaLogin.Text = "Bem-Vindo ";
            this.labIdFormTelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(804, 485);
            this.Controls.Add(this.groupBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 484);
            this.Name = "FormTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labUsuarioFormTelaLogin;
        private System.Windows.Forms.TextBox txtUsuarioFormTelaLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labSenhaFormTelaLogin;
        private System.Windows.Forms.Button btnSairFormTelaLogin;
        private System.Windows.Forms.Button btnEntrarFormTelaLogin;
        private System.Windows.Forms.Label labIdFormTelaLogin;
        private System.Windows.Forms.Button btnNovobFormTelaLogin;
        private System.Windows.Forms.Label labIdFormTelaLoginGrupo;
    }
}