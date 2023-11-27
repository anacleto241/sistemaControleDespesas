using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBCategorias();
            lista_gridDespesas();
        }

        void lista_gridDespesas()
        {
            ConectaBanco con = new ConectaBanco();
            dgDespesas.DataSource = con.listaDespesas();
            dgDespesas.Columns["despesaID"].Visible = false;
        }
        public void listaCBCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbCategoriaDespesa.DataSource = tabelaDados;
            cbCategoriaDespesa.DisplayMember = "nomeCategoria";
            cbCategoriaDespesa.ValueMember = "CategoriaID";
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

            (dgDespesas.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("descricaoDespesa like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveDespesa_Click(object sender, EventArgs e)
        {
            int linha = dgDespesas.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgDespesas.Rows[linha].Cells["despesaID"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Despesa", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaDespesa(id);
                if (retorno == true)
                {
                    MessageBox.Show("Despesa excluida com sucesso!");
                    lista_gridDespesas();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
           


        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }

        void limpaCampos()
        {
            txtdescricaodespesa.Clear();
            cbCategoriaDespesa.Text = "";
            txtvalor.Clear();
            txtdescricaodespesa.Focus();
        }
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Despesas novaDespesas = new Despesas();
            novaDespesas.DescricaoDespesa1 = txtdescricaodespesa.Text;
            novaDespesas.CategoriaID1 = Convert.ToInt32(cbCategoriaDespesa.SelectedValue.ToString());
            novaDespesas.Valor1 = Convert.ToDouble(txtvalor.Text);
            con.insereDespesas(novaDespesas);
            bool retorno = con.insereDespesas(novaDespesas);
            if (retorno == false)
                MessageBox.Show(con.mensagem);

            limpaCampos();
            lista_gridDespesas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
