using PetForm.Animais_;
using PetForm.Clientes_;
using PetForm.Especies_;
using PetForm.Funcionarios_;
using PetForm.Raça_;
using PetForm.Servico_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Login_
{
	public partial class TelaInicial : Form
	{
		public TelaInicial()
		{
			InitializeComponent();
		}

		private void listarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarFuncionario listafunc = new ListarFuncionario();
			listafunc.Show();
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastrarFuncionario cadasfunci = new CadastrarFuncionario();
			cadasfunci.Show();
		}

		private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListarRaca listaraca = new ListarRaca();
			listaraca.Show();
		}

		private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CadastrarRaca cadastraca = new CadastrarRaca();
			cadastraca.Show();
		}

		private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ListarEspecie listaespec = new ListarEspecie();
			listaespec.Show();
		}

		private void cadastrarEditarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastraEspecie cadastespecie = new CadastraEspecie();
			cadastespecie.Show();
		}

		private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			ListarCliente listacliente = new ListarCliente();
			listacliente.Show();
		}

		private void cadastrarEditarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CadastrarCliente cadasclie = new CadastrarCliente();
			cadasclie.Show();
		}

		private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			ListarAnimal listanimal = new ListarAnimal();
			listanimal.Show();
		}

		private void cadastrarEditarToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			CadastrarAnimal cadastanimal = new CadastrarAnimal();
			cadastanimal.Show();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

			ListarServico listar = new ListarServico();
			listar.Show();
		}

		private void cadastrarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastrarServico cadast = new CadastrarServico();
			cadast.Show();
		}

		private void TelaInicial_Load(object sender, EventArgs e)
		{
			label2.Text = acessoGeral.Nomfunc;//Da o nome do funcionario
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NovoServico novo = new NovoServico();
			novo.Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void serviçosAbertosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarOrdem_Servico abrir = new ListarOrdem_Servico();
			abrir.Show();
		}
	}
}
