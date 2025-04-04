﻿using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProjetoLogin
{    
    public partial class Form2Register : Form
    {
        private Button? btnMostrarSenha;
        private Button? btnMostrarConfirmarSenha;
        
        public Form2Register()
        {
            InitializeComponent();
            ConfigurarComponentes();
            ConfigurarEventos();
            AdicionarOlhosSenha();
            
       
        }

        private void ConfigurarComponentes()
        {
            txtSenhaCadastro.PasswordChar = '•';
            txtConfirmarSenhaCadastro.PasswordChar = '•';
            txtEmailCadastro.TabIndex = 0;
            txtSenhaCadastro.TabIndex = 1;
            txtConfirmarSenhaCadastro.TabIndex = 2;
            lblVoltarAoLoginCadastro.TabIndex = 4;
        }

        private void ConfigurarEventos()
        {
            btnCadastrar.Click += (sender, e) => BtnCadastrar_Click(sender!, e);
            lblVoltarAoLoginCadastro.Click += (s, e) => this.Close();

            txtEmailCadastro.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) txtSenhaCadastro.Focus();
            };

            txtSenhaCadastro.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) txtConfirmarSenhaCadastro.Focus();
            };

            txtConfirmarSenhaCadastro.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) BtnCadastrar_Click(sender!, e);
            };
        }

        private void AdicionarOlhosSenha()
        {
            btnMostrarSenha = CriarBotaoOlho(txtSenhaCadastro);
            btnMostrarConfirmarSenha = CriarBotaoOlho(txtConfirmarSenhaCadastro);
        }

        private Button CriarBotaoOlho(TextBox textBox)
        {
            var btn = new Button
            {
                Text = "🔒", // Emoji de cadeado inicialmente
                Font = new Font("Segoe UI Emoji", 12),
                ForeColor = Color.DarkGreen,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(30, textBox.Height - 4),
                Location = new Point(
                    textBox.Right - 35,
                    textBox.Top + 2),
                Cursor = Cursors.Hand,
                BackColor = SystemColors.Window,
                TabStop = false
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.White;

            // Efeito hover - Mostrar senha quando mouse entra
            btn.MouseEnter += (s, e) =>
            {
                textBox.PasswordChar = '\0';
                btn.Text = "👁️"; // Muda para olho aberto
            };

            // Efeito mouse leave - Esconder senha quando mouse sai
            btn.MouseLeave += (s, e) =>
            {
                if (this.ContainsFocus)
                {
                    textBox.PasswordChar = '•';
                    btn.Text = "🔒"; // Volta para cadeado
                }
            };

            

            this.Controls.Add(btn);
            btn.BringToFront();
            return btn;
        }

        private void BtnCadastrar_Click(object? sender, EventArgs e)
        {
            try
            {
                string email = txtEmailCadastro.Text.Trim();
                string senha = txtSenhaCadastro.Text;
                string confirmarSenha = txtConfirmarSenhaCadastro.Text;

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Por favor, informe seu e-mail.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailCadastro.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Por favor, informe sua senha.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenhaCadastro.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(confirmarSenha))
                {
                    MessageBox.Show("Por favor, confirme sua senha.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarSenhaCadastro.Focus();
                    return;
                }

                if (!ValidarEmail(email))
                {
                    MessageBox.Show("Por favor, informe um e-mail válido.", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailCadastro.SelectAll();
                    txtEmailCadastro.Focus();
                    return;
                }

                if (!ValidarForcaSenha(senha))
                {
                    MessageBox.Show("A senha deve conter:\n- Mínimo 8 caracteres\n- Letras maiúsculas\n- Letras minúsculas\n- Pelo menos um número",
                                 "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaCadastro.SelectAll();
                    txtSenhaCadastro.Focus();
                    return;
                }

                if (senha != confirmarSenha)
                {
                    MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarSenhaCadastro.SelectAll();
                    txtConfirmarSenhaCadastro.Focus();
                    return;
                }

                if (UsuarioRepositorio.BuscarPorEmail(email) != null)
                {
                    MessageBox.Show("Este e-mail já está cadastrado. Por favor, use outro e-mail.",
                                 "E-mail Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailCadastro.SelectAll();
                    txtEmailCadastro.Focus();
                    return;
                }

                UsuarioRepositorio.AdicionarUsuario(new Usuario(email, senha));
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar cadastro: {ex.Message}", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidarForcaSenha(string senha)
        {
            return senha.Length >= 8 &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsLower) &&
                   senha.Any(char.IsDigit);
        }
    }
}