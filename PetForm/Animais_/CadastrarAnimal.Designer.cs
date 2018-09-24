namespace PetForm.Animais_
{
	partial class CadastrarAnimal
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
			this.label8 = new System.Windows.Forms.Label();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cmdRaca = new System.Windows.Forms.ComboBox();
			this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet3 = new PetForm.PetShopDataSet3();
			this.cmdEspecie = new System.Windows.Forms.ComboBox();
			this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet2 = new PetForm.PetShopDataSet2();
			this.cmdCliente = new System.Windows.Forms.ComboBox();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet1 = new PetForm.PetShopDataSet1();
			this.txtObs = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.clienteTableAdapter = new PetForm.PetShopDataSet1TableAdapters.ClienteTableAdapter();
			this.especieTableAdapter = new PetForm.PetShopDataSet2TableAdapters.EspecieTableAdapter();
			this.racaTableAdapter = new PetForm.PetShopDataSet3TableAdapters.RacaTableAdapter();
			this.mtxtIdade = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Location = new System.Drawing.Point(32, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(290, 29);
			this.label8.TabIndex = 47;
			this.label8.Text = "Cadastrar/Editar/Excluir";
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(11, 415);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(104, 29);
			this.btnAlterar.TabIndex = 46;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(215, 415);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(113, 29);
			this.btnExcluir.TabIndex = 45;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 358);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 16);
			this.label9.TabIndex = 44;
			this.label9.Text = "Raça :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(5, 298);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 16);
			this.label10.TabIndex = 43;
			this.label10.Text = "Especie :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(0, 252);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 16);
			this.label11.TabIndex = 42;
			this.label11.Text = "Cliente :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(0, 185);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 16);
			this.label12.TabIndex = 41;
			this.label12.Text = "Obs. :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(1, 134);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 16);
			this.label13.TabIndex = 40;
			this.label13.Text = "Idade :";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(0, 79);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(57, 16);
			this.label14.TabIndex = 39;
			this.label14.Text = "Nome :";
			// 
			// cmdRaca
			// 
			this.cmdRaca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.racaBindingSource, "Id", true));
			this.cmdRaca.DataSource = this.racaBindingSource;
			this.cmdRaca.DisplayMember = "Descricao";
			this.cmdRaca.FormattingEnabled = true;
			this.cmdRaca.Location = new System.Drawing.Point(68, 358);
			this.cmdRaca.Margin = new System.Windows.Forms.Padding(4);
			this.cmdRaca.Name = "cmdRaca";
			this.cmdRaca.Size = new System.Drawing.Size(171, 24);
			this.cmdRaca.TabIndex = 38;
			this.cmdRaca.ValueMember = "Id";
			// 
			// racaBindingSource
			// 
			this.racaBindingSource.DataMember = "Raca";
			this.racaBindingSource.DataSource = this.petShopDataSet3;
			// 
			// petShopDataSet3
			// 
			this.petShopDataSet3.DataSetName = "PetShopDataSet3";
			this.petShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmdEspecie
			// 
			this.cmdEspecie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.especieBindingSource, "Id", true));
			this.cmdEspecie.DataSource = this.especieBindingSource;
			this.cmdEspecie.DisplayMember = "Descricao";
			this.cmdEspecie.FormattingEnabled = true;
			this.cmdEspecie.Location = new System.Drawing.Point(85, 295);
			this.cmdEspecie.Margin = new System.Windows.Forms.Padding(4);
			this.cmdEspecie.Name = "cmdEspecie";
			this.cmdEspecie.Size = new System.Drawing.Size(171, 24);
			this.cmdEspecie.TabIndex = 37;
			this.cmdEspecie.ValueMember = "Id";
			// 
			// especieBindingSource
			// 
			this.especieBindingSource.DataMember = "Especie";
			this.especieBindingSource.DataSource = this.petShopDataSet2;
			// 
			// petShopDataSet2
			// 
			this.petShopDataSet2.DataSetName = "PetShopDataSet2";
			this.petShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmdCliente
			// 
			this.cmdCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Id", true));
			this.cmdCliente.DataSource = this.clienteBindingSource;
			this.cmdCliente.DisplayMember = "Nome";
			this.cmdCliente.FormattingEnabled = true;
			this.cmdCliente.Location = new System.Drawing.Point(64, 249);
			this.cmdCliente.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCliente.Name = "cmdCliente";
			this.cmdCliente.Size = new System.Drawing.Size(171, 24);
			this.cmdCliente.TabIndex = 35;
			this.cmdCliente.ValueMember = "Id";
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "Cliente";
			this.clienteBindingSource.DataSource = this.petShopDataSet1;
			// 
			// petShopDataSet1
			// 
			this.petShopDataSet1.DataSetName = "PetShopDataSet1";
			this.petShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtObs
			// 
			this.txtObs.Location = new System.Drawing.Point(64, 185);
			this.txtObs.Margin = new System.Windows.Forms.Padding(4);
			this.txtObs.Multiline = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Size = new System.Drawing.Size(222, 43);
			this.txtObs.TabIndex = 34;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(77, 79);
			this.txtNome.Margin = new System.Windows.Forms.Padding(4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(171, 22);
			this.txtNome.TabIndex = 33;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(11, 7);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(171, 22);
			this.txtCodigo.TabIndex = 32;
			this.txtCodigo.Visible = false;
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// especieTableAdapter
			// 
			this.especieTableAdapter.ClearBeforeFill = true;
			// 
			// racaTableAdapter
			// 
			this.racaTableAdapter.ClearBeforeFill = true;
			// 
			// mtxtIdade
			// 
			this.mtxtIdade.Location = new System.Drawing.Point(53, 134);
			this.mtxtIdade.Mask = "00/00/0000";
			this.mtxtIdade.Name = "mtxtIdade";
			this.mtxtIdade.Size = new System.Drawing.Size(90, 22);
			this.mtxtIdade.TabIndex = 49;
			this.mtxtIdade.ValidatingType = typeof(System.DateTime);
			// 
			// CadastrarAnimal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(340, 465);
			this.Controls.Add(this.mtxtIdade);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.cmdRaca);
			this.Controls.Add(this.cmdEspecie);
			this.Controls.Add(this.cmdCliente);
			this.Controls.Add(this.txtObs);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCodigo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CadastrarAnimal";
			this.Text = "CadastrarAnimal";
			this.Load += new System.EventHandler(this.CadastrarAnimal_Load);
			((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmdRaca;
		private System.Windows.Forms.ComboBox cmdEspecie;
		private System.Windows.Forms.ComboBox cmdCliente;
		private System.Windows.Forms.TextBox txtObs;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCodigo;
		private PetShopDataSet1 petShopDataSet1;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private PetShopDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
		private PetShopDataSet2 petShopDataSet2;
		private System.Windows.Forms.BindingSource especieBindingSource;
		private PetShopDataSet2TableAdapters.EspecieTableAdapter especieTableAdapter;
		private PetShopDataSet3 petShopDataSet3;
		private System.Windows.Forms.BindingSource racaBindingSource;
		private PetShopDataSet3TableAdapters.RacaTableAdapter racaTableAdapter;
		private System.Windows.Forms.MaskedTextBox mtxtIdade;
	}
}