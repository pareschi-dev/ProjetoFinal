namespace ProjetoLogin
{
    partial class Form3Recovery
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
            lblVoltarAoLoginRecuperarSenha = new Label();
            btnEnviar = new Button();
            label1 = new Label();
            txtEmailCadastradoRecuperarSenha = new TextBox();
            SuspendLayout();
            // 
            // lblVoltarAoLoginRecuperarSenha
            // 
            lblVoltarAoLoginRecuperarSenha.AutoSize = true;
            lblVoltarAoLoginRecuperarSenha.BackColor = Color.White;
            lblVoltarAoLoginRecuperarSenha.Cursor = Cursors.Hand;
            lblVoltarAoLoginRecuperarSenha.FlatStyle = FlatStyle.Flat;
            lblVoltarAoLoginRecuperarSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVoltarAoLoginRecuperarSenha.ForeColor = Color.ForestGreen;
            lblVoltarAoLoginRecuperarSenha.Location = new Point(89, 350);
            lblVoltarAoLoginRecuperarSenha.Name = "lblVoltarAoLoginRecuperarSenha";
            lblVoltarAoLoginRecuperarSenha.Size = new Size(162, 25);
            lblVoltarAoLoginRecuperarSenha.TabIndex = 12;
            lblVoltarAoLoginRecuperarSenha.Text = "← Voltar ao Login";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.ForestGreen;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(89, 222);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(263, 52);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(79, 73);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 9;
            label1.Text = "Recuperar Senha";
            // 
            // txtEmailCadastradoRecuperarSenha
            // 
            txtEmailCadastradoRecuperarSenha.Font = new Font("Segoe UI Light", 15.75F);
            txtEmailCadastradoRecuperarSenha.ForeColor = Color.ForestGreen;
            txtEmailCadastradoRecuperarSenha.Location = new Point(89, 181);
            txtEmailCadastradoRecuperarSenha.Name = "txtEmailCadastradoRecuperarSenha";
            txtEmailCadastradoRecuperarSenha.PlaceholderText = "Digite seu e-mail cadastrado";
            txtEmailCadastradoRecuperarSenha.Size = new Size(263, 35);
            txtEmailCadastradoRecuperarSenha.TabIndex = 7;
            // 
            // Form3Recovery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CADFLOWRegistroCadastro458x507;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(442, 468);
            Controls.Add(lblVoltarAoLoginRecuperarSenha);
            Controls.Add(btnEnviar);
            Controls.Add(label1);
            Controls.Add(txtEmailCadastradoRecuperarSenha);
            DoubleBuffered = true;
            Name = "Form3Recovery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoltarAoLoginRecuperarSenha;
        private Button btnEnviar;
        private Label label1;
        private TextBox txtEmailCadastradoRecuperarSenha;
    }
}