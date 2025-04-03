using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form3Recovery : Form
    {
        public Form3Recovery()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            // Correção: Adicionado operador ! para indicar que sender não será nulo
            btnEnviar.Click += (sender, e) => BtnEnviarRecuperar_Click(sender!, e);
            lblVoltarAoLoginRecuperarSenha.Click += (s, e) => this.Close();

            txtEmailCadastradoRecuperarSenha.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter) BtnEnviarRecuperar_Click(s!, e);
            };
        }

        // Correção: Adicionado ? para indicar que sender pode ser nulo
        private void BtnEnviarRecuperar_Click(object? sender, EventArgs e)
        {
            try
            {
                string email = txtEmailCadastradoRecuperarSenha.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Por favor, informe seu e-mail cadastrado.", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailCadastradoRecuperarSenha.Focus();
                    return;
                }

                if (!ValidarEmail(email))
                {
                    MessageBox.Show("Por favor, informe um endereço de e-mail válido.", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailCadastradoRecuperarSenha.SelectAll();
                    txtEmailCadastradoRecuperarSenha.Focus();
                    return;
                }

                var usuario = UsuarioRepositorio.BuscarPorEmail(email);

                if (usuario == null)
                {
                    MessageBox.Show("Este e-mail não está cadastrado em nosso sistema.", "E-mail não encontrado",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmailCadastradoRecuperarSenha.SelectAll();
                    txtEmailCadastradoRecuperarSenha.Focus();
                    return;
                }

                MessageBox.Show($"Instruções para redefinição de senha foram enviadas para:\n{email}",
                             "E-mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar solicitação: {ex.Message}", "Erro",
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
    }
}