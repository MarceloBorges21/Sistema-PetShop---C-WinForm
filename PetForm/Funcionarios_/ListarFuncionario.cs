using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Funcionarios_
{
	public partial class ListarFuncionario : Form
	{
		public ListarFuncionario()
		{
			InitializeComponent();
		}

		private void ListarFuncionario_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet4.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.petShopDataSet4.Funcionario);

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0;
			string nome, documento, login, senha;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
					documento = dataGridView1.CurrentRow.Cells[2].Value.ToString();
					login = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
					senha = dataGridView1.CurrentRow.Cells[4].Value.ToString();


					var funcionarioss = new CadastrarFuncionario();
					funcionarioss.Carregafinci(Id, nome, documento, login, senha);
					funcionarioss.Show();
				}

			}
		}
	}
}
