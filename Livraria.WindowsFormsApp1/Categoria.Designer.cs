namespace Livraria.WindowsFormsApp1
{
    partial class Categoria
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
            this.ValorDiariatextBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NometextBox1 = new System.Windows.Forms.TextBox();
            this.Categoria_btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValorDiariatextBox5
            // 
            this.ValorDiariatextBox5.Location = new System.Drawing.Point(267, 145);
            this.ValorDiariatextBox5.Name = "ValorDiariatextBox5";
            this.ValorDiariatextBox5.Size = new System.Drawing.Size(348, 20);
            this.ValorDiariatextBox5.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor Diária";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome ";
            // 
            // NometextBox1
            // 
            this.NometextBox1.Location = new System.Drawing.Point(267, 114);
            this.NometextBox1.Name = "NometextBox1";
            this.NometextBox1.Size = new System.Drawing.Size(348, 20);
            this.NometextBox1.TabIndex = 12;
            // 
            // Categoria_btn_cadastrar
            // 
            this.Categoria_btn_cadastrar.Location = new System.Drawing.Point(388, 314);
            this.Categoria_btn_cadastrar.Name = "Categoria_btn_cadastrar";
            this.Categoria_btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Categoria_btn_cadastrar.TabIndex = 11;
            this.Categoria_btn_cadastrar.Text = "cadastrar";
            this.Categoria_btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValorDiariatextBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NometextBox1);
            this.Controls.Add(this.Categoria_btn_cadastrar);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValorDiariatextBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NometextBox1;
        private System.Windows.Forms.Button Categoria_btn_cadastrar;
    }
}