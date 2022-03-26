
namespace Somador
{
    partial class Somador
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
            this.bAdicionar = new System.Windows.Forms.Button();
            this.lstValores = new System.Windows.Forms.CheckedListBox();
            this.lSomaTotal = new System.Windows.Forms.Label();
            this.bSomar = new System.Windows.Forms.Button();
            this.lSomaMarcados = new System.Windows.Forms.Label();
            this.bRemover = new System.Windows.Forms.Button();
            this.tDica = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tValor)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(263, 84);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 20);
            this.bAdicionar.TabIndex = 1;
            this.bAdicionar.Text = "Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.bAdicionar_Click);
            // 
            // lstValores
            // 
            this.lstValores.FormattingEnabled = true;
            this.lstValores.Location = new System.Drawing.Point(44, 123);
            this.lstValores.Name = "lstValores";
            this.lstValores.Size = new System.Drawing.Size(213, 94);
            this.lstValores.TabIndex = 2;
            // 
            // lSomaTotal
            // 
            this.lSomaTotal.AutoSize = true;
            this.lSomaTotal.Location = new System.Drawing.Point(41, 267);
            this.lSomaTotal.Name = "lSomaTotal";
            this.lSomaTotal.Size = new System.Drawing.Size(35, 13);
            this.lSomaTotal.TabIndex = 4;
            this.lSomaTotal.Text = "label1";
            // 
            // bSomar
            // 
            this.bSomar.Location = new System.Drawing.Point(44, 223);
            this.bSomar.Name = "bSomar";
            this.bSomar.Size = new System.Drawing.Size(75, 23);
            this.bSomar.TabIndex = 5;
            this.bSomar.Text = "Somar";
            this.bSomar.UseVisualStyleBackColor = true;
            this.bSomar.Click += new System.EventHandler(this.bSomar_Click);
            // 
            // lSomaMarcados
            // 
            this.lSomaMarcados.AutoSize = true;
            this.lSomaMarcados.Location = new System.Drawing.Point(41, 303);
            this.lSomaMarcados.Name = "lSomaMarcados";
            this.lSomaMarcados.Size = new System.Drawing.Size(35, 13);
            this.lSomaMarcados.TabIndex = 6;
            this.lSomaMarcados.Text = "label2";
            // 
            // bRemover
            // 
            this.bRemover.Location = new System.Drawing.Point(125, 223);
            this.bRemover.Name = "bRemover";
            this.bRemover.Size = new System.Drawing.Size(132, 23);
            this.bRemover.TabIndex = 7;
            this.bRemover.Text = "Remover Selecionado";
            this.bRemover.UseVisualStyleBackColor = true;
            this.bRemover.Click += new System.EventHandler(this.bRemover_Click);
            // 
            // tDica
            // 
            this.tDica.AutoSize = true;
            this.tDica.Location = new System.Drawing.Point(41, 54);
            this.tDica.Name = "tDica";
            this.tDica.Size = new System.Drawing.Size(286, 13);
            this.tDica.TabIndex = 9;
            this.tDica.Text = "Use \',\' (vírgula) para separar as casas decimais. Ex.: 45,09.";
            // 
            // tValor
            // 
            this.tValor.InterceptArrowKeys = false;
            this.tValor.Location = new System.Drawing.Point(44, 84);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(213, 20);
            this.tValor.TabIndex = 10;
            this.tValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tValor_KeyDown);
            // 
            // Somador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 483);
            this.Controls.Add(this.tValor);
            this.Controls.Add(this.tDica);
            this.Controls.Add(this.bRemover);
            this.Controls.Add(this.lSomaMarcados);
            this.Controls.Add(this.bSomar);
            this.Controls.Add(this.lSomaTotal);
            this.Controls.Add(this.lstValores);
            this.Controls.Add(this.bAdicionar);
            this.Name = "Somador";
            this.Text = "Somador";
            this.Load += new System.EventHandler(this.Somador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdicionar;
        private System.Windows.Forms.CheckedListBox lstValores;
        private System.Windows.Forms.Label lSomaTotal;
        private System.Windows.Forms.Button bSomar;
        private System.Windows.Forms.Label lSomaMarcados;
        private System.Windows.Forms.Button bRemover;
        private System.Windows.Forms.Label tDica;
        private System.Windows.Forms.NumericUpDown tValor;
    }
}

