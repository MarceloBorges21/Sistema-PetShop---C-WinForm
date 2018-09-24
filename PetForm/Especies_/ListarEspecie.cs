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
	public partial class ListarEspecie : Form
	{
		public ListarEspecie()
		{
			InitializeComponent();
		}

		private void ListarEspecie_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet5.Especie'. Você pode movê-la ou removê-la conforme necessário.
			this.especieTableAdapter.Fill(this.petShopDataSet5.Especie);

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0;
			string descricao;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					descricao = dataGridView1.CurrentRow.Cells[1].Value.ToString();

					var especie = new CadastraEspecie();
					especie.CarregaEspecie(Id, descricao);
					especie.Show();
				}
			}
		}
	}
}
