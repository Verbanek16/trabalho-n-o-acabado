using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PetShopCli petshop = new PetShopCli();
            petshop.InserirCli(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtCelular.Text,txtEmail.Text,txtDataNascimento.Text);
            MessageBox.Show("Cliente inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetShopCli> cliente = 
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtDataNascimento.Text = "";
        }
    }
}
