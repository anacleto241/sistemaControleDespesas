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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conectaBanco = new ConectaBanco();
            if(conectaBanco.verifica(txtLogin.Text, txtSenha.Text)==true)
            {
                Sistema formSistema = new Sistema();
                this.Hide();
                formSistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!\n"+conectaBanco.mensagem);
            }
        }
    }
}
