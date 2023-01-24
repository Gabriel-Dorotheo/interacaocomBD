namespace ProjetoEscola1
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb4 = new System.Windows.Forms.Label();
			this.lb3 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.lb1 = new System.Windows.Forms.Label();
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(470, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.loginToolStripMenuItem.Text = "Login";
			// 
			// logonToolStripMenuItem
			// 
			this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
			this.logonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.logonToolStripMenuItem.Text = "Logon";
			this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
			// 
			// logoffToolStripMenuItem
			// 
			this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
			this.logoffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.logoffToolStripMenuItem.Text = "Logoff";
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.visualizarToolStripMenuItem});
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.novoToolStripMenuItem.Text = "Novo";
			// 
			// gerenciamentoToolStripMenuItem
			// 
			this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
			this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.gerenciamentoToolStripMenuItem.Text = "Gerenciar";
			this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
			// 
			// visualizarToolStripMenuItem
			// 
			this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
			this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.visualizarToolStripMenuItem.Text = "Visualizar";
			// 
			// alunosToolStripMenuItem
			// 
			this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2,
            this.gerenciarToolStripMenuItem1});
			this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
			this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.alunosToolStripMenuItem.Text = "Alunos";
			// 
			// novoToolStripMenuItem2
			// 
			this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
			this.novoToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
			this.novoToolStripMenuItem2.Text = "Novo";
			// 
			// gerenciarToolStripMenuItem1
			// 
			this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
			this.gerenciarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.gerenciarToolStripMenuItem1.Text = "Gerenciar";
			// 
			// cursosToolStripMenuItem
			// 
			this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.gerenciarToolStripMenuItem});
			this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
			this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.cursosToolStripMenuItem.Text = "Cursos";
			// 
			// novoToolStripMenuItem1
			// 
			this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
			this.novoToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.novoToolStripMenuItem1.Text = "Novo";
			// 
			// gerenciarToolStripMenuItem
			// 
			this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
			this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.gerenciarToolStripMenuItem.Text = "Gerenciar";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel1.Controls.Add(this.lb4);
			this.panel1.Controls.Add(this.lb3);
			this.panel1.Controls.Add(this.lb2);
			this.panel1.Controls.Add(this.lb1);
			this.panel1.Controls.Add(this.pb1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 513);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(470, 51);
			this.panel1.TabIndex = 1;
			// 
			// lb4
			// 
			this.lb4.AutoSize = true;
			this.lb4.Location = new System.Drawing.Point(198, 26);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(13, 13);
			this.lb4.TabIndex = 5;
			this.lb4.Text = "--";
			// 
			// lb3
			// 
			this.lb3.AutoSize = true;
			this.lb3.Location = new System.Drawing.Point(155, 26);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(37, 13);
			this.lb3.TabIndex = 4;
			this.lb3.Text = "Nivel.:";
			// 
			// lb2
			// 
			this.lb2.AutoSize = true;
			this.lb2.Location = new System.Drawing.Point(98, 26);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(13, 13);
			this.lb2.TabIndex = 3;
			this.lb2.Text = "--";
			// 
			// lb1
			// 
			this.lb1.AutoSize = true;
			this.lb1.Location = new System.Drawing.Point(43, 26);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(49, 13);
			this.lb1.TabIndex = 2;
			this.lb1.Text = "Usuário.:";
			this.lb1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pb1
			// 
			this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
			this.pb1.Location = new System.Drawing.Point(12, 14);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(25, 25);
			this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb1.TabIndex = 0;
			this.pb1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 564);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lb4;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.PictureBox pb1;
	}
}

