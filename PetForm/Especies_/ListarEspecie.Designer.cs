namespace PetForm.Especies_
{
	partial class ListarEspecie
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
			this.petShopDataSet5 = new PetForm.PetShopDataSet5();
			this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.especieTableAdapter = new PetForm.PetShopDataSet5TableAdapters.EspecieTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(464, 380);
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
			this.dataGridView1.DataSource = this.especieBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(528, 362);
			this.dataGridView1.TabIndex = 2;
			// 
			// petShopDataSet5
			// 
			this.petShopDataSet5.DataSetName = "PetShopDataSet5";
			this.petShopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// especieBindingSource
			// 
			this.especieBindingSource.DataMember = "Especie";
			this.especieBindingSource.DataSource = this.petShopDataSet5;
			// 
			// especieTableAdapter
			// 
			this.especieTableAdapter.ClearBeforeFill = true;
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
			// ListarEspecie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(547, 403);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarEspecie";
			this.Text = "Listar Especie";
			this.Load += new System.EventHandler(this.ListarEspecie_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PetShopDataSet5 petShopDataSet5;
		private System.Windows.Forms.BindingSource especieBindingSource;
		private PetShopDataSet5TableAdapters.EspecieTableAdapter especieTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
	}
}