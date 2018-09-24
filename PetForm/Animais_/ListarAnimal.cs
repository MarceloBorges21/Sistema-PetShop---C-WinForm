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
	public partial class ListarAnimal : Form
	{
		public ListarAnimal()
		{
			InitializeComponent();
		}

		private void ListarAnimal_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet11.View_2'. Você pode movê-la ou removê-la conforme necessário.
			this.view_2TableAdapter2.Fill(this.petShopDataSet11.View_2);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet10.View_2'. Você pode movê-la ou removê-la conforme necessário.
			this.view_2TableAdapter1.Fill(this.petShopDataSet10.View_2);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet9.View_2'. Você pode movê-la ou removê-la conforme necessário.
			this.view_2TableAdapter.Fill(this.petShopDataSet9.View_2);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet8.Animal'. Você pode movê-la ou removê-la conforme necessário.
			this.animalTableAdapter.Fill(this.petShopDataSet8.Animal);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet.ViewParaTabelaAnimal'. Você pode movê-la ou removê-la conforme necessário.
			//this.viewParaTabelaAnimalTableAdapter.Fill(this.petShopDataSet.ViewParaTabelaAnimal);

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0, id_raca = 0,  id_especie = 0, id_func = 0 ;
			string nome, idade, obs, id_cliente;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					id_cliente =(dataGridView1.CurrentRow.Cells[2].Value).ToString();
					id_raca = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
					id_especie = Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value);
					id_func = Convert.ToInt16(dataGridView1.CurrentRow.Cells[8].Value);
					nome = dataGridView1.CurrentRow.Cells[9].Value.ToString();
					idade = dataGridView1.CurrentRow.Cells[10].Value.ToString();
					obs = dataGridView1.CurrentRow.Cells[11].Value.ToString();


					var animal = new CadastrarAnimal();
					animal.CarregaAnimal(Id, nome, idade, obs, id_cliente, id_especie, id_raca);
					animal.Show();

				}

			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
