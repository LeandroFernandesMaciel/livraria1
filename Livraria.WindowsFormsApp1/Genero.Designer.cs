namespace Livraria.WindowsFormsApp1
{
    partial class Genero
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
            this.NomeGeneroLabel1 = new System.Windows.Forms.Label();
            this.NomeGenerotextBox1 = new System.Windows.Forms.TextBox();
            this.Genero_btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeGeneroLabel1
            // 
            this.NomeGeneroLabel1.AutoSize = true;
            this.NomeGeneroLabel1.Location = new System.Drawing.Point(186, 117);
            this.NomeGeneroLabel1.Name = "NomeGeneroLabel1";
            this.NomeGeneroLabel1.Size = new System.Drawing.Size(38, 13);
            this.NomeGeneroLabel1.TabIndex = 13;
            this.NomeGeneroLabel1.Text = "Nome ";
            // 
            // NomeGenerotextBox1
            // 
            this.NomeGenerotextBox1.Location = new System.Drawing.Point(267, 114);
            this.NomeGenerotextBox1.Name = "NomeGenerotextBox1";
            this.NomeGenerotextBox1.Size = new System.Drawing.Size(348, 20);
            this.NomeGenerotextBox1.TabIndex = 12;
            // 
            // Genero_btn_cadastrar
            // 
            this.Genero_btn_cadastrar.Location = new System.Drawing.Point(388, 314);
            this.Genero_btn_cadastrar.Name = "Genero_btn_cadastrar";
            this.Genero_btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Genero_btn_cadastrar.TabIndex = 11;
            this.Genero_btn_cadastrar.Text = "cadastrar";
            this.Genero_btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NomeGeneroLabel1);
            this.Controls.Add(this.NomeGenerotextBox1);
            this.Controls.Add(this.Genero_btn_cadastrar);
            this.Name = "Genero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeGeneroLabel1;
        private System.Windows.Forms.TextBox NomeGenerotextBox1;
        private System.Windows.Forms.Button Genero_btn_cadastrar;
    }
}