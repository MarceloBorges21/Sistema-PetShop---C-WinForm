using PetForm.Funcionarios_;
using PetForm.Login_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			if (txtLogin.Text == "" || txtSenha.Text == "")
			{
				MessageBox.Show("Informe Login e Senha!");
				return;
			}
			try
			{
				Funcionario usuario = new Funcionario();
				usuario.Login = txtLogin.Text;

				var form = new CadastrarFuncionario();

				string cifra = form.Cifrar(txtSenha.Text);

				usuario.Senha = form.Cifrar(txtSenha.Text);

				if (GetUsuarioPorLoginSenha(usuario) != null)
				{
					acessoGeral.IdUsuario = BuscaId(usuario);
					acessoGeral.Nomfunc = BuscaNome(usuario);
					//Se retornar corretamente ele redireciona para tela primcipal
					TelaInicial abrir = new TelaInicial();
					abrir.Show();

					//deixa o form login invisivel, pois ele é o principal e n pode ser fechado
					this.Hide();
				}
				else
				{
					MessageBox.Show("Erro!");
					txtLogin.Text = "";
					txtSenha.Text = "";
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Erro = " + ex.Message);
			}
		}

		public Funcionario GetUsuarioPorLoginSenha(Funcionario registro)
		{
			using (var ctx = new PetShopEntities())
			{
				return ctx.Funcionario.FirstOrDefault(u => u.Login == registro.Login
					&& u.Senha == registro.Senha);
			}
		}
		public int BuscaId(Funcionario registro)
		{
			var ctx = new PetShopEntities();
			var query = from a in ctx.Funcionario
						where a.Login == registro.Login &&
						a.Senha == registro.Senha
						select a.Id;

			var resultado = query.First();

			return resultado;
		}

		public string BuscaNome(Funcionario registro)
		{
			var ctx = new PetShopEntities();
			var query = from a in ctx.Funcionario
						where a.Login == registro.Login && a.Senha == registro.Senha
						select a.Nome;

			var resultado = query.First();

			return resultado;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
