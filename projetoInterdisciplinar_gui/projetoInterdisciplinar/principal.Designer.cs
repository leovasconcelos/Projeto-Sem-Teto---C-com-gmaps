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
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLng = new System.Windows.Forms.TextBox();
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
            this.msRCadastro});
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
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolherToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.relatoriosToolStripMenuItem.Text = "Vagas";
            // 
            // escolherToolStripMenuItem
            // 
            this.escolherToolStripMenuItem.Name = "escolherToolStripMenuItem";
            this.escolherToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.escolherToolStripMenuItem.Text = "Escolher";
            this.escolherToolStripMenuItem.Click += new System.EventHandler(this.escolherToolStripMenuItem_Click);
            // 
            // Mapa
            // 
            this.Mapa.Bearing = 0F;
            this.Mapa.CanDragMap = true;
            this.Mapa.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa.GrayScaleMode = false;
            this.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa.LevelsKeepInMemmory = 5;
            this.Mapa.Location = new System.Drawing.Point(12, 73);
            this.Mapa.MarkersEnabled = true;
            this.Mapa.MaxZoom = 2;
            this.Mapa.MinZoom = 2;
            this.Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapa.Name = "Mapa";
            this.Mapa.NegativeMode = false;
            this.Mapa.PolygonsEnabled = true;
            this.Mapa.RetryLoadTile = 0;
            this.Mapa.RoutesEnabled = true;
            this.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa.ShowTileGridLines = false;
            this.Mapa.Size = new System.Drawing.Size(592, 269);
            this.Mapa.TabIndex = 2;
            this.Mapa.Zoom = 0D;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(12, 27);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(30, 20);
            this.txtLat.TabIndex = 3;
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(48, 27);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(30, 20);
            this.txtLng.TabIndex = 4;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 354);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.Mapa);
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
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolherToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLng;
    }
}