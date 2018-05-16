namespace DesignPattern_Strategy_Factory
{
    partial class FrmExportacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cboTipoExportacao = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Caminho da Exportação";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(23, 33);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(335, 20);
            this.txtCaminho.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de Arquivo";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(274, 79);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(84, 23);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cboTipoExportacao
            // 
            this.cboTipoExportacao.FormattingEnabled = true;
            this.cboTipoExportacao.Items.AddRange(new object[] {
            "XML",
            "TXT",
            "Json"});
            this.cboTipoExportacao.Location = new System.Drawing.Point(23, 81);
            this.cboTipoExportacao.Name = "cboTipoExportacao";
            this.cboTipoExportacao.Size = new System.Drawing.Size(233, 21);
            this.cboTipoExportacao.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(23, 136);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(335, 219);
            this.txtResultado.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado";
            // 
            // FrmExportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboTipoExportacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmExportacao";
            this.Text = "Exportação de  Arquivo";
            this.Load += new System.EventHandler(this.FrmExportacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cboTipoExportacao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
    }
}