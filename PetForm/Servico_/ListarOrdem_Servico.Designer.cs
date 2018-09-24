namespace PetForm.Servico_
{
	partial class ListarOrdem_Servico
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarOrdem_Servico));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataEntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataSaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaEntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaSaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pessoaDeixouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pessouPegouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewOedemServicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet18 = new PetForm.PetShopDataSet18();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.viewOedemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.petShopDataSet17 = new PetForm.PetShopDataSet17();
			this.view_OedemServicoTableAdapter = new PetForm.PetShopDataSet17TableAdapters.View_OedemServicoTableAdapter();
			this.view_OedemServicoTableAdapter1 = new PetForm.PetShopDataSet18TableAdapters.View_OedemServicoTableAdapter();
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewOedemServicoBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewOedemServicoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet17)).BeginInit();
			this.fillByToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeAnimalDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.dataEntDataGridViewTextBoxColumn,
            this.dataSaidDataGridViewTextBoxColumn,
            this.horaEntDataGridViewTextBoxColumn,
            this.horaSaidDataGridViewTextBoxColumn,
            this.serviçoDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.pessoaDeixouDataGridViewTextBoxColumn,
            this.pessouPegouDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.viewOedemServicoBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(13, 29);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1318, 437);
			this.dataGridView1.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeAnimalDataGridViewTextBoxColumn
			// 
			this.nomeAnimalDataGridViewTextBoxColumn.DataPropertyName = "NomeAnimal";
			this.nomeAnimalDataGridViewTextBoxColumn.HeaderText = "NomeAnimal";
			this.nomeAnimalDataGridViewTextBoxColumn.Name = "nomeAnimalDataGridViewTextBoxColumn";
			this.nomeAnimalDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr1DataGridViewTextBoxColumn
			// 
			this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
			this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
			this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
			this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr1DataGridViewTextBoxColumn.Visible = false;
			// 
			// funcionarioDataGridViewTextBoxColumn
			// 
			this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario";
			this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
			this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
			this.funcionarioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr2DataGridViewTextBoxColumn
			// 
			this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
			this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
			this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
			this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr2DataGridViewTextBoxColumn.Visible = false;
			// 
			// dataEntDataGridViewTextBoxColumn
			// 
			this.dataEntDataGridViewTextBoxColumn.DataPropertyName = "Data Ent";
			this.dataEntDataGridViewTextBoxColumn.HeaderText = "Data Ent";
			this.dataEntDataGridViewTextBoxColumn.Name = "dataEntDataGridViewTextBoxColumn";
			this.dataEntDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataSaidDataGridViewTextBoxColumn
			// 
			this.dataSaidDataGridViewTextBoxColumn.DataPropertyName = "Data Said";
			this.dataSaidDataGridViewTextBoxColumn.HeaderText = "Data Said";
			this.dataSaidDataGridViewTextBoxColumn.Name = "dataSaidDataGridViewTextBoxColumn";
			this.dataSaidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// horaEntDataGridViewTextBoxColumn
			// 
			this.horaEntDataGridViewTextBoxColumn.DataPropertyName = "Hora Ent";
			this.horaEntDataGridViewTextBoxColumn.HeaderText = "Hora Ent";
			this.horaEntDataGridViewTextBoxColumn.Name = "horaEntDataGridViewTextBoxColumn";
			this.horaEntDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// horaSaidDataGridViewTextBoxColumn
			// 
			this.horaSaidDataGridViewTextBoxColumn.DataPropertyName = "Hora Said";
			this.horaSaidDataGridViewTextBoxColumn.HeaderText = "Hora Said";
			this.horaSaidDataGridViewTextBoxColumn.Name = "horaSaidDataGridViewTextBoxColumn";
			this.horaSaidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// serviçoDataGridViewTextBoxColumn
			// 
			this.serviçoDataGridViewTextBoxColumn.DataPropertyName = "Serviço";
			this.serviçoDataGridViewTextBoxColumn.HeaderText = "Serviço";
			this.serviçoDataGridViewTextBoxColumn.Name = "serviçoDataGridViewTextBoxColumn";
			this.serviçoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// expr3DataGridViewTextBoxColumn
			// 
			this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
			this.expr3DataGridViewTextBoxColumn.HeaderText = "Expr3";
			this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
			this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
			this.expr3DataGridViewTextBoxColumn.Visible = false;
			// 
			// valorDataGridViewTextBoxColumn
			// 
			this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
			this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
			this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
			this.valorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pessoaDeixouDataGridViewTextBoxColumn
			// 
			this.pessoaDeixouDataGridViewTextBoxColumn.DataPropertyName = "Pessoa Deixou";
			this.pessoaDeixouDataGridViewTextBoxColumn.HeaderText = "Pessoa Deixou";
			this.pessoaDeixouDataGridViewTextBoxColumn.Name = "pessoaDeixouDataGridViewTextBoxColumn";
			this.pessoaDeixouDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pessouPegouDataGridViewTextBoxColumn
			// 
			this.pessouPegouDataGridViewTextBoxColumn.DataPropertyName = "Pessou Pegou";
			this.pessouPegouDataGridViewTextBoxColumn.HeaderText = "Pessou Pegou";
			this.pessouPegouDataGridViewTextBoxColumn.Name = "pessouPegouDataGridViewTextBoxColumn";
			this.pessouPegouDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// viewOedemServicoBindingSource1
			// 
			this.viewOedemServicoBindingSource1.DataMember = "View_OedemServico";
			this.viewOedemServicoBindingSource1.DataSource = this.petShopDataSet18;
			// 
			// petShopDataSet18
			// 
			this.petShopDataSet18.DataSetName = "PetShopDataSet18";
			this.petShopDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.Red;
			this.btnFechar.Location = new System.Drawing.Point(1161, 472);
			this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(170, 37);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = "Fechar Serviço";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(13, 476);
			this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(112, 28);
			this.btnAlterar.TabIndex = 2;
			this.btnAlterar.Text = "Editar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// viewOedemServicoBindingSource
			// 
			this.viewOedemServicoBindingSource.DataMember = "View_OedemServico";
			this.viewOedemServicoBindingSource.DataSource = this.petShopDataSet17;
			// 
			// petShopDataSet17
			// 
			this.petShopDataSet17.DataSetName = "PetShopDataSet17";
			this.petShopDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view_OedemServicoTableAdapter
			// 
			this.view_OedemServicoTableAdapter.ClearBeforeFill = true;
			// 
			// view_OedemServicoTableAdapter1
			// 
			this.view_OedemServicoTableAdapter1.ClearBeforeFill = true;
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripLabel1});
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(1364, 25);
			this.fillByToolStrip.TabIndex = 3;
			this.fillByToolStrip.Text = "fillByToolStrip";
			// 
			// fillByToolStripButton
			// 
			this.fillByToolStripButton.BackColor = System.Drawing.Color.Lime;
			this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fillByToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByToolStripButton.Image")));
			this.fillByToolStripButton.Name = "fillByToolStripButton";
			this.fillByToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.fillByToolStripButton.Text = "Atualizar";
			this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.toolStripLabel1.Enabled = false;
			this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
			this.toolStripLabel1.Text = "Atualizar";
			// 
			// ListarOrdem_Servico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1364, 524);
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ListarOrdem_Servico";
			this.Text = "Listar Ordem_Servico";
			this.Load += new System.EventHandler(this.ListarOrdem_Servico_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewOedemServicoBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewOedemServicoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.petShopDataSet17)).EndInit();
			this.fillByToolStrip.ResumeLayout(false);
			this.fillByToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private PetShopDataSet17 petShopDataSet17;
		private System.Windows.Forms.BindingSource viewOedemServicoBindingSource;
		private PetShopDataSet17TableAdapters.View_OedemServicoTableAdapter view_OedemServicoTableAdapter;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataEntDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaEntDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviçoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pessoaDeixouDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pessouPegouDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private PetShopDataSet18 petShopDataSet18;
		private System.Windows.Forms.BindingSource viewOedemServicoBindingSource1;
		private PetShopDataSet18TableAdapters.View_OedemServicoTableAdapter view_OedemServicoTableAdapter1;
		private System.Windows.Forms.ToolStrip fillByToolStrip;
		private System.Windows.Forms.ToolStripButton fillByToolStripButton;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
	}
}