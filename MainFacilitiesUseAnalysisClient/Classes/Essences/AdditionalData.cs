using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Дополнительные данные
	/// </summary>
	public class AdditionalData : Essence
	{
		#region Поля
		/// <summary>
		/// Заголовок сущности
		/// </summary>
		new public const string ESSENCE_CAPTION = "Дополнительные данные";
		/// <summary>
		/// Текщее действие хранимой процедуры
		/// </summary>
		new public readonly StoredProcedureAction CurrentAction;

		#region Названия хранимых процедур
		/// <summary>
		/// Название хранимой процедуры показа
		/// </summary>
		new public const string    SHOW_STORED_PROCEDURE_NAME   =
			"SP_ShowAdditionalData";

		/// <summary>
		/// Название хранимой процедуры добавления
		/// </summary>
		new protected const string INSERT_STORED_PROCEDURE_NAME =
			"SP_InsertAdditionalData";
		/// <summary>
		/// Название хранимой процедуры обновления
		/// </summary>
		new protected const string UPDATE_STORED_PROCEDURE_NAME =
			"SP_UpdateAdditionalData";
		/// <summary>
		/// Название хранимой процедуры удаления
		/// </summary>
		new protected const string DELETE_STORED_PROCEDURE_NAME =
			"SP_DeleteAdditionalData";
		#endregion Названия хранимых процедур

		#region Названия таблиц сущностей и адаптеры Sql-данных
		/// <summary>
		/// Название таблицы дополнительных данных
		/// </summary>
		public readonly string   AdditionalDataDataSetTableName;
		/// <summary>
		/// Название адаптера Sql-данных дополнительных данных
		/// </summary>
		protected SqlDataAdapter m_AdditionalDataSqlDataAdapter;
		#endregion Названия таблиц сущностей и адаптеры Sql-данных

		#region Параметры
		/// <summary>
		/// Год
		/// </summary>
		protected Parameter m_Year          = new Parameter( "@parYear" );
		/// <summary>
		/// Старый год
		/// </summary>
		protected Parameter m_OldYear       = new Parameter( "@parOldYear" );
		/// <summary>
		/// Объём выпуска продукции
		/// </summary>
		protected Parameter m_ProductionOutputAmount             = new Parameter
			( "@parProductionOutputAmount" );
		/// <summary>
		/// Объём реализованной продукции
		/// </summary>
		protected Parameter m_MarketedProductionAmount           = new Parameter
			( "@parMarketedProductionAmount" );
		/// <summary>
		/// Себестоимость продукции
		/// </summary>
		protected Parameter m_ProductionPrimeCost                = new Parameter
			( "@parProductionPrimeCost" );
		/// <summary>
		/// Общая выручка
		/// </summary>
		protected Parameter m_TotalReceipts                      = new Parameter
			( "@parTotalReceipts" );
		/// <summary>
		/// Среднегодовое количество действующего оборудования
		/// </summary>
		protected Parameter m_ActingEquipmentAnnualAverageAmount = new Parameter
			( "@parActingEquipmentAnnualAverageAmount" );
		/// <summary>
		/// Количество часов, отработанных единицей оборудования
		/// </summary>
		protected Parameter m_EquipmentUnitPerfectedHours        = new Parameter
			( "@parEquipmentUnitPerfectedHours" );
		/// <summary>
		/// Количество дней, отработанных единицей оборудования
		/// </summary>
		protected Parameter m_EquipmentUnitPerfectedDays         = new Parameter
			( "@parEquipmentUnitPerfectedDays" );
		/// <summary>
		/// Количество смен, отработанных единицей оборудования
		/// </summary>
		protected Parameter m_EquipmentUnitPerfectedChanges      = new Parameter
			( "@parEquipmentUnitPerfectedChanges" );
		#endregion Параметры
		#endregion Поля

		#region Методы
		#region Методы инициализации и очистки
		/// <summary>
		/// Заполнение адаптеров Sql-данных
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		public override void FillSqlDataAdapters
			( ref MainFacilitiesUseAnalysisDataSet parDataSet )
		{
			// Заполнение адаптера Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			if ( ( this.CurrentAction == StoredProcedureAction.SHOW )   ||
					( this.CurrentAction  == StoredProcedureAction.INSERT ) ||
					( this.CurrentAction  == StoredProcedureAction.UPDATE ) ||
					( this.CurrentAction  == StoredProcedureAction.DELETE ) )
				// Адаптер Sql-данных дополнительных данных
				this.m_AdditionalDataSqlDataAdapter.Fill( parDataSet,
					this.AdditionalDataDataSetTableName );
			} // switch

		/// <summary>
		/// Инициализация
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		public override void Init
			( ref MainFacilitiesUseAnalysisDataSet parDataSet )
		{
			// Заполнение адаптеров Sql-данных
			base.Init( ref parDataSet );
			// Направление параметров
			ParameterDirection locDirection = ParameterDirection.InputOutput;
			// Допустимость неопределённого значения параметров
			bool locIsNullable              = true;

			// Инициализация пареметров в зависимости
			// от текущего действия хранимой процедуры
			switch ( this.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_Year.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_ProductionOutputAmount.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_MarketedProductionAmount.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_ProductionPrimeCost.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_TotalReceipts.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_ActingEquipmentAnnualAverageAmount.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedHours.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedDays.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedChanges.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_Year.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_OldYear.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_ProductionOutputAmount.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_MarketedProductionAmount.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_ProductionPrimeCost.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_TotalReceipts.InitMoney
						( locDirection, locIsNullable, string.Empty );
					this.m_ActingEquipmentAnnualAverageAmount.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedHours.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedDays.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					this.m_EquipmentUnitPerfectedChanges.InitSmallInt
						( locDirection, locIsNullable, string.Empty );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_Year.InitSmallInt( locDirection, locIsNullable,
						string.Empty );
					return;

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
		} // Init

		/// <summary>
		/// Очистка
		/// </summary>
		public override void Clear( )
		{
			// Очистка параметров в зависимости
			// от текущего действия хранимой процедуры
			switch ( this.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					this.m_Year.Clear( );
					this.m_ProductionOutputAmount.Clear( );
					this.m_MarketedProductionAmount.Clear( );
					this.m_ProductionPrimeCost.Clear( );
					this.m_TotalReceipts.Clear( );
					this.m_ActingEquipmentAnnualAverageAmount.Clear( );
					this.m_EquipmentUnitPerfectedHours.Clear( );
					this.m_EquipmentUnitPerfectedDays.Clear( );
					this.m_EquipmentUnitPerfectedChanges.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_Year.Clear( );
					this.m_OldYear.Clear( );
					this.m_ProductionOutputAmount.Clear( );
					this.m_MarketedProductionAmount.Clear( );
					this.m_ProductionPrimeCost.Clear( );
					this.m_TotalReceipts.Clear( );
					this.m_ActingEquipmentAnnualAverageAmount.Clear( );
					this.m_EquipmentUnitPerfectedHours.Clear( );
					this.m_EquipmentUnitPerfectedDays.Clear( );
					this.m_EquipmentUnitPerfectedChanges.Clear( );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_Year.Clear( );
					return;

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
		} // Clear
		#endregion Методы инициализации и очистки

		#region Методы загрузки параметров хранимых процедур
		/// <summary>
		/// Загрузка параметров хранимой процедуры добавления
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
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_YEAR,
		/// INVALID_PRODUCTION_OUTPUT_AMOUNT, INVALID_MARKETED_PRODUCTION_AMOUNT,
		/// INVALID_PRODUCTION_PRIME_COST, INVALID_TOTAL_RECEIPTS,
		/// INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES</returns>
		public virtual OperationReport LoadInsertStoredProcedureParameters
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
			// Установка года
			if ( this.m_Year.SetValue( parYear ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка объёма выпуска продукции
			if ( this.m_ProductionOutputAmount.SetValue
					( parProductionOutputAmount )    != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_OUTPUT_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка объёма реализованной продукции
			if ( this.m_MarketedProductionAmount.SetValue
					( parMarketedProductionAmount )   != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_MARKETED_PRODUCTION_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка себестоимости продукции
			if ( this.m_ProductionPrimeCost.SetValue( parProductionPrimeCost ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_PRIME_COST,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка общей выручки
			if ( this.m_TotalReceipts.SetValue( parTotalReceipts )             !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_TOTAL_RECEIPTS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка среднегодового количества действующего оборудования
			if ( this.m_ActingEquipmentAnnualAverageAmount.SetValue
					( parActingEquipmentAnnualAverageAmount ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества часов, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedHours.SetValue
					( parEquipmentUnitPerfectedHours )   != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества дней, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedDays.SetValue
					( parEquipmentUnitPerfectedDays )    != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества смен, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedChanges.SetValue
					( parEquipmentUnitPerfectedChanges ) != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры обновления
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
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_OLD_YEAR,
		/// INVALID_YEAR, INVALID_PRODUCTION_OUTPUT_AMOUNT,
		/// INVALID_MARKETED_PRODUCTION_AMOUNT, INVALID_PRODUCTION_PRIME_COST,
		/// INVALID_TOTAL_RECEIPTS,
		/// INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
		/// INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES</returns>
		public virtual OperationReport LoadUpdateStoredProcedureParameters
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
			// Установка старого года
			if ( this.m_OldYear.SetValue( parOldYear )                         !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка года
			if ( this.m_Year.SetValue( parYear ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка объёма выпуска продукции
			if ( this.m_ProductionOutputAmount.SetValue
					( parProductionOutputAmount )    != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_OUTPUT_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка объёма реализованной продукции
			if ( this.m_MarketedProductionAmount.SetValue
					( parMarketedProductionAmount )   != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_MARKETED_PRODUCTION_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка себестоимости продукции
			if ( this.m_ProductionPrimeCost.SetValue( parProductionPrimeCost ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_PRIME_COST,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка общей выручки
			if ( this.m_TotalReceipts.SetValue( parTotalReceipts )             !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_TOTAL_RECEIPTS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка среднегодового количества действующего оборудования
			if ( this.m_ActingEquipmentAnnualAverageAmount.SetValue
					( parActingEquipmentAnnualAverageAmount ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества часов, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedHours.SetValue
					( parEquipmentUnitPerfectedHours )   != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества дней, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedDays.SetValue
					( parEquipmentUnitPerfectedDays )    != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка количества смен, отработанных единицей оборудования
			if ( this.m_EquipmentUnitPerfectedChanges.SetValue
					( parEquipmentUnitPerfectedChanges ) != OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadUpdateStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры удаления
		/// </summary>
		/// <param name="parYear">Год</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL,
		/// INVALID_YEAR</returns>
		public virtual OperationReport LoadDeleteStoredProcedureParameters
			( string parYear )
		{
			// Установка года
			if ( this.m_Year.SetValue( parYear ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadDeleteStoredProcedureParameters
		#endregion Методы загрузки параметров хранимых процедур

		#region Методы добавления и вывода параметров хранимых процедур
		/// <summary>
		/// Добавление параметров хранимой процедуры
		/// </summary>
		/// <param name="parStoredProcedure">Хранимая процедура</param>
		protected override void AddStoredProcedureParameters
			( ref SqlCommand parStoredProcedure )
		{
			switch ( this.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					// Объём выпуска продукции
					parStoredProcedure.Parameters.Add
						( this.m_ProductionOutputAmount.SqlParameterView );
					// Объём реализованной продукции
					parStoredProcedure.Parameters.Add
						( this.m_MarketedProductionAmount.SqlParameterView );
					// Себестоимость продукции
					parStoredProcedure.Parameters.Add
						( this.m_ProductionPrimeCost.SqlParameterView );
					// Общая выручка
					parStoredProcedure.Parameters.Add
						( this.m_TotalReceipts.SqlParameterView );
					// Среднегодовое количество действующего оборудования
					parStoredProcedure.Parameters.Add
						( this.m_ActingEquipmentAnnualAverageAmount.SqlParameterView );
					// Количество часов, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedHours.SqlParameterView );
					// Количество дней, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedDays.SqlParameterView );
					// Количество смен, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedChanges.SqlParameterView );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старый год
					parStoredProcedure.Parameters.Add
						( this.m_OldYear.SqlParameterView );
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					// Объём выпуска продукции
					parStoredProcedure.Parameters.Add
						( this.m_ProductionOutputAmount.SqlParameterView );
					// Объём реализованной продукции
					parStoredProcedure.Parameters.Add
						( this.m_MarketedProductionAmount.SqlParameterView );
					// Себестоимость продукции
					parStoredProcedure.Parameters.Add
						( this.m_ProductionPrimeCost.SqlParameterView );
					// Общая выручка
					parStoredProcedure.Parameters.Add
						( this.m_TotalReceipts.SqlParameterView );
					// Среднегодовое количество действующего оборудования
					parStoredProcedure.Parameters.Add
						( this.m_ActingEquipmentAnnualAverageAmount.SqlParameterView );
					// Количество часов, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedHours.SqlParameterView );
					// Количество дней, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedDays.SqlParameterView );
					// Количество смен, отработанных единицей оборудования
					parStoredProcedure.Parameters.Add
						( this.m_EquipmentUnitPerfectedChanges.SqlParameterView );
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					break;

				// Прочие непредусмотренные процедуры
				default:
					break;
			} // switch
		} // AddStoredProcedureParameters

		/// <summary>
		/// Вывод параметров хранимой процедуры
		/// </summary>
		/// <param name="parStoredProcedure">Хранимая процедура</param>
		protected override void OutputStoredProcedureParameters
			( SqlCommand parStoredProcedure )
		{
			switch ( this.CurrentAction )
			{
				// Добавление
				case StoredProcedureAction.INSERT :
					// Год
					this.m_Year.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Объём выпуска продукции
					this.m_ProductionOutputAmount.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Объём реализованной продукции
					this.m_MarketedProductionAmount.Value =
						parStoredProcedure.Parameters[ 2 ].Value;
					// Себестоимость продукции
					this.m_ProductionPrimeCost.Value =
						parStoredProcedure.Parameters[ 3 ].Value;
					// Общая выручка
					this.m_TotalReceipts.Value =
						parStoredProcedure.Parameters[ 4 ].Value;
					// Среднегодовое количество действующего оборудования
					this.m_ActingEquipmentAnnualAverageAmount.Value =
						parStoredProcedure.Parameters[ 5 ].Value;
					// Количество часов, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedHours.Value =
						parStoredProcedure.Parameters[ 6 ].Value;
					// Количество дней, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedDays.Value =
						parStoredProcedure.Parameters[ 7 ].Value;
					// Количество смен, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedChanges.Value =
						parStoredProcedure.Parameters[ 8 ].Value;
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старый год
					this.m_OldYear.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Год
					this.m_Year.Value    = parStoredProcedure.Parameters[ 1 ].Value;
					// Объём выпуска продукции
					this.m_ProductionOutputAmount.Value =
						parStoredProcedure.Parameters[ 2 ].Value;
					// Объём реализованной продукции
					this.m_MarketedProductionAmount.Value =
						parStoredProcedure.Parameters[ 3 ].Value;
					// Себестоимость продукции
					this.m_ProductionPrimeCost.Value =
						parStoredProcedure.Parameters[ 4 ].Value;
					// Общая выручка
					this.m_TotalReceipts.Value =
						parStoredProcedure.Parameters[ 5 ].Value;
					// Среднегодовое количество действующего оборудования
					this.m_ActingEquipmentAnnualAverageAmount.Value =
						parStoredProcedure.Parameters[ 6 ].Value;
					// Количество часов, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedHours.Value =
						parStoredProcedure.Parameters[ 7 ].Value;
					// Количество дней, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedDays.Value =
						parStoredProcedure.Parameters[ 8 ].Value;
					// Количество смен, отработанных единицей оборудования
					this.m_EquipmentUnitPerfectedChanges.Value =
						parStoredProcedure.Parameters[ 9 ].Value;
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Год
					this.m_Year.Value = parStoredProcedure.Parameters[ 0 ].Value;
					break;

				// Прочие непредусмотренные процедуры
				default:
					break;
			} // switch
		} // OutputStoredProcedureParameters
		#endregion Методы добавления и вывода параметров хранимых процедур
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание дополнительных данных по умолчанию
		/// </summary>
		public AdditionalData( )
		{
			// Установка неизвестного текущего действия
			this.CurrentAction = StoredProcedureAction.UNKNOWN;
			// Пустое название таблицы сущности
			AdditionalDataDataSetTableName = string.Empty;
		} // AdditionalData

		/// <summary>
		/// Создание дополнительных данных c заданными действием
		/// хранимой процедуры и названием таблицы сущности
		/// </summary>
		/// <param name="parAction">Действие</param>
		/// <param name="parDataSet">Множество данных</param>
		/// <param name="parAdditionalDataDataSetTableName">
		/// Название таблицы дополнительных данных</param>
		public AdditionalData
		(
			StoredProcedureAction                parAction,
			ref MainFacilitiesUseAnalysisDataSet parDataSet,
			string                               parAdditionalDataDataSetTableName
		)
		{
			// Установка текущего действия
			this.CurrentAction = parAction;
			// Инициализация названия таблицы сущности
			AdditionalDataDataSetTableName = parAdditionalDataDataSetTableName;

			// Инициализация адаптера Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			if ( ( this.CurrentAction == StoredProcedureAction.SHOW )   ||
					( this.CurrentAction  == StoredProcedureAction.INSERT ) ||
					( this.CurrentAction  == StoredProcedureAction.UPDATE ) ||
					( this.CurrentAction  == StoredProcedureAction.DELETE ) )
				// Адаптер Sql-данных дополнительных данных
				this.m_AdditionalDataSqlDataAdapter = new SqlDataAdapter
					( new SqlCommand( AdditionalData.SHOW_STORED_PROCEDURE_NAME,
					DataContainer.Instance( ).CurrentSqlConnection ) );

			// Инициализация
			this.Init( ref parDataSet );
		} // AdditionalData
		#endregion Конструкторы

		#region Свойства
		/// <summary>
		/// Заголовок текущего действия
		/// </summary>
		public override string CurrentActionCaption
		{
			get
			{
				switch ( this.CurrentAction )
				{
					// Показ
					case StoredProcedureAction.SHOW :
						return Essence.SHOW_ACTION_CAPTION;

					// Установка
					case StoredProcedureAction.SET :
						return Essence.SET_ACTION_CAPTION;

					// Добавление
					case StoredProcedureAction.INSERT :
						return Essence.INSERT_ACTION_CAPTION;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return Essence.UPDATE_ACTION_CAPTION;

					// Удаление
					case StoredProcedureAction.DELETE :
						return Essence.DELETE_ACTION_CAPTION;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionCaption

		/// <summary>
		/// Название хранимой процедуры текущего действия
		/// </summary>
		public override string CurrentActionStoredProcedureName
		{
			get
			{
				switch ( this.CurrentAction )
				{
					// Показ
					case StoredProcedureAction.SHOW :
						return AdditionalData.SHOW_STORED_PROCEDURE_NAME;

					// Установка
					case StoredProcedureAction.SET :
						return AdditionalData.SET_STORED_PROCEDURE_NAME;

					// Добавление
					case StoredProcedureAction.INSERT :
						return AdditionalData.INSERT_STORED_PROCEDURE_NAME;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return AdditionalData.UPDATE_STORED_PROCEDURE_NAME;

					// Удаление
					case StoredProcedureAction.DELETE :
						return AdditionalData.DELETE_STORED_PROCEDURE_NAME;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionStoredProcedureName

		/// <summary>
		/// Год
		/// </summary>
		public virtual string Year
		{
			get
			{
				return this.m_Year.ValueString;
			} // get
		} // Year

		/// <summary>
		/// Старый год
		/// </summary>
		public virtual string OldYear
		{
			get
			{
				return this.m_OldYear.ValueString;
			} // get
		} // OldYear

		/// <summary>
		/// Объём выпуска продукции
		/// </summary>
		public virtual string ProductionOutputAmount
		{
			get
			{
				return this.m_ProductionOutputAmount.ValueString;
			} // get
		} // ProductionOutputAmount

		/// <summary>
		/// Объём реализованной продукции
		/// </summary>
		public virtual string MarketedProductionAmount
		{
			get
			{
				return this.m_MarketedProductionAmount.ValueString;
			} // get
		} // MarketedProductionAmount

		/// <summary>
		/// Себестоимость продукции
		/// </summary>
		public virtual string ProductionPrimeCost
		{
			get
			{
				return this.m_ProductionPrimeCost.ValueString;
			} // get
		} // ProductionPrimeCost

		/// <summary>
		/// Общая выручка
		/// </summary>
		public virtual string TotalReceipts
		{
			get
			{
				return this.m_TotalReceipts.ValueString;
			} // get
		} // TotalReceipts

		/// <summary>
		/// Среднегодовое количество действующего оборудования
		/// </summary>
		public virtual string ActingEquipmentAnnualAverageAmount
		{
			get
			{
				return this.m_ActingEquipmentAnnualAverageAmount.ValueString;
			} // get
		} // ActingEquipmentAnnualAverageAmount

		/// <summary>
		/// Количество часов, отработанных единицей оборудования
		/// </summary>
		public virtual string EquipmentUnitPerfectedHours
		{
			get
			{
				return this.m_EquipmentUnitPerfectedHours.ValueString;
			} // get
		} // EquipmentUnitPerfectedHours

		/// <summary>
		/// Количество дней, отработанных единицей оборудования
		/// </summary>
		public virtual string EquipmentUnitPerfectedDays
		{
			get
			{
				return this.m_EquipmentUnitPerfectedDays.ValueString;
			} // get
		} // EquipmentUnitPerfectedDays

		/// <summary>
		/// Количество смен, отработанных единицей оборудования
		/// </summary>
		public virtual string EquipmentUnitPerfectedChanges
		{
			get
			{
				return this.m_EquipmentUnitPerfectedChanges.ValueString;
			} // get
		} // EquipmentUnitPerfectedChanges
		#endregion Свойства
	} // AdditionalData
} // MainFacilitiesUseAnalysisClient