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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void adicionarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdicionarFunc func = new FormAdicionarFunc();
            func.ShowDialog();
        }

        private void SairSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes cli = new FormClientes();
            cli.ShowDialog();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnimais ani = new FormAnimais();
            ani.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda age = new FormAgenda();
            age.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicos serv = new FormServicos();
            serv.ShowDialog();
        }
    }
}
