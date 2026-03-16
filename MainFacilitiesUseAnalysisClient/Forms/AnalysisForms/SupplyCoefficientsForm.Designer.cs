namespace MainFacilitiesUseAnalysisClient
{
	partial class SupplyCoefficientsForm
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
			this.m_SupplyCoefficientsDataGridView = new System.Windows.Forms.DataGridView( );
			this.m_SupplyCoefficientsBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_DataSet = new MainFacilitiesUseAnalysisClient.MainFacilitiesUseAnalysisDataSet( );
			this.m_SupplyCoefficientsDescriptionDataGridView = new System.Windows.Forms.DataGridView( );
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_SupplyCoefficientsDescriptionBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_MeasurementUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_CoefficientChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_TableLayoutPanel.SuspendLayout( );
			this.m_ToolStrip.SuspendLayout( );
			this.m_SplitContainer.Panel1.SuspendLayout( );
			this.m_SplitContainer.Panel2.SuspendLayout( );
			this.m_SplitContainer.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsBindingSource ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDescriptionDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDescriptionBindingSource ) ).BeginInit( );
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
			this.m_TableLayoutPanel.Size = new System.Drawing.Size( 855, 335 );
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
			this.m_ToolStrip.Size = new System.Drawing.Size( 835, 40 );
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
			this.m_SplitContainer.Panel1.Controls.Add( this.m_SupplyCoefficientsDataGridView );
			this.m_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add( this.m_SupplyCoefficientsDescriptionDataGridView );
			this.m_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.m_SplitContainer.Size = new System.Drawing.Size( 829, 269 );
			this.m_SplitContainer.SplitterDistance = 159;
			this.m_SplitContainer.SplitterWidth = 6;
			this.m_SplitContainer.TabIndex = 24;
			// 
			// m_SupplyCoefficientsDataGridView
			// 
			this.m_SupplyCoefficientsDataGridView.AllowUserToAddRows = false;
			this.m_SupplyCoefficientsDataGridView.AllowUserToDeleteRows = false;
			this.m_SupplyCoefficientsDataGridView.AllowUserToOrderColumns = true;
			this.m_SupplyCoefficientsDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_SupplyCoefficientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.m_SupplyCoefficientsDataGridView.AutoGenerateColumns = false;
			this.m_SupplyCoefficientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_SupplyCoefficientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_SupplyCoefficientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_SupplyCoefficientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.m_SupplyCoefficientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_SupplyCoefficientsDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.m_NameDataGridViewTextBoxColumn,
            this.m_MeasurementUnitDataGridViewTextBoxColumn,
            this.m_BaseYearCoefficientDataGridViewTextBoxColumn,
            this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn,
            this.m_CoefficientChangeDataGridViewTextBoxColumn} );
			this.m_SupplyCoefficientsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_SupplyCoefficientsDataGridView.DataSource = this.m_SupplyCoefficientsBindingSource;
			this.m_SupplyCoefficientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SupplyCoefficientsDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_SupplyCoefficientsDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_SupplyCoefficientsDataGridView.MultiSelect = false;
			this.m_SupplyCoefficientsDataGridView.Name = "m_SupplyCoefficientsDataGridView";
			this.m_SupplyCoefficientsDataGridView.ReadOnly = true;
			this.m_SupplyCoefficientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_SupplyCoefficientsDataGridView.RowHeadersWidth = 20;
			this.m_SupplyCoefficientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_SupplyCoefficientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.m_SupplyCoefficientsDataGridView.RowTemplate.Height = 24;
			this.m_SupplyCoefficientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_SupplyCoefficientsDataGridView.Size = new System.Drawing.Size( 829, 159 );
			this.m_SupplyCoefficientsDataGridView.TabIndex = 24;
			// 
			// m_SupplyCoefficientsBindingSource
			// 
			this.m_SupplyCoefficientsBindingSource.DataMember = "SupplyCoefficients";
			this.m_SupplyCoefficientsBindingSource.DataSource = this.m_DataSet;
			// 
			// m_DataSet
			// 
			this.m_DataSet.DataSetName = "MainFacilitiesUseAnalysisDataSet";
			this.m_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// m_SupplyCoefficientsDescriptionDataGridView
			// 
			this.m_SupplyCoefficientsDescriptionDataGridView.AllowUserToAddRows = false;
			this.m_SupplyCoefficientsDescriptionDataGridView.AllowUserToDeleteRows = false;
			this.m_SupplyCoefficientsDescriptionDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_SupplyCoefficientsDescriptionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.m_SupplyCoefficientsDescriptionDataGridView.AutoGenerateColumns = false;
			this.m_SupplyCoefficientsDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_SupplyCoefficientsDescriptionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_SupplyCoefficientsDescriptionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_SupplyCoefficientsDescriptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.m_SupplyCoefficientsDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_SupplyCoefficientsDescriptionDataGridView.ColumnHeadersVisible = false;
			this.m_SupplyCoefficientsDescriptionDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.coefficientChangeDescriptionDataGridViewTextBoxColumn} );
			this.m_SupplyCoefficientsDescriptionDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_SupplyCoefficientsDescriptionDataGridView.DataSource = this.m_SupplyCoefficientsDescriptionBindingSource;
			this.m_SupplyCoefficientsDescriptionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SupplyCoefficientsDescriptionDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_SupplyCoefficientsDescriptionDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_SupplyCoefficientsDescriptionDataGridView.MultiSelect = false;
			this.m_SupplyCoefficientsDescriptionDataGridView.Name = "m_SupplyCoefficientsDescriptionDataGridView";
			this.m_SupplyCoefficientsDescriptionDataGridView.ReadOnly = true;
			this.m_SupplyCoefficientsDescriptionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_SupplyCoefficientsDescriptionDataGridView.RowHeadersWidth = 20;
			this.m_SupplyCoefficientsDescriptionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_SupplyCoefficientsDescriptionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.m_SupplyCoefficientsDescriptionDataGridView.RowTemplate.Height = 24;
			this.m_SupplyCoefficientsDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_SupplyCoefficientsDescriptionDataGridView.Size = new System.Drawing.Size( 829, 104 );
			this.m_SupplyCoefficientsDescriptionDataGridView.TabIndex = 25;
			// 
			// coefficientChangeDescriptionDataGridViewTextBoxColumn
			// 
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoefficientChangeDescription";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.HeaderText = "CoefficientChangeDescription";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.Name = "coefficientChangeDescriptionDataGridViewTextBoxColumn";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.Width = 780;
			// 
			// m_SupplyCoefficientsDescriptionBindingSource
			// 
			this.m_SupplyCoefficientsDescriptionBindingSource.DataMember = "SupplyCoefficientsDescription";
			this.m_SupplyCoefficientsDescriptionBindingSource.DataSource = this.m_DataSet;
			// 
			// m_NameDataGridViewTextBoxColumn
			// 
			this.m_NameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.m_NameDataGridViewTextBoxColumn.HeaderText = "Показатель";
			this.m_NameDataGridViewTextBoxColumn.Name = "m_NameDataGridViewTextBoxColumn";
			this.m_NameDataGridViewTextBoxColumn.ReadOnly = true;
			this.m_NameDataGridViewTextBoxColumn.Width = 380;
			// 
			// m_MeasurementUnitDataGridViewTextBoxColumn
			// 
			this.m_MeasurementUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.HeaderText = "Eдиницы измepeния";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.Name = "m_MeasurementUnitDataGridViewTextBoxColumn";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_BaseYearCoefficientDataGridViewTextBoxColumn
			// 
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.DataPropertyName = "BaseYearCoefficient";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.HeaderText = "Значение бaзoвoгo гoдa";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.Name = "m_BaseYearCoefficientDataGridViewTextBoxColumn";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_AnalysedYearCoefficientDataGridViewTextBoxColumn
			// 
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.DataPropertyName = "AnalysedYearCoefficient";
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.HeaderText = "Значение aнaлизиpуeмoгo гoдa";
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.Name = "m_AnalysedYearCoefficientDataGridViewTextBoxColumn";
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_CoefficientChangeDataGridViewTextBoxColumn
			// 
			this.m_CoefficientChangeDataGridViewTextBoxColumn.DataPropertyName = "CoefficientChange";
			this.m_CoefficientChangeDataGridViewTextBoxColumn.HeaderText = "Изменение значения";
			this.m_CoefficientChangeDataGridViewTextBoxColumn.Name = "m_CoefficientChangeDataGridViewTextBoxColumn";
			this.m_CoefficientChangeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// SupplyCoefficientsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size( 855, 335 );
			this.Controls.Add( this.m_TableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.MinimumSize = new System.Drawing.Size( 865, 250 );
			this.Name = "SupplyCoefficientsForm";
			this.Opacity = 0.96;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Движение и техническое состояние основных средств";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.SupplyCoefficientsForm_FormClosing );
			this.Load += new System.EventHandler( this.SupplyCoefficientsForm_Load );
			this.m_TableLayoutPanel.ResumeLayout( false );
			this.m_TableLayoutPanel.PerformLayout( );
			this.m_ToolStrip.ResumeLayout( false );
			this.m_ToolStrip.PerformLayout( );
			this.m_SplitContainer.Panel1.ResumeLayout( false );
			this.m_SplitContainer.Panel2.ResumeLayout( false );
			this.m_SplitContainer.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsBindingSource ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDescriptionDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_SupplyCoefficientsDescriptionBindingSource ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		protected System.Windows.Forms.BindingSource m_SupplyCoefficientsBindingSource;

		protected System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;

		protected System.Windows.Forms.ToolStrip m_ToolStrip;
		protected MainFacilitiesUseAnalysisDataSet m_DataSet;
		protected System.Windows.Forms.ToolStripLabel m_TwoYearsToolStripLabel;
		protected System.Windows.Forms.SplitContainer m_SplitContainer;
		protected System.Windows.Forms.DataGridView m_SupplyCoefficientsDataGridView;
		protected System.Windows.Forms.DataGridView m_SupplyCoefficientsDescriptionDataGridView;
		protected System.Windows.Forms.BindingSource m_SupplyCoefficientsDescriptionBindingSource;
		protected System.Windows.Forms.DataGridViewTextBoxColumn coefficientChangeDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_NameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_MeasurementUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_BaseYearCoefficientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_AnalysedYearCoefficientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_CoefficientChangeDataGridViewTextBoxColumn;
	}
}