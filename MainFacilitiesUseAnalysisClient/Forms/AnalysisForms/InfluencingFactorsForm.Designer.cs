namespace MainFacilitiesUseAnalysisClient
{
	partial class InfluencingFactorsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle( );
			this.m_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_ToolStrip = new System.Windows.Forms.ToolStrip( );
			this.m_TwoYearsToolStripLabel = new System.Windows.Forms.ToolStripLabel( );
			this.m_SplitContainer = new System.Windows.Forms.SplitContainer( );
			this.m_InfluencingFactorsDataGridView = new System.Windows.Forms.DataGridView( );
			this.m_InfluencingFactorsBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_DataSet = new MainFacilitiesUseAnalysisClient.MainFacilitiesUseAnalysisDataSet( );
			this.m_InfluencingFactorsDescriptionDataGridView = new System.Windows.Forms.DataGridView( );
			this.m_InfluencingFactorsDescriptionBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.influencingFactorDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_TableLayoutPanel.SuspendLayout( );
			this.m_ToolStrip.SuspendLayout( );
			this.m_SplitContainer.Panel1.SuspendLayout( );
			this.m_SplitContainer.Panel2.SuspendLayout( );
			this.m_SplitContainer.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsBindingSource ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDescriptionDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDescriptionBindingSource ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// m_TableLayoutPanel
			// 
			this.m_TableLayoutPanel.ColumnCount = 3;
			this.m_TableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_TableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_TableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_TableLayoutPanel.Controls.Add( this.m_ToolStrip, 1, 1 );
			this.m_TableLayoutPanel.Controls.Add( this.m_SplitContainer, 1, 2 );
			this.m_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_TableLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
			this.m_TableLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
			this.m_TableLayoutPanel.RowCount = 4;
			this.m_TableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_TableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 40F ) );
			this.m_TableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_TableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_TableLayoutPanel.Size = new System.Drawing.Size( 757, 581 );
			this.m_TableLayoutPanel.TabIndex = 22;
			// 
			// m_ToolStrip
			// 
			this.m_ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ToolStrip.Font = new System.Drawing.Font( "Tahoma", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.m_ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.m_TwoYearsToolStripLabel} );
			this.m_ToolStrip.Location = new System.Drawing.Point( 10, 10 );
			this.m_ToolStrip.Name = "m_ToolStrip";
			this.m_ToolStrip.Size = new System.Drawing.Size( 737, 40 );
			this.m_ToolStrip.TabIndex = 22;
			this.m_ToolStrip.Text = "Панель инструментов";
			// 
			// m_TwoYearsToolStripLabel
			// 
			this.m_TwoYearsToolStripLabel.AutoSize = false;
			this.m_TwoYearsToolStripLabel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.m_TwoYearsToolStripLabel.Margin = new System.Windows.Forms.Padding( 2, 3, 0, 3 );
			this.m_TwoYearsToolStripLabel.Name = "m_TwoYearsToolStripLabel";
			this.m_TwoYearsToolStripLabel.Padding = new System.Windows.Forms.Padding( 10, 0, 15, 0 );
			this.m_TwoYearsToolStripLabel.Size = new System.Drawing.Size( 145, 34 );
			this.m_TwoYearsToolStripLabel.Text = "TwoYears";
			// 
			// m_SplitContainer
			// 
			this.m_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SplitContainer.Location = new System.Drawing.Point( 13, 53 );
			this.m_SplitContainer.Name = "m_SplitContainer";
			this.m_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// m_SplitContainer.Panel1
			// 
			this.m_SplitContainer.Panel1.Controls.Add( this.m_InfluencingFactorsDataGridView );
			this.m_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add( this.m_InfluencingFactorsDescriptionDataGridView );
			this.m_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.m_SplitContainer.Size = new System.Drawing.Size( 731, 515 );
			this.m_SplitContainer.SplitterDistance = 263;
			this.m_SplitContainer.SplitterWidth = 6;
			this.m_SplitContainer.TabIndex = 24;
			// 
			// m_InfluencingFactorsDataGridView
			// 
			this.m_InfluencingFactorsDataGridView.AllowUserToAddRows = false;
			this.m_InfluencingFactorsDataGridView.AllowUserToDeleteRows = false;
			this.m_InfluencingFactorsDataGridView.AllowUserToOrderColumns = true;
			this.m_InfluencingFactorsDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_InfluencingFactorsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.m_InfluencingFactorsDataGridView.AutoGenerateColumns = false;
			this.m_InfluencingFactorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_InfluencingFactorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_InfluencingFactorsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_InfluencingFactorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.m_InfluencingFactorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_InfluencingFactorsDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.nameDataGridViewTextBoxColumn,
            this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn,
            this.productionFundProfitabilityChangeDataGridViewTextBoxColumn} );
			this.m_InfluencingFactorsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_InfluencingFactorsDataGridView.DataSource = this.m_InfluencingFactorsBindingSource;
			this.m_InfluencingFactorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_InfluencingFactorsDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_InfluencingFactorsDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_InfluencingFactorsDataGridView.MultiSelect = false;
			this.m_InfluencingFactorsDataGridView.Name = "m_InfluencingFactorsDataGridView";
			this.m_InfluencingFactorsDataGridView.ReadOnly = true;
			this.m_InfluencingFactorsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_InfluencingFactorsDataGridView.RowHeadersWidth = 20;
			this.m_InfluencingFactorsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_InfluencingFactorsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.m_InfluencingFactorsDataGridView.RowTemplate.Height = 24;
			this.m_InfluencingFactorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_InfluencingFactorsDataGridView.Size = new System.Drawing.Size( 731, 263 );
			this.m_InfluencingFactorsDataGridView.TabIndex = 24;
			// 
			// m_InfluencingFactorsBindingSource
			// 
			this.m_InfluencingFactorsBindingSource.DataMember = "InfluencingFactors";
			this.m_InfluencingFactorsBindingSource.DataSource = this.m_DataSet;
			// 
			// m_DataSet
			// 
			this.m_DataSet.DataSetName = "MainFacilitiesUseAnalysisDataSet";
			this.m_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// m_InfluencingFactorsDescriptionDataGridView
			// 
			this.m_InfluencingFactorsDescriptionDataGridView.AllowUserToAddRows = false;
			this.m_InfluencingFactorsDescriptionDataGridView.AllowUserToDeleteRows = false;
			this.m_InfluencingFactorsDescriptionDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_InfluencingFactorsDescriptionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.m_InfluencingFactorsDescriptionDataGridView.AutoGenerateColumns = false;
			this.m_InfluencingFactorsDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_InfluencingFactorsDescriptionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_InfluencingFactorsDescriptionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_InfluencingFactorsDescriptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.m_InfluencingFactorsDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_InfluencingFactorsDescriptionDataGridView.ColumnHeadersVisible = false;
			this.m_InfluencingFactorsDescriptionDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.influencingFactorDescriptionDataGridViewTextBoxColumn} );
			this.m_InfluencingFactorsDescriptionDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_InfluencingFactorsDescriptionDataGridView.DataSource = this.m_InfluencingFactorsDescriptionBindingSource;
			this.m_InfluencingFactorsDescriptionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_InfluencingFactorsDescriptionDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_InfluencingFactorsDescriptionDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_InfluencingFactorsDescriptionDataGridView.MultiSelect = false;
			this.m_InfluencingFactorsDescriptionDataGridView.Name = "m_InfluencingFactorsDescriptionDataGridView";
			this.m_InfluencingFactorsDescriptionDataGridView.ReadOnly = true;
			this.m_InfluencingFactorsDescriptionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_InfluencingFactorsDescriptionDataGridView.RowHeadersWidth = 20;
			this.m_InfluencingFactorsDescriptionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_InfluencingFactorsDescriptionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.m_InfluencingFactorsDescriptionDataGridView.RowTemplate.Height = 24;
			this.m_InfluencingFactorsDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_InfluencingFactorsDescriptionDataGridView.Size = new System.Drawing.Size( 731, 246 );
			this.m_InfluencingFactorsDescriptionDataGridView.TabIndex = 25;
			// 
			// m_InfluencingFactorsDescriptionBindingSource
			// 
			this.m_InfluencingFactorsDescriptionBindingSource.DataMember = "InfluencingFactorsDescription";
			this.m_InfluencingFactorsDescriptionBindingSource.DataSource = this.m_DataSet;
			// 
			// influencingFactorDescriptionDataGridViewTextBoxColumn
			// 
			this.influencingFactorDescriptionDataGridViewTextBoxColumn.DataPropertyName = "InfluencingFactorDescription";
			this.influencingFactorDescriptionDataGridViewTextBoxColumn.HeaderText = "InfluencingFactorDescription";
			this.influencingFactorDescriptionDataGridViewTextBoxColumn.Name = "influencingFactorDescriptionDataGridViewTextBoxColumn";
			this.influencingFactorDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.influencingFactorDescriptionDataGridViewTextBoxColumn.Width = 1600;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Фактор";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 280;
			// 
			// productionFundCapitalProductivityChangeDataGridViewTextBoxColumn
			// 
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn.DataPropertyName = "ProductionFundCapitalProductivityChange";
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn.HeaderText = "Изменение фондоотдачи";
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn.Name = "productionFundCapitalProductivityChangeDataGridViewTextBoxColumn";
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn.ReadOnly = true;
			this.productionFundCapitalProductivityChangeDataGridViewTextBoxColumn.Width = 200;
			// 
			// productionFundProfitabilityChangeDataGridViewTextBoxColumn
			// 
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn.DataPropertyName = "ProductionFundProfitabilityChange";
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn.HeaderText = "Изменение фондорентабельности";
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn.Name = "productionFundProfitabilityChangeDataGridViewTextBoxColumn";
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn.ReadOnly = true;
			this.productionFundProfitabilityChangeDataGridViewTextBoxColumn.Width = 200;
			// 
			// InfluencingFactorsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size( 757, 581 );
			this.Controls.Add( this.m_TableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.MinimumSize = new System.Drawing.Size( 767, 250 );
			this.Name = "InfluencingFactorsForm";
			this.Opacity = 0.96;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Факторы влияния на фондорентабильность";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.InfluencingFactorsForm_FormClosing );
			this.Load += new System.EventHandler( this.InfluencingFactorsForm_Load );
			this.m_TableLayoutPanel.ResumeLayout( false );
			this.m_TableLayoutPanel.PerformLayout( );
			this.m_ToolStrip.ResumeLayout( false );
			this.m_ToolStrip.PerformLayout( );
			this.m_SplitContainer.Panel1.ResumeLayout( false );
			this.m_SplitContainer.Panel2.ResumeLayout( false );
			this.m_SplitContainer.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsBindingSource ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDescriptionDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_InfluencingFactorsDescriptionBindingSource ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		protected System.Windows.Forms.BindingSource m_InfluencingFactorsBindingSource;

		protected System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;

		protected System.Windows.Forms.ToolStrip m_ToolStrip;
		protected MainFacilitiesUseAnalysisDataSet m_DataSet;
		protected System.Windows.Forms.ToolStripLabel m_TwoYearsToolStripLabel;
		protected System.Windows.Forms.SplitContainer m_SplitContainer;
		protected System.Windows.Forms.DataGridView m_InfluencingFactorsDataGridView;
		protected System.Windows.Forms.DataGridView m_InfluencingFactorsDescriptionDataGridView;
		protected System.Windows.Forms.BindingSource m_InfluencingFactorsDescriptionBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn influencingFactorDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productionFundCapitalProductivityChangeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productionFundProfitabilityChangeDataGridViewTextBoxColumn;
	}
}