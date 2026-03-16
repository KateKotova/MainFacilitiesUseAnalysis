using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Параметр
	/// </summary>
	public class Parameter : IClearAble
	{
		#region Поля
		/// <summary>
		/// Sql-тип
		/// </summary>
		protected ParameterSqlType m_SqlType          = ParameterSqlType.NONE;
		/// <summary>
		/// Представление Sql-параметра
		/// </summary>
		protected SqlParameter     m_SqlParameterView = new SqlParameter
			( string.Empty, DBNull.Value );
		#endregion Поля

		#region Методы
		#region Методы установки значения
		/// <summary>
		/// Установка неизвестного Sql-типа и неопределённого значения
		/// </summary>
		protected virtual void SetUnknownSqlType( )
		{
			// Неизвестный Sql-тип
			this.m_SqlType                    = ParameterSqlType.UNKNOWN;
			// По умолчанию Sql-тип строковый
			this.m_SqlParameterView.SqlDbType = SqlDbType.NVarChar;
			// Неопределённое значение
			this.m_SqlParameterView.Value     = DBNull.Value;
		} // SetUnknownSqlType

		/// <summary>
		/// Установка неопределённого Sql-типа и неопределённого значения
		/// </summary>
		protected virtual void SetNoneSqlType( )
		{
			// Неопределённый Sql-тип
			this.m_SqlType                    = ParameterSqlType.NONE;
			// По умолчанию Sql-тип строковый
			this.m_SqlParameterView.SqlDbType = SqlDbType.NVarChar;
			// Неопределённое значение
			this.m_SqlParameterView.Value     = DBNull.Value;
		} // SetNoneSqlType

		/// <summary>
		/// Установка значения
		/// </summary>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED,
		/// UNKNOWN_SQL_TYPE</returns>
		public virtual OperationResult SetValue( string parValue )
		{
			try
			{
				// Замена пустой или состоящей из одних пробелов строки
				// неопределённостью для нестроковых типов
				if ( parValue.Trim( ) == string.Empty )
				{
					if ( this.m_SqlType == ParameterSqlType.NVARCHAR )
						this.m_SqlParameterView.Value = string.Empty;
					else
						this.m_SqlParameterView.Value = DBNull.Value;

					// Успешный перевод из строки в заданный тип
					return OperationResult.SUCCESSFUL;
				} // if

				// Sql-ти
				switch ( this.m_SqlType )
				{
					// Неопределённый тип
					case ParameterSqlType.NONE:
						// Установка неопределённого Sql-типа и неопределённого значения
						this.SetNoneSqlType( );
						break;

					// Строка
					case ParameterSqlType.NVARCHAR :
						this.m_SqlParameterView.Value = parValue;
						break;

					// Малое целое число
					case ParameterSqlType.TINYINT :
						this.m_SqlParameterView.Value = Convert.ToByte   ( parValue );
						break;

					// Среднее целое число
					case ParameterSqlType.SMALLINT :
						this.m_SqlParameterView.Value = Convert.ToInt16  ( parValue );
						break;

					// Целое число
					case ParameterSqlType.INT :
						this.m_SqlParameterView.Value = Convert.ToInt32  ( parValue );
						break;

					// Денежная величина
					case ParameterSqlType.MONEY :
						this.m_SqlParameterView.Value = Convert.ToDecimal( parValue );
						break;

					default :
						// Установка неизвестного Sql-типа и неопределённого значения
						this.SetUnknownSqlType( );
						// Перевод не осуществлён из-за неизвестного Sql-типа
						return OperationResult.UNKNOWN_SQL_TYPE;
				} // switch

				// Успешный перевод из строки в заданный тип
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого значения
				this.m_SqlParameterView.Value = DBNull.Value;
				// Неуспешный перевод из строки в заданный тип
				return OperationResult.FAILED;
			} // catch
		} // SetValue

		/// <summary>
		/// Очистка
		/// </summary>
		public virtual void Clear( )
		{
			// Установка пустого значения
			this.SetValue( string.Empty );
		} // Clear
		#endregion Методы установки значения

		#region Методы инициализации педставления Sql-параметра
		/// <summary>
		/// Инициализация параметра типа varchar
		/// </summary>
		/// <param name="parDirection">Направление</param>
		/// <param name="parIsNullable">
		/// Допустимость неопределённого значения</param>
		/// <param name="parSize">Длина строки</param>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED</returns>
		public virtual OperationResult InitNVarChar
		(
			ParameterDirection parDirection,
			bool               parIsNullable,
			int                parSize,
			string             parValue
		)
		{
			try
			{
				this.m_SqlParameterView.SqlDbType  = SqlDbType.NVarChar;
				this.m_SqlParameterView.Direction  = parDirection;
				this.m_SqlParameterView.IsNullable = parIsNullable;
				this.m_SqlParameterView.Size       = parSize;
				this.m_SqlType                     = ParameterSqlType.NVARCHAR;
				this.SetValue( parValue );

				// Успешная инициализация параметра
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого Sql-типа и неопределённого значения
				this.SetNoneSqlType( );
				// Неуспешная инициализация параметра
				return OperationResult.FAILED;
			} // catch
		} // InitNVarChar

		/// <summary>
		/// Инициализация параметра типа tinyint
		/// </summary>
		/// <param name="parDirection">Направление</param>
		/// <param name="parIsNullable">
		/// Допустимость неопределённого значения</param>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED</returns>
		public virtual OperationResult InitTinyInt
		(
			ParameterDirection parDirection,
			bool               parIsNullable,
			string             parValue
		)
		{
			try
			{
				this.m_SqlParameterView.SqlDbType  = SqlDbType.TinyInt;
				this.m_SqlParameterView.Direction  = parDirection;
				this.m_SqlParameterView.IsNullable = parIsNullable;
				this.m_SqlType                     = ParameterSqlType.TINYINT;
				this.SetValue( parValue );

				// Успешная инициализация параметра
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого Sql-типа и неопределённого значения
				this.SetNoneSqlType( );
				// Неуспешная инициализация параметра
				return OperationResult.FAILED;
			} // catch
		} // InitTinyInt

		/// <summary>
		/// Инициализация параметра типа smallint
		/// </summary>
		/// <param name="parDirection">Направление</param>
		/// <param name="parIsNullable">
		/// Допустимость неопределённого значения</param>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED</returns>
		public virtual OperationResult InitSmallInt
		(
			ParameterDirection parDirection,
			bool               parIsNullable,
			string             parValue
		)
		{
			try
			{
				this.m_SqlParameterView.SqlDbType  = SqlDbType.SmallInt;
				this.m_SqlParameterView.Direction  = parDirection;
				this.m_SqlParameterView.IsNullable = parIsNullable;
				this.m_SqlType                     = ParameterSqlType.SMALLINT;
				this.SetValue( parValue );

				// Успешная инициализация параметра
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого Sql-типа и неопределённого значения
				this.SetNoneSqlType( );
				// Неуспешная инициализация параметра
				return OperationResult.FAILED;
			} // catch
		} // InitSmallInt

		/// <summary>
		/// Инициализация параметра типа int
		/// </summary>
		/// <param name="parDirection">Направление</param>
		/// <param name="parIsNullable">
		/// Допустимость неопределённого значения</param>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED</returns>
		public virtual OperationResult InitInt
		(
			ParameterDirection parDirection,
			bool               parIsNullable,
			string             parValue
		)
		{
			try
			{
				this.m_SqlParameterView.SqlDbType  = SqlDbType.Int;
				this.m_SqlParameterView.Direction  = parDirection;
				this.m_SqlParameterView.IsNullable = parIsNullable;
				this.m_SqlType                     = ParameterSqlType.INT;
				this.SetValue( parValue );

				// Успешная инициализация параметра
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого Sql-типа и неопределённого значения
				this.SetNoneSqlType( );
				// Неуспешная инициализация параметра
				return OperationResult.FAILED;
			} // catch
		} // InitInt

		/// <summary>
		/// Инициализация параметра типа money
		/// </summary>
		/// <param name="parDirection">Направление</param>
		/// <param name="parIsNullable">
		/// Допустимость неопределённого значения</param>
		/// <param name="parValue">Значение</param>
		/// <returns>Отчёт операции с результатами SUCCESSFUL, FAILED</returns>
		public virtual OperationResult InitMoney
		(
			ParameterDirection parDirection,
			bool               parIsNullable,
			string             parValue
		)
		{
			try
			{
				this.m_SqlParameterView.SqlDbType  = SqlDbType.Money;
				this.m_SqlParameterView.Direction  = parDirection;
				this.m_SqlParameterView.IsNullable = parIsNullable;
				this.m_SqlParameterView.Precision  = 19;
				this.m_SqlParameterView.Scale      = 4;
				this.m_SqlType                     = ParameterSqlType.MONEY;
				this.SetValue( parValue );

				// Успешная инициализация параметра
				return OperationResult.SUCCESSFUL;
			} // try

			catch
			{
				// Установка неопределённого Sql-типа и неопределённого значения
				this.SetNoneSqlType( );
				// Неуспешная инициализация параметра
				return OperationResult.FAILED;
			} // catch
		} // InitMoney
		#endregion Методы инициализации педставления Sql-параметра
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание параметра по умолчанию
		/// </summary>
		public Parameter( )
		{
		} // Parameter

		/// <summary>
		/// Создание параметра с заданным именем
		/// </summary>
		/// <param name="parName">Имя</param>
		public Parameter( string parName )
		{
			this.m_SqlParameterView.ParameterName = parName;
		} // Parameter
		#endregion Конструкторы

		#region Свойства
		/// <summary>
		/// Sql-тип
		/// </summary>
		public virtual ParameterSqlType SqlType
		{
			get
			{
				return this.m_SqlType;
			} // get
		} // SqlType

		/// <summary>
		/// Значение Sql-параметра
		/// </summary>
		public virtual object Value
		{
			get
			{
				return this.m_SqlParameterView.Value;
			} // get
			set
			{
				this.m_SqlParameterView.Value = value;
			} // set
		} // Value

		/// <summary>
		/// Строка значения Sql-параметра
		/// </summary>
		public virtual string ValueString
		{
			get
			{
				// Если значение параметра не определено, то выводится пустая строка
				if ( this.m_SqlParameterView.Value == DBNull.Value )
					return string.Empty;
				else
					return this.m_SqlParameterView.Value.ToString( );
			} // get
		} // ValueString

		/// <summary>
		/// Представление Sql-параметра
		/// </summary>
		public virtual SqlParameter SqlParameterView
		{
			get
			{
				return this.m_SqlParameterView;
			} // get
		} // SqlParameterView
		#endregion Свойства
	} // Parameter
} // MainFacilitiesUseAnalysisClient