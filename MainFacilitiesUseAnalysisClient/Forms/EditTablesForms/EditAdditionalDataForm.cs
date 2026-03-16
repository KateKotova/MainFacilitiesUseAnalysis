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
	/// Форма редактирования дополнительных данных
	/// </summary>
	public partial class EditAdditionalDataForm : Form, IEditEssenceForm
	{
		#region Поля
		/// <summary>
		/// Сущность дополнительных данных
		/// </summary>
		protected AdditionalData m_AdditionalData;
		/// <summary>
		/// Делегат события выполнения редактирования дополнительных данных
		/// </summary>
		/// <param name="sender">Источник</param>
		/// <param name="e">Параметры</param>
		public delegate void EditAdditionalDataEventHandler
		(
			object                      sender,
			EditAdditionalDataEventArgs e
		);
		/// <summary>
		/// Событие выполнения редактирования дополнительных данных
		/// </summary>
		public event EditAdditionalDataEventHandler
			AdditionalDataEditingIsExecuted;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Инициализация формы редактирования дополнительных данных
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public virtual void Init( StoredProcedureAction parAction )
		{
			// Создание дополнительных данных
			// c заданными действием хранимой процедуры
			// и названиями таблиц сущностей
			this.m_AdditionalData = new AdditionalData( parAction,
				ref this.m_DataSet, this.m_DataSet.AdditionalData.TableName );

			// Заголовок формы - заголовок сущности
			this.Text                 = AdditionalData.ESSENCE_CAPTION;
			// Надпись на кнопке выполнения
			this.m_ExecuteButton.Text = this.m_AdditionalData.CurrentActionCaption;

			// Сжатие областей параметров, нездействованных
			// в заданном виде операции, сокрытие их компонентов
			// и изменение размеров формы
			switch ( parAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Сокрытие элементов незадействованных параметов
					this.m_OldYearLabel.Visible   = false;
					this.m_OldYearTextBox.Visible = false;
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
					this.m_YearLabel.Visible                                 = false;
					this.m_YearTextBox.Visible                               = false;
					this.m_ProductionOutputAmountLabel.Visible               = false;
					this.m_ProductionOutputAmountTextBox.Visible             = false;
					this.m_MarketedProductionAmountLabel.Visible             = false;
					this.m_MarketedProductionAmountTextBox.Visible           = false;
					this.m_ProductionPrimeCostLabel.Visible                  = false;
					this.m_ProductionPrimeCostTextBox.Visible                = false;
					this.m_TotalReceiptsLabel.Visible                        = false;
					this.m_TotalReceiptsTextBox.Visible                      = false;
					this.m_ActingEquipmentAnnualAverageAmountLabel.Visible   = false;
					this.m_ActingEquipmentAnnualAverageAmountTextBox.Visible = false;
					this.m_EquipmentUnitPerfectedHoursLabel.Visible          = false;
					this.m_EquipmentUnitPerfectedHoursTextBox.Visible        = false;
					this.m_EquipmentUnitPerfectedDaysLabel.Visible           = false;
					this.m_EquipmentUnitPerfectedDaysTextBox.Visible         = false;
					this.m_EquipmentUnitPerfectedChangesLabel.Visible        = false;
					this.m_EquipmentUnitPerfectedChangesTextBox.Visible      = false;

					// Изменение высоты формы
					float locFormHeightChange       = 0;
					// Индекс начальной из сжимаемых по порядку строк таблицы-контейнера
					int locStartCompressedRowIndex  = 3;
					// Индекс последней из сжимаемых по порядку строк таблицы-контейнера
					int locFinishCompressedRowIndex = 20;

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
		/// Загрузка формы редактирования дополнительных данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditAdditionalDataForm_Load
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
		} // EditAdditionalDataForm_Load

		/// <summary>
		/// Завершение работы с формой редактирования дополнительных данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void EditAdditionalDataForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			// DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // EditAdditionalDataForm_FormClosing
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
			switch ( this.m_AdditionalData.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_YearTextBox.Clear( );
					this.m_ProductionOutputAmountTextBox.Clear( );
					this.m_MarketedProductionAmountTextBox.Clear( );
					this.m_ProductionPrimeCostTextBox.Clear( );
					this.m_TotalReceiptsTextBox.Clear( );
					this.m_ActingEquipmentAnnualAverageAmountTextBox.Clear( );
					this.m_EquipmentUnitPerfectedHoursTextBox.Clear( );
					this.m_EquipmentUnitPerfectedDaysTextBox.Clear( );
					this.m_EquipmentUnitPerfectedChangesTextBox.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldYearTextBox.Clear( );
					this.m_YearTextBox.Clear( );
					this.m_ProductionOutputAmountTextBox.Clear( );
					this.m_MarketedProductionAmountTextBox.Clear( );
					this.m_ProductionPrimeCostTextBox.Clear( );
					this.m_TotalReceiptsTextBox.Clear( );
					this.m_ActingEquipmentAnnualAverageAmountTextBox.Clear( );
					this.m_EquipmentUnitPerfectedHoursTextBox.Clear( );
					this.m_EquipmentUnitPerfectedDaysTextBox.Clear( );
					this.m_EquipmentUnitPerfectedChangesTextBox.Clear( );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldYearTextBox.Clear( );
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
		/// добавление: SUCCESSFUL, INVALID_YEAR,
		/// INVALID_PRODUCTION_OUTPUT_AMOUNT, INVALID_MARKETED_PRODUCTION_AMOUNT,
		/// INVALID_PRODUCTION_PRIME_COST, INVALID_TOTAL_RECEIPTS,
		/// INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES;
		/// обновление: SUCCESSFUL, INVALID_OLD_YEAR, INVALID_YEAR,
		/// INVALID_PRODUCTION_OUTPUT_AMOUNT, INVALID_MARKETED_PRODUCTION_AMOUNT,
		/// INVALID_PRODUCTION_PRIME_COST, INVALID_TOTAL_RECEIPTS,
		/// INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES;
		/// удаление: SUCCESSFUL, INVALID_YEAR;
		/// VOID</returns>
		public virtual OperationReport LoadStoredProcedureParameters( )
		{
			// Загрузка параметров хранимой процедуры в зависимости от её типа
			switch ( this.m_AdditionalData.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					return m_AdditionalData.LoadInsertStoredProcedureParameters
						( this.m_YearTextBox.Text,
						this.m_ProductionOutputAmountTextBox.Text,
						this.m_MarketedProductionAmountTextBox.Text,
						this.m_ProductionPrimeCostTextBox.Text,
						this.m_TotalReceiptsTextBox.Text,
						this.m_ActingEquipmentAnnualAverageAmountTextBox.Text,
						this.m_EquipmentUnitPerfectedHoursTextBox.Text,
						this.m_EquipmentUnitPerfectedDaysTextBox.Text,
						this.m_EquipmentUnitPerfectedChangesTextBox.Text );

				// Обновление
				case StoredProcedureAction.UPDATE :
					return m_AdditionalData.LoadUpdateStoredProcedureParameters
						( this.m_OldYearTextBox.Text, this.m_YearTextBox.Text,
						this.m_ProductionOutputAmountTextBox.Text,
						this.m_MarketedProductionAmountTextBox.Text,
						this.m_ProductionPrimeCostTextBox.Text,
						this.m_TotalReceiptsTextBox.Text,
						this.m_ActingEquipmentAnnualAverageAmountTextBox.Text,
						this.m_EquipmentUnitPerfectedHoursTextBox.Text,
						this.m_EquipmentUnitPerfectedDaysTextBox.Text,
						this.m_EquipmentUnitPerfectedChangesTextBox.Text );

				// Удаление
				case StoredProcedureAction.DELETE :
					return m_AdditionalData.LoadDeleteStoredProcedureParameters
						( this.m_OldYearTextBox.Text );

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
			switch ( this.m_AdditionalData.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_YearTextBox.Text = this.m_AdditionalData.Year;
					this.m_ProductionOutputAmountTextBox.Text             =
						this.m_AdditionalData.ProductionOutputAmount;
					this.m_MarketedProductionAmountTextBox.Text           =
						this.m_AdditionalData.MarketedProductionAmount;
					this.m_ProductionPrimeCostTextBox.Text                =
						this.m_AdditionalData.ProductionPrimeCost;
					this.m_TotalReceiptsTextBox.Text                      =
						this.m_AdditionalData.TotalReceipts;
					this.m_ActingEquipmentAnnualAverageAmountTextBox.Text =
						this.m_AdditionalData.ActingEquipmentAnnualAverageAmount;
					this.m_EquipmentUnitPerfectedHoursTextBox.Text        =
						this.m_AdditionalData.EquipmentUnitPerfectedHours;
					this.m_EquipmentUnitPerfectedDaysTextBox.Text         =
						this.m_AdditionalData.EquipmentUnitPerfectedDays;
					this.m_EquipmentUnitPerfectedChangesTextBox.Text      =
						this.m_AdditionalData.EquipmentUnitPerfectedChanges;
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_OldYearTextBox.Text = this.m_AdditionalData.OldYear;
					this.m_YearTextBox.Text    = this.m_AdditionalData.Year;
					this.m_ProductionOutputAmountTextBox.Text             =
						this.m_AdditionalData.ProductionOutputAmount;
					this.m_MarketedProductionAmountTextBox.Text           =
						this.m_AdditionalData.MarketedProductionAmount;
					this.m_ProductionPrimeCostTextBox.Text                =
						this.m_AdditionalData.ProductionPrimeCost;
					this.m_TotalReceiptsTextBox.Text                      =
						this.m_AdditionalData.TotalReceipts;
					this.m_ActingEquipmentAnnualAverageAmountTextBox.Text =
						this.m_AdditionalData.ActingEquipmentAnnualAverageAmount;
					this.m_EquipmentUnitPerfectedHoursTextBox.Text        =
						this.m_AdditionalData.EquipmentUnitPerfectedHours;
					this.m_EquipmentUnitPerfectedDaysTextBox.Text         =
						this.m_AdditionalData.EquipmentUnitPerfectedDays;
					this.m_EquipmentUnitPerfectedChangesTextBox.Text      =
						this.m_AdditionalData.EquipmentUnitPerfectedChanges;
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_OldYearTextBox.Text = this.m_AdditionalData.Year;
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
			switch ( this.m_AdditionalData.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Пометка поля параметра, на который указывает результат операции
					switch ( parOperationReport.Result )
					{
						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_YearTextBox,
								parOperationReport.Message );
							return;

						// Неверный объём выпуска продукции
						case OperationResult.INVALID_PRODUCTION_OUTPUT_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_ProductionOutputAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверный объём реализованной продукции
						case OperationResult.INVALID_MARKETED_PRODUCTION_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_MarketedProductionAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверная себестоимость продукции
						case OperationResult.INVALID_PRODUCTION_PRIME_COST :
							this.m_ErrorProvider.SetError
								( this.m_ProductionPrimeCostTextBox,
								parOperationReport.Message );
							return;

						// Неверная общая выручка
						case OperationResult.INVALID_TOTAL_RECEIPTS :
							this.m_ErrorProvider.SetError( this.m_TotalReceiptsTextBox,
								parOperationReport.Message );
							return;

						// Неверное среднегодовое количество действующего оборудования
						case OperationResult.
								INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_ActingEquipmentAnnualAverageAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество часов, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedHoursTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество дней, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedDaysTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество смен, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedChangesTextBox,
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
						// Неверный прежний год
						case OperationResult.INVALID_OLD_YEAR :
							this.m_ErrorProvider.SetError( this.m_OldYearTextBox,
								parOperationReport.Message );
							return;

						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_YearTextBox,
								parOperationReport.Message );
							return;

						// Неверный объём выпуска продукции
						case OperationResult.INVALID_PRODUCTION_OUTPUT_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_ProductionOutputAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверный объём реализованной продукции
						case OperationResult.INVALID_MARKETED_PRODUCTION_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_MarketedProductionAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверная себестоимость продукции
						case OperationResult.INVALID_PRODUCTION_PRIME_COST :
							this.m_ErrorProvider.SetError
								( this.m_ProductionPrimeCostTextBox,
								parOperationReport.Message );
							return;

						// Неверная общая выручка
						case OperationResult.INVALID_TOTAL_RECEIPTS :
							this.m_ErrorProvider.SetError( this.m_TotalReceiptsTextBox,
								parOperationReport.Message );
							return;

						// Неверное среднегодовое количество действующего оборудования
						case OperationResult.
								INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT :
							this.m_ErrorProvider.SetError
								( this.m_ActingEquipmentAnnualAverageAmountTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество часов, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedHoursTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество дней, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedDaysTextBox,
								parOperationReport.Message );
							return;

						// Неверное количество смен, отработанных единицей оборудования
						case OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES :
							this.m_ErrorProvider.SetError
								( this.m_EquipmentUnitPerfectedChangesTextBox,
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
						// Неверный год
						case OperationResult.INVALID_YEAR :
							this.m_ErrorProvider.SetError( this.m_OldYearTextBox,
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
			this.m_AdditionalData.ExecuteStoredProcedure
				( ref this.m_DataSet, true );
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
				if ( this.AdditionalDataEditingIsExecuted != null )
				{
					// Аргументы события выполнения редактирования дополнительных данных
					EditAdditionalDataEventArgs locEditAdditionalDataEventArgs =
						new EditAdditionalDataEventArgs
						( this.m_AdditionalData.CurrentAction,
						this.m_AdditionalData.Year );
					// Генерирование собятия выполнения редактирования
					// дополнительных данны
					this.AdditionalDataEditingIsExecuted
						( this, locEditAdditionalDataEventArgs );
				} // if
			return;
		}// m_ExecuteButton_Click
		#endregion Конкретные методы редактирования
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание формы редактирования дополнительных данных
		/// в заданном режиме редактирования без инизиализации параметров
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		public EditAdditionalDataForm( StoredProcedureAction parAction )
		{
			InitializeComponent( );
			// Инициализация формы редактирования дополнительных данных
			this.Init( parAction );
		} // EditAdditionalDataForm

		/// <summary>
		/// Создание формы редактирования дополнительных данных
		/// в заданном режиме добавления с инизиализацией параметров
		/// </summary>
		/// <param name="parYear">Год</param>
		/// <param name="parProductionOutputAmount">
		/// Объём выпуска продукции</param>
		/// <param name="parMarketedProductionAmount">
		/// Объём реализованной продукции</param>
		/// <param name="parProductionPrimeCost">
		/// Себестоимость продукции</param>
		/// <param name="parTotalReceipts">Общая выручка</param>
		/// <param name="parActingEquipmentAnnualAverageAmount">
		/// Среднегодовое количество действующего оборудования</param>
		/// <param name="parEquipmentUnitPerfectedHours">
		/// Количество часов, отработанных единицей оборудования</param>
		/// <param name="parEquipmentUnitPerfectedDays">
		/// Количество дней, отработанных единицей оборудования</param>
		/// <param name="parEquipmentUnitPerfectedChanges">
		/// Количество смен, отработанных единицей оборудования</param>
		public EditAdditionalDataForm
		(
			string parYear,
			string parProductionOutputAmount,
			string parMarketedProductionAmount,
			string parProductionPrimeCost,
			string parTotalReceipts,
			string parActingEquipmentAnnualAverageAmount,
			string parEquipmentUnitPerfectedHours,
			string parEquipmentUnitPerfectedDays,
			string parEquipmentUnitPerfectedChanges
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования дополнительных данных
			this.Init( StoredProcedureAction.INSERT );
			// Инициализация параметров
			this.m_YearTextBox.Text                   = parYear;
			this.m_ProductionOutputAmountTextBox.Text = parProductionOutputAmount;
			this.m_MarketedProductionAmountTextBox.Text           =
				parMarketedProductionAmount;
			this.m_ProductionPrimeCostTextBox.Text    = parProductionPrimeCost;
			this.m_TotalReceiptsTextBox.Text          = parTotalReceipts;
			this.m_ActingEquipmentAnnualAverageAmountTextBox.Text =
				parActingEquipmentAnnualAverageAmount;
			this.m_EquipmentUnitPerfectedHoursTextBox.Text        =
				parEquipmentUnitPerfectedHours;
			this.m_EquipmentUnitPerfectedDaysTextBox.Text         =
				parEquipmentUnitPerfectedDays;
			this.m_EquipmentUnitPerfectedChangesTextBox.Text      =
				parEquipmentUnitPerfectedChanges;
		} // EditAdditionalDataForm

		/// <summary>
		/// Создание формы редактирования дополнительных данных
		/// в заданном режиме обновления с инизиализацией параметров
		/// </summary>
		/// <param name="parOldYear">Старый год</param>
		/// <param name="parYear">Год</param>
		/// <param name="parProductionOutputAmount">
		/// Объём выпуска продукции</param>
		/// <param name="parMarketedProductionAmount">
		/// Объём реализованной продукции</param>
		/// <param name="parProductionPrimeCost">
		/// Себестоимость продукции</param>
		/// <param name="parTotalReceipts">Общая выручка</param>
		/// <param name="parActingEquipmentAnnualAverageAmount">
		/// Среднегодовое количество действующего оборудования</param>
		/// <param name="parEquipmentUnitPerfectedHours">
		/// Количество часов, отработанных единицей оборудования</param>
		/// <param name="parEquipmentUnitPerfectedDays">
		/// Количество дней, отработанных единицей оборудования</param>
		/// <param name="parEquipmentUnitPerfectedChanges">
		/// Количество смен, отработанных единицей оборудования</param>
		public EditAdditionalDataForm
		(
			string parOldYear,
			string parYear,
			string parProductionOutputAmount,
			string parMarketedProductionAmount,
			string parProductionPrimeCost,
			string parTotalReceipts,
			string parActingEquipmentAnnualAverageAmount,
			string parEquipmentUnitPerfectedHours,
			string parEquipmentUnitPerfectedDays,
			string parEquipmentUnitPerfectedChanges
		)
		{
			InitializeComponent( );
			// Инициализация формы редактирования дополнительных данных
			this.Init( StoredProcedureAction.UPDATE );
			// Инициализация параметров
			this.m_OldYearTextBox.Text                = parOldYear;
			this.m_YearTextBox.Text                   = parYear;
			this.m_ProductionOutputAmountTextBox.Text = parProductionOutputAmount;
			this.m_MarketedProductionAmountTextBox.Text           =
				parMarketedProductionAmount;
			this.m_ProductionPrimeCostTextBox.Text    = parProductionPrimeCost;
			this.m_TotalReceiptsTextBox.Text          = parTotalReceipts;
			this.m_ActingEquipmentAnnualAverageAmountTextBox.Text =
				parActingEquipmentAnnualAverageAmount;
			this.m_EquipmentUnitPerfectedHoursTextBox.Text        =
				parEquipmentUnitPerfectedHours;
			this.m_EquipmentUnitPerfectedDaysTextBox.Text         =
				parEquipmentUnitPerfectedDays;
			this.m_EquipmentUnitPerfectedChangesTextBox.Text      =
				parEquipmentUnitPerfectedChanges;
		} // EditAdditionalDataForm

		/// <summary>
		/// Создание формы редактирования дополнительных данных
		/// в заданном режиме удаления с инизиализацией параметров
		/// </summary>
		/// <param name="parYear">Год</param>
		public EditAdditionalDataForm( string parYear )
		{
			InitializeComponent( );
			// Инициализация формы редактирования дополнительных данных
			this.Init( StoredProcedureAction.DELETE );
			// Инициализация параметров
			this.m_OldYearTextBox.Text = parYear;
		} // EditAdditionalDataForm
		#endregion Конструкторы
	} // EditAdditionalDataForm
} // MainFacilitiesUseAnalysisClient