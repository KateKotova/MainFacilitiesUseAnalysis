namespace MainFacilitiesUseAnalysisClient
{
	partial class ChangeCoefficientsForm
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
			this.m_ChangeCoefficientsDataGridView = new System.Windows.Forms.DataGridView( );
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.measurementUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.coefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_ChangeCoefficientsBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_DataSet = new MainFacilitiesUseAnalysisClient.MainFacilitiesUseAnalysisDataSet( );
			this.m_ChangeCoefficientsDescriptionDataGridView = new System.Windows.Forms.DataGridView( );
			this.coefficientValueDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
			this.m_ChangeCoefficientsDescriptionBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.m_TableLayoutPanel.SuspendLayout( );
			this.m_ToolStrip.SuspendLayout( );
			this.m_SplitContainer.Panel1.SuspendLayout( );
			this.m_SplitContainer.Panel2.SuspendLayout( );
			this.m_SplitContainer.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsBindingSource ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDescriptionDataGridView ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDescriptionBindingSource ) ).BeginInit( );
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
			this.m_TableLayoutPanel.Size = new System.Drawing.Size( 1051, 735 );
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
			this.m_ToolStrip.Size = new System.Drawing.Size( 1031, 40 );
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
			this.m_SplitContainer.Panel1.Controls.Add( this.m_ChangeCoefficientsDataGridView );
			this.m_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// m_SplitContainer.Panel2
			// 
			this.m_SplitContainer.Panel2.Controls.Add( this.m_ChangeCoefficientsDescriptionDataGridView );
			this.m_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.m_SplitContainer.Size = new System.Drawing.Size( 1025, 669 );
			this.m_SplitContainer.SplitterDistance = 359;
			this.m_SplitContainer.SplitterWidth = 6;
			this.m_SplitContainer.TabIndex = 24;
			// 
			// m_ChangeCoefficientsDataGridView
			// 
			this.m_ChangeCoefficientsDataGridView.AllowUserToAddRows = false;
			this.m_ChangeCoefficientsDataGridView.AllowUserToDeleteRows = false;
			this.m_ChangeCoefficientsDataGridView.AllowUserToOrderColumns = true;
			this.m_ChangeCoefficientsDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_ChangeCoefficientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.m_ChangeCoefficientsDataGridView.AutoGenerateColumns = false;
			this.m_ChangeCoefficientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_ChangeCoefficientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_ChangeCoefficientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_ChangeCoefficientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.m_ChangeCoefficientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_ChangeCoefficientsDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.nameDataGridViewTextBoxColumn,
            this.measurementUnitDataGridViewTextBoxColumn,
            this.coefficientDataGridViewTextBoxColumn} );
			this.m_ChangeCoefficientsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_ChangeCoefficientsDataGridView.DataSource = this.m_ChangeCoefficientsBindingSource;
			this.m_ChangeCoefficientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ChangeCoefficientsDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_ChangeCoefficientsDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ChangeCoefficientsDataGridView.MultiSelect = false;
			this.m_ChangeCoefficientsDataGridView.Name = "m_ChangeCoefficientsDataGridView";
			this.m_ChangeCoefficientsDataGridView.ReadOnly = true;
			this.m_ChangeCoefficientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_ChangeCoefficientsDataGridView.RowHeadersWidth = 20;
			this.m_ChangeCoefficientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_ChangeCoefficientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.m_ChangeCoefficientsDataGridView.RowTemplate.Height = 24;
			this.m_ChangeCoefficientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_ChangeCoefficientsDataGridView.Size = new System.Drawing.Size( 1025, 359 );
			this.m_ChangeCoefficientsDataGridView.TabIndex = 24;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Показатель";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 775;
			// 
			// measurementUnitDataGridViewTextBoxColumn
			// 
			this.measurementUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit";
			this.measurementUnitDataGridViewTextBoxColumn.HeaderText = "Единицы измерения";
			this.measurementUnitDataGridViewTextBoxColumn.Name = "measurementUnitDataGridViewTextBoxColumn";
			this.measurementUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// coefficientDataGridViewTextBoxColumn
			// 
			this.coefficientDataGridViewTextBoxColumn.DataPropertyName = "Coefficient";
			this.coefficientDataGridViewTextBoxColumn.HeaderText = "Значение";
			this.coefficientDataGridViewTextBoxColumn.Name = "coefficientDataGridViewTextBoxColumn";
			this.coefficientDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// m_ChangeCoefficientsBindingSource
			// 
			this.m_ChangeCoefficientsBindingSource.DataMember = "ChangeCoefficients";
			this.m_ChangeCoefficientsBindingSource.DataSource = this.m_DataSet;
			// 
			// m_DataSet
			// 
			this.m_DataSet.DataSetName = "MainFacilitiesUseAnalysisDataSet";
			this.m_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// m_ChangeCoefficientsDescriptionDataGridView
			// 
			this.m_ChangeCoefficientsDescriptionDataGridView.AllowUserToAddRows = false;
			this.m_ChangeCoefficientsDescriptionDataGridView.AllowUserToDeleteRows = false;
			this.m_ChangeCoefficientsDescriptionDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font( "Tahoma", 7.5F );
			this.m_ChangeCoefficientsDescriptionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.m_ChangeCoefficientsDescriptionDataGridView.AutoGenerateColumns = false;
			this.m_ChangeCoefficientsDescriptionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_ChangeCoefficientsDescriptionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.m_ChangeCoefficientsDescriptionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_ChangeCoefficientsDescriptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.m_ChangeCoefficientsDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_ChangeCoefficientsDescriptionDataGridView.ColumnHeadersVisible = false;
			this.m_ChangeCoefficientsDescriptionDataGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[ ] {
            this.coefficientValueDescriptionDataGridViewTextBoxColumn} );
			this.m_ChangeCoefficientsDescriptionDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
			this.m_ChangeCoefficientsDescriptionDataGridView.DataSource = this.m_ChangeCoefficientsDescriptionBindingSource;
			this.m_ChangeCoefficientsDescriptionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ChangeCoefficientsDescriptionDataGridView.Location = new System.Drawing.Point( 0, 0 );
			this.m_ChangeCoefficientsDescriptionDataGridView.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ChangeCoefficientsDescriptionDataGridView.MultiSelect = false;
			this.m_ChangeCoefficientsDescriptionDataGridView.Name = "m_ChangeCoefficientsDescriptionDataGridView";
			this.m_ChangeCoefficientsDescriptionDataGridView.ReadOnly = true;
			this.m_ChangeCoefficientsDescriptionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.m_ChangeCoefficientsDescriptionDataGridView.RowHeadersWidth = 20;
			this.m_ChangeCoefficientsDescriptionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.Font = new System.Drawing.Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_ChangeCoefficientsDescriptionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.m_ChangeCoefficientsDescriptionDataGridView.RowTemplate.Height = 24;
			this.m_ChangeCoefficientsDescriptionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.m_ChangeCoefficientsDescriptionDataGridView.Size = new System.Drawing.Size( 1025, 304 );
			this.m_ChangeCoefficientsDescriptionDataGridView.TabIndex = 25;
			// 
			// coefficientValueDescriptionDataGridViewTextBoxColumn
			// 
			this.coefficientValueDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoefficientValueDescription";
			this.coefficientValueDescriptionDataGridViewTextBoxColumn.HeaderText = "CoefficientValueDescription";
			this.coefficientValueDescriptionDataGridViewTextBoxColumn.Name = "coefficientValueDescriptionDataGridViewTextBoxColumn";
			this.coefficientValueDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.coefficientValueDescriptionDataGridViewTextBoxColumn.Width = 1380;
			// 
			// m_ChangeCoefficientsDescriptionBindingSource
			// 
			this.m_ChangeCoefficientsDescriptionBindingSource.DataMember = "ChangeCoefficientsDescription";
			this.m_ChangeCoefficientsDescriptionBindingSource.DataSource = this.m_DataSet;
			// 
			// ChangeCoefficientsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size( 1051, 735 );
			this.Controls.Add( this.m_TableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.MinimumSize = new System.Drawing.Size( 865, 250 );
			this.Name = "ChangeCoefficientsForm";
			this.Opacity = 0.96;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменение фондоотдачи и фондорентабельности";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ChangeCoefficientsForm_FormClosing );
			this.Load += new System.EventHandler( this.ChangeCoefficientsForm_Load );
			this.m_TableLayoutPanel.ResumeLayout( false );
			this.m_TableLayoutPanel.PerformLayout( );
			this.m_ToolStrip.ResumeLayout( false );
			this.m_ToolStrip.PerformLayout( );
			this.m_SplitContainer.Panel1.ResumeLayout( false );
			this.m_SplitContainer.Panel2.ResumeLayout( false );
			this.m_SplitContainer.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsBindingSource ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDescriptionDataGridView ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ChangeCoefficientsDescriptionBindingSource ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		protected System.Windows.Forms.BindingSource m_ChangeCoefficientsBindingSource;

		protected System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;

		protected System.Windows.Forms.ToolStrip m_ToolStrip;
		protected MainFacilitiesUseAnalysisDataSet m_DataSet;
		protected System.Windows.Forms.ToolStripLabel m_TwoYearsToolStripLabel;
		protected System.Windows.Forms.SplitContainer m_SplitContainer;
		protected System.Windows.Forms.DataGridView m_ChangeCoefficientsDataGridView;
		protected System.Windows.Forms.DataGridView m_ChangeCoefficientsDescriptionDataGridView;
		protected System.Windows.Forms.BindingSource m_ChangeCoefficientsDescriptionBindingSource;
		protected System.Windows.Forms.DataGridViewTextBoxColumn coefficientValueDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn coefficientDataGridViewTextBoxColumn;
	}
}