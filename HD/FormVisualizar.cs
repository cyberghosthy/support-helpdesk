using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static HD.Form2;

namespace HD
{
    public partial class FormVisualizar : Form
    {
        public FormVisualizar()
        {
            InitializeComponent();
            EstilizarInterface();
        }

        public void CarregarNota(string caminho)
        {
            var nota = Nota.Carregar(caminho);
            lblTitulo.Text = nota.Titulo;

            using (MemoryStream ms = new MemoryStream(nota.ConteudoRTF))
            {
                richDescricao.LoadFile(ms, RichTextBoxStreamType.RichText);
            }
        }

        private void richDescricao_TextChanged(object sender, EventArgs e)
        {
            // Apenas leitura
        }

        private void EstilizarInterface()
        {
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Label do título
            lblTitulo.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.AutoSize = true;

            // RichTextBox como texto somente leitura visualmente

            // Essa linha de baixo estava quebrando completamente todo a vizulalização de imagens
            //richDescricao.ReadOnly = true;

            richDescricao.BackColor = this.BackColor; // mesma cor do fundo da janela
            richDescricao.BorderStyle = BorderStyle.None;
            richDescricao.TabStop = false; // não pode ser focado
            richDescricao.Cursor = Cursors.Default; // cursor normal, não de texto
            richDescricao.Font = new Font("Segoe UI", 200);
        }

    }
}
