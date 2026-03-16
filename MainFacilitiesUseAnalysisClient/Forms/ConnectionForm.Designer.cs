namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма подключения
	/// </summary>
	public partial class ConnectionForm
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
			this.m_ErrorProvider = new System.Windows.Forms.ErrorProvider( this.components );
			this.m_ControlsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_ServerLabel = new System.Windows.Forms.Label( );
			this.m_DatabaseLabel = new System.Windows.Forms.Label( );
			this.m_UserNameLabel = new System.Windows.Forms.Label( );
			this.m_PasswordLabel = new System.Windows.Forms.Label( );
			this.m_ServerTextBox = new System.Windows.Forms.TextBox( );
			this.m_DatabaseTextBox = new System.Windows.Forms.TextBox( );
			this.m_UserNameTextBox = new System.Windows.Forms.TextBox( );
			this.m_PasswordTextBox = new System.Windows.Forms.TextBox( );
			this.m_ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel( );
			this.m_ConnectButton = new System.Windows.Forms.Button( );
			this.m_CancelButton = new System.Windows.Forms.Button( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ErrorProvider ) ).BeginInit( );
			this.m_ControlsTableLayoutPanel.SuspendLayout( );
			this.m_ButtonsLayoutPanel.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// m_ErrorProvider
			// 
			this.m_ErrorProvider.ContainerControl = this;
			// 
			// m_ControlsTableLayoutPanel
			// 
			this.m_ControlsTableLayoutPanel.ColumnCount = 3;
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ControlsTableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 25F ) );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_ServerLabel, 1, 1 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_DatabaseLabel, 1, 3 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_UserNameLabel, 1, 5 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_PasswordLabel, 1, 7 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_ServerTextBox, 1, 2 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_DatabaseTextBox, 1, 4 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_UserNameTextBox, 1, 6 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_PasswordTextBox, 1, 8 );
			this.m_ControlsTableLayoutPanel.Controls.Add( this.m_ButtonsLayoutPanel, 1, 9 );
			this.m_ControlsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ControlsTableLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
			this.m_ControlsTableLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ControlsTableLayoutPanel.Name = "m_ControlsTableLayoutPanel";
			this.m_ControlsTableLayoutPanel.RowCount = 11;
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 24F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ControlsTableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 10F ) );
			this.m_ControlsTableLayoutPanel.Size = new System.Drawing.Size( 355, 321 );
			this.m_ControlsTableLayoutPanel.TabIndex = 22;
			// 
			// m_ServerLabel
			// 
			this.m_ServerLabel.AutoSize = true;
			this.m_ServerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ServerLabel.Location = new System.Drawing.Point( 15, 15 );
			this.m_ServerLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_ServerLabel.Name = "m_ServerLabel";
			this.m_ServerLabel.Size = new System.Drawing.Size( 310, 25 );
			this.m_ServerLabel.TabIndex = 22;
			this.m_ServerLabel.Text = "Имя сервера";
			this.m_ServerLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_DatabaseLabel
			// 
			this.m_DatabaseLabel.AutoSize = true;
			this.m_DatabaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_DatabaseLabel.Location = new System.Drawing.Point( 15, 74 );
			this.m_DatabaseLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_DatabaseLabel.Name = "m_DatabaseLabel";
			this.m_DatabaseLabel.Size = new System.Drawing.Size( 310, 25 );
			this.m_DatabaseLabel.TabIndex = 22;
			this.m_DatabaseLabel.Text = "Имя базы данных";
			this.m_DatabaseLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_UserNameLabel
			// 
			this.m_UserNameLabel.AutoSize = true;
			this.m_UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserNameLabel.Location = new System.Drawing.Point( 15, 133 );
			this.m_UserNameLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_UserNameLabel.Name = "m_UserNameLabel";
			this.m_UserNameLabel.Size = new System.Drawing.Size( 310, 25 );
			this.m_UserNameLabel.TabIndex = 22;
			this.m_UserNameLabel.Text = "Имя пользователя";
			this.m_UserNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_PasswordLabel
			// 
			this.m_PasswordLabel.AutoSize = true;
			this.m_PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_PasswordLabel.Location = new System.Drawing.Point( 15, 192 );
			this.m_PasswordLabel.Margin = new System.Windows.Forms.Padding( 5 );
			this.m_PasswordLabel.Name = "m_PasswordLabel";
			this.m_PasswordLabel.Size = new System.Drawing.Size( 310, 25 );
			this.m_PasswordLabel.TabIndex = 22;
			this.m_PasswordLabel.Text = "Пароль";
			this.m_PasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// m_ServerTextBox
			// 
			this.m_ServerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ServerTextBox.Location = new System.Drawing.Point( 10, 45 );
			this.m_ServerTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ServerTextBox.Name = "m_ServerTextBox";
			this.m_ServerTextBox.Size = new System.Drawing.Size( 320, 24 );
			this.m_ServerTextBox.TabIndex = 0;
			this.m_ServerTextBox.Text = "ACER\\SQL";
			this.m_ServerTextBox.WordWrap = false;
			// 
			// m_DatabaseTextBox
			// 
			this.m_DatabaseTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.m_DatabaseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_DatabaseTextBox.Location = new System.Drawing.Point( 10, 104 );
			this.m_DatabaseTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_DatabaseTextBox.Name = "m_DatabaseTextBox";
			this.m_DatabaseTextBox.Size = new System.Drawing.Size( 320, 24 );
			this.m_DatabaseTextBox.TabIndex = 1;
			this.m_DatabaseTextBox.Text = "MainFacilitiesUseAnalysis";
			this.m_DatabaseTextBox.WordWrap = false;
			// 
			// m_UserNameTextBox
			// 
			this.m_UserNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserNameTextBox.Location = new System.Drawing.Point( 10, 163 );
			this.m_UserNameTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_UserNameTextBox.Name = "m_UserNameTextBox";
			this.m_UserNameTextBox.Size = new System.Drawing.Size( 320, 24 );
			this.m_UserNameTextBox.TabIndex = 2;
			this.m_UserNameTextBox.WordWrap = false;
			// 
			// m_PasswordTextBox
			// 
			this.m_PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_PasswordTextBox.Location = new System.Drawing.Point( 10, 222 );
			this.m_PasswordTextBox.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_PasswordTextBox.Name = "m_PasswordTextBox";
			this.m_PasswordTextBox.PasswordChar = '*';
			this.m_PasswordTextBox.Size = new System.Drawing.Size( 320, 24 );
			this.m_PasswordTextBox.TabIndex = 3;
			this.m_PasswordTextBox.WordWrap = false;
			// 
			// m_ButtonsLayoutPanel
			// 
			this.m_ButtonsLayoutPanel.ColumnCount = 2;
			this.m_ButtonsLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			this.m_ButtonsLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
			this.m_ButtonsLayoutPanel.Controls.Add( this.m_ConnectButton, 0, 1 );
			this.m_ButtonsLayoutPanel.Controls.Add( this.m_CancelButton, 1, 1 );
			this.m_ButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ButtonsLayoutPanel.Location = new System.Drawing.Point( 10, 246 );
			this.m_ButtonsLayoutPanel.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ButtonsLayoutPanel.MinimumSize = new System.Drawing.Size( 320, 0 );
			this.m_ButtonsLayoutPanel.Name = "m_ButtonsLayoutPanel";
			this.m_ButtonsLayoutPanel.RowCount = 2;
			this.m_ButtonsLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
			this.m_ButtonsLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
			this.m_ButtonsLayoutPanel.Size = new System.Drawing.Size( 320, 65 );
			this.m_ButtonsLayoutPanel.TabIndex = 22;
			// 
			// m_ConnectButton
			// 
			this.m_ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_ConnectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_ConnectButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_ConnectButton.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold );
			this.m_ConnectButton.Location = new System.Drawing.Point( 0, 30 );
			this.m_ConnectButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_ConnectButton.Name = "m_ConnectButton";
			this.m_ConnectButton.Size = new System.Drawing.Size( 125, 35 );
			this.m_ConnectButton.TabIndex = 4;
			this.m_ConnectButton.Text = "Подключить";
			this.m_ConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_ConnectButton.UseVisualStyleBackColor = true;
			this.m_ConnectButton.Click += new System.EventHandler( this.m_ConnectButton_Click );
			// 
			// m_CancelButton
			// 
			this.m_CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_CancelButton.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold );
			this.m_CancelButton.Location = new System.Drawing.Point( 195, 30 );
			this.m_CancelButton.Margin = new System.Windows.Forms.Padding( 0 );
			this.m_CancelButton.Name = "m_CancelButton";
			this.m_CancelButton.Size = new System.Drawing.Size( 125, 35 );
			this.m_CancelButton.TabIndex = 5;
			this.m_CancelButton.Text = "Отменить";
			this.m_CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_CancelButton.UseVisualStyleBackColor = true;
			// 
			// ConnectionForm
			// 
			this.AcceptButton = this.m_ConnectButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.m_CancelButton;
			this.ClientSize = new System.Drawing.Size( 355, 321 );
			this.Controls.Add( this.m_ControlsTableLayoutPanel );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.MinimumSize = new System.Drawing.Size( 320, 305 );
			this.Name = "ConnectionForm";
			this.Opacity = 0.96;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Подключение";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ConnectionForm_FormClosing );
			this.Load += new System.EventHandler( this.ConnectionForm_Load );
			( ( System.ComponentModel.ISupportInitialize ) ( this.m_ErrorProvider ) ).EndInit( );
			this.m_ControlsTableLayoutPanel.ResumeLayout( false );
			this.m_ControlsTableLayoutPanel.PerformLayout( );
			this.m_ButtonsLayoutPanel.ResumeLayout( false );
			this.ResumeLayout( false );

		} // InitializeComponent
		#endregion Windows Form Designer generated code

		protected System.Windows.Forms.TableLayoutPanel m_ControlsTableLayoutPanel;
		protected System.Windows.Forms.Label m_ServerLabel;
		protected System.Windows.Forms.Label m_DatabaseLabel;
		protected System.Windows.Forms.TextBox m_ServerTextBox;
		protected System.Windows.Forms.Label m_UserNameLabel;
		protected System.Windows.Forms.Label m_PasswordLabel;
		protected System.Windows.Forms.TextBox m_DatabaseTextBox;
		protected System.Windows.Forms.TextBox m_UserNameTextBox;
		protected System.Windows.Forms.TextBox m_PasswordTextBox;
		protected System.Windows.Forms.TableLayoutPanel m_ButtonsLayoutPanel;
		protected System.Windows.Forms.Button m_ConnectButton;
		protected System.Windows.Forms.Button m_CancelButton;
		protected System.Windows.Forms.ErrorProvider m_ErrorProvider;
	} // ConnectionForm
} // MainFacilitiesUseAnalysisClient