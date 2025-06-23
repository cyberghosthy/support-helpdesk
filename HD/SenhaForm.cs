using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HD
{
    public partial class SenhaForm : Form
    {
        public string SenhaDigitada => textBoxSenha.Text;

        public SenhaForm()
        {
            InitializeComponent();
            Estilizarr();;
            textBoxSenha.PasswordChar = '*';
            this.AcceptButton = buttonOK;               // Faz o Enter acionar o botão
            buttonOK.DialogResult = DialogResult.OK;    // Faz o botão fechar o form com OK
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
        private void Estilizarr()
        {
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // Estiliza o botão de entrada se ele existir no Designer
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.BackColor = Color.FromArgb(0, 120, 215); // Azul
            buttonOK.ForeColor = Color.White;
            buttonOK.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
