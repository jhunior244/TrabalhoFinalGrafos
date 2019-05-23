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
            this.tbTotalProfessor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // tbTotalProfessor
            // 
            this.tbTotalProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalProfessor.Location = new System.Drawing.Point(218, 14);
            this.tbTotalProfessor.Name = "tbTotalProfessor";
            this.tbTotalProfessor.Size = new System.Drawing.Size(245, 31);
            this.tbTotalProfessor.TabIndex = 1;
            this.tbTotalProfessor.Text = "TOTAL PROFESSORES";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(173, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 387);
            this.panel1.TabIndex = 2;
            // 
            // TelaGerenciaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTotalProfessor);
            this.Controls.Add(this.btnGerarGrupos);
            this.Name = "TelaGerenciaGrupo";
            this.Text = "TelaGerenciaGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarGrupos;
        private System.Windows.Forms.TextBox tbTotalProfessor;
        private System.Windows.Forms.Panel panel1;
    }
}