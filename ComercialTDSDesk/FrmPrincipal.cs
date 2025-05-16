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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            Hide();
            frmLogin.ShowDialog();
            if (Program.UsuarioLogado.Id > 0)
            {
                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;


            }
            Show();

            // chamada do panel

        }
        private void AssociaPanel(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.Size = pnlCentral.Size;
            form.Controls.Clear();
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(form);

            form.Show();
            pnlCentral.Visible = true;
        }


        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLlogin = new();
            frmLlogin.bntCancelar.Text = "Sair";
            frmLlogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
        }

        private void tsslUsuarioLogado_Click(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void niveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNivel frmNivel = new FrmNivel();
            //frmNivel.MdiParent = this;
            //frmNivel.Show();
            AssociaPanel(new FrmNivel());
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmNivel());
        }
    }
}
