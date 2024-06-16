using ProjetoGrupoSaudeeVidaSim.DAO;
using ProjetoGrupoSaudeeVidaSim.DTO;
using ProjetoGrupoSaudeeVidaSim.DTO.ProjetoGrupoSaudeeVidaSim.DTO;
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
            AutenticacaoDAO dao = new AutenticacaoDAO();
            List<Autenticacao> usuarios = dao.ConsultarUsuarios(txtUsuario.Text);

            AtualizarListView(usuarios);
        }

        private void AtualizarListView(List<Autenticacao> usuarios)
        {
            ListViewFormControleUser.Items.Clear();
            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Usuario);

                ListViewFormControleUser.Items.Add(item);
            }
        }


        private void btnEditarFormControleUser_Click(object sender, EventArgs e)
        {
            if (ListViewFormControleUser.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionado = ListViewFormControleUser.SelectedItems[0];
                int id;
                if (!int.TryParse(itemSelecionado.Text, out id))
                {
                    MessageBox.Show("ID do usuário inválido.");
                    return;
                }

                string usuario = itemSelecionado.SubItems[1].Text;
                string novaSenha = txtNSenha.Text.Trim();
                string confSenha = txtCSenha.Text.Trim();

                if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confSenha))
                {
                    MessageBox.Show("Os campos de senha não podem estar vazios.");
                    return;
                }

                if (novaSenha != confSenha)
                {
                    MessageBox.Show("As senhas não coincidem.");
                    return;
                }

                Autenticacao usuarioAtualizado = new Autenticacao(id, usuario, novaSenha, confSenha);
                AutenticacaoDAO dao = new AutenticacaoDAO();

                try
                {
                    dao.EditarUsuario(usuarioAtualizado);

                    // Atualizar a ListView
                    List<Autenticacao> usuarios = dao.ConsultarUsuarios(txtUsuario.Text.Trim());
                    AtualizarListView(usuarios);

                    MessageBox.Show("Usuário atualizado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }

        }

        private void btnExcluirFormControleUser_Click(object sender, EventArgs e)
        {
            if (ListViewFormControleUser.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionado = ListViewFormControleUser.SelectedItems[0];
                int id;

                if (!int.TryParse(itemSelecionado.Text, out id))
                {
                    MessageBox.Show("ID do usuário inválido.");
                    return;
                }

                // Confirmar exclusão
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AutenticacaoDAO dao = new AutenticacaoDAO();

                    try
                    {
                        dao.ExcluirUsuario(id);

                        // Atualizar a ListView
                        List<Autenticacao> usuarios = dao.ConsultarUsuarios(txtUsuario.Text.Trim());
                        AtualizarListView(usuarios);

                        MessageBox.Show("Usuário excluído com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir usuário: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.");
            }
        }
    }
}


