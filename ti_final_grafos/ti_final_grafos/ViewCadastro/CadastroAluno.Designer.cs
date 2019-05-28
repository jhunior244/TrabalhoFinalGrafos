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
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeAluno.Location = new System.Drawing.Point(93, 12);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(667, 29);
            this.tbNomeAluno.TabIndex = 0;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(12, 12);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(75, 24);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "ALUNO";
            // 
            // dtNascimentoAluno
            // 
            this.dtNascimentoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimentoAluno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimentoAluno.Location = new System.Drawing.Point(154, 47);
            this.dtNascimentoAluno.Name = "dtNascimentoAluno";
            this.dtNascimentoAluno.Size = new System.Drawing.Size(134, 29);
            this.dtNascimentoAluno.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 51);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(136, 24);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "NASCIMENTO";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(16, 85);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(148, 35);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "CADASTRAR";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(294, 51);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(76, 24);
            this.lblCurso.TabIndex = 7;
            this.lblCurso.Text = "CURSO";
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAluno.Location = new System.Drawing.Point(214, 85);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(134, 35);
            this.btnBuscarAluno.TabIndex = 9;
            this.btnBuscarAluno.Text = "BUSCAR";
            this.btnBuscarAluno.UseVisualStyleBackColor = false;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // cbCurso
            // 
            this.cbCurso.CausesValidation = false;
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(376, 48);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(384, 32);
            this.cbCurso.TabIndex = 13;
            this.cbCurso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCurso_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(16, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 473);
            this.panel1.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(598, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 35);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 611);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dtNascimentoAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.tbNomeAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastroAluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.DateTimePicker dtNascimentoAluno;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
    }
}