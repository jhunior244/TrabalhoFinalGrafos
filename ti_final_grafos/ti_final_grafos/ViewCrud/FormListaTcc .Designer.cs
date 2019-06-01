namespace ti_final_grafos.ViewCrud
{
    partial class FormListaTcc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkTcc = new System.Windows.Forms.CheckedListBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkTcc);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 331);
            this.panel1.TabIndex = 0;
            // 
            // checkTcc
            // 
            this.checkTcc.FormattingEnabled = true;
            this.checkTcc.Location = new System.Drawing.Point(6, 6);
            this.checkTcc.Margin = new System.Windows.Forms.Padding(6);
            this.checkTcc.Name = "checkTcc";
            this.checkTcc.ScrollAlwaysVisible = true;
            this.checkTcc.Size = new System.Drawing.Size(327, 316);
            this.checkTcc.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(134, 356);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(102, 34);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // FormListaTcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 399);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormListaTcc";
            this.Text = "FormListaCurso";
            this.Load += new System.EventHandler(this.FormListaCurso_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkTcc;
        private System.Windows.Forms.Button btnAplicar;
    }
}