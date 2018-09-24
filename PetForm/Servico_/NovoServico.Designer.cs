namespace PetForm.Servico_
{
	partial class NovoServico
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmdAnimal = new System.Windows.Forms.ComboBox();
			this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet14 = new PetForm.PetShopDataSet14();
			this.cmdFuncionario = new System.Windows.Forms.ComboBox();
			this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet15 = new PetForm.PetShopDataSet15();
			this.cmdServico = new System.Windows.Forms.ComboBox();
			this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet16 = new PetForm.PetShopDataSet16();
			this.mtxtDataEnt = new System.Windows.Forms.MaskedTextBox();
			this.mtxtHoraEnt = new System.Windows.Forms.MaskedTextBox();
			this.txtNomeDeixou = new System.Windows.Forms.TextBox();
			this.txtNomePegou = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.animalTableAdapter = new PetForm.PetShopDataSet14TableAdapters.AnimalTableAdapter();
			this.funcionarioTableAdapter = new PetForm.PetShopDataSet15TableAdapters.FuncionarioTableAdapter();
			this.servicoTableAdapter = new PetForm.PetShopDataSet16TableAdapters.ServicoTableAdapter();
			this.mtxtValor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mtztHoraSaid = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mtxtDataSaid = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet16)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastra/Edita/Exclui";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 84);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome animal :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 130);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Funcionario :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 181);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Data Entrada :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(215, 184);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Hora Entrada :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 282);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "Serviço :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(18, 350);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(175, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "Nome de Quem Deixou :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Enabled = false;
			this.label10.Location = new System.Drawing.Point(19, 382);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(180, 16);
			this.label10.TabIndex = 9;
			this.label10.Text = "Nome De Quem Buscou :";
			// 
			// cmdAnimal
			// 
			this.cmdAnimal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "Id", true));
			this.cmdAnimal.DataSource = this.animalBindingSource;
			this.cmdAnimal.DisplayMember = "Nome";
			this.cmdAnimal.FormattingEnabled = true;
			this.cmdAnimal.Location = new System.Drawing.Point(132, 81);
			this.cmdAnimal.Name = "cmdAnimal";
			this.cmdAnimal.Size = new System.Drawing.Size(121, 24);
			this.cmdAnimal.TabIndex = 10;
			this.cmdAnimal.ValueMember = "Id";
			// 
			// animalBindingSource
			// 
			this.animalBindingSource.DataMember = "Animal";
			this.animalBindingSource.DataSource = this.petShopDataSet14;
			// 
			// petShopDataSet14
			// 
			this.petShopDataSet14.DataSetName = "PetShopDataSet14";
			this.petShopDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmdFuncionario
			// 
			this.cmdFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "Id", true));
			this.cmdFuncionario.DataSource = this.funcionarioBindingSource;
			this.cmdFuncionario.DisplayMember = "Nome";
			this.cmdFuncionario.FormattingEnabled = true;
			this.cmdFuncionario.Location = new System.Drawing.Point(126, 124);
			this.cmdFuncionario.Name = "cmdFuncionario";
			this.cmdFuncionario.Size = new System.Drawing.Size(121, 24);
			this.cmdFuncionario.TabIndex = 11;
			this.cmdFuncionario.ValueMember = "Id";
			// 
			// funcionarioBindingSource
			// 
			this.funcionarioBindingSource.DataMember = "Funcionario";
			this.funcionarioBindingSource.DataSource = this.petShopDataSet15;
			// 
			// petShopDataSet15
			// 
			this.petShopDataSet15.DataSetName = "PetShopDataSet15";
			this.petShopDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmdServico
			// 
			this.cmdServico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servicoBindingSource, "Id", true));
			this.cmdServico.DataSource = this.servicoBindingSource;
			this.cmdServico.DisplayMember = "Descricao";
			this.cmdServico.FormattingEnabled = true;
			this.cmdServico.Location = new System.Drawing.Point(97, 279);
			this.cmdServico.Name = "cmdServico";
			this.cmdServico.Size = new System.Drawing.Size(195, 24);
			this.cmdServico.TabIndex = 12;
			this.cmdServico.ValueMember = "Id";
			// 
			// servicoBindingSource
			// 
			this.servicoBindingSource.DataMember = "Servico";
			this.servicoBindingSource.DataSource = this.petShopDataSet16;
			// 
			// petShopDataSet16
			// 
			this.petShopDataSet16.DataSetName = "PetShopDataSet16";
			this.petShopDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// mtxtDataEnt
			// 
			this.mtxtDataEnt.Location = new System.Drawing.Point(126, 178);
			this.mtxtDataEnt.Mask = "00/00/0000";
			this.mtxtDataEnt.Name = "mtxtDataEnt";
			this.mtxtDataEnt.Size = new System.Drawing.Size(82, 22);
			this.mtxtDataEnt.TabIndex = 13;
			this.mtxtDataEnt.ValidatingType = typeof(System.DateTime);
			// 
			// mtxtHoraEnt
			// 
			this.mtxtHoraEnt.Location = new System.Drawing.Point(330, 181);
			this.mtxtHoraEnt.Mask = "00:00";
			this.mtxtHoraEnt.Name = "mtxtHoraEnt";
			this.mtxtHoraEnt.Size = new System.Drawing.Size(46, 22);
			this.mtxtHoraEnt.TabIndex = 16;
			this.mtxtHoraEnt.ValidatingType = typeof(System.DateTime);
			// 
			// txtNomeDeixou
			// 
			this.txtNomeDeixou.Location = new System.Drawing.Point(194, 347);
			this.txtNomeDeixou.Name = "txtNomeDeixou";
			this.txtNomeDeixou.Size = new System.Drawing.Size(211, 22);
			this.txtNomeDeixou.TabIndex = 17;
			// 
			// txtNomePegou
			// 
			this.txtNomePegou.Enabled = false;
			this.txtNomePegou.Location = new System.Drawing.Point(200, 379);
			this.txtNomePegou.Name = "txtNomePegou";
			this.txtNomePegou.Size = new System.Drawing.Size(211, 22);
			this.txtNomePegou.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(132, 417);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 38);
			this.button1.TabIndex = 19;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(24, 13);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigo.TabIndex = 20;
			this.txtCodigo.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Enabled = false;
			this.label11.Location = new System.Drawing.Point(21, 322);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 16);
			this.label11.TabIndex = 22;
			this.label11.Text = "Valor :";
			// 
			// animalTableAdapter
			// 
			this.animalTableAdapter.ClearBeforeFill = true;
			// 
			// funcionarioTableAdapter
			// 
			this.funcionarioTableAdapter.ClearBeforeFill = true;
			// 
			// servicoTableAdapter
			// 
			this.servicoTableAdapter.ClearBeforeFill = true;
			// 
			// mtxtValor
			// 
			this.mtxtValor.Enabled = false;
			this.mtxtValor.Location = new System.Drawing.Point(80, 319);
			this.mtxtValor.Name = "mtxtValor";
			this.mtxtValor.Size = new System.Drawing.Size(100, 22);
			this.mtxtValor.TabIndex = 23;
			this.mtxtValor.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Enabled = false;
			this.label7.Location = new System.Drawing.Point(197, 234);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Hora Saida :";
			// 
			// mtztHoraSaid
			// 
			this.mtztHoraSaid.Enabled = false;
			this.mtztHoraSaid.Location = new System.Drawing.Point(299, 231);
			this.mtztHoraSaid.Mask = "00:00";
			this.mtztHoraSaid.Name = "mtztHoraSaid";
			this.mtztHoraSaid.Size = new System.Drawing.Size(48, 22);
			this.mtztHoraSaid.TabIndex = 15;
			this.mtztHoraSaid.ValidatingType = typeof(System.DateTime);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Enabled = false;
			this.label5.Location = new System.Drawing.Point(18, 234);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Data Saida :";
			// 
			// mtxtDataSaid
			// 
			this.mtxtDataSaid.Enabled = false;
			this.mtxtDataSaid.Location = new System.Drawing.Point(110, 231);
			this.mtxtDataSaid.Mask = "00/00/0000";
			this.mtxtDataSaid.Name = "mtxtDataSaid";
			this.mtxtDataSaid.Size = new System.Drawing.Size(80, 22);
			this.mtxtDataSaid.TabIndex = 14;
			this.mtxtDataSaid.ValidatingType = typeof(System.DateTime);
			this.mtxtDataSaid.EnabledChanged += new System.EventHandler(this.mtxtDataSaid_EnabledChanged);
			// 
			// NovoServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(417, 461);
			this.Controls.Add(this.mtxtValor);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtNomePegou);
			this.Controls.Add(this.txtNomeDeixou);
			this.Controls.Add(this.mtxtHoraEnt);
			this.Controls.Add(this.mtztHoraSaid);
			this.Controls.Add(this.mtxtDataSaid);
			this.Controls.Add(this.mtxtDataEnt);
			this.Controls.Add(this.cmdServico);
			this.Controls.Add(this.cmdFuncionario);
			this.Controls.Add(this.cmdAnimal);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NovoServico";
			this.Text = "Novo Servico";
			this.Load += new System.EventHandler(this.NovoServico_Load);
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet16)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmdAnimal;
		private System.Windows.Forms.ComboBox cmdFuncionario;
		private System.Windows.Forms.ComboBox cmdServico;
		private System.Windows.Forms.MaskedTextBox mtxtDataEnt;
		private System.Windows.Forms.MaskedTextBox mtxtHoraEnt;
		private System.Windows.Forms.TextBox txtNomeDeixou;
		private System.Windows.Forms.TextBox txtNomePegou;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label11;
		private PetShopDataSet14 petShopDataSet14;
		private System.Windows.Forms.BindingSource animalBindingSource;
		private PetShopDataSet14TableAdapters.AnimalTableAdapter animalTableAdapter;
		private PetShopDataSet15 petShopDataSet15;
		private System.Windows.Forms.BindingSource funcionarioBindingSource;
		private PetShopDataSet15TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
		private PetShopDataSet16 petShopDataSet16;
		private System.Windows.Forms.BindingSource servicoBindingSource;
		private PetShopDataSet16TableAdapters.ServicoTableAdapter servicoTableAdapter;
		private System.Windows.Forms.TextBox mtxtValor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox mtztHoraSaid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox mtxtDataSaid;
	}
}