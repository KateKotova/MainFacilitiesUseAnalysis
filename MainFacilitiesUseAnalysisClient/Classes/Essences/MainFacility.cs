using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Основное средство
	/// </summary>
	public class MainFacility : Essence
	{
		#region Поля
		/// <summary>
		/// Заголовок сущности
		/// </summary>
		new public const string ESSENCE_CAPTION = "Основное средство";
		/// <summary>
		/// Текщее действие хранимой процедуры
		/// </summary>
		new public readonly StoredProcedureAction CurrentAction;

		#region Названия хранимых процедур
		/// <summary>
		/// Название хранимой процедуры показа
		/// </summary>
		new public const string    SHOW_STORED_PROCEDURE_NAME   =
			"SP_ShowMainFacilities";

		/// <summary>
		/// Название хранимой процедуры добавления
		/// </summary>
		new protected const string INSERT_STORED_PROCEDURE_NAME =
			"SP_InsertMainFacility";
		/// <summary>
		/// Название хранимой процедуры обновления
		/// </summary>
		new protected const string UPDATE_STORED_PROCEDURE_NAME =
			"SP_UpdateMainFacility";
		/// <summary>
		/// Название хранимой процедуры удаления
		/// </summary>
		new protected const string DELETE_STORED_PROCEDURE_NAME =
			"SP_DeleteMainFacility";

		/// <summary>
		/// Название хранимой процедуры показа групп
		/// </summary>
		protected const string SHOW_GROUPS_STORED_PROCEDURE_NAME =
			"SP_ShowGroups";
		#endregion Названия хранимых процедур

		#region Названия таблиц сущностей
		/// <summary>
		/// Название таблицы основных средств
		/// </summary>
		public readonly string MainFacilitiesDataSetTableName;
		/// <summary>
		/// Название таблицы групп
		/// </summary>
		public readonly string GroupsDataSetTableName;
		#endregion Названия таблиц сущностей

		#region Адаптеры Sql-данных
		/// <summary>
		/// Адаптер Sql-данных основных средств
		/// </summary>
		protected SqlDataAdapter m_MainFacilitiesSqlDataAdapter;
		/// <summary>
		/// Адаптер Sql-данных групп
		/// </summary>
		protected SqlDataAdapter m_GroupsSqlDataAdapter;
		#endregion Адаптеры Sql-данных

		#region Параметры
		/// <summary>
		/// Инвентарный номер
		/// </summary>
		protected Parameter m_InventoryNumber = new Parameter
			( "@parInventoryNumber" );
		/// <summary>
		/// Название
		/// </summary>
		protected Parameter m_Name      = new Parameter( "@parName" );
		/// <summary>
		/// Старое название
		/// </summary>
		protected Parameter m_OldName   = new Parameter( "@parOldName" );
		/// <summary>
		/// Название группы
		/// </summary>
		protected Parameter m_GroupName = new Parameter( "@parGroupName" );
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
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter.Fill( parDataSet,
						this.MainFacilitiesDataSetTableName );
					break;

				// Добавление
				case StoredProcedureAction.INSERT :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter.Fill( parDataSet,
						this.MainFacilitiesDataSetTableName );
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill        ( parDataSet,
						this.GroupsDataSetTableName );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter.Fill( parDataSet,
						this.MainFacilitiesDataSetTableName );
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter.Fill        ( parDataSet,
						this.GroupsDataSetTableName );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter.Fill( parDataSet,
						this.MainFacilitiesDataSetTableName );
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
					this.m_InventoryNumber.InitNVarChar( locDirection, locIsNullable,
						53, string.Empty );
					this.m_Name.InitNVarChar           ( locDirection, locIsNullable,
						250, string.Empty );
					this.m_GroupName.InitNVarChar      ( locDirection, locIsNullable,
						150, string.Empty );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_InventoryNumber.InitNVarChar( locDirection, locIsNullable,
						53, string.Empty );
					this.m_Name.InitNVarChar           ( locDirection, locIsNullable,
						250, string.Empty );
					this.m_OldName.InitNVarChar        ( locDirection, locIsNullable,
						250, string.Empty );
					this.m_GroupName.InitNVarChar      ( locDirection, locIsNullable,
						150, string.Empty );
					return;

				// Удаление
				case StoredProcedureAction.DELETE :
					this.m_Name.InitNVarChar( locDirection, locIsNullable, 250,
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
					this.m_InventoryNumber.Clear( );
					this.m_Name.Clear( );
					this.m_GroupName.Clear( );
					return;

				// Обновление
				case StoredProcedureAction.UPDATE :
					this.m_InventoryNumber.Clear( );
					this.m_Name.Clear( );
					this.m_OldName.Clear( );
					this.m_GroupName.Clear( );
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
		/// <param name="parInventoryNumber">Инвентарный номер</param>
		/// <param name="parName">Название</param>
		/// <param name="parGroupName">Название группы</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL,
		/// INVALID_INVENTORY_NUMBER, INVALID_NAME, INVALID_GROUP_NAME</returns>
		public virtual OperationReport LoadInsertStoredProcedureParameters
		(
			string parInventoryNumber,
			string parName,
			string parGroupName
		)
		{
			// Установка инвентарного номера
			if ( this.m_InventoryNumber.SetValue( parInventoryNumber ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_INVENTORY_NUMBER,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия
			if ( this.m_Name.SetValue( parName ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия группы
			if ( this.m_GroupName.SetValue( parGroupName )             !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_GROUP_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Успешное завершение операции
			return new OperationReport( );
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Загрузка параметров хранимой процедуры обновления
		/// </summary>
		/// <param name="parOldName">Старое название</param>
		/// <param name="parInventoryNumber">Инвентарный номер</param>
		/// <param name="parName">Название</param>
		/// <param name="parGroupName">Название группы</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, INVALID_OLD_NAME,
		/// INVALID_INVENTORY_NUMBER, INVALID_NAME, INVALID_GROUP_NAME</returns>
		public virtual OperationReport LoadUpdateStoredProcedureParameters
		(
			string parOldName,
			string parInventoryNumber,
			string parName,
			string parGroupName
		)
		{
			// Установка строго названия
			if ( this.m_OldName.SetValue( parOldName )                 !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_OLD_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка инвентарного номера
			if ( this.m_InventoryNumber.SetValue( parInventoryNumber ) !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_INVENTORY_NUMBER,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия
			if ( this.m_Name.SetValue( parName ) != OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_NAME,
					DataContainer.INVALID_DATA_TYPE_ERROR_MESSAGE );

			// Установка названия группы
			if ( this.m_GroupName.SetValue( parGroupName )             !=
					OperationResult.SUCCESSFUL )
				return new OperationReport( OperationResult.INVALID_GROUP_NAME,
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
				case StoredProcedureAction.INSERT:
					// Инвентарный номер
					parStoredProcedure.Parameters.Add
						( this.m_InventoryNumber.SqlParameterView );
					// Название
					parStoredProcedure.Parameters.Add( this.m_Name.SqlParameterView );
					// Название группы
					parStoredProcedure.Parameters.Add
						( this.m_GroupName.SqlParameterView );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE:
					// Старое название
					parStoredProcedure.Parameters.Add
						( this.m_OldName.SqlParameterView );
					// Инвентарный номер
					parStoredProcedure.Parameters.Add
						( this.m_InventoryNumber.SqlParameterView );
					// Название
					parStoredProcedure.Parameters.Add( this.m_Name.SqlParameterView );
					// Название группы
					parStoredProcedure.Parameters.Add
						( this.m_GroupName.SqlParameterView );
					break;

				// Удаление
				case StoredProcedureAction.DELETE:
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
				case StoredProcedureAction.INSERT:
					// Инвентарный номер
					this.m_InventoryNumber.Value =
						parStoredProcedure.Parameters[ 0 ].Value;
					// Название
					this.m_Name.Value      = parStoredProcedure.Parameters[ 1 ].Value;
					// Название группы
					this.m_GroupName.Value = parStoredProcedure.Parameters[ 2 ].Value;
					break;

				// Обновление
				case StoredProcedureAction.UPDATE:
					// Старое название
					this.m_OldName.Value    = parStoredProcedure.Parameters[ 0 ].Value;
					// Инвентарный номер
					this.m_InventoryNumber.Value =
						parStoredProcedure.Parameters[ 1 ].Value;
					// Название
					this.m_Name.Value      = parStoredProcedure.Parameters[ 2 ].Value;
					// Название группы
					this.m_GroupName.Value = parStoredProcedure.Parameters[ 3 ].Value;
					break;

				// Удаление
				case StoredProcedureAction.DELETE:
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
		/// Создание основного средства по умолчанию
		/// </summary>
		public MainFacility( )
		{
			// Установка неизвестного текущего действия
			this.CurrentAction = StoredProcedureAction.UNKNOWN;
			// Пустые названия таблиц сущностей
			this.MainFacilitiesDataSetTableName = string.Empty;
			this.GroupsDataSetTableName         = string.Empty;
		} // MainFacility

		/// <summary>
		/// Создание основного средства c заданными действием хранимой процедуры
		/// и названиями таблиц сущностей
		/// </summary>
		/// <param name="parAction">Действие</param>
		/// <param name="parDataSet">Множество данных</param>
		/// <param name="parMainFacilitiesDataSetTableName">
		/// Название таблицы основных средств</param>
		/// <param name="parGroupsDataSetTableName">Название таблицы групп</param>
		public MainFacility
		(
			StoredProcedureAction                parAction,
			ref MainFacilitiesUseAnalysisDataSet parDataSet,
			string                               parMainFacilitiesDataSetTableName,
			string                               parGroupsDataSetTableName
		)
		{
			// Установка текущего действия
			this.CurrentAction = parAction;
			// Инициализация названий таблиц сущностей
			this.MainFacilitiesDataSetTableName = parMainFacilitiesDataSetTableName;
			this.GroupsDataSetTableName         = parGroupsDataSetTableName;

			// Инициализация адаптеров Sql-данных в зависимости
			// от текущего действия хранимой процедуры
			switch ( this.CurrentAction )
			{
				// Показ
				case StoredProcedureAction.SHOW :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Добавление
				case StoredProcedureAction.INSERT :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter         = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_GROUPS_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Обновление
				case StoredProcedureAction.UPDATE :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					// Адаптер Sql-данных групп
					this.m_GroupsSqlDataAdapter         = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_GROUPS_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Удаление
				case StoredProcedureAction.DELETE :
					// Адаптер Sql-данных основных средств
					this.m_MainFacilitiesSqlDataAdapter = new SqlDataAdapter
						( new SqlCommand( MainFacility.SHOW_STORED_PROCEDURE_NAME,
						DataContainer.Instance( ).CurrentSqlConnection ) );
					break;

				// Прочие непредусмотренные процедуры
				default :
					break;
			} // switch

			// Инициализация
			this.Init( ref parDataSet );
		} // MainFacility
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
						return MainFacility.SHOW_STORED_PROCEDURE_NAME;

					// Установка
					case StoredProcedureAction.SET :
						return MainFacility.SET_STORED_PROCEDURE_NAME;

					// Добавление
					case StoredProcedureAction.INSERT :
						return MainFacility.INSERT_STORED_PROCEDURE_NAME;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return MainFacility.UPDATE_STORED_PROCEDURE_NAME;

					// Удаление
					case StoredProcedureAction.DELETE :
						return MainFacility.DELETE_STORED_PROCEDURE_NAME;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionStoredProcedureName

		/// <summary>
		/// Инвентарный номер
		/// </summary>
		public virtual string InventoryNumber
		{
			get
			{
				return this.m_InventoryNumber.ValueString;
			} // get
		} // InventoryNumber

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
		/// Название группы
		/// </summary>
		public virtual string GroupName
		{
			get
			{
				return this.m_GroupName.ValueString;
			} // get
		} // GroupName
		#endregion Свойства
	} // MainFacility
} // MainFacilitiesUseAnalysisClient