namespace ComercialTDSDesk
{
    partial class FrmNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel));
            btnGravar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvNiveis = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(68, 255);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(172, 255);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(263, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(147, 206);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(75, 23);
            txtSigla.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 151);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 214);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 9;
            label1.Text = "Sigla";
            // 
            // dgvNiveis
            // 
            dgvNiveis.AccessibleName = "";
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnSigla });
            dgvNiveis.Location = new Point(369, 80);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.Size = new Size(297, 198);
            dgvNiveis.TabIndex = 10;
            dgvNiveis.CellDoubleClick += dgvNiveis_CellDoubleClick;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Resizable = DataGridViewTriState.False;
            clnID.Visible = false;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnSigla
            // 
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 91);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 11;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 365);
            Controls.Add(txtId);
            Controls.Add(dgvNiveis);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNivel";
            Text = "FrmNivel";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnEditar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Label label2;
        private Label label1;
        private DataGridView dgvNiveis;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
        private TextBox txtId;
    }
}