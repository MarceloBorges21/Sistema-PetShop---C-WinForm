namespace PetForm.Animais_
{
	partial class ListarAnimal
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
			this.btnAlterar = new System.Windows.Forms.Button();
			this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet9 = new PetForm.PetShopDataSet9();
			this.viewParaTabelaAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet = new PetForm.PetShopDataSet();
			this.viewParaTabelaAnimalTableAdapter = new PetForm.PetShopDataSetTableAdapters.ViewParaTabelaAnimalTableAdapter();
			this.petShopDataSet8 = new PetForm.PetShopDataSet8();
			this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.animalTableAdapter = new PetForm.PetShopDataSet8TableAdapters.AnimalTableAdapter();
			this.view_2TableAdapter = new PetForm.PetShopDataSet9TableAdapters.View_2TableAdapter();
			this.petShopDataSet10 = new PetForm.PetShopDataSet10();
			this.view2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.view_2TableAdapter1 = new PetForm.PetShopDataSet10TableAdapters.View_2TableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.petShopDataSet11 = new PetForm.PetShopDataSet11();
			this.view2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.view_2TableAdapter2 = new PetForm.PetShopDataSet11TableAdapters.View_2TableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeclienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.raçaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.especieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewParaTabelaAnimalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(1002, 415);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 3;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// view2BindingSource
			// 
			this.view2BindingSource.DataMember = "View_2";
			this.view2BindingSource.DataSource = this.petShopDataSet9;
			// 
			// petShopDataSet9
			// 
			this.petShopDataSet9.DataSetName = "PetShopDataSet9";
			this.petShopDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// viewParaTabelaAnimalBindingSource
			// 
			this.viewParaTabelaAnimalBindingSource.DataMember = "ViewParaTabelaAnimal";
			this.viewParaTabelaAnimalBindingSource.DataSource = this.petShopDataSet;
			// 
			// petShopDataSet
			// 
			this.petShopDataSet.DataSetName = "PetShopDataSet";
			this.petShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// viewParaTabelaAnimalTableAdapter
			// 
			this.viewParaTabelaAnimalTableAdapter.ClearBeforeFill = true;
			// 
			// petShopDataSet8
			// 
			this.petShopDataSet8.DataSetName = "PetShopDataSet8";
			this.petShopDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// animalBindingSource
			// 
			this.animalBindingSource.DataMember = "Animal";
			this.animalBindingSource.DataSource = this.petShopDataSet8;
			// 
			// animalTableAdapter
			// 
			this.animalTableAdapter.ClearBeforeFill = true;
			// 
			// view_2TableAdapter
			// 
			this.view_2TableAdapter.ClearBeforeFill = true;
			// 
			// petShopDataSet10
			// 
			this.petShopDataSet10.DataSetName = "PetShopDataSet10";
			this.petShopDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view2BindingSource1
			// 
			this.view2BindingSource1.DataMember = "View_2";
			this.view2BindingSource1.DataSource = this.petShopDataSet10;
			// 
			// view_2TableAdapter1
			// 
			this.view_2TableAdapter1.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeclienDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.raçaDataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.especieDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.nomefuncDataGridViewTextBoxColumn,
            this.expr4DataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.view2BindingSource2;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1065, 396);
			this.dataGridView1.TabIndex = 4;
			// 
			// petShopDataSet11
			// 
			this.petShopDataSet11.DataSetName = "PetShopDataSet11";
			this.petShopDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view2BindingSource2
			// 
			this.view2BindingSource2.DataMember = "View_2";
			this.view2BindingSource2.DataSource = this.petShopDataSet11;
			// 
			// view_2TableAdapter2
			// 
			this.view_2TableAdapter2.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeclienDataGridViewTextBoxColumn
			// 
			this.nomeclienDataGridViewTextBoxColumn.DataPropertyName = "nomeclien";
			this.nomeclienDataGridViewTextBoxColumn.HeaderText = "nomeclien";
			this.nomeclienDataGridViewTextBoxColumn.Name = "nomeclienDataGridViewTextBoxColumn";
			this.nomeclienDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr1DataGridViewTextBoxColumn
			// 
			this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
			this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
			this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
			this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr1DataGridViewTextBoxColumn.Visible = false;
			// 
			// raçaDataGridViewTextBoxColumn
			// 
			this.raçaDataGridViewTextBoxColumn.DataPropertyName = "Raça";
			this.raçaDataGridViewTextBoxColumn.HeaderText = "Raça";
			this.raçaDataGridViewTextBoxColumn.Name = "raçaDataGridViewTextBoxColumn";
			this.raçaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr2DataGridViewTextBoxColumn
			// 
			this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
			this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
			this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
			this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr2DataGridViewTextBoxColumn.Visible = false;
			// 
			// especieDataGridViewTextBoxColumn
			// 
			this.especieDataGridViewTextBoxColumn.DataPropertyName = "Especie";
			this.especieDataGridViewTextBoxColumn.HeaderText = "Especie";
			this.especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
			this.especieDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr3DataGridViewTextBoxColumn
			// 
			this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
			this.expr3DataGridViewTextBoxColumn.HeaderText = "Expr3";
			this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
			this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr3DataGridViewTextBoxColumn.Visible = false;
			// 
			// nomefuncDataGridViewTextBoxColumn
			// 
			this.nomefuncDataGridViewTextBoxColumn.DataPropertyName = "nomefunc";
			this.nomefuncDataGridViewTextBoxColumn.HeaderText = "nomefunc";
			this.nomefuncDataGridViewTextBoxColumn.Name = "nomefuncDataGridViewTextBoxColumn";
			this.nomefuncDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr4DataGridViewTextBoxColumn
			// 
			this.expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4";
			this.expr4DataGridViewTextBoxColumn.HeaderText = "Expr4";
			this.expr4DataGridViewTextBoxColumn.Name = "expr4DataGridViewTextBoxColumn";
			this.expr4DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr4DataGridViewTextBoxColumn.Visible = false;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idadeDataGridViewTextBoxColumn
			// 
			this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
			this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
			this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
			this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// observacaoDataGridViewTextBoxColumn
			// 
			this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
			this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
			this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
			this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ListarAnimal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1083, 442);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAlterar);
			this.Name = "ListarAnimal";
			this.Text = "Listar Animal";
			this.Load += new System.EventHandler(this.ListarAnimal_Load);
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewParaTabelaAnimalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view2BindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAlterar;
		private PetShopDataSet petShopDataSet;
		private System.Windows.Forms.BindingSource viewParaTabelaAnimalBindingSource;
		private PetShopDataSetTableAdapters.ViewParaTabelaAnimalTableAdapter viewParaTabelaAnimalTableAdapter;
		private PetShopDataSet8 petShopDataSet8;
		private System.Windows.Forms.BindingSource animalBindingSource;
		private PetShopDataSet8TableAdapters.AnimalTableAdapter animalTableAdapter;
		private PetShopDataSet9 petShopDataSet9;
		private System.Windows.Forms.BindingSource view2BindingSource;
		private PetShopDataSet9TableAdapters.View_2TableAdapter view_2TableAdapter;
		private PetShopDataSet10 petShopDataSet10;
		private System.Windows.Forms.BindingSource view2BindingSource1;
		private PetShopDataSet10TableAdapters.View_2TableAdapter view_2TableAdapter1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PetShopDataSet11 petShopDataSet11;
		private System.Windows.Forms.BindingSource view2BindingSource2;
		private PetShopDataSet11TableAdapters.View_2TableAdapter view_2TableAdapter2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn raçaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
	}
}