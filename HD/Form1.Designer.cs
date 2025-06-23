namespace HD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.richDescricao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripFormatting = new System.Windows.Forms.ToolStrip();
            this.btnNegrito = new System.Windows.Forms.ToolStripButton();
            this.btnItalico = new System.Windows.Forms.ToolStripButton();
            this.btnSublinhado = new System.Windows.Forms.ToolStripButton();
            this.btnMarca = new System.Windows.Forms.ToolStripButton();
            this.btnInserirImagem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripFormatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(24, 37);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(338, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // richDescricao
            // 
            this.richDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richDescricao.Location = new System.Drawing.Point(24, 94);
            this.richDescricao.Name = "richDescricao";
            this.richDescricao.Size = new System.Drawing.Size(721, 293);
            this.richDescricao.TabIndex = 1;
            this.richDescricao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            // 
            // toolStripFormatting
            // 
            this.toolStripFormatting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripFormatting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNegrito,
            this.btnItalico,
            this.btnSublinhado,
            this.btnMarca,
            this.btnInserirImagem,
            this.toolStripSeparator1,
            this.btnSalvar});
            this.toolStripFormatting.Location = new System.Drawing.Point(0, 405);
            this.toolStripFormatting.Name = "toolStripFormatting";
            this.toolStripFormatting.Size = new System.Drawing.Size(770, 25);
            this.toolStripFormatting.TabIndex = 12;
            this.toolStripFormatting.Text = "toolStrip1";
            // 
            // btnNegrito
            // 
            this.btnNegrito.CheckOnClick = true;
            this.btnNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNegrito.Image = global::HD.Properties.Resources.icon_bold_24;
            this.btnNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNegrito.Name = "btnNegrito";
            this.btnNegrito.Size = new System.Drawing.Size(23, 22);
            this.btnNegrito.Text = "toolStripButton1";
            this.btnNegrito.Click += new System.EventHandler(this.btnNegrito_Click);
            // 
            // btnItalico
            // 
            this.btnItalico.CheckOnClick = true;
            this.btnItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalico.Image = global::HD.Properties.Resources.icon_italic_24;
            this.btnItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalico.Name = "btnItalico";
            this.btnItalico.Size = new System.Drawing.Size(23, 22);
            this.btnItalico.Text = "toolStripButton2";
            this.btnItalico.Click += new System.EventHandler(this.btnItalico_Click);
            // 
            // btnSublinhado
            // 
            this.btnSublinhado.CheckOnClick = true;
            this.btnSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSublinhado.Image = global::HD.Properties.Resources.icon_underline_24;
            this.btnSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSublinhado.Name = "btnSublinhado";
            this.btnSublinhado.Size = new System.Drawing.Size(23, 22);
            this.btnSublinhado.Text = "toolStripButton3";
            this.btnSublinhado.Click += new System.EventHandler(this.btnSublinhado_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.CheckOnClick = true;
            this.btnMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMarca.Image = global::HD.Properties.Resources._80619__1_;
            this.btnMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(23, 22);
            this.btnMarca.Text = "toolStripButton4";
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_CheckedChanged);
            // 
            // btnInserirImagem
            // 
            this.btnInserirImagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserirImagem.Image = global::HD.Properties.Resources.icon_image_24;
            this.btnInserirImagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserirImagem.Name = "btnInserirImagem";
            this.btnInserirImagem.Size = new System.Drawing.Size(23, 22);
            this.btnInserirImagem.Text = "toolStripButton1";
            this.btnInserirImagem.Click += new System.EventHandler(this.btnInserirImagem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = global::HD.Properties.Resources._5610944__1_;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "toolStripButton1";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 430);
            this.Controls.Add(this.toolStripFormatting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Name = "Form1";
            this.Text = "Adicionar Solução";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripFormatting.ResumeLayout(false);
            this.toolStripFormatting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox richDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStripFormatting;
        private System.Windows.Forms.ToolStripButton btnNegrito;
        private System.Windows.Forms.ToolStripButton btnItalico;
        private System.Windows.Forms.ToolStripButton btnSublinhado;
        private System.Windows.Forms.ToolStripButton btnMarca;
        private System.Windows.Forms.ToolStripButton btnInserirImagem;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

