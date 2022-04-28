using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_WF
{
    public partial class Form1 : Form
    {
        decimal total = 0.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            listProduto.Items.Add(txtProduto.Text);
            listPreco.Items.Add(txtPreco.Text);

            total += decimal.Parse(txtPreco.Text);
            lblTotalVenda.Text = $"Total: {total}";

            txtPreco.Clear();
            txtProduto.Clear();
            txtProduto.Focus();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            int removerList = listProduto.SelectedIndex;
            total -= decimal.Parse(listPreco.Items[removerList].ToString());

            lblTotalVenda.Text = $"Total: {total}";

            listPreco.Items.RemoveAt(removerList);
            listProduto.Items.RemoveAt(removerList);
        }
    }
}
