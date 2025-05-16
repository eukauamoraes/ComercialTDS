using ComercialTDSClass;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComercialTDSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            Program.UsuarioLogado = Usuario.EfatuarLogin(txtEmail.Text, txtSenha.Text);
            Close();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var host = Environment.MachineName;
            var user = Environment.UserName;
            MessageBox.Show($"Nome do pc: {host} \nUsuario: {user}");

            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MessageBox.Show(ip.ToString());

                }
                {

                }


            }
        }
    }
}

