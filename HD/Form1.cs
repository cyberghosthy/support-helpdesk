using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HD
{
    public partial class Form1 : Form
    {
        private string pastaSalvamento = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MinhasNotas");

        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(pastaSalvamento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            richDescricao.BorderStyle = BorderStyle.FixedSingle;
            richDescricao.BackColor = Color.White;
            richDescricao.ForeColor = Color.Black;
        }
        private void AtualizarEstilo()
        {
            if (richDescricao.SelectionFont != null)
            {
                FontStyle estilo = FontStyle.Regular;

                if (btnNegrito.Checked) estilo |= FontStyle.Bold;
                if (btnItalico.Checked) estilo |= FontStyle.Italic;
                if (btnSublinhado.Checked) estilo |= FontStyle.Underline;

                richDescricao.SelectionFont = new Font(richDescricao.SelectionFont, estilo);

                // Marca texto (fundo amarelo)
                if (btnMarca.Checked)
                    richDescricao.SelectionBackColor = Color.Yellow;
                else
                    richDescricao.SelectionBackColor = richDescricao.BackColor; // remove fundo
            }
        }

        private void EstilizarBotao(Button botao)
        {
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.BackColor = Color.FromArgb(0, 120, 215);
            botao.ForeColor = Color.White;
            botao.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            botao.Size = new Size(100, 40);
        }

        private void EstilizarCheckbox(CheckBox checkbox)
        {
            checkbox.Appearance = Appearance.Button;
            checkbox.FlatStyle = FlatStyle.Flat;
            checkbox.FlatAppearance.BorderSize = 0;
            checkbox.BackColor = Color.FromArgb(0, 120, 215);
            checkbox.ForeColor = Color.White;
            checkbox.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkbox.TextAlign = ContentAlignment.MiddleCenter;
            checkbox.Size = new Size(100, 40);
        }

        private void AplicarEstilo(FontStyle estilo)
        {
            if (richDescricao.SelectionFont != null)
            {
                Font currentFont = richDescricao.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ estilo;
                richDescricao.SelectionFont = new Font(currentFont, newStyle);
            }
        }

        private void btnInserirImagem_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Imagens|*.jpg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(dialog.FileName);
                    Clipboard.SetImage(img);
                    richDescricao.Paste();
                }
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Digite um título.");
                return;
            }

            string arquivoDestino = string.IsNullOrEmpty(caminhoNotaAberta)
                ? Path.Combine(pastaSalvamento, $"{titulo}.nota")
                : caminhoNotaAberta;

            using (FileStream fs = new FileStream(arquivoDestino, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(titulo);
                MemoryStream ms = new MemoryStream();
                richDescricao.SaveFile(ms, RichTextBoxStreamType.RichText);
                byte[] conteudoRTF = ms.ToArray();
                writer.Write(conteudoRTF.Length);
                writer.Write(conteudoRTF);
            }

            MessageBox.Show("Nota salva com sucesso!");
        }

        private void btnNegrito_Click(object sender, EventArgs e)
        {
            AplicarEstilo(FontStyle.Bold);
        }

        private void btnItalico_Click(object sender, EventArgs e)
        {
            AplicarEstilo(FontStyle.Italic);
        }

        private void btnSublinhado_Click(object sender, EventArgs e)
        {
            AplicarEstilo(FontStyle.Underline);
        }
        private void btnNegrito_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstilo();
        }

        private void btnItalico_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstilo();
        }

        private void btnSublinhado_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstilo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }

        // EDIÇÃO

        private string caminhoNotaAberta;

        public void CarregarNotaParaEdicao(string caminho)
        {
            using (BinaryReader reader = new BinaryReader(File.OpenRead(caminho)))
            {
                string titulo = reader.ReadString();
                int tamanho = reader.ReadInt32();
                byte[] rtf = reader.ReadBytes(tamanho);

                txtTitulo.Text = titulo;
                MemoryStream ms = new MemoryStream(rtf);
                richDescricao.LoadFile(ms, RichTextBoxStreamType.RichText);
            }

            caminhoNotaAberta = caminho;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
 
        }

        private void btnMarca_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstilo();
        }
    }
}