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
	/// Форма редактирования основного средства
	/// </summary>
	public partial class EditMainFacilityForm : Form, IEditEssenceForm
	{
		#region Поля
		/// <summary>
		/// Сущность основного средства
		/// </summary>
		protected MainFacility m_MainFacility;
		/// <summary>
		/// Делегат события выполнения редактирования основного средства
		/// </summary>
		/// <param name="sender">Источник</param>
		/// <param name="e">Параметры</param>
		public delegate void EditMainFacilityEventHandler
		(
			object                    sender,
			EditMainFacilityEventArgs e
		);
		/// <summary>
		/// Событие выполнения редактирования основного средства
		/// </summary>
		public event EditMainFacilityEventHandler MainFacilityEditingIsExecuted;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Инициализация формы редактирования основного средства
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public virtual void Init( StoredProcedureAction parAction )
		{
			// Создание основного средства c заданными действием хранимой процедуры
			// и названиями таблиц сущностей
			this.m_MainFacility = new MainFacility( parAction, ref this.m_DataSet,
				this.m_DataSet.MainFacilities.TableName,
				this.m_DataSet.Groups.TableName );

			// Заголовок формы - заголовок сущности
			this.Text                 = MainFacility.ESSENCE_CAPTION;
			// Надпись на кнопке выполнения
			this.m_ExecuteButton.Text = this.m_MainFacility.CurrentActionCaption;

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
					this.m_InventoryNumberLabel.Visible   = false;
					this.m_InventoryNumberTextBox.Visible = false;
					this.m_NameLabel.Visible              = false;
					this.m_NameTextBox.Visible            = false;
					this.m_GroupNameLabel.Visible         = false;
					this.m_GroupNameComboBox.Visible      = false;

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
		/// Загрузка формы редактирования основного средства
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditMainFacilityForm_Load
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
		} // EditMainFacilityForm_Load

		/// <summary>
		/// Завершение работы с формой редактирования основного средства
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditMainFacilityForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			// DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // EditMainFacilityForm_FormClosing
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
			switch ( this.m_MainFacility.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_InventoryNumberTextBox.Clear( );
					this.m_NameTextBox.Clear( );
					this.m_GroupNameComboBox.Text = string.Empty;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_InventoryNumberTextBox.Clear( );
					this.m_OldNameComboBox.Text   = string.Empty;
					this.m_NameTextBox.Clear( );
					this.m_GroupNameComboBox.Text = string.Empty;
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
		/// добавление: SUCCESSFUL, INVALID_INVENTORY_NUMBER, INVALID_NAME,
		/// INVALID_GROUP_NAME;
		/// обновление: SUCCESSFUL, INVALID_OLD_NAME, INVALID_INVENTORY_NUMBER,
		/// INVALID_NAME, INVALID_GROUP_NAME;
		/// удаление: SUCCESSFUL, INVALID_NAME;
		/// VOID</returns>
		public virtual OperationReport LoadStoredProcedureParameters( )
		{
			// Загрузка параметров хранимой процедуры в зависимости от её типа
			switch ( this.m_MainFacility.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					return m_MainFacility.LoadInsertStoredProcedureParameters
						( this.m_InventoryNumberTextBox.Text, this.m_NameTextBox.Text,
						this.m_GroupNameComboBox.Text );

				// Обновление
				case StoredProcedureAction.UPDATE :
					return m_MainFacility.LoadUpdateStoredProcedureParameters
						( this.m_OldNameComboBox.Text, this.m_InventoryNumberTextBox.Text,
						this.m_NameTextBox.Text, this.m_GroupNameComboBox.Text );

				// Удаление
				case StoredProcedureAction.DELETE :
					return m_MainFacility.LoadDeleteStoredProcedureParameters
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
			switch ( this.m_MainFacility.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_InventoryNumberTextBox.Text =
						this.m_MainFacility.InventoryNumber;
					this.m_NameTextBox.Text            = this.m_MainFacility.Name;
					this.m_GroupNameComboBox.Text      = this.m_MainFacility.GroupName;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldNameComboBox.Text        = this.m_MainFacility.OldName;
					this.m_InventoryNumberTextBox.Text =
						this.m_MainFacility.InventoryNumber;
					this.m_NameTextBox.Text            = this.m_MainFacility.Name;
					this.m_GroupNameComboBox.Text      = this.m_MainFacility.GroupName;
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldNameComboBox.Text = this.m_MainFacility.Name;
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
			switch ( this.m_MainFacility.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверный инвентарный номер
						case OperationResult.INVALID_INVENTORY_NUMBER :
							this.m_ErrorProvider.SetError( this.m_InventoryNumberTextBox,
								parOperationReport.Message );
							return;

						// Неверное название
						case OperationResult.INVALID_NAME :
							this.m_ErrorProvider.SetError( this.m_NameTextBox,
								parOperationReport.Message );
							return;

						// Неверное название группы
						case OperationResult.INVALID_GROUP_NAME :
							this.m_ErrorProvider.SetError( this.m_GroupNameComboBox,
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

						// Неверный инвентарный номер
						case OperationResult.INVALID_INVENTORY_NUMBER :
							this.m_ErrorProvider.SetError( this.m_InventoryNumberTextBox,
								parOperationReport.Message );
							return;

						// Неверное название
						case OperationResult.INVALID_NAME :
							this.m_ErrorProvider.SetError( this.m_NameTextBox,
								parOperationReport.Message );
							return;

						// Неверное название группы
						case OperationResult.INVALID_GROUP_NAME :
							this.m_ErrorProvider.SetError( this.m_GroupNameComboBox,
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
			this.m_MainFacility.ExecuteStoredProcedure( ref this.m_DataSet, true );
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
				if ( this.MainFacilityEditingIsExecuted != null )
				{
					// Аргументы события выполнения редактирования основного средства
					EditMainFacilityEventArgs locEditMainFacilityEventArgs =
						new EditMainFacilityEventArgs( this.m_MainFacility.CurrentAction,
						this.m_MainFacility.Name );
					// Генерирование собятия выполнения редактирования
					// основного средства
					this.MainFacilityEditingIsExecuted
						( this, locEditMainFacilityEventArgs );
				} // if
			return;
		}// m_ExecuteButton_Click
		#endregion Конкретные методы редактирования
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание формы редактирования основного средства
		/// в заданном режиме редактирования без инизиализации параметров
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public EditMainFacilityForm( StoredProcedureAction parAction )
		{
			InitializeComponent( );
			// Инициализация формы редактирования основного средства
			this.Init( parAction );
		} // EditMainFacilityForm

		/// <summary>
		/// Создание формы редактирования основного средства
		/// в заданном режиме добавления с инизиализацией параметров
		/// </summary>
		/// <param name="parInventoryNumber">Инвентарный номер</param>
		/// <param name="parName">Название</param>
		/// <param name="parGroupName">Название группы</param>
		public EditMainFacilityForm
		(
			string parInventoryNumber,
			string parName,
			string parGroupName
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования основного средства
			this.Init( StoredProcedureAction.INSERT );
			// Инициализация параметров
			this.m_InventoryNumberTextBox.Text = parInventoryNumber;
			this.m_NameTextBox.Text            = parName;
			this.m_GroupNameComboBox.Text      = parGroupName;
		} // EditMainFacilityForm

		/// <summary>
		/// Создание формы редактирования основного средства
		/// в заданном режиме обновления с инизиализацией параметров
		/// </summary>
		/// <param name="parOldName">Старое название</param>
		/// <param name="parInventoryNumber">Инвентарный номер</param>
		/// <param name="parName">Название</param>
		/// <param name="parGroupName">Название группы</param>
		public EditMainFacilityForm
		(
			string parOldName,
			string parInventoryNumber,
			string parName,
			string parGroupName
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования основного средства
			this.Init( StoredProcedureAction.UPDATE );
			// Инициализация параметров
			this.m_OldNameComboBox.Text        = parOldName;
			this.m_InventoryNumberTextBox.Text = parInventoryNumber;
			this.m_NameTextBox.Text            = parName;
			this.m_GroupNameComboBox.Text      = parGroupName;
		} // EditMainFacilityForm

		/// <summary>
		/// Создание формы редактирования основного средства
		/// в заданном режиме удаления с инизиализацией параметров
		/// </summary>
		/// <param name="parName">Название</param>
		public EditMainFacilityForm( string parName )
		{
			InitializeComponent( );
			// Инициализация формы редактирования основного средства
			this.Init( StoredProcedureAction.DELETE );
			// Инициализация параметров
			this.m_OldNameComboBox.Text = parName;
		} // EditMainFacilityForm
		#endregion Конструкторы
	} // EditMainFacilityForm
} // MainFacilitiesUseAnalysisClient