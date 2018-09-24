namespace PetForm.Raça_
{
	partial class ListarRaca
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.petShopDataSet7 = new PetForm.PetShopDataSet7();
			this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.racaTableAdapter = new PetForm.PetShopDataSet7TableAdapters.RacaTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(509, 309);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 3;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.descricaoDataGridViewTextBoxColumn,
            this.idFuncionarioDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.racaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(572, 282);
			this.dataGridView1.TabIndex = 2;
			// 
			// petShopDataSet7
			// 
			this.petShopDataSet7.DataSetName = "PetShopDataSet7";
			this.petShopDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// racaBindingSource
			// 
			this.racaBindingSource.DataMember = "Raca";
			this.racaBindingSource.DataSource = this.petShopDataSet7;
			// 
			// racaTableAdapter
			// 
			this.racaTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idFuncionarioDataGridViewTextBoxColumn
			// 
			this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
			this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Id_Funcionario";
			this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
			this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ListarRaca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(591, 334);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarRaca";
			this.Text = "Listar Raca";
			this.Load += new System.EventHandler(this.ListarRaca_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PetShopDataSet7 petShopDataSet7;
		private System.Windows.Forms.BindingSource racaBindingSource;
		private PetShopDataSet7TableAdapters.RacaTableAdapter racaTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
	}
}