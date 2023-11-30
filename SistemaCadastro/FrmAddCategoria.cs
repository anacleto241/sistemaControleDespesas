using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddCategoria : Form
    {
        int idAlterar;
        public FrmAddCategoria()
        {
            InitializeComponent();
            lista_gridCategorias();
        }
        private void Sistema_Load(object sender, EventArgs e)
        {
            lista_gridCategorias();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            this.Hide();
            formSistema.ShowDialog();
            this.Close();

        }
        void limpaCampos()
        {
            txtNomeCategoria.Clear();
            txtDescricaoCategoria.Clear();
            txtNomeCategoria.Focus();
        }
        private void BtnConfirmaCadastro_Click_1(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            CategoriaDespesas novaCategoria = new CategoriaDespesas();
            novaCategoria.NomeCategoria = txtNomeCategoria.Text;
            novaCategoria.DescricaoCategoria = txtDescricaoCategoria.Text;
            bool retorno = con.insereCategoriaDespesas(novaCategoria);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }

            limpaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        void lista_gridCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            dgCategorias.DataSource = con.listaCategorias();
            dgCategorias.Columns["categoriaID"].Visible = false;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgCategorias.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("nomeCategoria like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveCategoria_Click(object sender, EventArgs e)
        {
            int linha = dgCategorias.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgCategorias.Rows[linha].Cells["categoriaID"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Categoria", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaCategoria(id);
                if (retorno == true)
                {
                    MessageBox.Show("Categoria excluida com sucesso!");
                    lista_gridCategorias();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            int linha = dgCategorias.CurrentRow.Index;
            idAlterar = Convert.ToInt32(
                                   dgCategorias.Rows[linha].Cells["categoriaID"].Value.ToString());
            txtAlteraNome.Text = dgCategorias.Rows[linha].Cells["nomeCategoria"].Value.ToString();
            txtAlteraDescricao.Text = dgCategorias.Rows[linha].Cells["descricaoCategoria"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            CategoriaDespesas novaCategoria = new CategoriaDespesas();
            novaCategoria.NomeCategoria = txtAlteraNome.Text;
            novaCategoria.DescricaoCategoria = txtAlteraDescricao.Text;
            bool retorno = con.alteraCategoria(novaCategoria, idAlterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Despesa alterada com sucesso!");
            lista_gridCategorias();
        }
    }
}
