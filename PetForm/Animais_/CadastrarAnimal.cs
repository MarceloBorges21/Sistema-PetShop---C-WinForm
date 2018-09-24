using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Animais_
{
	public partial class CadastrarAnimal : Form
	{
		public CadastrarAnimal()
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

		public void CarregaAnimal(int ID, string Nome, string Data, string Obs, string Cliente, int Especie, int Raca)
		{
			txtCodigo.Text = ID.ToString();
			txtNome.Text = Nome;
			mtxtIdade.Text = Data;
			txtObs.Text = Obs;
			cmdCliente.SelectedValue = Cliente;
			cmdEspecie.SelectedValue = Especie;
			cmdRaca.SelectedValue = Raca;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(mtxtIdade.Text) && !String.IsNullOrEmpty(txtObs.Text))
			{
				int cliente = Convert.ToInt16(cmdCliente.SelectedValue);
				int especie = Convert.ToInt16(cmdEspecie.SelectedValue);
				int raca = Convert.ToInt16(cmdRaca.SelectedValue);
				string nome = txtNome.Text;
				string obs = txtObs.Text;
				DateTime date = Convert.ToDateTime(mtxtIdade.Text);

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
							Animal inseranimal = new Animal();
							inseranimal.Nome = nome.ToUpper();
							inseranimal.Id_Funcionario = acessoGeral.IdUsuario;
							inseranimal.Observacao = txtObs.Text.ToUpper();
							inseranimal.Idade = date;
							inseranimal.Id_Cliente = cliente;
							inseranimal.Id_Especie = especie;
							inseranimal.Id_Raca = raca;

							ctx.Animal.Add(inseranimal);
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
								var novoDados = update.Animal.Find(codigo);
								novoDados.Nome = nome.ToUpper();
								novoDados.Id_Funcionario = acessoGeral.IdUsuario;
								novoDados.Observacao = txtObs.Text.ToUpper();
								novoDados.Idade = date;
								novoDados.Id_Cliente = cliente;
								novoDados.Id_Especie = especie;
								novoDados.Id_Raca = raca;

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
				MessageBox.Show("Preencha Todo os campos!");

			}
		}

		private void CadastrarAnimal_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet3.Raca'. Você pode movê-la ou removê-la conforme necessário.
			this.racaTableAdapter.Fill(this.petShopDataSet3.Raca);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet2.Especie'. Você pode movê-la ou removê-la conforme necessário.
			this.especieTableAdapter.Fill(this.petShopDataSet2.Especie);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.clienteTableAdapter.Fill(this.petShopDataSet1.Cliente);

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

						var animal = context.Animal.Find(Convert.ToInt32(txtCodigo.Text));
						context.Animal.Remove(animal);
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
					txtCodigo.Text = "";
					txtObs.Text = "";
					mtxtIdade.Text = "";
					cmdRaca.SelectedText = "";
					cmdEspecie.SelectedText = "";
					cmdCliente.SelectedText = "";
				}

			}
		}
	}
}
