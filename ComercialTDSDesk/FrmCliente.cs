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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtDatanasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if(MaskCep.Text.Length == 9)
            {
                Endereco endereco = Endereco.ObterPorCep(MaskCep.Text);
                if (endereco.ClienteId > 0)
                {
                    txtLogradoura.Text = endereco.Logradouro;
                    txtNumero.Text = endereco.Numero;
                    txtComplemento.Text = endereco.Complemento;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    txtUF.Text = endereco.Uf;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado");
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty &&
                    txtEmail.Text != string.Empty
                    && txtTelefone.Text != string.Empty) ;
                {
                    Cliente cliente = new (txtNome.Text, txtCpf.Text, txtTelefone.Text,txtEmail.Text,DateTime.Parse(dateCliente.Text));

                    cliente.inserir();
                    if (cliente.Id > 0)
                    {
                        if (MaskCep.Text != string.Empty && txtLogradoura.Text != string.Empty &&
                    txtNumero.Text != string.Empty && txtComplemento.Text != string.Empty && txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && txtUF.Text
                    != string.Empty)
                        {
                            Endereco endereco = new( MaskCep.Text, txtLogradoura.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text);
                            endereco.inserir();
                            if (endereco.ClienteId > 0)
                            {
                                MessageBox.Show($"Cliente cadastrado com sucesso");

                            }
                        }
                    }
                }
            }
            else
            {
                Cliente cliente = new(txtNome.Text,txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateCliente.Text));
                if(cliente.atualizar())
     

                {
                    Endereco endereco = new(cliente.Id, MaskCep.Text, txtLogradoura.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtUF.Text);
                    endereco.atualizar();


                    MessageBox.Show("Cliente atualizado com sucesso!");


                }
            }
        }
    }
}

    