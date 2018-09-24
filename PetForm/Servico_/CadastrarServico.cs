using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Servico_
{
	public partial class CadastrarServico : Form
	{
		public CadastrarServico()
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

		public void CarregaServico(int ID, string Descricao)
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
							Servico inserraca = new Servico();
							inserraca.Descricao = descricao.ToUpper();
							inserraca.Id_Funcionario = acessoGeral.IdUsuario;


							ctx.Servico.Add(inserraca);
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
								var novoDados = update.Servico.Find(codigo);
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

						var servico = context.Servico.Find(Convert.ToInt32(txtCodigo.Text));
						context.Servico.Remove(servico);
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
