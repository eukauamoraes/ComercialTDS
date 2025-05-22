namespace ComercialTDSDesk
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntGravar = new Button();
            bntEditar = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtId = new TextBox();
            cmbNivel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bntCancelar = new Button();
            dgvUsuarios = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // bntGravar
            // 
            bntGravar.Location = new Point(240, 176);
            bntGravar.Name = "bntGravar";
            bntGravar.Size = new Size(75, 23);
            bntGravar.TabIndex = 0;
            bntGravar.Text = "&Gravar";
            bntGravar.UseVisualStyleBackColor = true;
            bntGravar.Click += bntGravar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(333, 176);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(65, 23);
            bntEditar.TabIndex = 1;
            bntEditar.Text = "&Editar";
            bntEditar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(240, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(240, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(133, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(240, 137);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(133, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(240, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Items.AddRange(new object[] { "Administradir", "Caixa" });
            cmbNivel.Location = new Point(379, 79);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(96, 23);
            cmbNivel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 58);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "Id";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 111);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 111);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 140);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Senha";
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(422, 176);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(63, 23);
            bntCancelar.TabIndex = 13;
            bntCancelar.Text = "&Cancelar ";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clmId, clnNome, clnEmail, clnNivel });
            dgvUsuarios.Location = new Point(198, 221);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(303, 150);
            dgvUsuarios.TabIndex = 14;
            // 
            // clmId
            // 
            clmId.HeaderText = "Id";
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            clmId.Visible = false;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnNivel
            // 
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 58);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 15;
            label6.Text = "Nivel";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 436);
            Controls.Add(label6);
            Controls.Add(dgvUsuarios);
            Controls.Add(bntCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbNivel);
            Controls.Add(txtId);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(bntEditar);
            Controls.Add(bntGravar);
            Name = "FrmUsuario";
            Text = "FrmUsuarios";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntGravar;
        private Button bntEditar;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtId;
        private ComboBox cmbNivel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button bntCancelar;
        private DataGridView dgvUsuarios;
        private Label label6;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
    }
}