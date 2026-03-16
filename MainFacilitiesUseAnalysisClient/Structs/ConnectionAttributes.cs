using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Атрибуты подключения
	/// </summary>
	public struct ConnectionAttributes
	{
		#region Поля
		/// <summary>
		/// Интервал времени в секундах, в течение которого
		/// происходит попытка установки соединения с источником данных
		/// </summary>
		public int                     ConnectTimeout;
		/// <summary>
		/// Имя копии SQL Server
		/// </summary>
		public string                  DataSource;
		/// <summary>
		/// Имя базы данных
		/// </summary>
		public string                  InitialCatalog;
		/// <summary>
		/// Идентификатор пользователя
		/// </summary>
		public string                  UserID;
		/// <summary>
		/// Пароль
		/// </summary>
		public string                  Password;
		/// <summary>
		/// Уровень безопасности подключения
		/// </summary>
		public ConnectionSecurityLevel SecurityLevel;
		#endregion Поля

		/// <summary>
		/// Строка подключения
		/// </summary>
		/// <returns>Строка подключения, построенная из полей структуры</returns>
		public string ConnectionString( )
		{
			// Построение строки подключения
			SqlConnectionStringBuilder locStringBuilder =
				new SqlConnectionStringBuilder( );
			locStringBuilder.ConnectTimeout             = this.ConnectTimeout;
			locStringBuilder.DataSource                 = this.DataSource;
			locStringBuilder.InitialCatalog             = this.InitialCatalog;

			// Если аутентификация назначена на уровне SQL Server,
			// то задаются имя пользователя и пароль
			if ( this.SecurityLevel == ConnectionSecurityLevel.DATABASE )
			{
				locStringBuilder.UserID             = this.UserID;
				locStringBuilder.Password           = this.Password;
				locStringBuilder.IntegratedSecurity = false;
			} // if
			// Иначе уровень безопасности подключения считается
			// на уровне системы Windows
			else
			{
				this.SecurityLevel                  = ConnectionSecurityLevel.WINDOWS;
				locStringBuilder.IntegratedSecurity = true;
			} // else

			return locStringBuilder.ConnectionString;
		} // ConnectionString

		/// <summary>
		/// Создание атрибутов подключения
		/// </summary>
		/// <param name="parConnectTimeout">Интервал времени в секундах,
		/// в течение которого происходит попытка
		/// установки соединения с источником данных</param>
		/// <param name="parDataSource">Имя копии SQL Server</param>
		/// <param name="parInitialCatalog">Имя базы данных</param>
		/// <param name="parUserID">Идентификатор пользователя</param>
		/// <param name="parPassword">Пароль</param>
		/// <param name="parSecurityLevel">
		/// Уровень безопасности подключения</param>
		public ConnectionAttributes
		(
			int                     parConnectTimeout,
			string                  parDataSource,
			string                  parInitialCatalog,
			string                  parUserID,
			string                  parPassword,
			ConnectionSecurityLevel parSecurityLevel
		)
		{
			this.ConnectTimeout = parConnectTimeout;
			this.DataSource     = parDataSource;
			this.InitialCatalog = parInitialCatalog;
			this.UserID         = parUserID;
			this.Password       = parPassword;
			this.SecurityLevel  = parSecurityLevel;
		} // ConnectionParameters
	} // ConnectionAttributes
} // MainFacilitiesUseAnalysisClient