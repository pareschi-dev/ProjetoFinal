﻿namespace ProjetoLogin
{
    partial class Form1Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmailLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            label1 = new Label();
            lblEsqueciMinhaSenha = new Label();
            btnEntrar = new Button();
            lblCriarUmaConta = new Label();
            SuspendLayout();
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = SystemColors.Window;
            txtEmailLogin.Cursor = Cursors.IBeam;
            txtEmailLogin.Font = new Font("Segoe UI Light", 15.75F);
            txtEmailLogin.ForeColor = Color.DarkGreen;
            txtEmailLogin.Location = new Point(89, 115);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.PlaceholderText = "E-mail";
            txtEmailLogin.Size = new Size(263, 35);
            txtEmailLogin.TabIndex = 0;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = SystemColors.Window;
            txtSenhaLogin.Cursor = Cursors.IBeam;
            txtSenhaLogin.Font = new Font("Segoe UI Light", 15.75F);
            txtSenhaLogin.ForeColor = Color.DarkGreen;
            txtSenhaLogin.Location = new Point(89, 156);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PlaceholderText = "Senha";
            txtSenhaLogin.Size = new Size(263, 35);
            txtSenhaLogin.TabIndex = 1;
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
            label1.Size = new Size(69, 30);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // lblEsqueciMinhaSenha
            // 
            lblEsqueciMinhaSenha.AutoSize = true;
            lblEsqueciMinhaSenha.BackColor = Color.White;
            lblEsqueciMinhaSenha.Cursor = Cursors.Hand;
            lblEsqueciMinhaSenha.FlatStyle = FlatStyle.Flat;
            lblEsqueciMinhaSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsqueciMinhaSenha.ForeColor = Color.DarkGreen;
            lblEsqueciMinhaSenha.Location = new Point(89, 213);
            lblEsqueciMinhaSenha.Name = "lblEsqueciMinhaSenha";
            lblEsqueciMinhaSenha.Size = new Size(190, 25);
            lblEsqueciMinhaSenha.TabIndex = 4;
            lblEsqueciMinhaSenha.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.DarkGreen;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(89, 282);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(263, 52);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblCriarUmaConta
            // 
            lblCriarUmaConta.AutoSize = true;
            lblCriarUmaConta.BackColor = Color.White;
            lblCriarUmaConta.Cursor = Cursors.Hand;
            lblCriarUmaConta.FlatStyle = FlatStyle.Flat;
            lblCriarUmaConta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriarUmaConta.ForeColor = Color.DarkGreen;
            lblCriarUmaConta.Location = new Point(89, 350);
            lblCriarUmaConta.Name = "lblCriarUmaConta";
            lblCriarUmaConta.Size = new Size(149, 25);
            lblCriarUmaConta.TabIndex = 6;
            lblCriarUmaConta.Text = "Criar uma conta";
            // 
            // Form1Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.CADFLOWRegistroCadastro458x507;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(442, 468);
            Controls.Add(lblCriarUmaConta);
            Controls.Add(btnEntrar);
            Controls.Add(lblEsqueciMinhaSenha);
            Controls.Add(label1);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtEmailLogin);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "Form1Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailLogin;
        private TextBox txtSenhaLogin;
        private Label label1;
        private Label lblEsqueciMinhaSenha;
        private Button btnEntrar;
        private Label lblCriarUmaConta;
    }
}
