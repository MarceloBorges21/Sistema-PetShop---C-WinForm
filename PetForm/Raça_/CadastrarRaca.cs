using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Raça_
{
	public partial class CadastrarRaca : Form
	{
		public CadastrarRaca()
		{
			InitializeComponent();
		}

		void LimparTextBox(Control con)
		{
			foreach (Control c in con.Controls)
			{
				if (c is TextBox)
					((TextBox)c).Clear();
				else
					LimparTextBox(c);
			}
		}

		public void Carregaraca(int ID, string Descricao)
		{
			txtCodigo.Text = ID.ToString();
			txtDescricao.Text = Descricao;

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtDescricao.Text))
			{
				string descricao = txtDescricao.Text;

				int codigo = 0;

				if (!String.IsNullOrEmpty(txtCodigo.Text))
				{
					codigo = Convert.ToInt32(txtCodigo.Text);
				}

				try
				{
					if (codigo == 0) //insere
					{
						using (var ctx = new PetShopEntities())
						{
							Raca inserraca = new Raca();
							inserraca.Descricao = descricao.ToUpper();
							inserraca.Id_Funcionario = acessoGeral.IdUsuario;


							ctx.Raca.Add(inserraca);
							ctx.SaveChanges();
							MessageBox.Show("Registro Salvo com sucesso!");
						}
					}
					else //update
					{
						try
						{
							using (PetShopEntities update = new PetShopEntities())
							{
								var novoDados = update.Raca.Find(codigo);
								novoDados.Descricao = descricao.ToUpper();
								novoDados.Id_Funcionario = acessoGeral.IdUsuario;


								update.SaveChanges();
								MessageBox.Show("Registro Alterado com sucesso!");
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Um erro ocorreu durante a inserção: " + ex.Message);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Um erro ocorreu durante a inserção: " + ex.Message);
				}
				finally
				{
					LimparTextBox(this);
				}

			}
			else
			{
				MessageBox.Show("Preencha Descrição e Funcionario!");

			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//Rotina para exclusão
				try
				{
					using (var context = new PetShopEntities())
					{

						var raca = context.Raca.Find(Convert.ToInt32(txtCodigo.Text));
						context.Raca.Remove(raca);
						context.SaveChanges();
					}
					MessageBox.Show("Registro excluído com sucesso", "Sucesso");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro de : " + ex);
				}
				finally
				{
					txtDescricao.Text = "";
					txtCodigo.Text = "";
				}

			}
		}
	}
}
