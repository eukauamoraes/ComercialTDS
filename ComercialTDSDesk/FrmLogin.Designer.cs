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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            bntEntrar = new Button();
            bntCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkExibeSEnha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bntEntrar
            // 
            bntEntrar.Location = new Point(260, 270);
            bntEntrar.Name = "bntEntrar";
            bntEntrar.Size = new Size(75, 25);
            bntEntrar.TabIndex = 0;
            bntEntrar.Text = "&Entrar";
            bntEntrar.UseVisualStyleBackColor = true;
            bntEntrar.Click += bntEntrar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(422, 271);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 25);
            bntCancelar.TabIndex = 1;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(260, 214);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // chkExibeSEnha
            // 
            chkExibeSEnha.AutoSize = true;
            chkExibeSEnha.Location = new Point(408, 245);
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
            label1.Location = new Point(12, 457);
            label1.Name = "label1";
            label1.Size = new Size(141, 14);
            label1.TabIndex = 5;
            label1.Text = "Comercial TDS System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 94);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 6;
            label2.Text = "Acesso System";
            // 
            // button1
            // 
            button1.Location = new Point(422, 321);
            button1.Name = "button1";
            button1.Size = new Size(76, 25);
            button1.TabIndex = 7;
            button1.Text = "info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.icons8_customer_32__1_;
            pictureBox1.Location = new Point(224, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 33);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_321;
            pictureBox2.Location = new Point(223, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AcceptButton = bntEntrar;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bntCancelar;
            ClientSize = new Size(800, 480);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}