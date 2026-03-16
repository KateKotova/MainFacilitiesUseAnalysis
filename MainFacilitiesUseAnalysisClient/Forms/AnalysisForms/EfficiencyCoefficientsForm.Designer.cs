namespace MainFacilitiesUseAnalysisClient
{
	partial class EfficiencyCoefficientsForm
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
			this.m_EfficiencyCoefficientsDataGridView = new System.Windows.Forms.DataGridView( );
			this.m_EfficiencyCoefficientsBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_DataSet = new MainFacilitiesUseAnalysisClient.MainFacilitiesUseAnalysisDataSet( );
			this.m_EfficiencyCoefficientsDescriptionDataGridView = new System.Windows.Forms.DataGridView( );
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_EfficiencyCoefficientsDescriptionBindingSource = new System.Windows.Forms.BindingSource( this.components );
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
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsBindingSource ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDescriptionDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDescriptionBindingSource ) ).BeginInit( );
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
			this.m_TableLayoutPanel.Size = new System.Drawing.Size( 1055, 735 );
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
			this.m_ToolStrip.Size = new System.Drawing.Size( 1035, 40 );
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
			this.m_SplitContainer.Panel1.Controls.Add( this.m_EfficiencyCoefficientsDataGridView );
			this.m_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add( this.m_EfficiencyCoefficientsDescriptionDataGridView );
			this.m_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.m_SplitContainer.Size = new System.Drawing.Size( 1029, 669 );
			this.m_SplitContainer.SplitterDistance = 359;
			this.m_SplitContainer.SplitterWidth = 6;
			this.m_SplitContainer.TabIndex = 24;
			// 
			// m_EfficiencyCoefficientsDataGridView
			// 
			this.m_EfficiencyCoefficientsDataGridView.AllowUserToAddRows = false;
			this.m_EfficiencyCoefficientsDataGridView.AllowUserToDeleteRows = false;
			this.m_EfficiencyCoefficientsDataGridView.AllowUserToOrderColumns = true;
			this.m_EfficiencyCoefficientsDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_EfficiencyCoefficientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.m_EfficiencyCoefficientsDataGridView.AutoGenerateColumns = false;
			this.m_EfficiencyCoefficientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_EfficiencyCoefficientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_EfficiencyCoefficientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_EfficiencyCoefficientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.m_EfficiencyCoefficientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_EfficiencyCoefficientsDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.m_NameDataGridViewTextBoxColumn,
            this.m_MeasurementUnitDataGridViewTextBoxColumn,
            this.m_BaseYearCoefficientDataGridViewTextBoxColumn,
            this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn,
            this.m_CoefficientChangeDataGridViewTextBoxColumn} );
			this.m_EfficiencyCoefficientsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_EfficiencyCoefficientsDataGridView.DataSource = this.m_EfficiencyCoefficientsBindingSource;
			this.m_EfficiencyCoefficientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_EfficiencyCoefficientsDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_EfficiencyCoefficientsDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_EfficiencyCoefficientsDataGridView.MultiSelect = false;
			this.m_EfficiencyCoefficientsDataGridView.Name = "m_EfficiencyCoefficientsDataGridView";
			this.m_EfficiencyCoefficientsDataGridView.ReadOnly = true;
			this.m_EfficiencyCoefficientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_EfficiencyCoefficientsDataGridView.RowHeadersWidth = 20;
			this.m_EfficiencyCoefficientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_EfficiencyCoefficientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.m_EfficiencyCoefficientsDataGridView.RowTemplate.Height = 24;
			this.m_EfficiencyCoefficientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_EfficiencyCoefficientsDataGridView.Size = new System.Drawing.Size( 1029, 359 );
			this.m_EfficiencyCoefficientsDataGridView.TabIndex = 24;
			// 
			// m_EfficiencyCoefficientsBindingSource
			// 
			this.m_EfficiencyCoefficientsBindingSource.DataMember = "EfficiencyCoefficients";
			this.m_EfficiencyCoefficientsBindingSource.DataSource = this.m_DataSet;
			// 
			// m_DataSet
			// 
			this.m_DataSet.DataSetName = "MainFacilitiesUseAnalysisDataSet";
			this.m_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// m_EfficiencyCoefficientsDescriptionDataGridView
			// 
			this.m_EfficiencyCoefficientsDescriptionDataGridView.AllowUserToAddRows = false;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.AllowUserToDeleteRows = false;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.AutoGenerateColumns = false;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.ColumnHeadersVisible = false;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.coefficientChangeDescriptionDataGridViewTextBoxColumn} );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.DataSource = this.m_EfficiencyCoefficientsDescriptionBindingSource;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.MultiSelect = false;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Name = "m_EfficiencyCoefficientsDescriptionDataGridView";
			this.m_EfficiencyCoefficientsDescriptionDataGridView.ReadOnly = true;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.RowHeadersWidth = 20;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.RowTemplate.Height = 24;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_EfficiencyCoefficientsDescriptionDataGridView.Size = new System.Drawing.Size( 1029, 304 );
			this.m_EfficiencyCoefficientsDescriptionDataGridView.TabIndex = 25;
			// 
			// coefficientChangeDescriptionDataGridViewTextBoxColumn
			// 
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoefficientChangeDescription";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.HeaderText = "CoefficientChangeDescription";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.Name = "coefficientChangeDescriptionDataGridViewTextBoxColumn";
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.coefficientChangeDescriptionDataGridViewTextBoxColumn.Width = 1150;
			// 
			// m_EfficiencyCoefficientsDescriptionBindingSource
			// 
			this.m_EfficiencyCoefficientsDescriptionBindingSource.DataMember = "EfficiencyCoefficientsDescription";
			this.m_EfficiencyCoefficientsDescriptionBindingSource.DataSource = this.m_DataSet;
			// 
			// m_NameDataGridViewTextBoxColumn
			// 
			this.m_NameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.m_NameDataGridViewTextBoxColumn.HeaderText = "Показатель";
			this.m_NameDataGridViewTextBoxColumn.Name = "m_NameDataGridViewTextBoxColumn";
			this.m_NameDataGridViewTextBoxColumn.ReadOnly = true;
			this.m_NameDataGridViewTextBoxColumn.Width = 580;
			// 
			// m_MeasurementUnitDataGridViewTextBoxColumn
			// 
			this.m_MeasurementUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.HeaderText = "Единицы измерения";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.Name = "m_MeasurementUnitDataGridViewTextBoxColumn";
			this.m_MeasurementUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_BaseYearCoefficientDataGridViewTextBoxColumn
			// 
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.DataPropertyName = "BaseYearCoefficient";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.HeaderText = "Значение базового года";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.Name = "m_BaseYearCoefficientDataGridViewTextBoxColumn";
			this.m_BaseYearCoefficientDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_AnalysedYearCoefficientDataGridViewTextBoxColumn
			// 
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.DataPropertyName = "AnalysedYearCoefficient";
			this.m_AnalysedYearCoefficientDataGridViewTextBoxColumn.HeaderText = "Значение анализируемого года";
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
			// EfficiencyCoefficientsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size( 1055, 735 );
			this.Controls.Add( this.m_TableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.MinimumSize = new System.Drawing.Size( 865, 250 );
			this.Name = "EfficiencyCoefficientsForm";
			this.Opacity = 0.96;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Эффективность использования основных средств";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.EfficiencyCoefficientsForm_FormClosing );
			this.Load += new System.EventHandler( this.EfficiencyCoefficientsForm_Load );
			this.m_TableLayoutPanel.ResumeLayout( false );
			this.m_TableLayoutPanel.PerformLayout( );
			this.m_ToolStrip.ResumeLayout( false );
			this.m_ToolStrip.PerformLayout( );
			this.m_SplitContainer.Panel1.ResumeLayout( false );
			this.m_SplitContainer.Panel2.ResumeLayout( false );
			this.m_SplitContainer.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsBindingSource ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDescriptionDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_EfficiencyCoefficientsDescriptionBindingSource ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		protected System.Windows.Forms.BindingSource m_EfficiencyCoefficientsBindingSource;

		protected System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;

		protected System.Windows.Forms.ToolStrip m_ToolStrip;
		protected MainFacilitiesUseAnalysisDataSet m_DataSet;
		protected System.Windows.Forms.ToolStripLabel m_TwoYearsToolStripLabel;
		protected System.Windows.Forms.SplitContainer m_SplitContainer;
		protected System.Windows.Forms.DataGridView m_EfficiencyCoefficientsDataGridView;
		protected System.Windows.Forms.DataGridView m_EfficiencyCoefficientsDescriptionDataGridView;
		protected System.Windows.Forms.BindingSource m_EfficiencyCoefficientsDescriptionBindingSource;
		protected System.Windows.Forms.DataGridViewTextBoxColumn coefficientChangeDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_NameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_MeasurementUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_BaseYearCoefficientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_AnalysedYearCoefficientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_CoefficientChangeDataGridViewTextBoxColumn;
	}
}