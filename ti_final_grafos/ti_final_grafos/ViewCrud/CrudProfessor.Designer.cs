namespace ti_final_grafos.ViewCrud
{
    partial class CrudProfessor
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
            this.tbProfessor = new System.Windows.Forms.TextBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtNascimentoProfessor = new System.Windows.Forms.DateTimePicker();
            this.btnVincularCurso = new System.Windows.Forms.Button();
            this.btnVincularAreaPesquisa = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarProfessor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbProfessor
            // 
            this.tbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfessor.Location = new System.Drawing.Point(145, 6);
            this.tbProfessor.Name = "tbProfessor";
            this.tbProfessor.Size = new System.Drawing.Size(643, 29);
            this.tbProfessor.TabIndex = 0;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(12, 9);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(127, 24);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "PROFESSOR";
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
            // btnVincularCurso
            // 
            this.btnVincularCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincularCurso.Location = new System.Drawing.Point(285, 38);
            this.btnVincularCurso.Name = "btnVincularCurso";
            this.btnVincularCurso.Size = new System.Drawing.Size(213, 32);
            this.btnVincularCurso.TabIndex = 6;
            this.btnVincularCurso.Text = "VINCULAR CURSO";
            this.btnVincularCurso.UseVisualStyleBackColor = true;
            this.btnVincularCurso.Click += new System.EventHandler(this.btnVincularCurso_Click);
            // 
            // btnVincularAreaPesquisa
            // 
            this.btnVincularAreaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincularAreaPesquisa.Location = new System.Drawing.Point(504, 38);
            this.btnVincularAreaPesquisa.Name = "btnVincularAreaPesquisa";
            this.btnVincularAreaPesquisa.Size = new System.Drawing.Size(284, 32);
            this.btnVincularAreaPesquisa.TabIndex = 7;
            this.btnVincularAreaPesquisa.Text = "VINCULAR AREA PESQUISA";
            this.btnVincularAreaPesquisa.UseVisualStyleBackColor = true;
            this.btnVincularAreaPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(16, 73);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(148, 35);
            this.btnCadastrarAluno.TabIndex = 8;
            this.btnCadastrarAluno.Text = "CADASTRAR";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(456, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarProfessor
            // 
            this.btnBuscarProfessor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfessor.Location = new System.Drawing.Point(254, 76);
            this.btnBuscarProfessor.Name = "btnBuscarProfessor";
            this.btnBuscarProfessor.Size = new System.Drawing.Size(134, 35);
            this.btnBuscarProfessor.TabIndex = 17;
            this.btnBuscarProfessor.Text = "BUSCAR";
            this.btnBuscarProfessor.UseVisualStyleBackColor = false;
            this.btnBuscarProfessor.Click += new System.EventHandler(this.btnBuscarProfessor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(16, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 321);
            this.panel1.TabIndex = 20;
            // 
            // CrudProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscarProfessor);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnVincularAreaPesquisa);
            this.Controls.Add(this.btnVincularCurso);
            this.Controls.Add(this.dtNascimentoProfessor);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.tbProfessor);
            this.Name = "CrudProfessor";
            this.Text = "CrudProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtNascimentoProfessor;
        private System.Windows.Forms.Button btnVincularCurso;
        private System.Windows.Forms.Button btnVincularAreaPesquisa;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarProfessor;
        private System.Windows.Forms.Panel panel1;
    }
}