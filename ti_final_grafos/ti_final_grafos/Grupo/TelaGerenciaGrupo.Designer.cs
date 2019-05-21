namespace ti_final_grafos.Grupo
{
    partial class TelaGerenciaGrupo
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
            this.btnGerarGrupos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerarGrupos
            // 
            this.btnGerarGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarGrupos.Location = new System.Drawing.Point(12, 12);
            this.btnGerarGrupos.Name = "btnGerarGrupos";
            this.btnGerarGrupos.Size = new System.Drawing.Size(200, 33);
            this.btnGerarGrupos.TabIndex = 0;
            this.btnGerarGrupos.Text = "GERAR GRUPOS";
            this.btnGerarGrupos.UseVisualStyleBackColor = true;
            this.btnGerarGrupos.Click += new System.EventHandler(this.btnGerarGrupos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "TOTAL PROFESSORES";
            // 
            // TelaGerenciaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGerarGrupos);
            this.Name = "TelaGerenciaGrupo";
            this.Text = "TelaGerenciaGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarGrupos;
        private System.Windows.Forms.TextBox textBox1;
    }
}