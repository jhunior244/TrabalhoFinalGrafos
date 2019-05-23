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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.dtNascimentoAluno = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.dtvInfAlunos = new System.Windows.Forms.DataGridView();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.cbAgruparPor = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvInfAlunos)).BeginInit();
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
            this.btnCadastrarAluno.Location = new System.Drawing.Point(181, 85);
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
            this.btnBuscarAluno.Location = new System.Drawing.Point(335, 85);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(134, 35);
            this.btnBuscarAluno.TabIndex = 9;
            this.btnBuscarAluno.Text = "BUSCAR";
            this.btnBuscarAluno.UseVisualStyleBackColor = false;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // dtvInfAlunos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvInfAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvInfAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvInfAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvInfAlunos.Location = new System.Drawing.Point(16, 125);
            this.dtvInfAlunos.Name = "dtvInfAlunos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvInfAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvInfAlunos.Size = new System.Drawing.Size(744, 474);
            this.dtvInfAlunos.TabIndex = 10;
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Location = new System.Drawing.Point(598, 87);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(162, 32);
            this.cbOrdenarPor.TabIndex = 11;
            this.cbOrdenarPor.Text = "ORDENAR POR";
            // 
            // cbAgruparPor
            // 
            this.cbAgruparPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgruparPor.FormattingEnabled = true;
            this.cbAgruparPor.Location = new System.Drawing.Point(12, 86);
            this.cbAgruparPor.Name = "cbAgruparPor";
            this.cbAgruparPor.Size = new System.Drawing.Size(163, 32);
            this.cbAgruparPor.TabIndex = 12;
            this.cbAgruparPor.Text = "AGRUPAR POR";
            // 
            // cbCurso
            // 
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
            this.button1.Location = new System.Drawing.Point(475, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.cbAgruparPor);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.dtvInfAlunos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvInfAlunos)).EndInit();
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
        private System.Windows.Forms.DataGridView dtvInfAlunos;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.ComboBox cbAgruparPor;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Button button1;
    }
}