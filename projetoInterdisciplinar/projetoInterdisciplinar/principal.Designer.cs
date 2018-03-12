namespace projetoInterdisciplinar
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msACadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.republicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msRVagas = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraVagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherVagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.msRRepublica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.republicaToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msACadastro});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Aluno";
            // 
            // msACadastro
            // 
            this.msACadastro.Name = "msACadastro";
            this.msACadastro.Size = new System.Drawing.Size(121, 22);
            this.msACadastro.Text = "Cadastro";
            this.msACadastro.Click += new System.EventHandler(this.msACadastro_Click);
            // 
            // republicaToolStripMenuItem
            // 
            this.republicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRCadastro,
            this.msRVagas});
            this.republicaToolStripMenuItem.Name = "republicaToolStripMenuItem";
            this.republicaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.republicaToolStripMenuItem.Text = "Republica";
            // 
            // msRCadastro
            // 
            this.msRCadastro.Name = "msRCadastro";
            this.msRCadastro.Size = new System.Drawing.Size(121, 22);
            this.msRCadastro.Text = "Cadastro";
            this.msRCadastro.Click += new System.EventHandler(this.msRCadastro_Click);
            // 
            // msRVagas
            // 
            this.msRVagas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraVagaToolStripMenuItem,
            this.escolherVagaToolStripMenuItem});
            this.msRVagas.Name = "msRVagas";
            this.msRVagas.Size = new System.Drawing.Size(152, 22);
            this.msRVagas.Text = "Vagas";
            // 
            // cadastraVagaToolStripMenuItem
            // 
            this.cadastraVagaToolStripMenuItem.Name = "cadastraVagaToolStripMenuItem";
            this.cadastraVagaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cadastraVagaToolStripMenuItem.Text = "Adicionar Vaga";
            this.cadastraVagaToolStripMenuItem.Click += new System.EventHandler(this.cadastraVagaToolStripMenuItem_Click);
            // 
            // escolherVagaToolStripMenuItem
            // 
            this.escolherVagaToolStripMenuItem.Name = "escolherVagaToolStripMenuItem";
            this.escolherVagaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.escolherVagaToolStripMenuItem.Text = "Escolher Vaga";
            this.escolherVagaToolStripMenuItem.Click += new System.EventHandler(this.escolherVagaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRAluno,
            this.msRRepublica});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // msRAluno
            // 
            this.msRAluno.Name = "msRAluno";
            this.msRAluno.Size = new System.Drawing.Size(126, 22);
            this.msRAluno.Text = "Aluno";
            // 
            // msRRepublica
            // 
            this.msRRepublica.Name = "msRRepublica";
            this.msRRepublica.Size = new System.Drawing.Size(126, 22);
            this.msRRepublica.Text = "Republica";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 354);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msACadastro;
        private System.Windows.Forms.ToolStripMenuItem republicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msRCadastro;
        private System.Windows.Forms.ToolStripMenuItem msRVagas;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msRAluno;
        private System.Windows.Forms.ToolStripMenuItem msRRepublica;
        private System.Windows.Forms.ToolStripMenuItem cadastraVagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolherVagaToolStripMenuItem;
    }
}