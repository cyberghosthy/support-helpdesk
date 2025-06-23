using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class Nota
        {
            public string Titulo { get; set; }
            public byte[] ConteudoRTF { get; set; }

            public void Salvar(string caminho)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Create(caminho)))
                {
                    writer.Write(Titulo);
                    writer.Write(ConteudoRTF.Length);
                    writer.Write(ConteudoRTF);
                }
            }

            public static Nota Carregar(string caminho)
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(caminho)))
                {
                    string titulo = reader.ReadString();
                    int tamanho = reader.ReadInt32();
                    byte[] rtf = reader.ReadBytes(tamanho);
                    return new Nota { Titulo = titulo, ConteudoRTF = rtf };
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            string termo = txtPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termo))
                return;

            string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MinhasNotas");
            if (!Directory.Exists(pasta)) return;

            string[] arquivos = Directory.GetFiles(pasta, "*.nota");

            foreach (string caminho in arquivos)
            {
                var nota = Nota.Carregar(caminho);

                string textoPlano;
                using (RichTextBox temp = new RichTextBox())
                {
                    temp.Rtf = Encoding.UTF8.GetString(nota.ConteudoRTF);
                    textoPlano = temp.Text.ToLower();
                }

                if (nota.Titulo.ToLower().Contains(termo) || textoPlano.Contains(termo))
                {
                    lstResultados.Items.Add(new ResultadoNota { Titulo = nota.Titulo, Caminho = caminho });
                }
            }
        }
        class ResultadoNota
        {
            public string Titulo { get; set; }
            public string Caminho { get; set; }

            public override string ToString()
            {
                return Titulo;
            }
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstResultados_DoubleClick(object sender, EventArgs e)
        {
            if (lstResultados.SelectedItem is ResultadoNota nota)
            {
                FormVisualizar frm = new FormVisualizar();
                frm.CarregarNota(nota.Caminho);
                frm.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Estilo geral do formulário
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Estilo da caixa de pesquisa
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.Font = new Font("Segoe UI", 10);
            txtPesquisa.ForeColor = Color.Black;
            txtPesquisa.BackColor = Color.White;

            // Estilo da lista de resultados
            lstResultados.BorderStyle = BorderStyle.FixedSingle;
            lstResultados.BackColor = Color.White;
            lstResultados.ForeColor = Color.Black;
            lstResultados.Font = new Font("Segoe UI", 10);

            // Estilo dos botões
            EstilizarBotao(button1, Color.FromArgb(33, 150, 243)); // Azul moderno
            EstilizarBotao(btnEditar, Color.FromArgb(0, 122, 204));      // Azul escuro
        }

        private void EstilizarBotao(Button botao, Color corFundo)
        {
            botao.BackColor = corFundo;
            botao.ForeColor = Color.White;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            botao.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstResultados.SelectedItem is ResultadoNota notaSelecionada)
            {
                Form1 formEdicao = new Form1();
                formEdicao.CarregarNotaParaEdicao(notaSelecionada.Caminho);
                formEdicao.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma nota para editar.");
            }
        }
    }
}
