namespace PetForm.Servico_
{
	partial class FecharServico
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
			this.mtxtValor = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtNomePegou = new System.Windows.Forms.TextBox();
			this.txtNomeDeixou = new System.Windows.Forms.TextBox();
			this.mtxtHoraEnt = new System.Windows.Forms.MaskedTextBox();
			this.mtztHoraSaid = new System.Windows.Forms.MaskedTextBox();
			this.mtxtDataSaid = new System.Windows.Forms.MaskedTextBox();
			this.mtxtDataEnt = new System.Windows.Forms.MaskedTextBox();
			this.cmdServico = new System.Windows.Forms.ComboBox();
			this.cmdFuncionario = new System.Windows.Forms.ComboBox();
			this.cmdAnimal = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.petShopDataSet19 = new PetForm.PetShopDataSet19();
			this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.animalTableAdapter = new PetForm.PetShopDataSet19TableAdapters.AnimalTableAdapter();
			this.petShopDataSet20 = new PetForm.PetShopDataSet20();
			this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.funcionarioTableAdapter = new PetForm.PetShopDataSet20TableAdapters.FuncionarioTableAdapter();
			this.petShopDataSet21 = new PetForm.PetShopDataSet21();
			this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.servicoTableAdapter = new PetForm.PetShopDataSet21TableAdapters.ServicoTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mtxtValor
			// 
			this.mtxtValor.Location = new System.Drawing.Point(73, 307);
			this.mtxtValor.Name = "mtxtValor";
			this.mtxtValor.Size = new System.Drawing.Size(100, 22);
			this.mtxtValor.TabIndex = 46;
			this.mtxtValor.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 310);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 16);
			this.label11.TabIndex = 45;
			this.label11.Text = "Valor :";
			this.label11.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(0, 0);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(18, 22);
			this.txtCodigo.TabIndex = 44;
			this.txtCodigo.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(125, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 38);
			this.button1.TabIndex = 43;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtNomePegou
			// 
			this.txtNomePegou.Location = new System.Drawing.Point(193, 367);
			this.txtNomePegou.Name = "txtNomePegou";
			this.txtNomePegou.Size = new System.Drawing.Size(211, 22);
			this.txtNomePegou.TabIndex = 42;
			// 
			// txtNomeDeixou
			// 
			this.txtNomeDeixou.Enabled = false;
			this.txtNomeDeixou.Location = new System.Drawing.Point(187, 335);
			this.txtNomeDeixou.Name = "txtNomeDeixou";
			this.txtNomeDeixou.Size = new System.Drawing.Size(211, 22);
			this.txtNomeDeixou.TabIndex = 41;
			// 
			// mtxtHoraEnt
			// 
			this.mtxtHoraEnt.Enabled = false;
			this.mtxtHoraEnt.Location = new System.Drawing.Point(323, 169);
			this.mtxtHoraEnt.Mask = "00:00";
			this.mtxtHoraEnt.Name = "mtxtHoraEnt";
			this.mtxtHoraEnt.Size = new System.Drawing.Size(46, 22);
			this.mtxtHoraEnt.TabIndex = 40;
			this.mtxtHoraEnt.ValidatingType = typeof(System.DateTime);
			// 
			// mtztHoraSaid
			// 
			this.mtztHoraSaid.Location = new System.Drawing.Point(292, 219);
			this.mtztHoraSaid.Mask = "00:00";
			this.mtztHoraSaid.Name = "mtztHoraSaid";
			this.mtztHoraSaid.Size = new System.Drawing.Size(48, 22);
			this.mtztHoraSaid.TabIndex = 39;
			this.mtztHoraSaid.ValidatingType = typeof(System.DateTime);
			this.mtztHoraSaid.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// mtxtDataSaid
			// 
			this.mtxtDataSaid.Location = new System.Drawing.Point(103, 219);
			this.mtxtDataSaid.Mask = "00/00/0000";
			this.mtxtDataSaid.Name = "mtxtDataSaid";
			this.mtxtDataSaid.Size = new System.Drawing.Size(80, 22);
			this.mtxtDataSaid.TabIndex = 38;
			this.mtxtDataSaid.ValidatingType = typeof(System.DateTime);
			this.mtxtDataSaid.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// mtxtDataEnt
			// 
			this.mtxtDataEnt.Enabled = false;
			this.mtxtDataEnt.Location = new System.Drawing.Point(119, 166);
			this.mtxtDataEnt.Mask = "00/00/0000";
			this.mtxtDataEnt.Name = "mtxtDataEnt";
			this.mtxtDataEnt.Size = new System.Drawing.Size(82, 22);
			this.mtxtDataEnt.TabIndex = 37;
			this.mtxtDataEnt.ValidatingType = typeof(System.DateTime);
			// 
			// cmdServico
			// 
			this.cmdServico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servicoBindingSource, "Id", true));
			this.cmdServico.DataSource = this.servicoBindingSource;
			this.cmdServico.DisplayMember = "Descricao";
			this.cmdServico.Enabled = false;
			this.cmdServico.FormattingEnabled = true;
			this.cmdServico.Location = new System.Drawing.Point(90, 267);
			this.cmdServico.Name = "cmdServico";
			this.cmdServico.Size = new System.Drawing.Size(195, 24);
			this.cmdServico.TabIndex = 36;
			this.cmdServico.ValueMember = "Id";
			// 
			// cmdFuncionario
			// 
			this.cmdFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "Id", true));
			this.cmdFuncionario.DataSource = this.funcionarioBindingSource;
			this.cmdFuncionario.DisplayMember = "Nome";
			this.cmdFuncionario.Enabled = false;
			this.cmdFuncionario.FormattingEnabled = true;
			this.cmdFuncionario.Location = new System.Drawing.Point(119, 112);
			this.cmdFuncionario.Name = "cmdFuncionario";
			this.cmdFuncionario.Size = new System.Drawing.Size(151, 24);
			this.cmdFuncionario.TabIndex = 35;
			this.cmdFuncionario.ValueMember = "Id";
			// 
			// cmdAnimal
			// 
			this.cmdAnimal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "Id", true));
			this.cmdAnimal.DataSource = this.animalBindingSource;
			this.cmdAnimal.DisplayMember = "Nome";
			this.cmdAnimal.Enabled = false;
			this.cmdAnimal.FormattingEnabled = true;
			this.cmdAnimal.Location = new System.Drawing.Point(125, 69);
			this.cmdAnimal.Name = "cmdAnimal";
			this.cmdAnimal.Size = new System.Drawing.Size(145, 24);
			this.cmdAnimal.TabIndex = 34;
			this.cmdAnimal.ValueMember = "Id";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 370);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(180, 16);
			this.label10.TabIndex = 33;
			this.label10.Text = "Nome De Quem Buscou :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Enabled = false;
			this.label9.Location = new System.Drawing.Point(11, 338);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(175, 16);
			this.label9.TabIndex = 32;
			this.label9.Text = "Nome de Quem Deixou :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Enabled = false;
			this.label8.Location = new System.Drawing.Point(14, 270);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "Serviço :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(190, 222);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 16);
			this.label7.TabIndex = 30;
			this.label7.Text = "Hora Saida :";
			this.label7.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Enabled = false;
			this.label6.Location = new System.Drawing.Point(208, 172);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 16);
			this.label6.TabIndex = 29;
			this.label6.Text = "Hora Entrada :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 222);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 16);
			this.label5.TabIndex = 28;
			this.label5.Text = "Data Saida :";
			this.label5.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(11, 169);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Data Entrada :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Enabled = false;
			this.label3.Location = new System.Drawing.Point(14, 118);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Funcionario :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(11, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Nome animal :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(85, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 25);
			this.label1.TabIndex = 24;
			this.label1.Text = "Cadastra/Edita/Exclui";
			// 
			// petShopDataSet19
			// 
			this.petShopDataSet19.DataSetName = "PetShopDataSet19";
			this.petShopDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// animalBindingSource
			// 
			this.animalBindingSource.DataMember = "Animal";
			this.animalBindingSource.DataSource = this.petShopDataSet19;
			// 
			// animalTableAdapter
			// 
			this.animalTableAdapter.ClearBeforeFill = true;
			// 
			// petShopDataSet20
			// 
			this.petShopDataSet20.DataSetName = "PetShopDataSet20";
			this.petShopDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// funcionarioBindingSource
			// 
			this.funcionarioBindingSource.DataMember = "Funcionario";
			this.funcionarioBindingSource.DataSource = this.petShopDataSet20;
			// 
			// funcionarioTableAdapter
			// 
			this.funcionarioTableAdapter.ClearBeforeFill = true;
			// 
			// petShopDataSet21
			// 
			this.petShopDataSet21.DataSetName = "PetShopDataSet21";
			this.petShopDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// servicoBindingSource
			// 
			this.servicoBindingSource.DataMember = "Servico";
			this.servicoBindingSource.DataSource = this.petShopDataSet21;
			// 
			// servicoTableAdapter
			// 
			this.servicoTableAdapter.ClearBeforeFill = true;
			// 
			// FecharServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(411, 458);
			this.Controls.Add(this.label1);
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
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FecharServico";
			this.Text = "Fechar Servico";
			this.Load += new System.EventHandler(this.FecharServico_Load);
			this.TextChanged += new System.EventHandler(this.mtxtValor_TextChanged);
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox mtxtValor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtNomePegou;
		private System.Windows.Forms.TextBox txtNomeDeixou;
		private System.Windows.Forms.MaskedTextBox mtxtHoraEnt;
		private System.Windows.Forms.MaskedTextBox mtztHoraSaid;
		private System.Windows.Forms.MaskedTextBox mtxtDataSaid;
		private System.Windows.Forms.MaskedTextBox mtxtDataEnt;
		private System.Windows.Forms.ComboBox cmdServico;
		private System.Windows.Forms.ComboBox cmdFuncionario;
		private System.Windows.Forms.ComboBox cmdAnimal;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private PetShopDataSet19 petShopDataSet19;
		private System.Windows.Forms.BindingSource animalBindingSource;
		private PetShopDataSet19TableAdapters.AnimalTableAdapter animalTableAdapter;
		private PetShopDataSet20 petShopDataSet20;
		private System.Windows.Forms.BindingSource funcionarioBindingSource;
		private PetShopDataSet20TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
		private PetShopDataSet21 petShopDataSet21;
		private System.Windows.Forms.BindingSource servicoBindingSource;
		private PetShopDataSet21TableAdapters.ServicoTableAdapter servicoTableAdapter;
	}
}