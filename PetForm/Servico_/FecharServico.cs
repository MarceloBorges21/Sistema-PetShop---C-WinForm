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
	public partial class FecharServico : Form
	{
		public FecharServico()
		{
			InitializeComponent();
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
				decimal valor = Decimal.Parse(mtxtValor.Text);
				string nomedeixou = txtNomeDeixou.Text;
				string nomepegou = txtNomePegou.Text;


				int codigo = 0;

				if (!String.IsNullOrEmpty(txtCodigo.Text))
				{
					codigo = Convert.ToInt32(txtCodigo.Text);
				}

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
						novoDados.Status = "F";

						update.SaveChanges();
						MessageBox.Show("Registro Alterado com sucesso!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Um erro ocorreu durante a Edição: " + ex.Message);
				}
				finally
				{
					LimparTextBox(this);
					this.Hide();
				}
			}
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
				if (n.Length > 3 & n.Substring(0, 1) == "0")
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

		private void FecharServico_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet21.Servico'. Você pode movê-la ou removê-la conforme necessário.
			this.servicoTableAdapter.Fill(this.petShopDataSet21.Servico);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet20.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.petShopDataSet20.Funcionario);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet19.Animal'. Você pode movê-la ou removê-la conforme necessário.
			this.animalTableAdapter.Fill(this.petShopDataSet19.Animal);

		}

		private void mtxtValor_TextChanged(object sender, EventArgs e)
		{
			Moeda(ref mtxtValor);
		}
	}
}
