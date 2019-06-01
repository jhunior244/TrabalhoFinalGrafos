namespace ti_final_grafos.ViewCrud
{
    partial class CrudExaminador
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
            this.tbExaminador = new System.Windows.Forms.TextBox();
            this.lblExaminador = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtNascimentoProfessor = new System.Windows.Forms.DateTimePicker();
            this.btnVincularTcc = new System.Windows.Forms.Button();
            this.btnCadastrarExaminador = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscarExaminador = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbExaminador
            // 
            this.tbExaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExaminador.Location = new System.Drawing.Point(154, 6);
            this.tbExaminador.Name = "tbExaminador";
            this.tbExaminador.Size = new System.Drawing.Size(634, 29);
            this.tbExaminador.TabIndex = 0;
            // 
            // lblExaminador
            // 
            this.lblExaminador.AutoSize = true;
            this.lblExaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExaminador.Location = new System.Drawing.Point(12, 9);
            this.lblExaminador.Name = "lblExaminador";
            this.lblExaminador.Size = new System.Drawing.Size(138, 24);
            this.lblExaminador.TabIndex = 1;
            this.lblExaminador.Text = "EXAMINADOR";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(12, 42);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(136, 24);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "NASCIMENTO";
            // 
            // dtNascimentoProfessor
            // 
            this.dtNascimentoProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimentoProfessor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimentoProfessor.Location = new System.Drawing.Point(154, 40);
            this.dtNascimentoProfessor.Name = "dtNascimentoProfessor";
            this.dtNascimentoProfessor.Size = new System.Drawing.Size(125, 29);
            this.dtNascimentoProfessor.TabIndex = 5;
            // 
            // btnVincularTcc
            // 
            this.btnVincularTcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincularTcc.Location = new System.Drawing.Point(285, 38);
            this.btnVincularTcc.Name = "btnVincularTcc";
            this.btnVincularTcc.Size = new System.Drawing.Size(501, 32);
            this.btnVincularTcc.TabIndex = 6;
            this.btnVincularTcc.Text = "TCCs PARA EXAMINAR";
            this.btnVincularTcc.UseVisualStyleBackColor = true;
            this.btnVincularTcc.Click += new System.EventHandler(this.btnVincularTcc_Click);
            // 
            // btnCadastrarExaminador
            // 
            this.btnCadastrarExaminador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarExaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarExaminador.Location = new System.Drawing.Point(16, 73);
            this.btnCadastrarExaminador.Name = "btnCadastrarExaminador";
            this.btnCadastrarExaminador.Size = new System.Drawing.Size(148, 35);
            this.btnCadastrarExaminador.TabIndex = 8;
            this.btnCadastrarExaminador.Text = "CADASTRAR";
            this.btnCadastrarExaminador.UseVisualStyleBackColor = false;
            this.btnCadastrarExaminador.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(638, 76);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 35);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(456, 76);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 35);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscarExaminador
            // 
            this.btnBuscarExaminador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarExaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarExaminador.Location = new System.Drawing.Point(254, 76);
            this.btnBuscarExaminador.Name = "btnBuscarExaminador";
            this.btnBuscarExaminador.Size = new System.Drawing.Size(134, 35);
            this.btnBuscarExaminador.TabIndex = 17;
            this.btnBuscarExaminador.Text = "BUSCAR";
            this.btnBuscarExaminador.UseVisualStyleBackColor = false;
            this.btnBuscarExaminador.Click += new System.EventHandler(this.btnBuscarExaminador_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(16, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 321);
            this.panel1.TabIndex = 20;
            // 
            // CrudExaminador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscarExaminador);
            this.Controls.Add(this.btnCadastrarExaminador);
            this.Controls.Add(this.btnVincularTcc);
            this.Controls.Add(this.dtNascimentoProfessor);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblExaminador);
            this.Controls.Add(this.tbExaminador);
            this.Name = "CrudExaminador";
            this.Text = "CrudProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbExaminador;
        private System.Windows.Forms.Label lblExaminador;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtNascimentoProfessor;
        private System.Windows.Forms.Button btnVincularTcc;
        private System.Windows.Forms.Button btnCadastrarExaminador;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscarExaminador;
        private System.Windows.Forms.Panel panel1;
    }
}