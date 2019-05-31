namespace ti_final_grafos.ViewCrud
{
    partial class FormListaAreaPesquisa
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
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkAreaPesquisa = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(136, 353);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(102, 34);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkAreaPesquisa);
            this.panel1.Location = new System.Drawing.Point(16, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 331);
            this.panel1.TabIndex = 2;
            // 
            // checkAreaPesquisa
            // 
            this.checkAreaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAreaPesquisa.FormattingEnabled = true;
            this.checkAreaPesquisa.Location = new System.Drawing.Point(6, 6);
            this.checkAreaPesquisa.Margin = new System.Windows.Forms.Padding(6);
            this.checkAreaPesquisa.Name = "checkAreaPesquisa";
            this.checkAreaPesquisa.ScrollAlwaysVisible = true;
            this.checkAreaPesquisa.Size = new System.Drawing.Size(327, 319);
            this.checkAreaPesquisa.TabIndex = 0;
            // 
            // FormListaAreaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 391);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.panel1);
            this.Name = "FormListaAreaPesquisa";
            this.Text = "FormAreaPesquisa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkAreaPesquisa;
    }
}