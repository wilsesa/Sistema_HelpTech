namespace Sistema_HelpTech
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.txtIduser = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(22, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "*Id:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(22, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "*Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(22, 140);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 19);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "*Login:";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.Location = new System.Drawing.Point(22, 195);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(74, 19);
            this.lblFone.TabIndex = 3;
            this.lblFone.Text = "Telefone";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(235, 140);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 19);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "*Senha";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(235, 195);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(54, 19);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "*Perfil";
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Funcionario"});
            this.cbPerfil.Location = new System.Drawing.Point(347, 195);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbPerfil.TabIndex = 6;
            // 
            // txtIduser
            // 
            this.txtIduser.Location = new System.Drawing.Point(113, 52);
            this.txtIduser.Name = "txtIduser";
            this.txtIduser.Size = new System.Drawing.Size(116, 20);
            this.txtIduser.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(113, 141);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(116, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(113, 195);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(116, 20);
            this.txtFone.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(347, 141);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(121, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(523, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(72, 60);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(523, 110);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(72, 60);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(523, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 60);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(598, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 60);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(598, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 60);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(598, 177);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 60);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 271);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIduser);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Help Tech - Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.TextBox txtIduser;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
    }
}