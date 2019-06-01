namespace ti_final_grafos
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDissimilaridadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarExaminador = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openArquivo = new System.Windows.Forms.OpenFileDialog();
            this.gerenciarGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabalhoToolStripMenuItem,
            this.matrizDissimilaridadeToolStripMenuItem,
            this.arquivoAlunosToolStripMenuItem});
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // trabalhoToolStripMenuItem
            // 
            this.trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            this.trabalhoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.trabalhoToolStripMenuItem.Text = "Trabalho";
            // 
            // matrizDissimilaridadeToolStripMenuItem
            // 
            this.matrizDissimilaridadeToolStripMenuItem.Name = "matrizDissimilaridadeToolStripMenuItem";
            this.matrizDissimilaridadeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.matrizDissimilaridadeToolStripMenuItem.Text = "Matriz dissimilaridade";
            this.matrizDissimilaridadeToolStripMenuItem.Click += new System.EventHandler(this.matrizDissimilaridadeToolStripMenuItem_Click);
            // 
            // arquivoAlunosToolStripMenuItem
            // 
            this.arquivoAlunosToolStripMenuItem.Name = "arquivoAlunosToolStripMenuItem";
            this.arquivoAlunosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.arquivoAlunosToolStripMenuItem.Text = "Arquivo alunos";
            this.arquivoAlunosToolStripMenuItem.Click += new System.EventHandler(this.arquivoAlunosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarAluno,
            this.gerenciarExaminador,
            this.gerenciarProfessor,
            this.gerenciarGrupos});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.abrirToolStripMenuItem.Text = "Gerenciar";
            // 
            // gerenciarAluno
            // 
            this.gerenciarAluno.Name = "gerenciarAluno";
            this.gerenciarAluno.Size = new System.Drawing.Size(180, 22);
            this.gerenciarAluno.Text = "Aluno";
            this.gerenciarAluno.Click += new System.EventHandler(this.gerenciarAluno_Click);
            // 
            // gerenciarExaminador
            // 
            this.gerenciarExaminador.Name = "gerenciarExaminador";
            this.gerenciarExaminador.Size = new System.Drawing.Size(180, 22);
            this.gerenciarExaminador.Text = "Examinador";
            this.gerenciarExaminador.Click += new System.EventHandler(this.gerenciarExaminador_Click);
            // 
            // gerenciarProfessor
            // 
            this.gerenciarProfessor.Name = "gerenciarProfessor";
            this.gerenciarProfessor.Size = new System.Drawing.Size(180, 22);
            this.gerenciarProfessor.Text = "Professor";
            this.gerenciarProfessor.Click += new System.EventHandler(this.gerenciarProfessor_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o programa";
            // 
            // openArquivo
            // 
            this.openArquivo.FileName = "openFileDialog1";
            // 
            // gerenciarGrupos
            // 
            this.gerenciarGrupos.Name = "gerenciarGrupos";
            this.gerenciarGrupos.Size = new System.Drawing.Size(180, 22);
            this.gerenciarGrupos.Text = "Grupos";
            this.gerenciarGrupos.Click += new System.EventHandler(this.gerenciarGrupos_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(429, 281);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDissimilaridadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAluno;
        private System.Windows.Forms.ToolStripMenuItem gerenciarExaminador;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProfessor;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoAlunosToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openArquivo;
        private System.Windows.Forms.ToolStripMenuItem gerenciarGrupos;
    }
}

