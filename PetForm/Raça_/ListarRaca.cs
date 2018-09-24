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
	public partial class ListarRaca : Form
	{
		public ListarRaca()
		{
			InitializeComponent();
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


					var raca = new CadastrarRaca();
					raca.Carregaraca(Id, descricao);
					raca.Show();
				}
			}
		}

		private void ListarRaca_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet7.Raca'. Você pode movê-la ou removê-la conforme necessário.
			this.racaTableAdapter.Fill(this.petShopDataSet7.Raca);

		}
	}
}
