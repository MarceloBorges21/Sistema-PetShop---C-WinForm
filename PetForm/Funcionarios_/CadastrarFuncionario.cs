using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm.Funcionarios_
{
	public partial class CadastrarFuncionario : Form
	{
		public CadastrarFuncionario()
		{
			InitializeComponent();
		}

		public void Carregafinci(int ID, string Nome, string Documento, string Login, string Senha)
		{
			txtCodigo.Text = ID.ToString();
			txtNome.Text = Nome;
			txtDocumento.Text = Documento.ToString();
			txtLogin.Text = Login;
			txtSenha.Text = Senha;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtDocumento.Text) && !String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
			{
				string nome = txtNome.Text;
				string documento = txtDocumento.Text;
				string login = txtLogin.Text;
				string senha = txtSenha.Text;
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
							Funcionario inserfuncion = new Funcionario();
							inserfuncion.Nome = nome.ToUpper();
							inserfuncion.Documento = documento;
							inserfuncion.Login = login;
							inserfuncion.Senha = Cifrar(senha);

							ctx.Funcionario.Add(inserfuncion);
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
								var novoDados = update.Funcionario.Find(codigo);
								novoDados.Nome = nome.ToUpper();
								novoDados.Documento = documento;
								novoDados.Login = login;
								novoDados.Senha = Cifrar(senha);

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
				MessageBox.Show("Preencha Nome, Documento, Login e Senha!");

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
		public string Cifrar(string textoPuro)
		{
			string chaveCifragem = "MACVS2014XYW";
			byte[] bytesLimpos = Encoding.Unicode.GetBytes(textoPuro);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCifragem,
					new byte[]
			  { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65,
				  0x64, 0x65, 0x76 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms,
						encryptor.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesLimpos, 0, bytesLimpos.Length);
						cs.Close();
					}
					textoPuro = Convert.ToBase64String(ms.ToArray());
				}
			}
			return textoPuro;
		}
		public string Decifrar(string textoCifrado)
		{
			string chaveCifragem = "MACVS2014XYW";
			byte[] bytesCifrados = Convert.FromBase64String(textoCifrado);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCifragem, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesCifrados, 0, bytesCifrados.Length);
						cs.Close();
					}
					textoCifrado = Encoding.Unicode.GetString(ms.ToArray());
				}
			}
			return textoCifrado;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtDocumento.Text) && !String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
			{
				if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					//Rotina para exclusão
					try
					{
						using (var exclui = new PetShopEntities())
						{

							var funci = exclui.Funcionario.Find(Convert.ToInt32(txtCodigo.Text));
							exclui.Funcionario.Remove(funci);
							exclui.SaveChanges();
						}
						MessageBox.Show("Registro excluído com sucesso", "Sucesso");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Ocorreu um erro de : " + ex);
					}
					finally
					{
						LimparTextBox(this);
					}
				}
				else
				{
					MessageBox.Show("Digite os registros a serem excluidos");
				}

			}
		}
	}
}
