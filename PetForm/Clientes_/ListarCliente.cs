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
	public partial class ListarCliente : Form
	{
		public ListarCliente()
		{
			InitializeComponent();
		}

		private void ListarCliente_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet6.Cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.clienteTableAdapter.Fill(this.petShopDataSet6.Cliente);

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0;
			string nome, documento, endereco, telefone;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
					endereco = dataGridView1.CurrentRow.Cells[2].Value.ToString();
					documento = dataGridView1.CurrentRow.Cells[3].Value.ToString();
					telefone = dataGridView1.CurrentRow.Cells[4].Value.ToString();


					var clientee = new CadastrarCliente();
					clientee.CarregaCliente(Id, nome, endereco, documento, telefone);
					clientee.Show();
				}
			}
		}
	}
}
