using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Clientes_
{
	public partial class CadastrarCliente : Form
	{
		public CadastrarCliente()
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

		public void CarregaCliente(int ID, string Nome, string Endereco, string Documento, string Telefone)
		{
			txtCodigo.Text = ID.ToString();
			txtNome.Text = Nome;
			txtEndereco.Text = Endereco;
			txtDocumento.Text = Documento;
			txtTelefone.Text = Telefone;

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEndereco.Text) && !String.IsNullOrEmpty(txtTelefone.Text))
			{
				string nome = txtNome.Text;
				string endereco = txtEndereco.Text;
				string documento = txtDocumento.Text;
				string telefone = txtTelefone.Text;

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
							Cliente insercliente = new Cliente();
							insercliente.Nome = nome.ToUpper();
							insercliente.Id_Funcionario = acessoGeral.IdUsuario;
							insercliente.Endereco = endereco.ToUpper();
							insercliente.Documento = documento.ToUpper();
							insercliente.Telefone = telefone;

							ctx.Cliente.Add(insercliente);
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
								var novoDados = update.Cliente.Find(codigo);
								novoDados.Nome = nome.ToUpper();
								novoDados.Endereco = endereco.ToUpper();
								novoDados.Documento = documento.ToUpper();
								novoDados.Telefone = telefone;
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

						var cliente = context.Cliente.Find(Convert.ToInt32(txtCodigo.Text));
						context.Cliente.Remove(cliente);
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
					txtNome.Text = "";
					txtEndereco.Text = "";
					txtDocumento.Text = "";
					txtTelefone.Text = "";

				}

			}
		}
	}
}
