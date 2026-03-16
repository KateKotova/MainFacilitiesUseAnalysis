using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Документ
	/// </summary>
	public class Document : Essence
	{
		#region Поля
		/// <summary>
		/// Заголовок сущности
		/// </summary>
		new public const string ESSENCE_CAPTION = "Документ";
		/// <summary>
		/// Текщее действие хранимой процедуры
		/// </summary>
		new public readonly StoredProcedureAction CurrentAction;

		#region Названия хранимых процедур
		/// <summary>
		/// Название хранимой процедуры показа
		/// </summary>
		new public const string    SHOW_STORED_PROCEDURE_NAME   =
			"SP_ShowDocuments";

		/// <summary>
		/// Название хранимой процедуры добавления
		/// </summary>
		new protected const string INSERT_STORED_PROCEDURE_NAME =
			"SP_InsertDocument";
		/// <summary>
		/// Название хранимой процедуры обновления
		/// </summary>
		new protected const string UPDATE_STORED_PROCEDURE_NAME =
			"SP_UpdateDocument";
		/// <summary>
		/// Название хранимой процедуры удаления
		/// </summary>
		new protected const string DELETE_STORED_PROCEDURE_NAME =
			"SP_DeleteDocument";

		/// <summary>
		/// Название хранимой процедуры показа типов документов
		/// </summary>
		protected const string SHOW_DOCUMENTS_TYPES_STORED_PROCEDURE_NAME =
			"SP_ShowDocumentsTypes";
		/// <summary>
		/// Название хранимой процедуры показа основных средств
		/// </summary>
		protected const string SHOW_MAIN_FACILITIES_STORED_PROCEDURE_NAME =
			"SP_ShowMainFacilities";
		#endregion Названия хранимых процедур

		#region Названия таблиц сущностей
		/// <summary>
		/// Название таблицы документов
		/// </summary>
		public readonly string DocumentsDataSetTableName;
		/// <summary>
		/// Название таблицы типов документов
		/// </summary>
		public readonly string DocumentsTypesDataSetTableName;
		/// <summary>
		/// Название таблицы основных средств
		/// </summary>
		public readonly string MainFacilitiesDataSetTableName;
		#endregion Названия таблиц сущностей

		#region Адаптеры Sql-данных
		/// <summary>
		/// Адаптер Sql-данных документов
		/// </summary>
		protected SqlDataAdapter m_DocumentsSqlDataAdapter;
		/// <summary>
		/// Адаптер Sql-данных типов документов
		/// </summary>
		protected SqlDataAdapter m_DocumentsTypesSqlDataAdapter;
		/// <summary>
		/// Адаптер Sql-данных основных средств
		/// </summary>
		protected SqlDataAdapter m_MainFacilitiesSqlDataAdapter;
		#endregion Адаптеры Sql-данных

		#region Параметры
		/// <summary>
		/// Название типа
		/// </summary>
		protected Parameter m_TypeName    = new Parameter( "@parTypeName" );
		/// <summary>
		/// Старое название типа
		/// </summary>
		protected Parameter m_OldTypeName = new Parameter( "@parOldTypeName" );
		/// <summary>
		/// Название основного средства
		/// </summary>
		protected Parameter m_MainFacilityName    = new Parameter
			( "@parMainFacilityName" );
		/// <summary>
		/// Старое название основного средства
		/// </summary>
		protected Parameter m_OldMainFacilityName = new Parameter
			( "@parOldMainFacilityName" );
		/// <summary>
		/// Год
		/// </summary>
		protected Parameter m_Year        = new Parameter( "@parYear" );
		/// <summary>
		/// Старый год
		/// </summary>
		protected Parameter m_OldYear     = new Parameter( "@parOldYear" );
		/// <summary>
		/// Месяц
		/// </summary>
		protected Parameter m_Month       = new Parameter( "@parMonth" );
		/// <summary>
		/// Старый месяц
		/// </summary>
		protected Parameter m_OldMonth    = new Parameter( "@parOldMonth" );
		/// <summary>
		/// День
		/// </summary>
		protected Parameter m_Day         = new Parameter( "@parDay" );
		/// <summary>
		/// Старый день
		/// </summary>
		protected Parameter m_OldDay      = new Parameter( "@parOldDay" );
		/// <summary>
		/// Стоимость
		/// </summary>
		protected Parameter m_Cost        = new Parameter( "@parCost" );
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
			// Инициализация адаптера Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			if ( ( this.CurrentAction == StoredProcedureAction.INSERT ) ||
					( this.CurrentAction  == StoredProcedureAction.UPDATE ) ||
					( this.CurrentAction  == StoredProcedureAction.DELETE ) )
			{
				// Адаптер Sql-данных документов
				this.m_DocumentsSqlDataAdapter.     Fill( parDataSet,
					this.DocumentsDataSetTableName );
				// Адаптер Sql-данных типов документов
				this.m_DocumentsTypesSqlDataAdapter.Fill( parDataSet,
					this.DocumentsTypesDataSetTableName );
				// Адаптер Sql-данных основных средств
				this.m_MainFacilitiesSqlDataAdapter.Fill( parDataSet,
					this.MainFacilitiesDataSetTableName );
			} // if
			else
				if ( this.CurrentAction == StoredProcedureAction.SHOW )
					// Адаптер Sql-данных документов
					this.m_DocumentsSqlDataAdapter.     Fill( parDataSet,
						this.DocumentsDataSetTableName );
		} // FillSqlDataAdapters

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
					this.m_TypeName.InitNVarChar        ( locDirection, locIsNullable,
						75, string.Empty );
					this.m_MainFacilityName.InitNVarChar( locDirection, locIsNullable,
						250, string.Empty );
					this.m_Year.InitSmallInt            ( locDirection, locIsNullable,
						string.Empty );
					this.m_Month.InitTinyInt            ( locDirection, locIsNullable,
						string.Empty );
					this.m_Day.InitTinyInt              ( locDirection, locIsNullable,
						string.Empty );
					this.m_Cost.InitMoney               ( locDirection, locIsNullable,
						string.Empty );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_TypeName.InitNVarChar           ( locDirection,
						locIsNullable, 75, string.Empty );
					this.m_OldTypeName.InitNVarChar        ( locDirection,
						locIsNullable, 75, string.Empty );
					this.m_MainFacilityName.InitNVarChar   ( locDirection,
						locIsNullable, 250, string.Empty );
					this.m_OldMainFacilityName.InitNVarChar( locDirection,
						locIsNullable, 250, string.Empty );
					this.m_Year.InitSmallInt               ( locDirection,
						locIsNullable, string.Empty );
					this.m_OldYear.InitSmallInt            ( locDirection,
						locIsNullable, string.Empty );
					this.m_Month.InitTinyInt               ( locDirection,
						locIsNullable, string.Empty );
					this.m_OldMonth.InitTinyInt            ( locDirection,
						locIsNullable, string.Empty );
					this.m_Day.InitTinyInt                 ( locDirection,
						locIsNullable, string.Empty );
					this.m_OldDay.InitTinyInt              ( locDirection,
						locIsNullable, string.Empty );
					this.m_Cost.InitMoney                  ( locDirection,
						locIsNullable, string.Empty );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_TypeName.InitNVarChar        ( locDirection, locIsNullable,
						75, string.Empty );
					this.m_MainFacilityName.InitNVarChar( locDirection, locIsNullable,
						250, string.Empty );
					this.m_Year.InitSmallInt            ( locDirection, locIsNullable,
						string.Empty );
					this.m_Month.InitTinyInt            ( locDirection, locIsNullable,
						string.Empty );
					this.m_Day.InitTinyInt              ( locDirection, locIsNullable,
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
					this.m_TypeName.Clear( );
					this.m_MainFacilityName.Clear( );
					this.m_Year.Clear( );
					this.m_Month.Clear( );
					this.m_Day.Clear( );
					this.m_Cost.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_TypeName.Clear( );
					this.m_OldTypeName.Clear( );
					this.m_MainFacilityName.Clear( );
					this.m_OldMainFacilityName.Clear( );
					this.m_Year.Clear( );
					this.m_OldYear.Clear( );
					this.m_Month.Clear( );
					this.m_OldMonth.Clear( );
					this.m_Day.Clear( );
					this.m_OldDay.Clear( );
					this.m_Cost.Clear( );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_TypeName.Clear( );
					this.m_MainFacilityName.Clear( );
					this.m_Year.Clear( );
					this.m_Month.Clear( );
					this.m_Day.Clear( );
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
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		/// <param name="parCost">Стоимость</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_TYPE_NAME,
		/// INVALID_MAIN_FACILITY_NAME, INVALID_YEAR, INVALID_MONTH, INVALID_DAY,
		/// INVALID_COST</returns>
		public virtual OperationReport LoadInsertStoredProcedureParameters
		(
			string   parTypeName,
			string   parMainFacilityName,
			DateTime parDate,
			string   parCost
		)
		{
			// Установка названия типа
			if ( this.m_TypeName.SetValue( parTypeName )                 !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия основного средства
			if ( this.m_MainFacilityName.SetValue( parMainFacilityName ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_MAIN_FACILITY_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка года
			if ( this.m_Year.SetValue( parDate.Year.ToString( ) )        !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка месяца
			if ( this.m_Month.SetValue( parDate.Month.ToString( ) )      !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_MONTH,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка дня
			if ( this.m_Day.SetValue( parDate.Day.ToString( ) )          !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_DAY,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка стоимости
			if ( this.m_Cost.SetValue( parCost ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_COST,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры обновления
		/// </summary>
		/// <param name="parOldTypeName">Старое название типа</param>
		/// <param name="parOldMainFacilityName">
		/// Старое название основного средства</param>
		/// <param name="parOldDate">Старая дата</param>
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		/// <param name="parCost">Стоимость</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL,
		/// INVALID_OLD_TYPE_NAME, INVALID_OLD_MAIN_FACILITY_NAME,
		/// INVALID_OLD_YEAR, INVALID_OLD_MONTH, INVALID_OLD_DAY,
		/// INVALID_TYPE_NAME, INVALID_MAIN_FACILITY_NAME, INVALID_YEAR,
		/// INVALID_MONTH, INVALID_DAY, INVALID_COST</returns>
		public virtual OperationReport LoadUpdateStoredProcedureParameters
		(
			string   parOldTypeName,
			string   parOldMainFacilityName,
			DateTime parOldDate,
			string   parTypeName,
			string   parMainFacilityName,
			DateTime parDate,
			string   parCost
		)
		{
			// Установка старого названия типа
			if ( this.m_OldTypeName.SetValue( parOldTypeName )                 !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка старого названия основного средства
			if ( this.m_OldMainFacilityName.SetValue( parOldMainFacilityName ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_OLD_MAIN_FACILITY_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка старого года
			if ( this.m_OldYear.SetValue( parOldDate.Year.ToString( ) )        !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка старого месяца
			if ( this.m_OldMonth.SetValue( parOldDate.Month.ToString( ) )      !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_MONTH,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка старого дня
			if ( this.m_OldDay.SetValue( parOldDate.Day.ToString( ) )          !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_DAY,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия типа
			if ( this.m_TypeName.SetValue( parTypeName )                       !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия основного средства
			if ( this.m_MainFacilityName.SetValue( parMainFacilityName )       !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_MAIN_FACILITY_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка года
			if ( this.m_Year.SetValue( parDate.Year.ToString( ) )              !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка месяца
			if ( this.m_Month.SetValue( parDate.Month.ToString( ) )            !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_MONTH,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка дня
			if ( this.m_Day.SetValue( parDate.Day.ToString( ) ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_DAY,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка стоимости
			if ( this.m_Cost.SetValue( parCost ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_COST,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadUpdateStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры удаления
		/// </summary>
		/// <param name="parTypeName">Название типа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_TYPE_NAME,
		/// INVALID_MAIN_FACILITY_NAME, INVALID_YEAR, INVALID_MONTH,
		/// INVALID_DAY</returns>
		public virtual OperationReport LoadDeleteStoredProcedureParameters
		(
			string   parTypeName,
			string   parMainFacilityName,
			DateTime parDate
		)
		{
			// Установка названия типа
			if ( this.m_TypeName.SetValue( parTypeName )                 !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия основного средства
			if ( this.m_MainFacilityName.SetValue( parMainFacilityName ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_MAIN_FACILITY_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка года
			if ( this.m_Year.SetValue( parDate.Year.ToString( ) )        !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_YEAR,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка месяца
			if ( this.m_Month.SetValue( parDate.Month.ToString( ) )      !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_MONTH,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка дня
			if ( this.m_Day.SetValue( parDate.Day.ToString( ) )          !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_DAY,
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
					// Название типа
					parStoredProcedure.Parameters.Add
						( this.m_TypeName.SqlParameterView );
					// Название основного средства
					parStoredProcedure.Parameters.Add
						( this.m_MainFacilityName.SqlParameterView );
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					// Месяц
					parStoredProcedure.Parameters.Add( this.m_Month.SqlParameterView );
					// День
					parStoredProcedure.Parameters.Add( this.m_Day.SqlParameterView );
					// Стоимость
					parStoredProcedure.Parameters.Add( this.m_Cost.SqlParameterView );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старое название типа
					parStoredProcedure.Parameters.Add
						( this.m_OldTypeName.SqlParameterView );
					// Старое название основного средства
					parStoredProcedure.Parameters.Add
						( this.m_OldMainFacilityName.SqlParameterView );
					// Старый год
					parStoredProcedure.Parameters.Add
						( this.m_OldYear.SqlParameterView );
					// Старый месяц
					parStoredProcedure.Parameters.Add
						( this.m_OldMonth.SqlParameterView );
					// Старый день
					parStoredProcedure.Parameters.Add( this.m_OldDay.SqlParameterView );
					// Название типа
					parStoredProcedure.Parameters.Add
						( this.m_TypeName.SqlParameterView );
					// Название основного средства
					parStoredProcedure.Parameters.Add
						( this.m_MainFacilityName.SqlParameterView );
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					// Месяц
					parStoredProcedure.Parameters.Add( this.m_Month.SqlParameterView );
					// День
					parStoredProcedure.Parameters.Add( this.m_Day.SqlParameterView );
					// Стоимость
					parStoredProcedure.Parameters.Add( this.m_Cost.SqlParameterView );
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Название типа
					parStoredProcedure.Parameters.Add
						( this.m_TypeName.SqlParameterView );
					// Название основного средства
					parStoredProcedure.Parameters.Add
						( this.m_MainFacilityName.SqlParameterView );
					// Год
					parStoredProcedure.Parameters.Add( this.m_Year.SqlParameterView );
					// Месяц
					parStoredProcedure.Parameters.Add( this.m_Month.SqlParameterView );
					// День
					parStoredProcedure.Parameters.Add( this.m_Day.SqlParameterView );
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
					// Название типа
					this.m_TypeName.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Название основного средства
					this.m_MainFacilityName.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Год
					this.m_Year.Value     = parStoredProcedure.Parameters[ 2 ].Value;
					// Месяц
					this.m_Month.Value    = parStoredProcedure.Parameters[ 3 ].Value;
					// День
					this.m_Day.Value      = parStoredProcedure.Parameters[ 4 ].Value;
					// Стоимость
					this.m_Cost.Value     = parStoredProcedure.Parameters[ 5 ].Value;
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старое название типа
					this.m_OldTypeName.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Старое название основного средства
					this.m_OldMainFacilityName.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Старый год
					this.m_OldYear.Value     = parStoredProcedure.Parameters[ 2 ].Value;
					// Старый месяц
					this.m_OldMonth.Value    = parStoredProcedure.Parameters[ 3 ].Value;
					// Старый день
					this.m_OldDay.Value      = parStoredProcedure.Parameters[ 4 ].Value;
					// Название типа
					this.m_TypeName.Value    = parStoredProcedure.Parameters[ 5 ].Value;
					// Название основного средства
					this.m_MainFacilityName.Value =
						parStoredProcedure.Parameters[ 6 ].Value;
					// Год
					this.m_Year.Value        = parStoredProcedure.Parameters[ 7 ].Value;
					// Месяц
					this.m_Month.Value       = parStoredProcedure.Parameters[ 8 ].Value;
					// День
					this.m_Day.Value         = parStoredProcedure.Parameters[ 9 ].Value;
					// Стоимость
					this.m_Cost.Value        = parStoredProcedure.Parameters[ 10 ].Value;
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Название типа
					this.m_TypeName.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Название основного средства
					this.m_MainFacilityName.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Год
					this.m_Year.Value     = parStoredProcedure.Parameters[ 2 ].Value;
					// Месяц
					this.m_Month.Value    = parStoredProcedure.Parameters[ 3 ].Value;
					// День
					this.m_Day.Value      = parStoredProcedure.Parameters[ 4 ].Value;
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
		/// Создание документа по умолчанию
		/// </summary>
		public Document( )
		{
			// Установка неизвестного текущего действия
			this.CurrentAction = StoredProcedureAction.UNKNOWN;
			// Пустые названия таблиц сущностей
			this.DocumentsDataSetTableName      = string.Empty;
			this.DocumentsTypesDataSetTableName = string.Empty;
			this.MainFacilitiesDataSetTableName = string.Empty;
		} // Document

		/// <summary>
		/// Создание документа c заданными действием хранимой процедуры
		/// и названиями таблиц сущностей
		/// </summary>
		/// <param name="parAction">Действие</param>
		/// <param name="parDataSet">Множество данных</param>
		/// <param name="parDocumentsDataSetTableName">
		/// Название таблицы документов</param>
		/// <param name="parDocumentsTypesDataSetTableName">
		/// Название таблицы типов документов</param>
		/// <param name="parMainFacilitiesDataSetTableName">
		/// Название таблицы основных средств</param>
		public Document
		(
			StoredProcedureAction                parAction,
			ref MainFacilitiesUseAnalysisDataSet parDataSet,
			string                               parDocumentsDataSetTableName,
			string                               parDocumentsTypesDataSetTableName,
			string                               parMainFacilitiesDataSetTableName
		)
		{
			// Установка текущего действия
			this.CurrentAction = parAction;
			// Инициализация названий таблиц сущностей
			this.DocumentsDataSetTableName      = parDocumentsDataSetTableName;
			this.DocumentsTypesDataSetTableName = parDocumentsTypesDataSetTableName;
			this.MainFacilitiesDataSetTableName = parMainFacilitiesDataSetTableName;

			// Инициализация адаптера Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			if ( ( this.CurrentAction == StoredProcedureAction.INSERT ) ||
					( this.CurrentAction  == StoredProcedureAction.UPDATE ) ||
					( this.CurrentAction  == StoredProcedureAction.DELETE ) )
			{
				// Адаптер Sql-данных документов
				this.m_DocumentsSqlDataAdapter      = new SqlDataAdapter
					( new SqlCommand( Document.SHOW_STORED_PROCEDURE_NAME,
					DataContainer.Instance( ).CurrentSqlConnection ) );
				// Адаптер Sql-данных типов документов
				this.m_DocumentsTypesSqlDataAdapter = new SqlDataAdapter
					( new SqlCommand
					( Document.SHOW_DOCUMENTS_TYPES_STORED_PROCEDURE_NAME,
					DataContainer.Instance( ).CurrentSqlConnection ) );
				// Адаптер Sql-данных основных средств
				this.m_MainFacilitiesSqlDataAdapter = new SqlDataAdapter
					( new SqlCommand
					( Document.SHOW_MAIN_FACILITIES_STORED_PROCEDURE_NAME,
					DataContainer.Instance( ).CurrentSqlConnection ) );
			} // if
			else
				if ( this.CurrentAction == StoredProcedureAction.SHOW )
					// Адаптер Sql-данных документов
					this.m_DocumentsSqlDataAdapter      = new SqlDataAdapter
						( new SqlCommand( Document.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );

			// Инициализация
			this.Init( ref parDataSet );
		} // Document
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
						return Document.SHOW_STORED_PROCEDURE_NAME;

					// Установка
					case StoredProcedureAction.SET :
						return Document.SET_STORED_PROCEDURE_NAME;

					// Добавление
					case StoredProcedureAction.INSERT :
						return Document.INSERT_STORED_PROCEDURE_NAME;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return Document.UPDATE_STORED_PROCEDURE_NAME;

					// Удаление
					case StoredProcedureAction.DELETE :
						return Document.DELETE_STORED_PROCEDURE_NAME;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionStoredProcedureName

		/// <summary>
		/// Название типа
		/// </summary>
		public virtual string TypeName
		{
			get
			{
				return this.m_TypeName.ValueString;
			} // get
		} // TypeName

		/// <summary>
		/// Старое название типа
		/// </summary>
		public virtual string OldTypeName
		{
			get
			{
				return this.m_OldTypeName.ValueString;
			} // get
		} // OldTypeName

		/// <summary>
		/// Название основного средства
		/// </summary>
		public virtual string MainFacilityName
		{
			get
			{
				return this.m_MainFacilityName.ValueString;
			} // get
		} // MainFacilityName

		/// <summary>
		/// Старое название основного средства
		/// </summary>
		public virtual string OldMainFacilityName
		{
			get
			{
				return this.m_OldMainFacilityName.ValueString;
			} // get
		} // OldMainFacilityName

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
		/// Месяц
		/// </summary>
		public virtual string Month
		{
			get
			{
				return this.m_Month.ValueString;
			} // get
		} // Month

		/// <summary>
		/// Старый месяц
		/// </summary>
		public virtual string OldMonth
		{
			get
			{
				return this.m_OldMonth.ValueString;
			} // get
		} // OldMonth

		/// <summary>
		/// День
		/// </summary>
		public virtual string Day
		{
			get
			{
				return this.m_Day.ValueString;
			} // get
		} // Day

		/// <summary>
		/// Старый день
		/// </summary>
		public virtual string OldDay
		{
			get
			{
				return this.m_OldDay.ValueString;
			} // get
		} // OldDay

		/// <summary>
		/// Стоимость
		/// </summary>
		public virtual string Cost
		{
			get
			{
				return this.m_Cost.ValueString;
			} // get
		} // Cost

		/// <summary>
		/// Дата
		/// </summary>
		public virtual DateTime Date
		{
			get
			{
				return new DateTime
					( Convert.ToInt16( this.m_Year.SqlParameterView.Value ),
					Convert.ToInt16( this.m_Month.SqlParameterView.Value ),
					Convert.ToInt16( this.m_Day.SqlParameterView.Value ) );
			} // get
		} // Date

		/// <summary>
		/// Старая дата
		/// </summary>
		public virtual DateTime OldDate
		{
			get
			{
				return new DateTime
					( Convert.ToInt16( this.m_OldYear.SqlParameterView.Value ),
					Convert.ToInt16( this.m_OldMonth.SqlParameterView.Value ),
					Convert.ToInt16( this.m_OldDay.SqlParameterView.Value ) );
			} // get
		} // OldDate
		#endregion Свойства
	} // Document
} // MainFacilitiesUseAnalysisClient