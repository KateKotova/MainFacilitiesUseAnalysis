using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Группа
	/// </summary>
	public class Group : Essence
	{
		#region Поля
		/// <summary>
		/// Заголовок сущности
		/// </summary>
		new public const string ESSENCE_CAPTION = "Группа";
		/// <summary>
		/// Текщее действие хранимой процедуры
		/// </summary>
		new public readonly StoredProcedureAction CurrentAction;

		#region Названия хранимых процедур
		/// <summary>
		/// Название хранимой процедуры показа
		/// </summary>
		new public const string    SHOW_STORED_PROCEDURE_NAME   = "SP_ShowGroups";

		/// <summary>
		/// Название хранимой процедуры добавления
		/// </summary>
		new protected const string INSERT_STORED_PROCEDURE_NAME =
			"SP_InsertGroup";
		/// <summary>
		/// Название хранимой процедуры обновления
		/// </summary>
		new protected const string UPDATE_STORED_PROCEDURE_NAME =
			"SP_UpdateGroup";
		/// <summary>
		/// Название хранимой процедуры удаления
		/// </summary>
		new protected const string DELETE_STORED_PROCEDURE_NAME =
			"SP_DeleteGroup";

		/// <summary>
		/// Название хранимой процедуры показа типов производственности
		/// </summary>
		protected const string SHOW_PRODUCTION_TYPES_STORED_PROCEDURE_NAME =
			"SP_ShowProductionTypes";
		/// <summary>
		/// Название хранимой процедуры показа типов активности
		/// </summary>
		protected const string SHOW_ACTIVITY_TYPES_STORED_PROCEDURE_NAME   =
			"SP_ShowActivityTypes";
		#endregion Названия хранимых процедур

		#region Названия таблиц сущностей
		/// <summary>
		/// Название таблицы групп
		/// </summary>
		public readonly string GroupsDataSetTableName;
		/// <summary>
		/// Название таблицы типов производственности
		/// </summary>
		public readonly string ProductionTypesDataSetTableName;
		/// <summary>
		/// Название таблицы типов активности
		/// </summary>
		public readonly string ActivityTypesDataSetTableName;
		#endregion Названия таблиц сущностей

		#region Адаптеры Sql-данных
		/// <summary>
		/// Адаптер Sql-данных групп
		/// </summary>
		protected SqlDataAdapter m_GroupsSqlDataAdapter;
		/// <summary>
		/// Адаптер Sql-данных типов производственности
		/// </summary>
		protected SqlDataAdapter m_ProductionTypesSqlDataAdapter;
		/// <summary>
		/// Адаптер Sql-данных типов активности
		/// </summary>
		protected SqlDataAdapter m_ActivityTypesSqlDataAdapter;
		#endregion Адаптеры Sql-данных

		#region Параметры
		/// <summary>
		/// Название
		/// </summary>
		protected Parameter m_Name    = new Parameter("@parName");
		/// <summary>
		/// Старое название
		/// </summary>
		protected Parameter m_OldName = new Parameter( "@parOldName" );
		/// <summary>
		/// Название типа производственности
		/// </summary>
		protected Parameter m_ProductionTypeName = new Parameter
			( "@parProductionTypeName" );
		/// <summary>
		/// Название типа активности
		/// </summary>
		protected Parameter m_ActivityTypeName   = new Parameter
			( "@parActivityTypeName" );
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
			// Заполнение адаптеров Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			switch ( this.CurrentAction )
			{
				// Показ
				case StoredProcedureAction.SHOW :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill( parDataSet,
						this.GroupsDataSetTableName );
					break;

				// Добавление
				case StoredProcedureAction.INSERT :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill         ( parDataSet,
						this.GroupsDataSetTableName );
					// Адаптер Sql-данных типов производственности
					this.m_ProductionTypesSqlDataAdapter.Fill( parDataSet,
						this.ProductionTypesDataSetTableName );
					// Адаптер Sql-данных типов активности
					this.m_ActivityTypesSqlDataAdapter.Fill  ( parDataSet,
						this.ActivityTypesDataSetTableName );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill         ( parDataSet,
						this.GroupsDataSetTableName );
					// Адаптер Sql-данных типов производственности
					this.m_ProductionTypesSqlDataAdapter.Fill( parDataSet,
						this.ProductionTypesDataSetTableName );
					// Адаптер Sql-данных типов активности
					this.m_ActivityTypesSqlDataAdapter.Fill  ( parDataSet,
						this.ActivityTypesDataSetTableName );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill( parDataSet,
						this.GroupsDataSetTableName );
					return;

				// Прочие непредусмотренные процедуры
				default :
					return;
			} // switch
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
					this.m_Name.InitNVarChar              ( locDirection, locIsNullable,
						150, string.Empty );
					this.m_ProductionTypeName.InitNVarChar( locDirection, locIsNullable,
						75,  string.Empty );
					this.m_ActivityTypeName.InitNVarChar  ( locDirection, locIsNullable,
						75,  string.Empty );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_Name.InitNVarChar              ( locDirection, locIsNullable,
						150, string.Empty );
					this.m_OldName.InitNVarChar           ( locDirection, locIsNullable,
						150, string.Empty );
					this.m_ProductionTypeName.InitNVarChar( locDirection, locIsNullable,
						75,  string.Empty );
					this.m_ActivityTypeName.InitNVarChar  ( locDirection, locIsNullable,
						75,  string.Empty );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_Name.InitNVarChar ( locDirection, locIsNullable,
						150, string.Empty );
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
					this.m_Name.Clear( );
					this.m_ProductionTypeName.Clear( );
					this.m_ActivityTypeName.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_Name.Clear( );
					this.m_OldName.Clear( );
					this.m_ProductionTypeName.Clear( );
					this.m_ActivityTypeName.Clear( );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_Name.Clear( );
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
		/// <param name="parName">Название</param>
		/// <param name="parProductionTypeName">
		/// Название типа производственности</param>
		/// <param name="parActivityTypeName">Название типа активности</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_NAME,
		/// INVALID_PRODUCTION_TYPE_NAME, INVALID_ACTIVITY_TYPE_NAME</returns>
		public virtual OperationReport LoadInsertStoredProcedureParameters
		(
			string parName,
			string parProductionTypeName,
			string parActivityTypeName
		)
		{
			// Установка названия
			if ( this.m_Name.SetValue( parName ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия типа производственности
			if ( this.m_ProductionTypeName.SetValue( parProductionTypeName ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия типа активности
			if ( this.m_ActivityTypeName.SetValue( parActivityTypeName )     !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_ACTIVITY_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры обновления
		/// </summary>
		/// <param name="parOldName">Старое название</param>
		/// <param name="parName">Название</param>
		/// <param name="parProductionTypeName">
		/// Название типа производственности</param>
		/// <param name="parActivityTypeName">Название типа активности</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_OLD_NAME,
		/// NVALID_NAME, INVALID_PRODUCTION_TYPE_NAME,
		/// INVALID_ACTIVITY_TYPE_NAME</returns>
		public virtual OperationReport LoadUpdateStoredProcedureParameters
		(
			string parOldName,
			string parName,
			string parProductionTypeName,
			string parActivityTypeName
		)
		{
			// Установка строго названия
			if ( this.m_OldName.SetValue( parOldName )                      !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия
			if ( this.m_Name.SetValue( parName ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия типа производственности
			if (this.m_ProductionTypeName.SetValue( parProductionTypeName ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_PRODUCTION_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия типа активности
			if ( this.m_ActivityTypeName.SetValue( parActivityTypeName )    !=
					OperationResult.SUCCESSFUL )
				return new OperationReport
					( OperationResult.INVALID_ACTIVITY_TYPE_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadUpdateStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры удаления
		/// </summary>
		/// <param name="parName">Название</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL,
		/// INVALID_NAME</returns>
		public virtual OperationReport LoadDeleteStoredProcedureParameters
			( string parName )
		{
			// Установка названия
			if ( this.m_Name.SetValue( parName ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_NAME,
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
					// Название
					parStoredProcedure.Parameters.Add( this.m_Name.SqlParameterView );
					// Название типа производственности
					parStoredProcedure.Parameters.Add
						( this.m_ProductionTypeName.SqlParameterView );
					// Название типа активности
					parStoredProcedure.Parameters.Add
						( this.m_ActivityTypeName.SqlParameterView );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старое название
					parStoredProcedure.Parameters.Add
						( this.m_OldName.SqlParameterView );
					// Название
					parStoredProcedure.Parameters.Add( this.m_Name.SqlParameterView );
					// Название типа производственности
					parStoredProcedure.Parameters.Add
						( this.m_ProductionTypeName.SqlParameterView );
					// Название типа активности
					parStoredProcedure.Parameters.Add
						( this.m_ActivityTypeName.SqlParameterView );
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Название
					parStoredProcedure.Parameters.Add( this.m_Name.SqlParameterView );
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
					// Название
					this.m_Name.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Название типа производственности
					this.m_ProductionTypeName.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Название типа активности
					this.m_ActivityTypeName.Value =
						parStoredProcedure.Parameters[ 2 ].Value;
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Старое название
					this.m_OldName.Value = parStoredProcedure.Parameters[ 0 ].Value;
					// Название
					this.m_Name.Value    = parStoredProcedure.Parameters[ 1 ].Value;
					// Название типа производственности
					this.m_ProductionTypeName.Value =
						parStoredProcedure.Parameters[ 2 ].Value;
					// Название типа активности
					this.m_ActivityTypeName.Value =
						parStoredProcedure.Parameters[ 3 ].Value;
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Название
					this.m_Name.Value = parStoredProcedure.Parameters[ 0 ].Value;
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
		/// Создание группы по умолчанию
		/// </summary>
		public Group( )
		{
			// Установка неизвестного текущего действия
			this.CurrentAction = StoredProcedureAction.UNKNOWN;
			// Пустые названия таблиц сущностей
			this.GroupsDataSetTableName          = string.Empty;
			this.ProductionTypesDataSetTableName = string.Empty;
			this.ActivityTypesDataSetTableName   = string.Empty;
		} // Group

		/// <summary>
		/// Создание группы c заданными действием хранимой процедуры
		/// и названиями таблиц сущностей
		/// </summary>
		/// <param name="parAction">Действие</param>
		/// <param name="parDataSet">Множество данных</param>
		/// <param name="parGroupsDataSetTableName">Название таблицы групп</param>
		/// <param name="parProductionTypesDataSetTableName">
		/// Название таблицы типов производственности</param>
		/// <param name="parActivityTypesDataSetTableName">
		/// Название таблицы типов активности</param>
		public Group
		(
			StoredProcedureAction                parAction,
			ref MainFacilitiesUseAnalysisDataSet parDataSet,
			string                               parGroupsDataSetTableName,
			string                               parProductionTypesDataSetTableName,
			string                               parActivityTypesDataSetTableName
		)
		{
			// Установка текущего действия
			this.CurrentAction = parAction;
			// Инициализация названий таблиц сущностей
			this.GroupsDataSetTableName          = parGroupsDataSetTableName;
			this.ProductionTypesDataSetTableName =
				parProductionTypesDataSetTableName;
			this.ActivityTypesDataSetTableName   = parActivityTypesDataSetTableName;

			// Инициализация адаптеров Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			switch ( this.CurrentAction )
			{
				// Показ
				case StoredProcedureAction.SHOW :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( Group.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Добавление
				case StoredProcedureAction.INSERT :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter          = new SqlDataAdapter
						( new SqlCommand( Group.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных типов производственности
					this.m_ProductionTypesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand
						( Group.SHOW_PRODUCTION_TYPES_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных типов активности
					this.m_ActivityTypesSqlDataAdapter   = new SqlDataAdapter
						( new SqlCommand
						( Group.SHOW_ACTIVITY_TYPES_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter          = new SqlDataAdapter
						( new SqlCommand( Group.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных типов производственности
					this.m_ProductionTypesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand
						( Group.SHOW_PRODUCTION_TYPES_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных типов активности
					this.m_ActivityTypesSqlDataAdapter   = new SqlDataAdapter
						( new SqlCommand
						( Group.SHOW_ACTIVITY_TYPES_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( Group.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Прочие непредусмотренные процедуры
				default :
					break;
			} // switch

			// Инициализация
			this.Init( ref parDataSet );
		} // Group
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
						return Group.SHOW_STORED_PROCEDURE_NAME;

					// Установка
					case StoredProcedureAction.SET :
						return Group.SET_STORED_PROCEDURE_NAME;

					// Добавление
					case StoredProcedureAction.INSERT :
						return Group.INSERT_STORED_PROCEDURE_NAME;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return Group.UPDATE_STORED_PROCEDURE_NAME;

					// Удаление
					case StoredProcedureAction.DELETE :
						return Group.DELETE_STORED_PROCEDURE_NAME;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionStoredProcedureName

		/// <summary>
		/// Название
		/// </summary>
		public virtual string Name
		{
			get
			{
				return this.m_Name.ValueString;
			} // get
		} // Name

		/// <summary>
		/// Старое название
		/// </summary>
		public virtual string OldName
		{
			get
			{
				return this.m_OldName.ValueString;
			} // get
		} // OldName

		/// <summary>
		/// Название типа производственности
		/// </summary>
		public virtual string ProductionTypeName
		{
			get
			{
				return this.m_ProductionTypeName.ValueString;
			} // get
		} // ProductionTypeName

		/// <summary>
		/// Название типа активности
		/// </summary>
		public virtual string ActivityTypeName
		{
			get
			{
				return this.m_ActivityTypeName.ValueString;
			} // get
		} // ActivityTypeName
		#endregion Свойства
	} // Group
} // MainFacilitiesUseAnalysisClient