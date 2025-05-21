namespace ComercialTDSDesk
{
    partial class FrmCategoria
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(152, 102);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 225);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 18;
            label1.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 162);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Nome";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(152, 217);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(75, 23);
            txtSigla.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(152, 159);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(268, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(177, 266);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(73, 266);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            IsMdiContainer = true;
            Name = "FrmCategoria";
            Text = "Sistema Comercial TDS T01";
            WindowState = FormWindowState.Maximized;
            Load += FrmCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtSigla;
        private TextBox txtNome;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGravar;
    }
}