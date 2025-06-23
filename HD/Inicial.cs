using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HD
{
    public partial class Inicial : Form
    {
        private string senhaCorreta = "PE@Penso#"; // Altere aqui a senha conforme quiser

        public Inicial()
        {
            InitializeComponent();
            EstilizarFormulario();
        }

        private void EstilizarFormulario()
        {
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // Estiliza o botão de entrada se ele existir no Designer
            Entrar.FlatStyle = FlatStyle.Flat;
            Entrar.FlatAppearance.BorderSize = 0;
            Entrar.BackColor = Color.FromArgb(0, 120, 215); // Azul
            Entrar.ForeColor = Color.White;
            Entrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Entrar.Size = new Size(120, 40);
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            using (var senhaForm = new SenhaForm())
            {
                if (senhaForm.ShowDialog() == DialogResult.OK)
                {
                    string senha = senhaForm.SenhaDigitada;

                    if (senha == senhaCorreta)
                    {
                        Form2 formPrincipal = new Form2();
                        this.Hide();
                        formPrincipal.FormClosed += (s, args) => this.Close();
                        formPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/kauanvldsouza/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o link: " + ex.Message);
            }
        }

        private void LOGO_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
