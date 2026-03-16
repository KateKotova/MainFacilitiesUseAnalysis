using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма редактирования группы
	/// </summary>
	public partial class EditGroupForm : Form, IEditEssenceForm
	{
		#region Поля
		/// <summary>
		/// Сущность редактируемой группы
		/// </summary>
		protected Group m_Group;
		/// <summary>
		/// Делегат события выполнения редактирования группы
		/// </summary>
		/// <param name="sender">Источник</param>
		/// <param name="e">Параметры</param>
		public delegate void EditGroupEventHandler
		(
			object             sender,
			EditGroupEventArgs e
		);
		/// <summary>
		/// Событие выполнения редактирования группы
		/// </summary>
		public event EditGroupEventHandler GroupEditingIsExecuted;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Инициализация формы редактирования группы
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public virtual void Init( StoredProcedureAction parAction )
		{
			// Создание редактируемой группы c заданными действием
			// хранимой процедуры и названиями таблиц сущностей
			this.m_Group = new Group( parAction, ref this.m_DataSet,
				this.m_DataSet.Groups.TableName,
				this.m_DataSet.ProductionTypes.TableName,
				this.m_DataSet.ActivityTypes.TableName );

			// Заголовок формы - заголовок сущности
			this.Text                 = Group.ESSENCE_CAPTION;
			// Надпись на кнопке выполнения
			this.m_ExecuteButton.Text = this.m_Group.CurrentActionCaption;

			// Сжатие областей параметров, нездействованных
			// в заданном виде операции, сокрытие их компонентов
			// и изменение размеров формы
			switch ( parAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Сокрытие элементов незадействованных параметов
					this.m_OldNameLabel.Visible    = false;
					this.m_OldNameComboBox.Visible = false;
					// Уменьшение высоты формы
					this.Height -= Convert.ToInt32
						( this.m_ControlsTableLayoutPanel.RowStyles[ 1 ].Height +
						this.m_ControlsTableLayoutPanel.RowStyles[ 2 ].Height );
					// Сжатие области элементов незадействованных параметов
					this.m_ControlsTableLayoutPanel.RowStyles[ 1 ].Height = 0;
					this.m_ControlsTableLayoutPanel.RowStyles[ 2 ].Height = 0;
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Сокрытие элементов незадействованных параметов
					this.m_NameLabel.Visible                  = false;
					this.m_NameTextBox.Visible                = false;
					this.m_ProductionTypeNameLabel.Visible    = false;
					this.m_ProductionTypeNameComboBox.Visible = false;
					this.m_ActivityTypeNameLabel.Visible      = false;
					this.m_ActivityTypeNameComboBox.Visible   = false;

					// Изменение высоты формы
					float locFormHeightChange       = 0;
					// Индекс начальной из сжимаемых по порядку строк таблицы-контейнера
					int locStartCompressedRowIndex  = 3;
					// Индекс последней из сжимаемых по порядку строк таблицы-контейнера
					int locFinishCompressedRowIndex = 8;

					// Получение изменения высоты формы и постепенное сжатие
					// областей незадействованных элементов
					for ( int locCompressedRowIndex = locStartCompressedRowIndex;
							locCompressedRowIndex <= locFinishCompressedRowIndex;
							locCompressedRowIndex++ )
					{
						locFormHeightChange += this.m_ControlsTableLayoutPanel.
							RowStyles[ locCompressedRowIndex ].Height;
						this.m_ControlsTableLayoutPanel.
							RowStyles[ locCompressedRowIndex ].Height = 0;
					} // for
					// Уменьшение высоты формы
					this.Height -= Convert.ToInt32( locFormHeightChange );
					break;

				// Прочие непредусмотренные процедуры
				default :
					break;
			} // switch

			// Запоминание минимальных размеров формы
			System.Drawing.Size locMinimumSize = new Size( this.Width,this.Height );
			this.MinimumSize                   = locMinimumSize;
		} // Init

		#region Стандартные методы
		/// <summary>
		/// Загрузка формы редактирования группы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditGroupForm_Load
		(
			object sender,
			EventArgs e
		)
		{
			// Явное открытие соединения предотвратит лишние операции по неявному
			// открытию и закрытию его во время вызова метода SqlDataAdapter.Fill
			if ( DataContainer.Instance( ).CurrentSqlConnection.State !=
					ConnectionState.Open )
				DataContainer.Instance( ).CurrentSqlConnection.Open( );
		} // EditGroupForm_Load

		/// <summary>
		/// Завершение работы с формой редактирования группы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditGroupForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			// DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // EditGroupForm_FormClosing
		#endregion Стандартные методы

		#region Методы обработки данных
		/// <summary>
		/// Очистка
		/// </summary>
		public virtual void Clear( )
		{
			// Очистка предупреждающих пометок полей
			m_ErrorProvider.Clear( );

			// Очистка полей параметров в зависимости
			// от текущего действия хранимой процедуры сущности
			switch ( this.m_Group.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_NameTextBox.Clear( );
					this.m_ProductionTypeNameComboBox.Text = string.Empty;
					this.m_ActivityTypeNameComboBox.Text   = string.Empty;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldNameComboBox.Text            = string.Empty;
					this.m_NameTextBox.Clear( );
					this.m_ProductionTypeNameComboBox.Text = string.Empty;
					this.m_ActivityTypeNameComboBox.Text   = string.Empty;
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldNameComboBox.Text = string.Empty;
					return;

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
		} // Clear

		/// <summary>
		/// Загрузка параметров хранимой процедуры
		/// </summary>
		/// <returns>Отчёт операции с результатами:
		/// добавление: SUCCESSFUL, INVALID_NAME, INVALID_PRODUCTION_TYPE_NAME,
		/// INVALID_ACTIVITY_TYPE_NAME;
		/// обновление: SUCCESSFUL, INVALID_OLD_NAME, INVALID_NAME,
		/// INVALID_PRODUCTION_TYPE_NAME, INVALID_ACTIVITY_TYPE_NAME;
		/// удаление: SUCCESSFUL, INVALID_NAME;
		/// VOID</returns>
		public virtual OperationReport LoadStoredProcedureParameters( )
		{
			// Загрузка параметров хранимой процедуры в зависимости от её типа
			switch ( this.m_Group.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					return m_Group.LoadInsertStoredProcedureParameters
						( this.m_NameTextBox.Text, this.m_ProductionTypeNameComboBox.Text,
						this.m_ActivityTypeNameComboBox.Text );

				// Обновление
				case StoredProcedureAction.UPDATE :
					return m_Group.LoadUpdateStoredProcedureParameters
						( this.m_OldNameComboBox.Text, this.m_NameTextBox.Text,
						this.m_ProductionTypeNameComboBox.Text,
						this.m_ActivityTypeNameComboBox.Text );

				// Удаление
				case StoredProcedureAction.DELETE :
					return m_Group.LoadDeleteStoredProcedureParameters
						( this.m_OldNameComboBox.Text );

				// Прочие непредусмотренные процедуры
				default:
					return new OperationReport( OperationResult.VOID,
						DataContainer.VOID_OPERATION_ERROR_MESSAGE );
			} // switch
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Вывод параметров хранимой процедуры
		/// </summary>
		public virtual void OutputStoredProcedureParameters( )
		{
			// Вывод значений параметров в поля в зависимости
			// от текущего действия хранимой процедуры сущности
			switch ( this.m_Group.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_NameTextBox.Text                = this.m_Group.Name;
					this.m_ProductionTypeNameComboBox.Text =
						this.m_Group.ProductionTypeName;
					this.m_ActivityTypeNameComboBox.Text   =
						this.m_Group.ActivityTypeName;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldNameComboBox.Text            = this.m_Group.OldName;
					this.m_NameTextBox.Text                = this.m_Group.Name;
					this.m_ProductionTypeNameComboBox.Text =
						this.m_Group.ProductionTypeName;
					this.m_ActivityTypeNameComboBox.Text   =
						this.m_Group.ActivityTypeName;
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldNameComboBox.Text = this.m_Group.Name;
					return;

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
		} // OutputStoredProcedureParameters

		/// <summary>
		/// Выделение неверного параметра
		/// </summary>
		/// <param name="parOperationReport">Отчёт операции</param>
		public virtual void MarkInvalidParameter
			( OperationReport parOperationReport )
		{
			// Выделение поля неверного параметра в зависимости
			// от текущего действия хранимой процедуры сущности
			switch ( this.m_Group.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверное название
						case OperationResult.INVALID_NAME :
							this.m_ErrorProvider.SetError( this.m_NameTextBox,
								parOperationReport.Message );
							return;

						// Неверное название типа роизводительности
						case OperationResult.INVALID_PRODUCTION_TYPE_NAME :
							this.m_ErrorProvider.SetError
								( this.m_ProductionTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название типа активности
						case OperationResult.INVALID_ACTIVITY_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_ActivityTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Прочие ошибки
						default:
							this.m_ErrorProvider.SetError( this.m_ExecuteButton,
								parOperationReport.Message );
							return;
					} // switch

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверное прежнее название
						case OperationResult.INVALID_OLD_NAME :
							this.m_ErrorProvider.SetError( this.m_OldNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название
						case OperationResult.INVALID_NAME :
							this.m_ErrorProvider.SetError( this.m_NameTextBox,
								parOperationReport.Message );
							return;

						// Неверное название типа роизводительности
						case OperationResult.INVALID_PRODUCTION_TYPE_NAME :
							this.m_ErrorProvider.SetError
								( this.m_ProductionTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название типа активности
						case OperationResult.INVALID_ACTIVITY_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_ActivityTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Прочие ошибки
						default:
							this.m_ErrorProvider.SetError( this.m_ExecuteButton,
								parOperationReport.Message );
							return;
					} // switch

				// Удаление
				case StoredProcedureAction.DELETE :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверное название
						case OperationResult.INVALID_NAME :
							this.m_ErrorProvider.SetError( this.m_OldNameComboBox,
								parOperationReport.Message );
							return;

						// Прочие ошибки
						default:
							this.m_ErrorProvider.SetError( this.m_ExecuteButton,
								parOperationReport.Message );
							return;
					} // switch

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
		} // MarkInvalidParameter
		#endregion Методы обработки данных

		#region Конкретные методы редактирования
		/// <summary>
		/// Выполнение хранимой процедуры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void m_ExecuteButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			this.Cursor = Cursors.WaitCursor;
			// Очистка предупреждающих пометок полей
			this.m_ErrorProvider.Clear( );
			// Отчёт об операции загрузки параметров хранимой процедуры
			// в зависимости от её типа
			OperationReport locOperationReport =
				this.LoadStoredProcedureParameters( );

			// Если предварительная операция загрузки параметров не удачна
			if ( locOperationReport.Result != OperationResult.SUCCESSFUL )
			{
				this.Cursor = Cursors.Default;
				// Выделение неверного параметра
				this.MarkInvalidParameter( locOperationReport );
				return;
			} // if

			// Выполнение хранимой процедуры с использованием сообщений об ошибках
			this.m_Group.ExecuteStoredProcedure( ref this.m_DataSet, true );
			// Вывод параметров хранимой процедуры
			this.OutputStoredProcedureParameters( );
			this.Cursor = Cursors.Default;

			// Если операция не выполнена, то выдаётся сообщение об ошибке
			if ( DataContainer.Instance( ).ErrorCodeParameter.Value !=
					DBNull.Value && ( int ) DataContainer.Instance( ).
					ErrorCodeParameter.Value != 0 )
				new MessageForm( ( string ) DataContainer.Instance( ).
					ShortErrorMessageParameter.Value, ( string ) DataContainer.
					Instance( ).SystemErrorMessageParameter.Value ).ShowDialog( );
			// Иначе инициализируется событие выполнения редактирования
			else
				if ( this.GroupEditingIsExecuted != null )
				{
					// Аргументы события выполнения редактирования группы
					EditGroupEventArgs locEditGroupEventArgs = new EditGroupEventArgs
						( this.m_Group.CurrentAction, this.m_Group.Name );
					// Генерирование собятия выполнения редактирования группы
					this.GroupEditingIsExecuted( this, locEditGroupEventArgs );
				} // if
			return;
		}// m_ExecuteButton_Click
		#endregion Конкретные методы редактирования
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание формы редактирования группы
		/// в заданном режиме редактирования без инизиализации параметров
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public EditGroupForm( StoredProcedureAction parAction )
		{
			InitializeComponent( );
			// Инициализация формы редактирования группы
			this.Init( parAction );
		} // EditGroupForm

		/// <summary>
		/// Создание формы редактирования группы
		/// в заданном режиме добавления с инизиализацией параметров
		/// </summary>
		/// <param name="parName">Название</param>
		/// <param name="parProductionTypeName">
		/// Название типа производственности</param>
		/// <param name="parActivityTypeName">Название типа активности</param>
		public EditGroupForm
		(
			string parName,
			string parProductionTypeName,
			string parActivityTypeName
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования группы
			this.Init( StoredProcedureAction.INSERT );
			// Инициализация параметров
			this.m_NameTextBox.Text                = parName;
			this.m_ProductionTypeNameComboBox.Text = parProductionTypeName;
			this.m_ActivityTypeNameComboBox.Text   = parActivityTypeName;
		} // EditGroupForm

		/// <summary>
		/// Создание формы редактирования группы
		/// в заданном режиме обновления с инизиализацией параметров
		/// </summary>
		/// <param name="parOldName">Старое название</param>
		/// <param name="parName">Название</param>
		/// <param name="parProductionTypeName">
		/// Название типа производственности</param>
		/// <param name="parActivityTypeName">Название типа активности</param>
		public EditGroupForm
		(
			string parOldName,
			string parName,
			string parProductionTypeName,
			string parActivityTypeName
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования группы
			this.Init( StoredProcedureAction.UPDATE );
			// Инициализация параметров
			this.m_OldNameComboBox.Text            = parOldName;
			this.m_NameTextBox.Text                = parName;
			this.m_ProductionTypeNameComboBox.Text = parProductionTypeName;
			this.m_ActivityTypeNameComboBox.Text   = parActivityTypeName;
		} // EditGroupForm

		/// <summary>
		/// Создание формы редактирования группы
		/// в заданном режиме удаления с инизиализацией параметров
		/// </summary>
		/// <param name="parName">Название</param>
		public EditGroupForm( string parName )
		{
			InitializeComponent( );
			// Инициализация формы редактирования группы
			this.Init( StoredProcedureAction.DELETE );
			// Инициализация параметров
			this.m_OldNameComboBox.Text = parName;
		} // EditGroupForm
		#endregion Конструкторы
	} // EditGroupForm
} // MainFacilitiesUseAnalysisClient