using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola1
{
	public partial class F_login : Form
	{
		public F_login()
		{
			InitializeComponent();
		}

		private void bt1_Click(object sender, EventArgs e)
		{
			string username = tb_user.Text;
			string senha = tb_senha.Text;
			if(username == "" || senha == "")
			{
				MessageBox.Show("Preencha todos os campos!");
				tb_user.Focus();
				return;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void bt2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
