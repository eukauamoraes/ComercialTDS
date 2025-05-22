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
            button1 = new Button();
            SuspendLayout();
            // 
            // bntEntrar
            // 
            bntEntrar.Location = new Point(269, 276);
            bntEntrar.Name = "bntEntrar";
            bntEntrar.Size = new Size(75, 25);
            bntEntrar.TabIndex = 0;
            bntEntrar.Text = "&Entrar";
            bntEntrar.UseVisualStyleBackColor = true;
            bntEntrar.Click += bntEntrar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(431, 277);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 25);
            bntCancelar.TabIndex = 1;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(269, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(269, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // chkExibeSEnha
            // 
            chkExibeSEnha.AutoSize = true;
            chkExibeSEnha.Location = new Point(417, 251);
            chkExibeSEnha.Name = "chkExibeSEnha";
            chkExibeSEnha.Size = new Size(90, 20);
            chkExibeSEnha.TabIndex = 4;
            chkExibeSEnha.Text = "Exibir Senha";
            chkExibeSEnha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 97);
            label1.Name = "label1";
            label1.Size = new Size(141, 14);
            label1.TabIndex = 5;
            label1.Text = "Comercial TDS System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 127);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Acesso System";
            // 
            // button1
            // 
            button1.Location = new Point(557, 337);
            button1.Name = "button1";
            button1.Size = new Size(84, 25);
            button1.TabIndex = 7;
            button1.Text = "info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = bntEntrar;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bntCancelar;
            ClientSize = new Size(800, 480);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkExibeSEnha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(bntCancelar);
            Controls.Add(bntEntrar);
            Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Button button1;
    }
}