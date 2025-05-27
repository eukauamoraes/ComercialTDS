using ComercialTDSClass;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bntGravar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                // INSERIR
                if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty && cmbNivel.SelectedItem != null)
                {
                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado, true);
                    usuario.Inserir();

                    if (usuario.Id > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        //btnGravar.Enabled = false;
                    }
                }


            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

