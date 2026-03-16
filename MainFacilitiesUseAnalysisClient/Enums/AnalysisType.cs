using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Вид анализа
	/// </summary>
	public enum AnalysisType
	{
		/// <summary>
		/// Неизвестный
		/// </summary>
		UNKNOWN = -1,
		/// <summary>
		/// Стоимости
		/// </summary>
		COST    = 0,
		/// <summary>
		/// Удельные веса
		/// </summary>
		WEIGHT,
		/// <summary>
		/// Стоимости и удельные веса
		/// </summary>
		COST_AND_WEIGHT,
		/// <summary>
		/// Коэффициенты oбecпeчeннocти
		/// </summary>
		SUPPLY_COEFFICIENTS,
		/// <summary>
		/// Коэффициенты эффeктивнocти
		/// </summary>
		EFFICIENCY_COEFFICIENTS,
		/// <summary>
		/// Коэффициенты измeнeния
		/// </summary>
		CHANGE_COEFFICIENTS,
		/// <summary>
		/// Факторы влияния
		/// </summary>
		INFLUENCING_FACTORS
	} // AnalysisType
} // MainFacilitiesUseAnalysisClient