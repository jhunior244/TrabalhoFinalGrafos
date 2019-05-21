namespace ti_final_grafos.ViewCadastro
{
    partial class CadastroAluno
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
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.dtNascimentoAluno = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeAluno.Location = new System.Drawing.Point(93, 71);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(389, 29);
            this.tbNomeAluno.TabIndex = 0;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(12, 74);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(75, 24);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "ALUNO";
            // 
            // dtNascimentoAluno
            // 
            this.dtNascimentoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimentoAluno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimentoAluno.Location = new System.Drawing.Point(177, 117);
            this.dtNascimentoAluno.Name = "dtNascimentoAluno";
            this.dtNascimentoAluno.Size = new System.Drawing.Size(201, 29);
            this.dtNascimentoAluno.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 121);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(136, 24);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "NASCIMENTO";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(177, 187);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(138, 37);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "CADASTRAR";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 287);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dtNascimentoAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.tbNomeAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastroAluno";
            this.Text = "Cadastro Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.DateTimePicker dtNascimentoAluno;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btnCadastrarAluno;
    }
}