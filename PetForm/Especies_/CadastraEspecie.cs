using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Especies_
{
	public partial class CadastraEspecie : Form
	{
		public CadastraEspecie()
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

		public void CarregaEspecie(int ID, string Descricao)
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
							Especie inserraca = new Especie();
							inserraca.Descricao = descricao.ToUpper();
							inserraca.Id_Funcionario = acessoGeral.IdUsuario;


							ctx.Especie.Add(inserraca);
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
								var novoDados = update.Especie.Find(codigo);
								novoDados.Descricao = descricao.ToUpper();

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

						var especie = context.Especie.Find(Convert.ToInt32(txtCodigo.Text));
						context.Especie.Remove(especie);
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
