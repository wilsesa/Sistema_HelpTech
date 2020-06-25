namespace Sistema_HelpTech
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtFrmLogin = new System.Windows.Forms.TextBox();
            this.txtFrmSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(59, 184);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(59, 222);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(64, 19);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // txtFrmLogin
            // 
            this.txtFrmLogin.BackColor = System.Drawing.Color.Silver;
            this.txtFrmLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrmLogin.Location = new System.Drawing.Point(162, 184);
            this.txtFrmLogin.Name = "txtFrmLogin";
            this.txtFrmLogin.Size = new System.Drawing.Size(203, 26);
            this.txtFrmLogin.TabIndex = 3;
            // 
            // txtFrmSenha
            // 
            this.txtFrmSenha.BackColor = System.Drawing.Color.Silver;
            this.txtFrmSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrmSenha.Location = new System.Drawing.Point(162, 214);
            this.txtFrmSenha.Name = "txtFrmSenha";
            this.txtFrmSenha.PasswordChar = '*';
            this.txtFrmSenha.Size = new System.Drawing.Size(203, 26);
            this.txtFrmSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(63, 277);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(132, 46);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar:";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(241, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 46);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair:";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 344);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtFrmSenha);
            this.Controls.Add(this.txtFrmLogin);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtFrmLogin;
        private System.Windows.Forms.TextBox txtFrmSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
    }
}