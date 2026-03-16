using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Действие хранимой процедуры
	/// </summary>
	public enum StoredProcedureAction
	{
		/// <summary>
		/// Неизвестное
		/// </summary>
		UNKNOWN = -1,
		/// <summary>
		/// Показ
		/// </summary>
		SHOW    = 0,
		/// <summary>
		/// Установка
		/// </summary>
		SET,
		/// <summary>
		/// Добавление
		/// </summary>
		INSERT,
		/// <summary>
		/// Обновление
		/// </summary>
		UPDATE,
		/// <summary>
		/// Удаление
		/// </summary>
		DELETE
	} // StoredProcedureAction
} // MainFacilitiesUseAnalysisClient