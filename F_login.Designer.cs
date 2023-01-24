namespace ProjetoEscola1
{
	partial class F_login
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
			this.bt1 = new System.Windows.Forms.Button();
			this.tb_user = new System.Windows.Forms.TextBox();
			this.tb_senha = new System.Windows.Forms.TextBox();
			this.lb_usuario = new System.Windows.Forms.Label();
			this.lb_senha = new System.Windows.Forms.Label();
			this.bt2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bt1
			// 
			this.bt1.Location = new System.Drawing.Point(32, 166);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(94, 33);
			this.bt1.TabIndex = 0;
			this.bt1.Text = "Login";
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.bt1_Click);
			// 
			// tb_user
			// 
			this.tb_user.Location = new System.Drawing.Point(32, 57);
			this.tb_user.Name = "tb_user";
			this.tb_user.Size = new System.Drawing.Size(210, 20);
			this.tb_user.TabIndex = 1;
			this.tb_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tb_senha
			// 
			this.tb_senha.Location = new System.Drawing.Point(32, 110);
			this.tb_senha.Name = "tb_senha";
			this.tb_senha.Size = new System.Drawing.Size(210, 20);
			this.tb_senha.TabIndex = 2;
			this.tb_senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lb_usuario
			// 
			this.lb_usuario.AutoSize = true;
			this.lb_usuario.Location = new System.Drawing.Point(29, 41);
			this.lb_usuario.Name = "lb_usuario";
			this.lb_usuario.Size = new System.Drawing.Size(43, 13);
			this.lb_usuario.TabIndex = 3;
			this.lb_usuario.Text = "Usuário";
			// 
			// lb_senha
			// 
			this.lb_senha.AutoSize = true;
			this.lb_senha.Location = new System.Drawing.Point(29, 94);
			this.lb_senha.Name = "lb_senha";
			this.lb_senha.Size = new System.Drawing.Size(38, 13);
			this.lb_senha.TabIndex = 4;
			this.lb_senha.Text = "Senha";
			// 
			// bt2
			// 
			this.bt2.Location = new System.Drawing.Point(148, 166);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(94, 33);
			this.bt2.TabIndex = 5;
			this.bt2.Text = "Cancelar";
			this.bt2.UseVisualStyleBackColor = true;
			this.bt2.Click += new System.EventHandler(this.bt2_Click);
			// 
			// F_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 228);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.lb_senha);
			this.Controls.Add(this.lb_usuario);
			this.Controls.Add(this.tb_senha);
			this.Controls.Add(this.tb_user);
			this.Controls.Add(this.bt1);
			this.Name = "F_login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.TextBox tb_user;
		private System.Windows.Forms.TextBox tb_senha;
		private System.Windows.Forms.Label lb_usuario;
		private System.Windows.Forms.Label lb_senha;
		private System.Windows.Forms.Button bt2;
	}
}