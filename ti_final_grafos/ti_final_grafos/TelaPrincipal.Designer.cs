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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDissimilaridadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoDissimilaridadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emUmCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoExaminadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEmUmTCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraOrientarUmGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaDePesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaÁreaDePesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEmUmCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examinadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openArquivo = new System.Windows.Forms.OpenFileDialog();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.editarToolStripMenuItem1,
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
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoDissimilaridadeToolStripMenuItem,
            this.examinadorToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.areaDePesquisaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.abrirToolStripMenuItem.Text = "Cadastrar";
            // 
            // arquivoDissimilaridadeToolStripMenuItem
            // 
            this.arquivoDissimilaridadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.emUmCursoToolStripMenuItem});
            this.arquivoDissimilaridadeToolStripMenuItem.Name = "arquivoDissimilaridadeToolStripMenuItem";
            this.arquivoDissimilaridadeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.arquivoDissimilaridadeToolStripMenuItem.Text = "Aluno";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // emUmCursoToolStripMenuItem
            // 
            this.emUmCursoToolStripMenuItem.Name = "emUmCursoToolStripMenuItem";
            this.emUmCursoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.emUmCursoToolStripMenuItem.Text = "Em um curso";
            // 
            // examinadorToolStripMenuItem
            // 
            this.examinadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoExaminadorToolStripMenuItem,
            this.cadastrarEmUmTCCToolStripMenuItem});
            this.examinadorToolStripMenuItem.Name = "examinadorToolStripMenuItem";
            this.examinadorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.examinadorToolStripMenuItem.Text = "Examinador";
            // 
            // novoExaminadorToolStripMenuItem
            // 
            this.novoExaminadorToolStripMenuItem.Name = "novoExaminadorToolStripMenuItem";
            this.novoExaminadorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.novoExaminadorToolStripMenuItem.Text = "Novo Examinador";
            // 
            // cadastrarEmUmTCCToolStripMenuItem
            // 
            this.cadastrarEmUmTCCToolStripMenuItem.Name = "cadastrarEmUmTCCToolStripMenuItem";
            this.cadastrarEmUmTCCToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarEmUmTCCToolStripMenuItem.Text = "Cadastrar em um TCC";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProfessorToolStripMenuItem,
            this.paraOrientarUmGrupoToolStripMenuItem});
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // novoProfessorToolStripMenuItem
            // 
            this.novoProfessorToolStripMenuItem.Name = "novoProfessorToolStripMenuItem";
            this.novoProfessorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.novoProfessorToolStripMenuItem.Text = "Novo Professor";
            // 
            // paraOrientarUmGrupoToolStripMenuItem
            // 
            this.paraOrientarUmGrupoToolStripMenuItem.Name = "paraOrientarUmGrupoToolStripMenuItem";
            this.paraOrientarUmGrupoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paraOrientarUmGrupoToolStripMenuItem.Text = "Para orientar um grupo";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCursoToolStripMenuItem});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // novoCursoToolStripMenuItem
            // 
            this.novoCursoToolStripMenuItem.Name = "novoCursoToolStripMenuItem";
            this.novoCursoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.novoCursoToolStripMenuItem.Text = "Novo Curso";
            // 
            // areaDePesquisaToolStripMenuItem
            // 
            this.areaDePesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaÁreaDePesquisaToolStripMenuItem,
            this.adicionarEmUmCursoToolStripMenuItem});
            this.areaDePesquisaToolStripMenuItem.Name = "areaDePesquisaToolStripMenuItem";
            this.areaDePesquisaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.areaDePesquisaToolStripMenuItem.Text = "Area de Pesquisa";
            // 
            // novaÁreaDePesquisaToolStripMenuItem
            // 
            this.novaÁreaDePesquisaToolStripMenuItem.Name = "novaÁreaDePesquisaToolStripMenuItem";
            this.novaÁreaDePesquisaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.novaÁreaDePesquisaToolStripMenuItem.Text = "Nova Área de Pesquisa";
            // 
            // adicionarEmUmCursoToolStripMenuItem
            // 
            this.adicionarEmUmCursoToolStripMenuItem.Name = "adicionarEmUmCursoToolStripMenuItem";
            this.adicionarEmUmCursoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.adicionarEmUmCursoToolStripMenuItem.Text = "Adicionar em um curso";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem1,
            this.examinadorToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.professorToolStripMenuItem1.Text = "Professor";
            // 
            // examinadorToolStripMenuItem1
            // 
            this.examinadorToolStripMenuItem1.Name = "examinadorToolStripMenuItem1";
            this.examinadorToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.examinadorToolStripMenuItem1.Text = "Examinador";
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
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o programa";
            // 
            // openArquivo
            // 
            this.openArquivo.FileName = "openFileDialog1";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarGruposToolStripMenuItem,
            this.editarGruposToolStripMenuItem});
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // gerarGruposToolStripMenuItem
            // 
            this.gerarGruposToolStripMenuItem.Name = "gerarGruposToolStripMenuItem";
            this.gerarGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerarGruposToolStripMenuItem.Text = "Gerar grupos";
            this.gerarGruposToolStripMenuItem.Click += new System.EventHandler(this.gerarGruposToolStripMenuItem_Click);
            // 
            // editarGruposToolStripMenuItem
            // 
            this.editarGruposToolStripMenuItem.Name = "editarGruposToolStripMenuItem";
            this.editarGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarGruposToolStripMenuItem.Text = "Editar grupos";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(763, 589);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDissimilaridadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoDissimilaridadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emUmCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoExaminadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEmUmTCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraOrientarUmGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaDePesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaÁreaDePesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEmUmCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examinadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoAlunosToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openArquivo;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarGruposToolStripMenuItem;
    }
}

