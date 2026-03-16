using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма подключения
	/// </summary>
	public partial class ConnectionForm : Form
	{
		/// <summary>
		/// Признак необходимости завершения диалога подключения
		/// </summary>
		protected bool m_MustCloseDialog = true;

		#region Методы
		#region Стандартные методы
		/// <summary>
		/// Загрузка исходных параметров подключения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void ConnectionForm_Load
		(
			object sender,
			EventArgs e
		)
		{
		} // ConnectionForm_Load

		/// <summary>
		/// Завершение попытки подключения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void ConnectionForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Закрытие формы зависит от результата теста подключения
			e.Cancel = ! this.m_MustCloseDialog;
			// Попытка подключения совершена, и диалог может быть отменён
			// или предпринята новая попытка подключения
			this.m_MustCloseDialog = true;
		} // ConnectionForm_FormClosing
		#endregion Стандартные методы

		/// <summary>
		/// Попытка подключения к базе данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_ConnectButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Диалог не может быть закрыт, пока не состоялась попытка подключения
			this.m_MustCloseDialog = false;
			// Очиста сигнализаторов об ошибке
			this.m_ErrorProvider.Clear( );

			// Установка параметров подключения
			DataContainer.Instance( ).DataSource     = this.m_ServerTextBox.Text;
			DataContainer.Instance( ).InitialCatalog = this.m_DatabaseTextBox.Text;
			DataContainer.Instance( ).UserID         = this.m_UserNameTextBox.Text;
			DataContainer.Instance( ).Password       = this.m_PasswordTextBox.Text;

			// Попытка подключения
			this.Cursor               = Cursors.WaitCursor;
			OperationReport locReport = DataContainer.Instance( ).Connect( );
			this.Cursor               = Cursors.Default;

			// Просмотр отчёта о результате подключения
			switch ( locReport.Result )
			{
				// Успешное поделючение
				case OperationResult.SUCCESSFUL :
					// Диалог состоялся успешно и может быть закрыт
					this.m_MustCloseDialog = true;
					return;

				// Невеное имя сервера
				case OperationResult.INVALID_SERVER :
					this.m_ErrorProvider.SetError( this.m_ServerTextBox,
						locReport.Message );
					break;

				// Невеное имя базы данных
				case OperationResult.INVALID_DATABASE :
					this.m_ErrorProvider.SetError( this.m_DatabaseTextBox,
						locReport.Message );
					break;

				// Невеное имя пользователя или пароль
				case OperationResult.INVALID_USER_NAME_OR_PASSWORD :
					this.m_ErrorProvider.SetError( this.m_UserNameTextBox,
						locReport.Message );
					this.m_ErrorProvider.SetError( this.m_PasswordTextBox,
						locReport.Message );
					break;

				// Прочие ошибки
				default :
					this.m_ErrorProvider.SetError( this.m_ConnectButton,
						locReport.Message );
					break;
			} // switch
		} // m_ConnectButton_Click
		#endregion Методы

		/// <summary>
		/// Создание формы соединения
		/// </summary>
		public ConnectionForm( )
		{
			InitializeComponent( );
		} // ConnectionForm
	} // ConnectionForm
} // MainFacilitiesUseAnalysisClient