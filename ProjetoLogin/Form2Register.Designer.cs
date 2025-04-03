namespace ProjetoLogin
{
    partial class Form2Register
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
            lblVoltarAoLoginCadastro = new Label();
            btnCadastrar = new Button();
            label1 = new Label();
            txtSenhaCadastro = new TextBox();
            txtEmailCadastro = new TextBox();
            txtConfirmarSenhaCadastro = new TextBox();
            SuspendLayout();
            // 
            // lblVoltarAoLoginCadastro
            // 
            lblVoltarAoLoginCadastro.AutoSize = true;
            lblVoltarAoLoginCadastro.BackColor = Color.White;
            lblVoltarAoLoginCadastro.Cursor = Cursors.Hand;
            lblVoltarAoLoginCadastro.FlatStyle = FlatStyle.Flat;
            lblVoltarAoLoginCadastro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVoltarAoLoginCadastro.ForeColor = Color.DarkGreen;
            lblVoltarAoLoginCadastro.Location = new Point(89, 350);
            lblVoltarAoLoginCadastro.Name = "lblVoltarAoLoginCadastro";
            lblVoltarAoLoginCadastro.Size = new Size(162, 25);
            lblVoltarAoLoginCadastro.TabIndex = 12;
            lblVoltarAoLoginCadastro.Text = "← Voltar ao Login";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(89, 282);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(263, 52);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(79, 73);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 9;
            label1.Text = "Cadastro";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI Light", 15.75F);
            txtSenhaCadastro.ForeColor = Color.DarkGreen;
            txtSenhaCadastro.Location = new Point(89, 179);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Senha";
            txtSenhaCadastro.Size = new Size(263, 35);
            txtSenhaCadastro.TabIndex = 8;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Font = new Font("Segoe UI Light", 15.75F);
            txtEmailCadastro.ForeColor = Color.DarkGreen;
            txtEmailCadastro.Location = new Point(89, 130);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "E-mail";
            txtEmailCadastro.Size = new Size(263, 35);
            txtEmailCadastro.TabIndex = 7;
            // 
            // txtConfirmarSenhaCadastro
            // 
            txtConfirmarSenhaCadastro.Font = new Font("Segoe UI Light", 15.75F);
            txtConfirmarSenhaCadastro.ForeColor = Color.DarkGreen;
            txtConfirmarSenhaCadastro.Location = new Point(89, 230);
            txtConfirmarSenhaCadastro.Name = "txtConfirmarSenhaCadastro";
            txtConfirmarSenhaCadastro.PlaceholderText = "Confirmar Senha";
            txtConfirmarSenhaCadastro.Size = new Size(263, 35);
            txtConfirmarSenhaCadastro.TabIndex = 13;
            // 
            // Form2Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CADFLOWRegistroCadastro458x507;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(442, 468);
            Controls.Add(txtConfirmarSenhaCadastro);
            Controls.Add(lblVoltarAoLoginCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtEmailCadastro);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoltarAoLoginCadastro;
        private Button btnCadastrar;
        private Label label1;
        private TextBox txtSenhaCadastro;
        private TextBox txtEmailCadastro;
        private TextBox txtConfirmarSenhaCadastro;
    }
}