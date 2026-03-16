using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Контейнер данных
	/// </summary>
	public sealed class DataContainer
	{
		#region Поля
		#region Публичные поля
		/// <summary>
		/// Атрибуты подключения по умолчанию
		/// </summary>
		public readonly ConnectionAttributes DefaultConnectionAttributes =
			new ConnectionAttributes( 30, @"ACER\SQL", "MainFacilitiesUseAnalysis",
			string.Empty, string.Empty, ConnectionSecurityLevel.WINDOWS );

		/// <summary>
		/// Максимальная длина сообщения об ошибке Sql-сервера
		/// </summary>
		public const ushort SERVER_ERROR_MESSAGE_MAXIMUM_LENGTH = 4000;

		/// <summary>
		/// Строка тире
		/// </summary>
		public const string DASH_STRING                     = " - ";
		/// <summary>
		/// Заголовок сообщения об ошибке
		/// </summary>
		public const string ERROR_MESSAGE_CAPTION           = "Ошибка!";
		/// <summary>
		/// Сообщение об ошибке недействительной операции
		/// </summary>
		public const string VOID_OPERATION_ERROR_MESSAGE    =
			"Недействительная операция";
		/// <summary>
		/// Сообщение об ошибке несоответствия типу данных
		/// </summary>
		public const string INVALID_DATA_TYPE_ERROR_MESSAGE =
			"Неверный тип данных";

		/// <summary>
		/// Шрифт шапки таблицы
		/// </summary>
		public readonly Font DataGridViewColumnHeadersFont =
			new Font( "Tahoma", 7.5F, System.Drawing.FontStyle.Bold );
		#endregion Публичные поля

		#region Приватные поля
		/// <summary>
		/// Текущее состояние подключения
		/// </summary>
		private ConnectionCondition m_CurrentConnectionCondition;
		/// <summary>
		/// Текущее Sql-cоединение
		/// </summary>
		private SqlConnection       m_CurrentSqlConnection;

		/// <summary>
		/// Параметр кода ошибки
		/// </summary>
		private Parameter m_ErrorCodeParameter          =
			new Parameter( "@locErrorCode" );
		/// <summary>
		/// Параметр краткого сообщения об ошибке
		/// </summary>
		private Parameter m_ShortErrorMessageParameter  =
			new Parameter( "@parShortErrorMessage" );
		/// <summary>
		/// Параметр системного сообщения об ошибке
		/// </summary>
		private Parameter m_SystemErrorMessageParameter =
			new Parameter( "@parSystemErrorMessage" );

		/// <summary>
		/// Единственный экземпляр контейнера данных
		/// </summary>
		private static DataContainer m_Instance = null;
		#endregion Приватные поля
		#endregion Поля

		#region Методы
		/// <summary>
		/// Подключение
		/// </summary>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, VOID, FAILED,
		/// INVALID_SERVER, INVALID_DATABASE,
		/// INVALID_USER_NAME_OR_PASSWORD</returns>
		public OperationReport Connect( )
		{
			// Удаление прежнего sql-соединения
			if ( this.m_CurrentSqlConnection != null )
				this.m_CurrentSqlConnection.Dispose( );

			// Проверка возможности осуществеления нового подключения
			OperationReport locReport = this.m_CurrentConnectionCondition.Test( );
			// Если подключение осуществимо, то оно выполяется и становится текущим
			if ( locReport.Result == OperationResult.SUCCESSFUL )
				// Установка текущего Sql-cоединения
				this.m_CurrentSqlConnection = new SqlConnection
					( this.m_CurrentConnectionCondition.Attributes.
					ConnectionString( ) );

			// Возврат результата проверки возможности осуществления подключения
			return locReport;
		} // Connect

		/// <summary>
		/// Инициализация единственного экземпляра контейнера данных
		/// </summary>
		/// <returns>Есдинственный экземпляр контейнера данных</returns>
		public static DataContainer Instance( )
		{
			if ( m_Instance == null )
				m_Instance = new DataContainer( );

			return m_Instance;
		} // Instance
		#endregion Методы

		/// <summary>
		/// Скрытое создание контейнера данных
		/// </summary>
		private DataContainer( )
		{
			// Текщее состояние подключения с атрибутами по умолчанию
			this.m_CurrentConnectionCondition = new ConnectionCondition
				( this.DefaultConnectionAttributes );

			// Sql-параметры
			// Параметр кода ошибки - целое число, возвращаемое значение
			this.m_ErrorCodeParameter.InitInt( ParameterDirection.ReturnValue,
				false, string.Empty );
			// Параметр краткого сообщения об ошибке   - строка, параметр вывода
			this.m_ShortErrorMessageParameter.InitNVarChar
				( ParameterDirection.Output, false,
				DataContainer.SERVER_ERROR_MESSAGE_MAXIMUM_LENGTH, string.Empty );
			// Параметр системного сообщения об ошибке - строка, параметр вывода
			this.m_SystemErrorMessageParameter.InitNVarChar
				( ParameterDirection.Output, false,
				DataContainer.SERVER_ERROR_MESSAGE_MAXIMUM_LENGTH, string.Empty );
		} // DataContainer

		#region Свойства
		#region Характеристики подключения
		/// <summary>
		/// Интервал времени в секундах, в течение которого происходит попытка
		/// установки соединения с источником данных
		/// </summary>
		public int ConnectTimeout
		{
			get
			{
				return this.m_CurrentConnectionCondition.ConnectTimeout;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.ConnectTimeout = value;
			} // set
		} // ConnectTimeout

		/// <summary>
		/// Имя копии SQL Server
		/// </summary>
		public string DataSource
		{
			get
			{
				return this.m_CurrentConnectionCondition.DataSource;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.DataSource = value;
			} // set
		} // DataSource

		/// <summary>
		/// Имя базы данных
		/// </summary>
		public string InitialCatalog
		{
			get
			{
				return this.m_CurrentConnectionCondition.InitialCatalog;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.InitialCatalog = value;
			} // set
		} // InitialCatalog

		/// <summary>
		/// Идентификатор пользователя
		/// </summary>
		public string UserID
		{
			get
			{
				return this.m_CurrentConnectionCondition.UserID;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.UserID = value;
			} // set
		} // UserID

		/// <summary>
		/// Пароль
		/// </summary>
		public string Password
		{
			get
			{
				return this.m_CurrentConnectionCondition.Password;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.Password = value;
			} // set
		} // Password

		/// <summary>
		/// Уровень безопасности подключения
		/// </summary>
		public ConnectionSecurityLevel SecurityLevel
		{
			get
			{
				return this.m_CurrentConnectionCondition.SecurityLevel;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.SecurityLevel = value;
			} // set
		} // SecurityLevel

		/// <summary>
		/// Атрибуты текущего подключения
		/// </summary>
		public ConnectionAttributes CurrentConnectionAttributes
		{
			get
			{
				return this.m_CurrentConnectionCondition.Attributes;
			} // get
			set
			{
				this.m_CurrentConnectionCondition.Attributes = value;
			} // set
		} // CurrentConnectionAttributes

		/// <summary>
		/// Текущее Sql-cоединение
		/// </summary>
		public SqlConnection CurrentSqlConnection
		{
			get
			{
				return this.m_CurrentSqlConnection;
			} // get
		} // CurrentSqlConnection
		#endregion Характеристики подключения

		#region Sql-параметры
		/// <summary>
		/// Sql-параметр кода ошибки
		/// </summary>
		public SqlParameter ErrorCodeParameter
		{
			get
			{
				return this.m_ErrorCodeParameter.SqlParameterView;
			} // get
		} // ErrorCodeParameter

		/// <summary>
		/// Sql-параметр краткого сообщения об ошибке
		/// </summary>
		public SqlParameter ShortErrorMessageParameter
		{
			get
			{
				return this.m_ShortErrorMessageParameter.SqlParameterView;
			} // get
		} // ShortErrorMessageParameter

		/// <summary>
		/// Sql-параметр системного сообщения об ошибке
		/// </summary>
		public SqlParameter SystemErrorMessageParameter
		{
			get
			{
				return this.m_SystemErrorMessageParameter.SqlParameterView;
			} // get
		} // SystemErrorMessageParameter
		#endregion Sql-параметры
		#endregion Свойства
	} // DataContainer
} // MainFacilitiesUseAnalysisClient