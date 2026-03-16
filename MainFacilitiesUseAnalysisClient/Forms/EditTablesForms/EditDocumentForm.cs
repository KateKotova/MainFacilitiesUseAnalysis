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
	/// Форма редактирования документа
	/// </summary>
	public partial class EditDocumentForm : Form, IEditEssenceForm
	{
		#region Поля
		/// <summary>
		/// Сущность документа
		/// </summary>
		protected Document m_Document;
		/// <summary>
		/// Делегат события выполнения редактирования документа
		/// </summary>
		/// <param name="sender">Источник</param>
		/// <param name="e">Параметры</param>
		public delegate void EditDocumentEventHandler
		(
			object                sender,
			EditDocumentEventArgs e
		);
		/// <summary>
		/// Событие выполнения редактирования документа
		/// </summary>
		public event EditDocumentEventHandler DocumentEditingIsExecuted;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Инициализация формы редактирования документа
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public virtual void Init( StoredProcedureAction parAction )
		{
			// Создание документа c заданными действием хранимой процедуры
			// и названиями таблиц сущностей
			this.m_Document = new Document( parAction, ref this.m_DataSet,
				this.m_DataSet.Documents.TableName,
				this.m_DataSet.DocumentsTypes.TableName,
				this.m_DataSet.MainFacilities.TableName );

			// Заголовок формы - заголовок сущности
			this.Text                 = Document.ESSENCE_CAPTION;
			// Надпись на кнопке выполнения
			this.m_ExecuteButton.Text = this.m_Document.CurrentActionCaption;

			// Изменение высоты формы
			float locFormHeightChange       = 0;
			// Индекс начальной из сжимаемых по порядку строк таблицы-контейнера
			int locStartCompressedRowIndex  = 0;
			// Индекс последней из сжимаемых по порядку строк таблицы-контейнера
			int locFinishCompressedRowIndex = 0;

			// Сжатие областей параметров, нездействованных
			// в заданном виде операции, сокрытие их компонентов
			// и изменение размеров формы
			switch ( parAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Сокрытие элементов незадействованных параметов
					this.m_OldTypeNameLabel.Visible            = false;
					this.m_OldTypeNameComboBox.Visible         = false;
					this.m_OldMainFacilityNameLabel.Visible    = false;
					this.m_OldMainFacilityNameComboBox.Visible = false;
					this.m_OldDateLabel.Visible                = false;
					this.m_OldDateDateTimePicker.Visible       = false;

					// Индекс начальной из сжимаемых по порядку строк таблицы-контейнера
					locStartCompressedRowIndex  = 1;
					// Индекс последней из сжимаемых по порядку строк таблицы-контейнера
					locFinishCompressedRowIndex = 6;

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

				// Обновление
				case StoredProcedureAction.UPDATE :
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Сокрытие элементов незадействованных параметов
					this.m_TypeNameLabel.Visible            = false;
					this.m_TypeNameComboBox.Visible         = false;
					this.m_MainFacilityNameLabel.Visible    = false;
					this.m_MainFacilityNameComboBox.Visible = false;
					this.m_DateLabel.Visible                = false;
					this.m_DateDateTimePicker.Visible       = false;
					this.m_CostLabel.Visible                = false;
					this.m_CostTextBox.Visible              = false;

					// Индекс начальной из сжимаемых по порядку строк таблицы-контейнера
					locStartCompressedRowIndex  = 7;
					// Индекс последней из сжимаемых по порядку строк таблицы-контейнера
					locFinishCompressedRowIndex = 14;

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
		/// Загрузка формы редактирования документа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditDocumentForm_Load
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
		} // EditDocumentForm_Load

		/// <summary>
		/// Завершение работы с формой редактирования документа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditDocumentForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			// DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // EditDocumentForm_FormClosing
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
			switch ( this.m_Document.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_TypeNameComboBox.Text         = string.Empty;
					this.m_MainFacilityNameComboBox.Text = string.Empty;
					this.m_DateDateTimePicker.Text       = string.Empty;
					this.m_CostTextBox.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldTypeNameComboBox.Text         = string.Empty;
					this.m_OldMainFacilityNameComboBox.Text = string.Empty;
					this.m_OldDateDateTimePicker.Text       = string.Empty;
					this.m_TypeNameComboBox.Text            = string.Empty;
					this.m_MainFacilityNameComboBox.Text    = string.Empty;
					this.m_DateDateTimePicker.Text          = string.Empty;
					this.m_CostTextBox.Clear( );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldTypeNameComboBox.Text         = string.Empty;
					this.m_OldMainFacilityNameComboBox.Text = string.Empty;
					this.m_OldDateDateTimePicker.Text       = string.Empty;
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
		/// добавление: SUCCESSFUL, INVALID_TYPE_NAME, INVALID_MAIN_FACILITY_NAME,
		/// INVALID_YEAR, INVALID_MONTH, INVALID_DAY, INVALID_COST;
		/// обновление: SUCCESSFUL, INVALID_OLD_TYPE_NAME,
		/// INVALID_OLD_MAIN_FACILITY_NAME, INVALID_OLD_YEAR, INVALID_OLD_MONTH,
		/// INVALID_OLD_DAY, INVALID_TYPE_NAME, INVALID_MAIN_FACILITY_NAME,
		/// INVALID_YEAR, INVALID_MONTH, INVALID_DAY, INVALID_COST;
		/// удаление: SUCCESSFUL, INVALID_TYPE_NAME, INVALID_MAIN_FACILITY_NAME,
		/// INVALID_YEAR, INVALID_MONTH, INVALID_DAY;
		/// VOID</returns>
		public virtual OperationReport LoadStoredProcedureParameters( )
		{
			// Загрузка параметров хранимой процедуры в зависимости от её типа
			switch ( this.m_Document.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					return m_Document.LoadInsertStoredProcedureParameters
						( this.m_TypeNameComboBox.Text,
						this.m_MainFacilityNameComboBox.Text,
						this.m_DateDateTimePicker.Value, this.m_CostTextBox.Text );

				// Обновление
				case StoredProcedureAction.UPDATE :
					return m_Document.LoadUpdateStoredProcedureParameters
						( this.m_OldTypeNameComboBox.Text,
						this.m_OldMainFacilityNameComboBox.Text,
						this.m_OldDateDateTimePicker.Value, this.m_TypeNameComboBox.Text,
						this.m_MainFacilityNameComboBox.Text,
						this.m_DateDateTimePicker.Value, this.m_CostTextBox.Text );

				// Удаление
				case StoredProcedureAction.DELETE :
					return m_Document.LoadDeleteStoredProcedureParameters
						( this.m_OldTypeNameComboBox.Text,
						this.m_OldMainFacilityNameComboBox.Text,
						this.m_OldDateDateTimePicker.Value );

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
			switch ( this.m_Document.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_TypeNameComboBox.Text         = this.m_Document.TypeName;
					this.m_MainFacilityNameComboBox.Text =
						this.m_Document.MainFacilityName;
					this.m_DateDateTimePicker.Value      = this.m_Document.Date;
					this.m_CostTextBox.Text              = this.m_Document.Cost;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldTypeNameComboBox.Text         =
						this.m_Document.OldTypeName;
					this.m_OldMainFacilityNameComboBox.Text =
						this.m_Document.OldMainFacilityName;
					this.m_OldDateDateTimePicker.Value      = this.m_Document.OldDate;
					this.m_TypeNameComboBox.Text            = this.m_Document.TypeName;
					this.m_MainFacilityNameComboBox.Text    =
						this.m_Document.MainFacilityName;
					this.m_DateDateTimePicker.Value         = this.m_Document.Date;
					this.m_CostTextBox.Text                 = this.m_Document.Cost;
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldTypeNameComboBox.Text         = this.m_Document.TypeName;
					this.m_OldMainFacilityNameComboBox.Text =
						this.m_Document.MainFacilityName;
					this.m_OldDateDateTimePicker.Value      = this.m_Document.Date;
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
			switch ( this.m_Document.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверное название типа
						case OperationResult.INVALID_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_TypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название основного средства
						case OperationResult.INVALID_MAIN_FACILITY_NAME :
							this.m_ErrorProvider.SetError( this.m_MainFacilityNameComboBox,
								parOperationReport.Message );
							return;

						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный месяц
						case OperationResult.INVALID_MONTH :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный день
						case OperationResult.INVALID_DAY :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверная стоимость
						case OperationResult.INVALID_COST :
							this.m_ErrorProvider.SetError( this.m_CostTextBox,
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
						// Неверное прежнее название типа
						case OperationResult.INVALID_OLD_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_OldTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное прежнее название основного средства
						case OperationResult.INVALID_OLD_MAIN_FACILITY_NAME :
							this.m_ErrorProvider.SetError
								( this.m_OldMainFacilityNameComboBox,
								parOperationReport.Message );
							return;

						// Неверный прежний год
						case OperationResult.INVALID_OLD_YEAR :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный прежний месяц
						case OperationResult.INVALID_OLD_MONTH :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный прежний день
						case OperationResult.INVALID_OLD_DAY :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверное название типа
						case OperationResult.INVALID_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_TypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название основного средства
						case OperationResult.INVALID_MAIN_FACILITY_NAME :
							this.m_ErrorProvider.SetError( this.m_MainFacilityNameComboBox,
								parOperationReport.Message );
							return;

						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный месяц
						case OperationResult.INVALID_MONTH :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный день
						case OperationResult.INVALID_DAY :
							this.m_ErrorProvider.SetError( this.m_DateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверная стоимость
						case OperationResult.INVALID_COST :
							this.m_ErrorProvider.SetError( this.m_CostTextBox,
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
						// Неверное название типа
						case OperationResult.INVALID_TYPE_NAME :
							this.m_ErrorProvider.SetError( this.m_OldTypeNameComboBox,
								parOperationReport.Message );
							return;

						// Неверное название основного средства
						case OperationResult.INVALID_MAIN_FACILITY_NAME :
							this.m_ErrorProvider.SetError
								( this.m_OldMainFacilityNameComboBox,
								parOperationReport.Message );
							return;

						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный месяц
						case OperationResult.INVALID_MONTH :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
								parOperationReport.Message );
							return;

						// Неверный день
						case OperationResult.INVALID_DAY :
							this.m_ErrorProvider.SetError( this.m_OldDateDateTimePicker,
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
			this.m_Document.ExecuteStoredProcedure( ref this.m_DataSet, true );
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
				if ( this.DocumentEditingIsExecuted != null )
				{
					// Аргументы события выполнения редактирования документа
					EditDocumentEventArgs locEditDocumentEventArgs =
						new EditDocumentEventArgs( this.m_Document.CurrentAction,
						this.m_Document.TypeName, this.m_Document.MainFacilityName,
						this.m_Document.Date.ToShortDateString( ) );
					// Генерирование собятия выполнения редактирования документа
					this.DocumentEditingIsExecuted( this, locEditDocumentEventArgs );
				} // if
			return;
		}// m_ExecuteButton_Click
		#endregion Конкретные методы редактирования
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание формы редактирования документа
		/// в заданном режиме редактирования без инизиализации параметров
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public EditDocumentForm( StoredProcedureAction parAction )
		{
			InitializeComponent( );
			// Инициализация формы редактирования документа
			this.Init( parAction );
		} // EditDocumentForm

		/// <summary>
		/// Создание формы редактирования документа
		/// в заданном режиме добавления с инизиализацией параметров
		/// </summary>
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		/// <param name="parCost">Стоимость</param>
		public EditDocumentForm
		(
			string parTypeName,
			string parMainFacilityName,
			string parDate,
			string parCost
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования документа
			this.Init( StoredProcedureAction.INSERT );
			// Инициализация параметров
			this.m_TypeNameComboBox.Text         = parTypeName;
			this.m_MainFacilityNameComboBox.Text = parMainFacilityName;
			this.m_DateDateTimePicker.Value      = Convert.ToDateTime( parDate );
			this.m_CostTextBox.Text              = parCost;
		} // EditDocumentForm

		/// <summary>
		/// Создание формы редактирования документа
		/// в заданном режиме обновления с инизиализацией параметров
		/// </summary>
		/// <param name="parOldTypeName">Старое название типа</param>
		/// <param name="parOldMainFacilityName">
		/// Старое название основного средства</param>
		/// <param name="parOldDate">Старая дата</param>
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		/// <param name="parCost">Стоимость</param>
		public EditDocumentForm
		(
			string parOldTypeName,
			string parOldMainFacilityName,
			string parOldDate,
			string parTypeName,
			string parMainFacilityName,
			string parDate,
			string parCost
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования документа
			this.Init( StoredProcedureAction.UPDATE );
			// Инициализация параметров
			this.m_OldTypeNameComboBox.Text         = parOldTypeName;
			this.m_OldMainFacilityNameComboBox.Text = parOldMainFacilityName;
			this.m_OldDateDateTimePicker.Value = Convert.ToDateTime( parOldDate );
			this.m_TypeNameComboBox.Text            = parTypeName;
			this.m_MainFacilityNameComboBox.Text    = parMainFacilityName;
			this.m_DateDateTimePicker.Value         = Convert.ToDateTime( parDate );
			this.m_CostTextBox.Text                 = parCost;
		} // EditDocumentForm

		/// <summary>
		/// Создание формы редактирования документа
		/// в заданном режиме удаления с инизиализацией параметров
		/// </summary>
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		public EditDocumentForm
		(
			string parTypeName,
			string parMainFacilityName,
			string parDate
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования документа
			this.Init( StoredProcedureAction.DELETE );
			// Инициализация параметров
			this.m_OldTypeNameComboBox.Text         = parTypeName;
			this.m_OldMainFacilityNameComboBox.Text = parMainFacilityName;
			this.m_OldDateDateTimePicker.Value      = Convert.ToDateTime( parDate );
		} // EditDocumentForm
		#endregion Конструкторы
	} // EditDocumentForm
} // MainFacilitiesUseAnalysisClient