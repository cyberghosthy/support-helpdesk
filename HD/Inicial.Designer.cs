namespace HD
{
    partial class Inicial
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
            System.Windows.Forms.Label LOGO;
            System.Windows.Forms.Label label1;
            this.Entrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            LOGO = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LOGO
            // 
            LOGO.AutoSize = true;
            LOGO.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LOGO.Location = new System.Drawing.Point(128, 107);
            LOGO.Name = "LOGO";
            LOGO.Size = new System.Drawing.Size(189, 50);
            LOGO.TabIndex = 3;
            LOGO.Text = "SUPPORT";
            LOGO.Click += new System.EventHandler(this.LOGO_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(240, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 50);
            label1.TabIndex = 4;
            label1.Text = "HELPDESK";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(224, 298);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(126, 27);
            this.Entrar.TabIndex = 1;
            this.Entrar.Text = "ENTRAR";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(461, 355);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Desenvoledor; Kauan";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 377);
            this.Controls.Add(label1);
            this.Controls.Add(LOGO);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Entrar);
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}