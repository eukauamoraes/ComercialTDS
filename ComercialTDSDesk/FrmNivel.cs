using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text == string.Empty && txtSigla.Text != string.Empty)
                { }
                Nivel nivel = new(txtNome.Text, txtSigla.Text);
                nivel.Inserir();
                if (nivel.Id > 0)
                {
                    MessageBox.Show($"Nivel cadastrado com sucesso");

                    btnGravar.Enabled = false;
                }

            }
            else
            {
                Nivel nivel = new Nivel(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
                if (nivel.Atualizar())
                {

                    MessageBox.Show($"Nivel atualizado com sucesso!");
                    btnGravar.Enabled = false;

                }
            }
            carregagGrid();
            LimpaControles();
        }

        private void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();

        }
        private void carregagGrid()
        {
            var niveis = Nivel.ObterLista();
            int linha = 0;
            dgvNiveis.Rows.Clear();
            foreach (var nivel in niveis)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = nivel.Id;
                dgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;
                linha++;
            }
        }


        private void dgvNiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // recuperando o indice da linha do grid
            int linha = dgvNiveis.CurrentRow.Index;
            // recuperando o id do nivel na coluna, oculta, ID (0)
            int id = Convert.ToInt32(dgvNiveis.Rows[linha].Cells[0].Value);
            //obert o objeto nivel
            var nivel = Nivel.ObterPorId(id);
            // Atribuindo os dados aos Controles
            txtId.Text = nivel.Id.ToString();
            txtNome.Text = nivel.Nome;
            txtSigla.Text = nivel.Sigla;
            txtNome.ReadOnly = true;
            txtSigla.ReadOnly = true;
            btnEditar.Enabled = true;


            // MessageBox.Show({$"nivel.Id} {nivel.Nome} {nivel.Sigla}");
        }

        private void dgvNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtSigla.ReadOnly = false;
            btnGravar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {

        }
    }
}

        

        
        
          

