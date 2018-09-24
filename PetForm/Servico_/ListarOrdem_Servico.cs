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
	public partial class ListarOrdem_Servico : Form
	{
		public ListarOrdem_Servico()
		{
			InitializeComponent();
		}

		private void ListarOrdem_Servico_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet18.View_OedemServico'. Você pode movê-la ou removê-la conforme necessário.
			this.view_OedemServicoTableAdapter1.Fill(this.petShopDataSet18.View_OedemServico);
			// TODO: esta linha de código carrega dados na tabela 'petShopDataSet17.View_OedemServico'. Você pode movê-la ou removê-la conforme necessário.
			this.view_OedemServicoTableAdapter.Fill(this.petShopDataSet17.View_OedemServico);

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0, id_animal = 0, id_funcionario = 0, id_servico = 0;
			string dataent, datasaid, horaent, horasaid, valor, nomedeixou, nomepegou;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					id_animal = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
					id_funcionario = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
					dataent = dataGridView1.CurrentRow.Cells[5].Value.ToString();
					datasaid = dataGridView1.CurrentRow.Cells[6].Value.ToString();
					horaent = dataGridView1.CurrentRow.Cells[7].Value.ToString();
					horasaid = dataGridView1.CurrentRow.Cells[8].Value.ToString();
					id_servico = Convert.ToInt16(dataGridView1.CurrentRow.Cells[10].Value);
					valor = dataGridView1.CurrentRow.Cells[11].Value.ToString();
					nomedeixou = dataGridView1.CurrentRow.Cells[12].Value.ToString();
					nomepegou = dataGridView1.CurrentRow.Cells[13].Value.ToString();


					var servico = new NovoServico();
					servico.CarregaServico(Id, id_animal,id_funcionario, dataent, datasaid, horaent, horasaid, id_servico, valor, nomedeixou, nomepegou) ;
					servico.Show();

				}

			}
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.view_OedemServicoTableAdapter.FillBy(this.petShopDataSet17.View_OedemServico);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.view_OedemServicoTableAdapter.FillBy1(this.petShopDataSet17.View_OedemServico);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.view_OedemServicoTableAdapter.FillBy2(this.petShopDataSet17.View_OedemServico);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillByToolStripButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.view_OedemServicoTableAdapter1.FillBy(this.petShopDataSet18.View_OedemServico);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			var indice = dataGridView1.CurrentRow.Index;
			int Id = 0, id_animal = 0, id_funcionario = 0, id_servico = 0;
			string dataent, datasaid, horaent, horasaid, valor, nomedeixou, nomepegou;

			if (indice >= 0)
			{
				var linha = dataGridView1.Rows[indice];
				if (!linha.IsNewRow)
				{
					Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
					id_animal = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
					id_funcionario = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
					dataent = dataGridView1.CurrentRow.Cells[5].Value.ToString();
					datasaid = dataGridView1.CurrentRow.Cells[6].Value.ToString();
					horaent = dataGridView1.CurrentRow.Cells[7].Value.ToString();
					horasaid = dataGridView1.CurrentRow.Cells[8].Value.ToString();
					id_servico = Convert.ToInt16(dataGridView1.CurrentRow.Cells[10].Value);
					valor = dataGridView1.CurrentRow.Cells[11].Value.ToString();
					nomedeixou = dataGridView1.CurrentRow.Cells[12].Value.ToString();
					nomepegou = dataGridView1.CurrentRow.Cells[13].Value.ToString();


					var servico = new FecharServico();
					servico.CarregaServico(Id, id_animal, id_funcionario, dataent, datasaid, horaent, horasaid, id_servico, valor, nomedeixou, nomepegou);
					servico.Show();
				}

			}
		}
	}
}
