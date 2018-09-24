namespace PetForm.Clientes_
{
	partial class ListarCliente
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
			this.petShopDataSet6 = new PetForm.PetShopDataSet6();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clienteTableAdapter = new PetForm.PetShopDataSet6TableAdapters.ClienteTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(713, 374);
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
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.idFuncionarioDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clienteBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(776, 356);
			this.dataGridView1.TabIndex = 2;
			// 
			// petShopDataSet6
			// 
			this.petShopDataSet6.DataSetName = "PetShopDataSet6";
			this.petShopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "Cliente";
			this.clienteBindingSource.DataSource = this.petShopDataSet6;
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// documentoDataGridViewTextBoxColumn
			// 
			this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
			this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
			this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
			this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefoneDataGridViewTextBoxColumn
			// 
			this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
			this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
			this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
			this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idFuncionarioDataGridViewTextBoxColumn
			// 
			this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
			this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Id_Funcionario";
			this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
			this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ListarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(797, 401);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListarCliente";
			this.Text = "Listar Cliente";
			this.Load += new System.EventHandler(this.ListarCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PetShopDataSet6 petShopDataSet6;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private PetShopDataSet6TableAdapters.ClienteTableAdapter clienteTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
	}
}