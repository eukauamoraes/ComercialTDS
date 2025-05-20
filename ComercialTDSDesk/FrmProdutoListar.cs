using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmProdutoListar : Form
    {
        public FrmProdutoListar()
        {
            InitializeComponent();
        }

        private void FrmProdutoListar_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            int linha = 0;
            dgvProduto.Rows.Clear();
            foreach (var item in lista)
            {
                dgvProduto.Rows.Add();
                dgvProduto.Rows[linha].Cells[0].Value = item.id;
                dgvProduto.Rows[linha].Cells[1].Value = item.CodBarras;
                dgvProduto.Rows[linha].Cells[2].Value = item.Descricao;
                dgvProduto.Rows[linha].Cells[3].Value = item.ValorUnit;
                linha++;
            }



        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
