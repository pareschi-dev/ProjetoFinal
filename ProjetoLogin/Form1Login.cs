using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form1Login : Form
    {
        private Button? btnMostrarSenha; // Campo anulável

        public Form1Login()
        {
            InitializeComponent();
            ConfigurarComponentes();
            ConfigurarEventos();
            AdicionarOlhoSenha();
           
        }

        private void ConfigurarComponentes()
        {
            txtSenhaLogin.PasswordChar = '•';
            txtEmailLogin.TabIndex = 0;
            txtSenhaLogin.TabIndex = 1;
            btnEntrar.TabIndex = 2;
            lblEsqueciMinhaSenha.TabIndex = 3;
            lblCriarUmaConta.TabIndex = 4;
        }

        private void ConfigurarEventos()
        {
            // Configuração dos eventos com tratamento de nulidade
            btnEntrar.Click += (sender, e) => BtnEntrar_Click(sender!, e);
            lblEsqueciMinhaSenha.Click += (sender, e) => LblEsqueciMinhaSenha_Click(sender!, e);
            lblCriarUmaConta.Click += (sender, e) => LblCriarUmaConta_Click(sender!, e);

            // Navegação com tecla Enter
            txtEmailLogin.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter) txtSenhaLogin.Focus();
            };

            txtSenhaLogin.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter) BtnEntrar_Click(sender!, e);
            };
        }

        private void AdicionarOlhoSenha()
        {
            btnMostrarSenha = new Button
            {
                Text = "🔒", // Emoji de olho fechado inicialmente
                Font = new Font("Segoe UI Emoji", 12),
                ForeColor = Color.DarkGreen,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(30, txtSenhaLogin.Height - 4),
                Location = new Point(
                    txtSenhaLogin.Right - 35,
                    txtSenhaLogin.Top + 2),
                Cursor = Cursors.Hand,
                BackColor = SystemColors.Window,
                TabStop = false
            };

            // Remover bordas do botão
            btnMostrarSenha.FlatAppearance.BorderSize = 0;

            // Efeito hover - Mostrar senha quando mouse entra
            btnMostrarSenha.MouseEnter += (s, e) =>
            {
                txtSenhaLogin.PasswordChar = '\0';
                btnMostrarSenha.Text = "👁️"; // Muda para olho aberto
            };

            // Efeito mouse leave - Esconder senha quando mouse sai
            btnMostrarSenha.MouseLeave += (s, e) =>
            {
                if (this.ContainsFocus)
                {
                    txtSenhaLogin.PasswordChar = '•';
                    btnMostrarSenha.Text = "🔒"; // Volta para olho fechado
                }
            };

            

            // Adicionar efeito visual ao passar o mouse
            btnMostrarSenha.FlatAppearance.MouseOverBackColor = Color.White;

            this.Controls.Add(btnMostrarSenha);
            btnMostrarSenha.BringToFront();
        }

        private void BtnEntrar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmailLogin.Text))
                {
                    MessageBox.Show("Por favor, informe seu e-mail.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailLogin.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
                {
                    MessageBox.Show("Por favor, informe sua senha.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenhaLogin.Focus();
                    return;
                }

                var usuario = UsuarioRepositorio.BuscarPorEmail(txtEmailLogin.Text.Trim());

                if (usuario == null || !UsuarioRepositorio.VerificarSenha(txtSenhaLogin.Text, usuario.Senha))
                {
                    MessageBox.Show("E-mail ou senha incorretos!", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaLogin.SelectAll();
                    txtSenhaLogin.Focus();
                    return;
                }

                this.Hide();
                using (var mainForm = new Form4MainSystem(usuario.Email))
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar login: {ex.Message}", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblEsqueciMinhaSenha_Click(object? sender, EventArgs e)
        {
            this.Hide();
            using (var recoveryForm = new Form3Recovery())
            {
                recoveryForm.ShowDialog();
            }
            this.Show();
        }

        private void LblCriarUmaConta_Click(object? sender, EventArgs e)
        {
            this.Hide();
            using (var registerForm = new Form2Register())
            {
                registerForm.ShowDialog();
            }
            this.Show();
        }
    }
}