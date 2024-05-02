namespace Checkbox
{
    partial class FrmCheckbox
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
            this.cbEntretenimento = new System.Windows.Forms.CheckBox();
            this.cbTecnologia = new System.Windows.Forms.CheckBox();
            this.cbNoticias = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVerif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEntretenimento
            // 
            this.cbEntretenimento.AutoSize = true;
            this.cbEntretenimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEntretenimento.Location = new System.Drawing.Point(182, 86);
            this.cbEntretenimento.Name = "cbEntretenimento";
            this.cbEntretenimento.Size = new System.Drawing.Size(123, 21);
            this.cbEntretenimento.TabIndex = 0;
            this.cbEntretenimento.Text = "Entretenimento";
            this.cbEntretenimento.UseVisualStyleBackColor = true;
            // 
            // cbTecnologia
            // 
            this.cbTecnologia.AutoSize = true;
            this.cbTecnologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTecnologia.Location = new System.Drawing.Point(182, 113);
            this.cbTecnologia.Name = "cbTecnologia";
            this.cbTecnologia.Size = new System.Drawing.Size(97, 21);
            this.cbTecnologia.TabIndex = 1;
            this.cbTecnologia.Text = "Tecnologia";
            this.cbTecnologia.UseVisualStyleBackColor = true;
            // 
            // cbNoticias
            // 
            this.cbNoticias.AutoSize = true;
            this.cbNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbNoticias.Location = new System.Drawing.Point(182, 140);
            this.cbNoticias.Name = "cbNoticias";
            this.cbNoticias.Size = new System.Drawing.Size(77, 21);
            this.cbNoticias.TabIndex = 2;
            this.cbNoticias.Text = "Noticias";
            this.cbNoticias.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(384, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Checkbox";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(6, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Resultado";
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerif.Location = new System.Drawing.Point(171, 167);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(143, 36);
            this.btnVerif.TabIndex = 5;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(35, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(12, 402);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 36);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbNoticias);
            this.Controls.Add(this.cbTecnologia);
            this.Controls.Add(this.cbEntretenimento);
            this.Name = "FrmCheckbox";
            this.Text = "Checkbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEntretenimento;
        private System.Windows.Forms.CheckBox cbTecnologia;
        private System.Windows.Forms.CheckBox cbNoticias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
    }
}

