
using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoGrupoSaudeeVidaSim
{
    public partial class FormControleDeUsuarios : Form
    {
        private AutenticacaoDAO conexaoAutenticacaoDAO;

        public FormControleDeUsuarios()
        {
            InitializeComponent();
            conexaoAutenticacaoDAO = new AutenticacaoDAO();
        }

        private void btnConsultarFormControleUser_Click(object sender, EventArgs e)
        {
            // Dados estáticos para testar o ListView
            List<Autenticacao> usuarios = new List<Autenticacao>
            {
                new Autenticacao(1, "Admin", "", ""),
                new Autenticacao(2, "Jailton.Morais", "", ""),
                new Autenticacao(3, "OutroUsuario", "", "")
            };

            AtualizarListView(usuarios);
        }

        private void AtualizarListView(List<Autenticacao> usuarios)
        {
            ListViewFormControleUser.Items.Clear();
            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Usuario);

                // Debug: Verificar se os itens estão sendo adicionados corretamente
                Console.WriteLine($"ListViewItem - ID: {usuario.Id}, Usuario: {usuario.Usuario}");
                MessageBox.Show($"ListViewItem - ID: {usuario.Id}, Usuario: {usuario.Usuario}");

                ListViewFormControleUser.Items.Add(item);
            }
        }
    }
}

    