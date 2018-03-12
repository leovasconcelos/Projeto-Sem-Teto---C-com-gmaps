namespace projetoInterdisciplinar
{
    partial class frmAssociar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAluno = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstVaga = new System.Windows.Forms.ListBox();
            this.gbxRep = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtAluguel = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.txtAlunoResp = new System.Windows.Forms.TextBox();
            this.txtNomeRep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepublica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 626);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // lstAluno
            // 
            this.lstAluno.FormattingEnabled = true;
            this.lstAluno.Location = new System.Drawing.Point(6, 19);
            this.lstAluno.Name = "lstAluno";
            this.lstAluno.Size = new System.Drawing.Size(183, 472);
            this.lstAluno.TabIndex = 0;
            this.lstAluno.SelectedIndexChanged += new System.EventHandler(this.lstAluno_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVaga);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 626);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vagas";
            // 
            // lstVaga
            // 
            this.lstVaga.FormattingEnabled = true;
            this.lstVaga.Location = new System.Drawing.Point(6, 19);
            this.lstVaga.Name = "lstVaga";
            this.lstVaga.Size = new System.Drawing.Size(183, 472);
            this.lstVaga.TabIndex = 2;
            this.lstVaga.SelectedIndexChanged += new System.EventHandler(this.lstVaga_SelectedIndexChanged);
            // 
            // gbxRep
            // 
            this.gbxRep.Controls.Add(this.label8);
            this.gbxRep.Controls.Add(this.txtDescricao);
            this.gbxRep.Controls.Add(this.txtAluguel);
            this.gbxRep.Controls.Add(this.txtTipo);
            this.gbxRep.Controls.Add(this.txtVagas);
            this.gbxRep.Controls.Add(this.txtCapacidade);
            this.gbxRep.Controls.Add(this.txtAlunoResp);
            this.gbxRep.Controls.Add(this.txtNomeRep);
            this.gbxRep.Controls.Add(this.label7);
            this.gbxRep.Controls.Add(this.label6);
            this.gbxRep.Controls.Add(this.label5);
            this.gbxRep.Controls.Add(this.label4);
            this.gbxRep.Controls.Add(this.label3);
            this.gbxRep.Controls.Add(this.label2);
            this.gbxRep.Location = new System.Drawing.Point(414, 12);
            this.gbxRep.Name = "gbxRep";
            this.gbxRep.Size = new System.Drawing.Size(498, 262);
            this.gbxRep.TabIndex = 3;
            this.gbxRep.TabStop = false;
            this.gbxRep.Text = "Republica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor do Aluguel";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(171, 175);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 67);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtAluguel
            // 
            this.txtAluguel.Location = new System.Drawing.Point(171, 149);
            this.txtAluguel.Name = "txtAluguel";
            this.txtAluguel.Size = new System.Drawing.Size(321, 20);
            this.txtAluguel.TabIndex = 12;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(171, 123);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(181, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // txtVagas
            // 
            this.txtVagas.Location = new System.Drawing.Point(171, 97);
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(100, 20);
            this.txtVagas.TabIndex = 10;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(171, 71);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidade.TabIndex = 9;
            // 
            // txtAlunoResp
            // 
            this.txtAlunoResp.Location = new System.Drawing.Point(171, 45);
            this.txtAlunoResp.Name = "txtAlunoResp";
            this.txtAlunoResp.Size = new System.Drawing.Size(321, 20);
            this.txtAlunoResp.TabIndex = 8;
            // 
            // txtNomeRep
            // 
            this.txtNomeRep.Location = new System.Drawing.Point(171, 19);
            this.txtNomeRep.Name = "txtNomeRep";
            this.txtNomeRep.Size = new System.Drawing.Size(321, 20);
            this.txtNomeRep.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descrição da Republica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo da Republica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero de Vagas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aluno Responsavel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Republica:";
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(471, 386);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(112, 60);
            this.btnAssociar.TabIndex = 4;
            this.btnAssociar.Text = "&Registrar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(483, 298);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(100, 20);
            this.txtAluno.TabIndex = 15;
            this.txtAluno.TextChanged += new System.EventHandler(this.txtAluno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Aluno:";
            // 
            // txtRepublica
            // 
            this.txtRepublica.Location = new System.Drawing.Point(483, 342);
            this.txtRepublica.Name = "txtRepublica";
            this.txtRepublica.Size = new System.Drawing.Size(100, 20);
            this.txtRepublica.TabIndex = 17;
            this.txtRepublica.TextChanged += new System.EventHandler(this.txtRepublica_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Republica:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(589, 386);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 60);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(707, 386);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 60);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "&Desvincular";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(821, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 60);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAssociar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 647);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtRepublica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssociar);
            this.Controls.Add(this.gbxRep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssociar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar";
            this.Load += new System.EventHandler(this.frmAssociar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbxRep.ResumeLayout(false);
            this.gbxRep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstAluno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstVaga;
        private System.Windows.Forms.GroupBox gbxRep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtAluguel;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtVagas;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.TextBox txtAlunoResp;
        private System.Windows.Forms.TextBox txtNomeRep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepublica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}