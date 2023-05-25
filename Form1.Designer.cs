namespace CRUD
{
    partial class Form_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_input_usuario = new System.Windows.Forms.TextBox();
            this.login_label_usuario = new System.Windows.Forms.Label();
            this.login_label_senha = new System.Windows.Forms.Label();
            this.login_input_senha = new System.Windows.Forms.TextBox();
            this.login_button_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_label_resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_input_usuario
            // 
            this.login_input_usuario.Location = new System.Drawing.Point(72, 86);
            this.login_input_usuario.Name = "login_input_usuario";
            this.login_input_usuario.Size = new System.Drawing.Size(239, 22);
            this.login_input_usuario.TabIndex = 0;
            // 
            // login_label_usuario
            // 
            this.login_label_usuario.AutoSize = true;
            this.login_label_usuario.Location = new System.Drawing.Point(12, 89);
            this.login_label_usuario.Name = "login_label_usuario";
            this.login_label_usuario.Size = new System.Drawing.Size(54, 16);
            this.login_label_usuario.TabIndex = 1;
            this.login_label_usuario.Text = "Usuário";
            // 
            // login_label_senha
            // 
            this.login_label_senha.AutoSize = true;
            this.login_label_senha.Location = new System.Drawing.Point(20, 132);
            this.login_label_senha.Name = "login_label_senha";
            this.login_label_senha.Size = new System.Drawing.Size(46, 16);
            this.login_label_senha.TabIndex = 2;
            this.login_label_senha.Text = "Senha";
            // 
            // login_input_senha
            // 
            this.login_input_senha.Location = new System.Drawing.Point(72, 129);
            this.login_input_senha.Name = "login_input_senha";
            this.login_input_senha.Size = new System.Drawing.Size(239, 22);
            this.login_input_senha.TabIndex = 3;
            // 
            // login_button_entrar
            // 
            this.login_button_entrar.Location = new System.Drawing.Point(89, 176);
            this.login_button_entrar.Name = "login_button_entrar";
            this.login_button_entrar.Size = new System.Drawing.Size(144, 42);
            this.login_button_entrar.TabIndex = 4;
            this.login_button_entrar.Text = "Entrar";
            this.login_button_entrar.UseVisualStyleBackColor = true;
            this.login_button_entrar.Click += new System.EventHandler(this.login_button_entrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // login_label_resposta
            // 
            this.login_label_resposta.AutoSize = true;
            this.login_label_resposta.Location = new System.Drawing.Point(54, 251);
            this.login_label_resposta.Name = "login_label_resposta";
            this.login_label_resposta.Size = new System.Drawing.Size(16, 16);
            this.login_label_resposta.TabIndex = 5;
            this.login_label_resposta.Text = "...";
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 295);
            this.Controls.Add(this.login_label_resposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_button_entrar);
            this.Controls.Add(this.login_input_senha);
            this.Controls.Add(this.login_label_senha);
            this.Controls.Add(this.login_label_usuario);
            this.Controls.Add(this.login_input_usuario);
            this.MaximizeBox = false;
            this.Name = "Form_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_input_usuario;
        private System.Windows.Forms.Label login_label_usuario;
        private System.Windows.Forms.Label login_label_senha;
        private System.Windows.Forms.TextBox login_input_senha;
        private System.Windows.Forms.Button login_button_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_label_resposta;
    }
}

