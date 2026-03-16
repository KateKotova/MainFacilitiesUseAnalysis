using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Состояние подключения
	/// </summary>
	public class ConnectionCondition
	{
		#region Поля
		#region Сообщения об ошибках
		/// <summary>
		/// Сообщение об ошибке неверного имени сервера
		/// </summary>
		protected const string INVALID_SERVER_ERROR_MESSAGE   =
			"Неверное имя сервера";
		/// <summary>
		/// Сообщение об ошибке неверного имени базы данных
		/// </summary>
		protected const string INVALID_DATABASE_ERROR_MESSAGE =
			"Неверное имя базы данных";
		/// <summary>
		/// Сообщение об ошибке неверного имени пользователя или пароля
		/// </summary>
		protected const string
			INVALID_USER_NAME_OR_PASSWORD_ERROR_MESSAGE         =
			"Неверное имя пользователя или пароль";
		/// <summary>
		/// Сообщение об ошибке подключения
		/// </summary>
		protected const string CONNECTION_ERROR_MESSAGE       =
			"Ошибка подключения";
		#endregion Сообщения об ошибках

		/// <summary>
		/// Атрибуты подключения
		/// </summary>
		protected ConnectionAttributes m_Attributes = new ConnectionAttributes
			( 15, ".", "Northwind", "sa", "sa", ConnectionSecurityLevel.WINDOWS );
		#endregion Поля

		/// <summary>
		/// Проверка возможности осуществеления подключения
		/// </summary>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, VOID, FAILED,
		/// INVALID_SERVER, INVALID_DATABASE,
		/// INVALID_USER_NAME_OR_PASSWORD</returns>
		public virtual OperationReport Test( )
		{
			// Локализация временных ресурсов соединения в следующем блоке,
			// гарантирующем их освобождение по его окончанию
			using ( SqlConnection locConnection = new SqlConnection
				( this.Attributes.ConnectionString( ) ) )
			{
				try
				{
					// Попытка подключения
					locConnection.Open( );
				} // try

				// Перехват ошибки при попытке подключения
				catch ( SqlException locException )
				{
					foreach ( SqlError locError in locException.Errors )
					{
						// Номер ошибки SQL Server
						switch ( locError.Number )
						{
							// Неверное имя сервера
							case 17 :
								return new OperationReport( OperationResult.INVALID_SERVER,
									ConnectionCondition.INVALID_SERVER_ERROR_MESSAGE );

							// Неверное имя базы данных
							case 4060 :
								return new OperationReport( OperationResult.INVALID_DATABASE,
									ConnectionCondition.INVALID_DATABASE_ERROR_MESSAGE );

							// Неверное имя пользователя или пароль
							case 18456 :
								return new OperationReport
									( OperationResult.INVALID_USER_NAME_OR_PASSWORD,
									ConnectionCondition.
									INVALID_USER_NAME_OR_PASSWORD_ERROR_MESSAGE );

							// Ошибка подключения
							default :
								return new OperationReport( OperationResult.FAILED,
									ConnectionCondition.CONNECTION_ERROR_MESSAGE );
						} // switch
					} // foreach
				} // catch

				// Прочие ошибки
				catch ( Exception )
				{
					// Недействительная операция
					return new OperationReport( OperationResult.VOID,
						DataContainer.VOID_OPERATION_ERROR_MESSAGE );
				} // catch
			} // using

			// Подключение состоялось
			return new OperationReport( );
		} // Test

		#region Конструкторы
		/// <summary>
		/// Создание состояния подключения по умолчанию
		/// </summary>
		public ConnectionCondition( )
		{
		} // ConnectionCondition

		/// <summary>
		/// Создание состояния подключения с заданными атрибутами
		/// </summary>
		/// <param name="parAttributes">Аттрибуты</param>
		public ConnectionCondition( ConnectionAttributes parAttributes )
		{
			this.Attributes = parAttributes;
		} // ConnectionCondition
		#endregion Конструкторы

		#region Свойства
		/// <summary>
		/// Интервал времени в секундах, в течение которого происходит попытка
		/// установки соединения с источником данных
		/// </summary>
		public virtual int ConnectTimeout
		{
			get
			{
				return this.m_Attributes.ConnectTimeout;
			} // get
			set
			{
				this.m_Attributes.ConnectTimeout = value;
			} // set
		} // ConnectTimeout

		/// <summary>
		/// Имя копии SQL Server
		/// </summary>
		public virtual string DataSource
		{
			get
			{
				return this.m_Attributes.DataSource;
			} // get
			set
			{
				this.m_Attributes.DataSource = value;
			} // set
		} // DataSource

		/// <summary>
		/// Имя базы данных
		/// </summary>
		public virtual string InitialCatalog
		{
			get
			{
				return this.m_Attributes.InitialCatalog;
			} // get
			set
			{
				this.m_Attributes.InitialCatalog = value;
			} // set
		} // InitialCatalog

		/// <summary>
		/// Идентификатор пользователя
		/// </summary>
		public virtual string UserID
		{
			get
			{
				return this.m_Attributes.UserID;
			} // get
			set
			{
				this.m_Attributes.UserID = value;
			} // set
		} // UserID

		/// <summary>
		/// Пароль
		/// </summary>
		public virtual string Password
		{
			get
			{
				return this.m_Attributes.Password;
			} // get
			set
			{
				this.m_Attributes.Password = value;
			} // set
		} // Password

		/// <summary>
		/// Уровень безопасности подключения
		/// </summary>
		public virtual ConnectionSecurityLevel SecurityLevel
		{
			get
			{
				return this.m_Attributes.SecurityLevel;
			} // get
			set
			{
				this.m_Attributes.SecurityLevel = value;
			} // set
		} // SecurityLevel

		/// <summary>
		/// Атрибуты
		/// </summary>
		public virtual ConnectionAttributes Attributes
		{
			get
			{
				return this.m_Attributes;
			} // get
			set
			{
				this.m_Attributes = value;
			} // set
		} // Attributes
		#endregion Свойства
	} // ConnectionCondition
} // MainFacilitiesUseAnalysisClient