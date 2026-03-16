namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма подключения
	/// </summary>
	public partial class AnalysisTypeChoiceForm
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
		} // Dispose

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container( );
			this.m_ControlsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_AnalysedYearTextBox = new System.Windows.Forms.TextBox( );
			this.m_AnalysedYearLabel = new System.Windows.Forms.Label( );
			this.m_BaseYearTextBox = new System.Windows.Forms.TextBox( );
			this.m_BaseYearLabel = new System.Windows.Forms.Label( );
			this.m_ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_AnalyseButton = new System.Windows.Forms.Button( );
			this.m_CancelButton = new System.Windows.Forms.Button( );
			this.m_AnalysisTypesGroupBox = new System.Windows.Forms.GroupBox( );
			this.m_AnalysisTypesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_StructureAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_SupplyAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_EfficiencyAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_ChangeAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_FactorsAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_StructureAnalysisGroupBox = new System.Windows.Forms.GroupBox( );
			this.m_StructureAnalysisTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_CostAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_WeightAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_CostAndWeightAnalysisRadioButton = new System.Windows.Forms.RadioButton( );
			this.m_ErrorProvider = new System.Windows.Forms.ErrorProvider( this.components );
			this.m_DataSet = new MainFacilitiesUseAnalysisClient.MainFacilitiesUseAnalysisDataSet( );
			this.m_ControlsTableLayoutPanel.SuspendLayout( );
			this.m_ButtonsLayoutPanel.SuspendLayout( );
			this.m_AnalysisTypesGroupBox.SuspendLayout( );
			this.m_AnalysisTypesTableLayoutPanel.SuspendLayout( );
			this.m_StructureAnalysisGroupBox.SuspendLayout( );
			this.m_StructureAnalysisTableLayoutPanel.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ErrorProvider ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// m_ControlsTableLayoutPanel
			// 
			this.m_ControlsTableLayoutPanel.ColumnCount = 3;
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 25F ) );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_AnalysedYearTextBox, 1, 4 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_AnalysedYearLabel, 1, 3 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_BaseYearTextBox, 1, 2 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_BaseYearLabel, 1, 1 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_ButtonsLayoutPanel, 1, 7 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_AnalysisTypesGroupBox, 1, 6 );
			this.m_ControlsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ControlsTableLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
			this.m_ControlsTableLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ControlsTableLayoutPanel.Name = "m_ControlsTableLayoutPanel";
			this.m_ControlsTableLayoutPanel.RowCount = 9;
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 320F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.Size = new System.Drawing.Size( 590, 524 );
			this.m_ControlsTableLayoutPanel.TabIndex = 22;
			// 
			// m_AnalysedYearTextBox
			// 
			this.m_AnalysedYearTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_AnalysedYearTextBox.Location = new System.Drawing.Point( 10, 104 );
			this.m_AnalysedYearTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_AnalysedYearTextBox.Name = "m_AnalysedYearTextBox";
			this.m_AnalysedYearTextBox.Size = new System.Drawing.Size( 555, 24 );
			this.m_AnalysedYearTextBox.TabIndex = 1;
			this.m_AnalysedYearTextBox.Text = "2003";
			this.m_AnalysedYearTextBox.WordWrap = false;
			// 
			// m_AnalysedYearLabel
			// 
			this.m_AnalysedYearLabel.AutoSize = true;
			this.m_AnalysedYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_AnalysedYearLabel.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_AnalysedYearLabel.Location = new System.Drawing.Point( 15, 74 );
			this.m_AnalysedYearLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_AnalysedYearLabel.Name = "m_AnalysedYearLabel";
			this.m_AnalysedYearLabel.Size = new System.Drawing.Size( 545, 25 );
			this.m_AnalysedYearLabel.TabIndex = 22;
			this.m_AnalysedYearLabel.Text = "Анализируемый год";
			this.m_AnalysedYearLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_BaseYearTextBox
			// 
			this.m_BaseYearTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_BaseYearTextBox.Location = new System.Drawing.Point( 10, 45 );
			this.m_BaseYearTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_BaseYearTextBox.Name = "m_BaseYearTextBox";
			this.m_BaseYearTextBox.Size = new System.Drawing.Size( 555, 24 );
			this.m_BaseYearTextBox.TabIndex = 0;
			this.m_BaseYearTextBox.Text = "2002";
			this.m_BaseYearTextBox.WordWrap = false;
			// 
			// m_BaseYearLabel
			// 
			this.m_BaseYearLabel.AutoSize = true;
			this.m_BaseYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_BaseYearLabel.Location = new System.Drawing.Point( 15, 15 );
			this.m_BaseYearLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_BaseYearLabel.Name = "m_BaseYearLabel";
			this.m_BaseYearLabel.Size = new System.Drawing.Size( 545, 25 );
			this.m_BaseYearLabel.TabIndex = 22;
			this.m_BaseYearLabel.Text = "Базовый год";
			this.m_BaseYearLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_ButtonsLayoutPanel
			// 
			this.m_ButtonsLayoutPanel.ColumnCount = 2;
			this.m_ButtonsLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			this.m_ButtonsLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			this.m_ButtonsLayoutPanel.Controls.Add( this.m_AnalyseButton, 0, 1 );
			this.m_ButtonsLayoutPanel.Controls.Add( this.m_CancelButton, 1, 1 );
			this.m_ButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ButtonsLayoutPanel.Location = new System.Drawing.Point( 10, 468 );
			this.m_ButtonsLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ButtonsLayoutPanel.MinimumSize = new System.Drawing.Size( 320, 0 );
			this.m_ButtonsLayoutPanel.Name = "m_ButtonsLayoutPanel";
			this.m_ButtonsLayoutPanel.RowCount = 2;
			this.m_ButtonsLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ButtonsLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ButtonsLayoutPanel.Size = new System.Drawing.Size( 555, 46 );
			this.m_ButtonsLayoutPanel.TabIndex = 22;
			// 
			// m_AnalyseButton
			// 
			this.m_AnalyseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_AnalyseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_AnalyseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_AnalyseButton.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold );
			this.m_AnalyseButton.Location = new System.Drawing.Point( 0, 11 );
			this.m_AnalyseButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_AnalyseButton.Name = "m_AnalyseButton";
			this.m_AnalyseButton.Size = new System.Drawing.Size( 150, 35 );
			this.m_AnalyseButton.TabIndex = 12;
			this.m_AnalyseButton.Text = "Анализировать";
			this.m_AnalyseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_AnalyseButton.UseVisualStyleBackColor = true;
			this.m_AnalyseButton.Click += new System.EventHandler( this.m_AnalyseButton_Click );
			// 
			// m_CancelButton
			// 
			this.m_CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_CancelButton.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold );
			this.m_CancelButton.Location = new System.Drawing.Point( 405, 11 );
			this.m_CancelButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_CancelButton.Name = "m_CancelButton";
			this.m_CancelButton.Size = new System.Drawing.Size( 150, 35 );
			this.m_CancelButton.TabIndex = 13;
			this.m_CancelButton.Text = "Отменить";
			this.m_CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_CancelButton.UseVisualStyleBackColor = true;
			// 
			// m_AnalysisTypesGroupBox
			// 
			this.m_AnalysisTypesGroupBox.Controls.Add( this.m_AnalysisTypesTableLayoutPanel );
			this.m_AnalysisTypesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_AnalysisTypesGroupBox.Font = new System.Drawing.Font( "Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.m_AnalysisTypesGroupBox.Location = new System.Drawing.Point( 10, 148 );
			this.m_AnalysisTypesGroupBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_AnalysisTypesGroupBox.Name = "m_AnalysisTypesGroupBox";
			this.m_AnalysisTypesGroupBox.Padding = new System.Windows.Forms.Padding( 0 );
			this.m_AnalysisTypesGroupBox.Size = new System.Drawing.Size( 555, 320 );
			this.m_AnalysisTypesGroupBox.TabIndex = 2;
			this.m_AnalysisTypesGroupBox.TabStop = false;
			this.m_AnalysisTypesGroupBox.Text = "Вид анализа использования осноных средств";
			// 
			// m_AnalysisTypesTableLayoutPanel
			// 
			this.m_AnalysisTypesTableLayoutPanel.ColumnCount = 3;
			this.m_AnalysisTypesTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_AnalysisTypesTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_AnalysisTypesTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_StructureAnalysisRadioButton, 1, 1 );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_SupplyAnalysisRadioButton, 1, 3 );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_EfficiencyAnalysisRadioButton, 1, 4 );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_ChangeAnalysisRadioButton, 1, 5 );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_FactorsAnalysisRadioButton, 1, 6 );
			this.m_AnalysisTypesTableLayoutPanel.Controls.Add( this.m_StructureAnalysisGroupBox, 1, 2 );
			this.m_AnalysisTypesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_AnalysisTypesTableLayoutPanel.Location = new System.Drawing.Point( 0, 20 );
			this.m_AnalysisTypesTableLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_AnalysisTypesTableLayoutPanel.Name = "m_AnalysisTypesTableLayoutPanel";
			this.m_AnalysisTypesTableLayoutPanel.RowCount = 9;
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 130F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_AnalysisTypesTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_AnalysisTypesTableLayoutPanel.Size = new System.Drawing.Size( 555, 300 );
			this.m_AnalysisTypesTableLayoutPanel.TabIndex = 22;
			// 
			// m_StructureAnalysisRadioButton
			// 
			this.m_StructureAnalysisRadioButton.AutoSize = true;
			this.m_StructureAnalysisRadioButton.Checked = true;
			this.m_StructureAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_StructureAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_StructureAnalysisRadioButton.Location = new System.Drawing.Point( 10, 10 );
			this.m_StructureAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_StructureAnalysisRadioButton.Name = "m_StructureAnalysisRadioButton";
			this.m_StructureAnalysisRadioButton.Size = new System.Drawing.Size( 535, 30 );
			this.m_StructureAnalysisRadioButton.TabIndex = 3;
			this.m_StructureAnalysisRadioButton.TabStop = true;
			this.m_StructureAnalysisRadioButton.Text = "Анализ стpуктуpы основных средств";
			this.m_StructureAnalysisRadioButton.UseVisualStyleBackColor = true;
			this.m_StructureAnalysisRadioButton.CheckedChanged += new System.EventHandler( this.m_StructureAnalysisRadioButton_CheckedChanged );
			// 
			// m_SupplyAnalysisRadioButton
			// 
			this.m_SupplyAnalysisRadioButton.AutoSize = true;
			this.m_SupplyAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_SupplyAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_SupplyAnalysisRadioButton.Location = new System.Drawing.Point( 10, 170 );
			this.m_SupplyAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_SupplyAnalysisRadioButton.Name = "m_SupplyAnalysisRadioButton";
			this.m_SupplyAnalysisRadioButton.Size = new System.Drawing.Size( 535, 30 );
			this.m_SupplyAnalysisRadioButton.TabIndex = 8;
			this.m_SupplyAnalysisRadioButton.TabStop = true;
			this.m_SupplyAnalysisRadioButton.Text = "Анализ движения и технического состояния основных средств";
			this.m_SupplyAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_EfficiencyAnalysisRadioButton
			// 
			this.m_EfficiencyAnalysisRadioButton.AutoSize = true;
			this.m_EfficiencyAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_EfficiencyAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_EfficiencyAnalysisRadioButton.Location = new System.Drawing.Point( 10, 200 );
			this.m_EfficiencyAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_EfficiencyAnalysisRadioButton.Name = "m_EfficiencyAnalysisRadioButton";
			this.m_EfficiencyAnalysisRadioButton.Size = new System.Drawing.Size( 535, 30 );
			this.m_EfficiencyAnalysisRadioButton.TabIndex = 9;
			this.m_EfficiencyAnalysisRadioButton.TabStop = true;
			this.m_EfficiencyAnalysisRadioButton.Text = "Анализ эффективности использования основных средств";
			this.m_EfficiencyAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_ChangeAnalysisRadioButton
			// 
			this.m_ChangeAnalysisRadioButton.AutoSize = true;
			this.m_ChangeAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ChangeAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_ChangeAnalysisRadioButton.Location = new System.Drawing.Point( 10, 230 );
			this.m_ChangeAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ChangeAnalysisRadioButton.Name = "m_ChangeAnalysisRadioButton";
			this.m_ChangeAnalysisRadioButton.Size = new System.Drawing.Size( 535, 30 );
			this.m_ChangeAnalysisRadioButton.TabIndex = 10;
			this.m_ChangeAnalysisRadioButton.TabStop = true;
			this.m_ChangeAnalysisRadioButton.Text = "Анализ изменения фондоотдачи и фондорентабильности основных средств";
			this.m_ChangeAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_FactorsAnalysisRadioButton
			// 
			this.m_FactorsAnalysisRadioButton.AutoSize = true;
			this.m_FactorsAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_FactorsAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_FactorsAnalysisRadioButton.Location = new System.Drawing.Point( 10, 260 );
			this.m_FactorsAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_FactorsAnalysisRadioButton.Name = "m_FactorsAnalysisRadioButton";
			this.m_FactorsAnalysisRadioButton.Size = new System.Drawing.Size( 535, 30 );
			this.m_FactorsAnalysisRadioButton.TabIndex = 11;
			this.m_FactorsAnalysisRadioButton.TabStop = true;
			this.m_FactorsAnalysisRadioButton.Text = "Факторный анлиз фондорентабильности основных средств";
			this.m_FactorsAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_StructureAnalysisGroupBox
			// 
			this.m_StructureAnalysisGroupBox.Controls.Add( this.m_StructureAnalysisTableLayoutPanel );
			this.m_StructureAnalysisGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_StructureAnalysisGroupBox.Location = new System.Drawing.Point( 10, 40 );
			this.m_StructureAnalysisGroupBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_StructureAnalysisGroupBox.Name = "m_StructureAnalysisGroupBox";
			this.m_StructureAnalysisGroupBox.Padding = new System.Windows.Forms.Padding( 0 );
			this.m_StructureAnalysisGroupBox.Size = new System.Drawing.Size( 535, 130 );
			this.m_StructureAnalysisGroupBox.TabIndex = 4;
			this.m_StructureAnalysisGroupBox.TabStop = false;
			// 
			// m_StructureAnalysisTableLayoutPanel
			// 
			this.m_StructureAnalysisTableLayoutPanel.ColumnCount = 3;
			this.m_StructureAnalysisTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.m_StructureAnalysisTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_StructureAnalysisTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_StructureAnalysisTableLayoutPanel.Controls.Add( this.m_CostAnalysisRadioButton, 1, 0 );
			this.m_StructureAnalysisTableLayoutPanel.Controls.Add( this.m_WeightAnalysisRadioButton, 1, 1 );
			this.m_StructureAnalysisTableLayoutPanel.Controls.Add( this.m_CostAndWeightAnalysisRadioButton, 1, 2 );
			this.m_StructureAnalysisTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_StructureAnalysisTableLayoutPanel.Location = new System.Drawing.Point( 0, 20 );
			this.m_StructureAnalysisTableLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_StructureAnalysisTableLayoutPanel.Name = "m_StructureAnalysisTableLayoutPanel";
			this.m_StructureAnalysisTableLayoutPanel.RowCount = 5;
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 30F ) );
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_StructureAnalysisTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.m_StructureAnalysisTableLayoutPanel.Size = new System.Drawing.Size( 535, 110 );
			this.m_StructureAnalysisTableLayoutPanel.TabIndex = 22;
			// 
			// m_CostAnalysisRadioButton
			// 
			this.m_CostAnalysisRadioButton.AutoSize = true;
			this.m_CostAnalysisRadioButton.Checked = true;
			this.m_CostAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_CostAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_CostAnalysisRadioButton.Location = new System.Drawing.Point( 20, 0 );
			this.m_CostAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_CostAnalysisRadioButton.Name = "m_CostAnalysisRadioButton";
			this.m_CostAnalysisRadioButton.Size = new System.Drawing.Size( 505, 30 );
			this.m_CostAnalysisRadioButton.TabIndex = 5;
			this.m_CostAnalysisRadioButton.TabStop = true;
			this.m_CostAnalysisRadioButton.Text = "Анализ стpуктуpы cтoимocтeй основных средств";
			this.m_CostAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_WeightAnalysisRadioButton
			// 
			this.m_WeightAnalysisRadioButton.AutoSize = true;
			this.m_WeightAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_WeightAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_WeightAnalysisRadioButton.Location = new System.Drawing.Point( 20, 30 );
			this.m_WeightAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_WeightAnalysisRadioButton.Name = "m_WeightAnalysisRadioButton";
			this.m_WeightAnalysisRadioButton.Size = new System.Drawing.Size( 505, 30 );
			this.m_WeightAnalysisRadioButton.TabIndex = 6;
			this.m_WeightAnalysisRadioButton.TabStop = true;
			this.m_WeightAnalysisRadioButton.Text = "Анализ стpуктуpы удельных весов основных средств";
			this.m_WeightAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_CostAndWeightAnalysisRadioButton
			// 
			this.m_CostAndWeightAnalysisRadioButton.AutoSize = true;
			this.m_CostAndWeightAnalysisRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_CostAndWeightAnalysisRadioButton.Font = new System.Drawing.Font( "Tahoma", 8.25F );
			this.m_CostAndWeightAnalysisRadioButton.Location = new System.Drawing.Point( 20, 60 );
			this.m_CostAndWeightAnalysisRadioButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_CostAndWeightAnalysisRadioButton.Name = "m_CostAndWeightAnalysisRadioButton";
			this.m_CostAndWeightAnalysisRadioButton.Size = new System.Drawing.Size( 505, 30 );
			this.m_CostAndWeightAnalysisRadioButton.TabIndex = 7;
			this.m_CostAndWeightAnalysisRadioButton.TabStop = true;
			this.m_CostAndWeightAnalysisRadioButton.Text = "Анализ стpуктуpы стоимостей и удельных весов основных средств";
			this.m_CostAndWeightAnalysisRadioButton.UseVisualStyleBackColor = true;
			// 
			// m_ErrorProvider
			// 
			this.m_ErrorProvider.ContainerControl = this;
			// 
			// m_DataSet
			// 
			this.m_DataSet.DataSetName = "MainFacilitiesUseAnalysisDataSet";
			this.m_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// AnalysisTypeChoiceForm
			// 
			this.AcceptButton = this.m_AnalyseButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.m_CancelButton;
			this.ClientSize = new System.Drawing.Size( 590, 524 );
			this.Controls.Add( this.m_ControlsTableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.MinimumSize = new System.Drawing.Size( 320, 305 );
			this.Name = "AnalysisTypeChoiceForm";
			this.Opacity = 0.9;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор параметров анализа";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.AnalysisTypeChoiceForm_FormClosing );
			this.Load += new System.EventHandler( this.AnalysisTypeChoiceForm_Load );
			this.m_ControlsTableLayoutPanel.ResumeLayout( false );
			this.m_ControlsTableLayoutPanel.PerformLayout( );
			this.m_ButtonsLayoutPanel.ResumeLayout( false );
			this.m_AnalysisTypesGroupBox.ResumeLayout( false );
			this.m_AnalysisTypesTableLayoutPanel.ResumeLayout( false );
			this.m_AnalysisTypesTableLayoutPanel.PerformLayout( );
			this.m_StructureAnalysisGroupBox.ResumeLayout( false );
			this.m_StructureAnalysisTableLayoutPanel.ResumeLayout( false );
			this.m_StructureAnalysisTableLayoutPanel.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ErrorProvider ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_DataSet ) ).EndInit( );
			this.ResumeLayout( false );

		} // InitializeComponent
		#endregion Windows Form Designer generated code

		protected System.Windows.Forms.TableLayoutPanel m_ControlsTableLayoutPanel;
		protected System.Windows.Forms.TableLayoutPanel m_ButtonsLayoutPanel;
		protected System.Windows.Forms.Button m_AnalyseButton;
		protected System.Windows.Forms.Button m_CancelButton;
		protected System.Windows.Forms.Label m_BaseYearLabel;
		protected System.Windows.Forms.TextBox m_BaseYearTextBox;
		protected System.Windows.Forms.TextBox m_AnalysedYearTextBox;
		protected System.Windows.Forms.Label m_AnalysedYearLabel;
		protected System.Windows.Forms.GroupBox m_AnalysisTypesGroupBox;
		protected System.Windows.Forms.ErrorProvider m_ErrorProvider;
		protected System.Windows.Forms.TableLayoutPanel m_AnalysisTypesTableLayoutPanel;
		protected System.Windows.Forms.RadioButton m_StructureAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_SupplyAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_EfficiencyAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_ChangeAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_FactorsAnalysisRadioButton;
		protected System.Windows.Forms.GroupBox m_StructureAnalysisGroupBox;
		protected System.Windows.Forms.TableLayoutPanel m_StructureAnalysisTableLayoutPanel;
		protected System.Windows.Forms.RadioButton m_CostAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_WeightAnalysisRadioButton;
		protected System.Windows.Forms.RadioButton m_CostAndWeightAnalysisRadioButton;
		protected MainFacilitiesUseAnalysisDataSet m_DataSet;
	} // ConnectionForm
} // MainFacilitiesUseAnalysisClient