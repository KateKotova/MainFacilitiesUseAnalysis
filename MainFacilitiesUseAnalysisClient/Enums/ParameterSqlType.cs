using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Sql-тип параметра
	/// </summary>
	public enum ParameterSqlType
	{
		/// <summary>
		/// Неизвестный
		/// </summary>
		UNKNOWN = -1,
		/// <summary>
		/// Неопределённый
		/// </summary>
		NONE    = 0,
		/// <summary>
		/// Строка переменной длины до 4000 символов Unicode-символов
		/// </summary>
		NVARCHAR,
		/// <summary>
		/// Целое число в диапазоне от 0 до 255
		/// </summary>
		TINYINT,
		/// <summary>
		/// Целое число в диапазоне от -2^15 (-32,768) до 2^15 - 1 (32,767)
		/// </summary>
		SMALLINT,
		/// <summary>
		/// Целое число в диапазоне от -2^31 (-2,147,483,648)
		/// до 2^31 - 1 (2,147,483,647)
		/// </summary>
		INT,
		/// <summary>
		/// Денежная величинв в диапазоне от -2^63 (-922,337,203,685,477.5808) до
		/// 2^63 - 1 (+922,337,203,685,477.5807) с точностью до десятитысячных
		/// </summary>
		MONEY
	} // ParameterSqlType
} // MainFacilitiesUseAnalysisClient