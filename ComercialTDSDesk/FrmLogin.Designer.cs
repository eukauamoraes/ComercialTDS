namespace ComercialTDSDesk
{
    partial class FrmLogin
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
            bntEntrar = new Button();
            bntCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkExibeSEnha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bntEntrar
            // 
            bntEntrar.Location = new Point(226, 196);
            bntEntrar.Name = "bntEntrar";
            bntEntrar.Size = new Size(75, 23);
            bntEntrar.TabIndex = 0;
            bntEntrar.Text = "&Entrar";
            bntEntrar.UseVisualStyleBackColor = true;
            bntEntrar.Click += bntEntrar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(388, 197);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 23);
            bntCancelar.TabIndex = 1;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(226, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // chkExibeSEnha
            // 
            chkExibeSEnha.AutoSize = true;
            chkExibeSEnha.Location = new Point(374, 172);
            chkExibeSEnha.Name = "chkExibeSEnha";
            chkExibeSEnha.Size = new Size(89, 19);
            chkExibeSEnha.TabIndex = 4;
            chkExibeSEnha.Text = "Exibir Senha";
            chkExibeSEnha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 14);
            label1.TabIndex = 5;
            label1.Text = "Comercial TDS System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 60);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Acesso System";
            // 
            // FrmLogin
            // 
            AcceptButton = bntEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bntCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkExibeSEnha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(bntCancelar);
            Controls.Add(bntEntrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntEntrar;
        public Button bntCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkExibeSEnha;
        private Label label1;
        private Label label2;
    }
}