
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form4MainSystem : Form
    {
        public Form4MainSystem(string emailUsuario)
        {
            InitializeComponent();

            // Configuração básica do formulário principal
            this.Text = $"Sistema Principal - {emailUsuario}";
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;            // Seu TabControl com 7 abas já está configurado no designer
            // Nenhuma alteração é necessária aqui
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}