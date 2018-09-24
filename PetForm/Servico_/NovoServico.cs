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
	public partial class NovoServico : Form
	{
		public NovoServico()
		{
			
			InitializeComponent();
		}
		
		public static void Moeda(ref TextBox txt)
		{
			string n = string.Empty;
			decimal v = 0;
			try
			{
				n = txt.Text.Replace(",", "").Replace(".", "");
				if (n.Equals(""))
					n = "";
				n = n.PadLeft(3, '0');
				if(n.Length>3 & n.Substring(0,1) == "0")
					n = n.Substring(1, n.Length - 1);
				v = Convert.ToDecimal(n) / 100;
				txt.Text = string.Format("{0:N}", v);
				txt.SelectionStart = txt.Text.Length;
			}
			catch (Exception)
			{

				throw;
			}
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

		public void CarregaServico(int ID, int Animal, int Funcionario, string DataEnt, string DataSaid,
			string HoraEnt, string HoraSaid, int Servico, string Valor, string NomeDeixou, string NomePegou)
		{
			txtCodigo.Text = ID.ToString();
			cmdAnimal.SelectedValue = Animal;
			cmdFuncionario.SelectedValue = Funcionario;
			mtxtDataEnt.Text = DataEnt;
			mtxtDataSaid.Text = DataSaid;
			mtxtHoraEnt.Text = HoraEnt;
			mtztHoraSaid.Text = HoraSaid;
			cmdServico.SelectedValue = Servico;
			mtxtValor.Text = Valor;
			txtNomeDeixou.Text = NomeDeixou;
			txtNomePegou.Text = NomePegou;
			ativartxt();
		}
		public void ativartxt ()
		{
			label5.Enabled = true;
			label7.Enabled = true;
			label11.Enabled = true;
			label10.Enabled = true;
			txtNomePegou.Enabled = true;
			mtxtValor.Enabled = true;
			mtxtDataSaid.Enabled = true;
			mtztHoraSaid.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(mtxtDataEnt.Text) &&
			   !String.IsNullOrEmpty(mtxtHoraEnt.Text) 
			   && !String.IsNullOrEmpty(txtNomeDeixou.Text))
			{

				int animal = Convert.ToInt16(cmdAnimal.SelectedValue);
				int funcionario = Convert.ToInt16(cmdFuncionario.SelectedValue);
				DateTime dataent = Convert.ToDateTime(mtxtDataEnt.Text);
				DateTime datasaid = Convert.ToDateTime(mtxtDataSaid.Text);
				string horaent = mtxtHoraEnt.Text;
				string horasaid = mtztHoraSaid.Text;
				int servico = Convert.ToInt16(cmdServico.SelectedValue);
				decimal valor =Decimal.Parse(mtxtValor.Text);
				string nomedeixou = txtNomeDeixou.Text;
				string nomepegou = txtNomePegou.Text;


				int codigo = 0;

				if (!String.IsNullOrEmpty(txtCodigo.Text))
				{
					codigo = Convert.ToInt32(txtCodigo.Text);
				}

				try
				{
					if (codigo == 0) //insere
					{
						string mudar= mtxtDataSaid.Text = "10/10/2018";
						using (var ctx = new PetShopEntities())
						{
							Ordem_Serviço inserservico = new Ordem_Serviço();
							inserservico.Id_Animal = animal;
							inserservico.Id_Funcionario = funcionario;
							inserservico.DT_Entrada = dataent;
							inserservico.DT_Saida =DateTime.Now;
							inserservico.Hora_Entrada = horaent;
							inserservico.Hora_Saida = null;
							inserservico.Id_Servico = servico;
							inserservico.Valor = valor;
							inserservico.Nome_Deixou = nomedeixou;
							inserservico.Nome_Pegou = null;
							inserservico.Status = "A";

							ctx.Ordem_Serviço.Add(inserservico);
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
								var novoDados = update.Ordem_Serviço.Find(codigo);
								novoDados.Id_Animal = animal;
								novoDados.Id_Funcionario = funcionario;
								novoDados.DT_Entrada = dataent;
								novoDados.DT_Saida = datasaid;
								novoDados.Hora_Entrada = horaent;
								novoDados.Hora_Saida = horasaid;
								novoDados.Id_Servico = servico;
								novoDados.Valor = valor;
								novoDados.Nome_Deixou = nomedeixou;
								novoDados.Nome_Pegou = nomepegou;

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

		private void NovoServico_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet16.Servico'. Você pode movê-la ou removê-la conforme necessário.
			this.servicoTableAdapter.Fill(this.petShopDataSet16.Servico);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet15.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.petShopDataSet15.Funcionario);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet14.Animal'. Você pode movê-la ou removê-la conforme necessário.
			this.animalTableAdapter.Fill(this.petShopDataSet14.Animal);

		}

		private void mtxtValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		
		}

		private void mtxtValor_TextChanged(object sender, EventArgs e)
		{
			Moeda(ref mtxtValor);
		}

		private void mtxtDataSaid_EnabledChanged(object sender, EventArgs e)
		{

		}
	}
}
