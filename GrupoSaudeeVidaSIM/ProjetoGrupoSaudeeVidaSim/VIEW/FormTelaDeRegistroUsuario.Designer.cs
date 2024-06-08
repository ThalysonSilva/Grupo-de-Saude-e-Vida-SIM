namespace ProjetoGrupoSaudeeVidaSim
{
    partial class FormTelaDeRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaDeRegistroUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.labSenhaFormTelaRegistroUser = new System.Windows.Forms.Label();
            this.labConfSenhaFormTelaRegistroUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labUsuarioFormTelaRegistroUser = new System.Windows.Forms.Label();
            this.labIdFormRegistroUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtConfSenha);
            this.groupBox1.Controls.Add(this.labSenhaFormTelaRegistroUser);
            this.groupBox1.Controls.Add(this.labConfSenhaFormTelaRegistroUser);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.labUsuarioFormTelaRegistroUser);
            this.groupBox1.Controls.Add(this.labIdFormRegistroUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(874, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalvar.Location = new System.Drawing.Point(300, 325);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(296, 54);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(298, 181);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(298, 32);
            this.txtSenha.TabIndex = 4;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.Location = new System.Drawing.Point(298, 249);
            this.txtConfSenha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(298, 32);
            this.txtConfSenha.TabIndex = 4;
            // 
            // labSenhaFormTelaRegistroUser
            // 
            this.labSenhaFormTelaRegistroUser.AutoSize = true;
            this.labSenhaFormTelaRegistroUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSenhaFormTelaRegistroUser.Location = new System.Drawing.Point(208, 189);
            this.labSenhaFormTelaRegistroUser.Name = "labSenhaFormTelaRegistroUser";
            this.labSenhaFormTelaRegistroUser.Size = new System.Drawing.Size(76, 25);
            this.labSenhaFormTelaRegistroUser.TabIndex = 3;
            this.labSenhaFormTelaRegistroUser.Text = "Senha:";
            // 
            // labConfSenhaFormTelaRegistroUser
            // 
            this.labConfSenhaFormTelaRegistroUser.AutoSize = true;
            this.labConfSenhaFormTelaRegistroUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfSenhaFormTelaRegistroUser.Location = new System.Drawing.Point(111, 258);
            this.labConfSenhaFormTelaRegistroUser.Name = "labConfSenhaFormTelaRegistroUser";
            this.labConfSenhaFormTelaRegistroUser.Size = new System.Drawing.Size(166, 25);
            this.labConfSenhaFormTelaRegistroUser.TabIndex = 3;
            this.labConfSenhaFormTelaRegistroUser.Text = "Confirmar Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(300, 119);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(296, 32);
            this.txtUsuario.TabIndex = 2;

            // 
            // labUsuarioFormTelaRegistroUser
            // 
            this.labUsuarioFormTelaRegistroUser.AutoSize = true;
            this.labUsuarioFormTelaRegistroUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuarioFormTelaRegistroUser.Location = new System.Drawing.Point(198, 126);
            this.labUsuarioFormTelaRegistroUser.Name = "labUsuarioFormTelaRegistroUser";
            this.labUsuarioFormTelaRegistroUser.Size = new System.Drawing.Size(85, 25);
            this.labUsuarioFormTelaRegistroUser.TabIndex = 1;
            this.labUsuarioFormTelaRegistroUser.Text = "Usuário:";
            // 
            // labIdFormRegistroUsuario
            // 
            this.labIdFormRegistroUsuario.AutoSize = true;
            this.labIdFormRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdFormRegistroUsuario.Location = new System.Drawing.Point(342, 21);
            this.labIdFormRegistroUsuario.Name = "labIdFormRegistroUsuario";
            this.labIdFormRegistroUsuario.Size = new System.Drawing.Size(204, 26);
            this.labIdFormRegistroUsuario.TabIndex = 0;
            this.labIdFormRegistroUsuario.Text = "Registro de Usuário";
            // 
            // FormTelaDeRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 591);
            this.Name = "FormTelaDeRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Novos Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labUsuarioFormTelaRegistroUser;
        private System.Windows.Forms.Label labIdFormRegistroUsuario;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label labConfSenhaFormTelaRegistroUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labSenhaFormTelaRegistroUser;
        private System.Windows.Forms.Button btnSalvar;
    }
}