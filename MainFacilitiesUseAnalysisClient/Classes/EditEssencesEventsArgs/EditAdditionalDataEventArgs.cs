using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Аргументы события выполнения редактирования дополнительных данных
	/// </summary>
	public class EditAdditionalDataEventArgs: EventArgs
	{
		#region Поля
		/// <summary>
		/// Действие редактирования
		/// </summary>
		public StoredProcedureAction Action;
		/// <summary>
		/// Год
		/// </summary>
		public string                Year;
		#endregion Поля

		/// <summary>
		/// Создание аргументов события выполнения редактирования
		/// дополнительных данных
		/// </summary>
		/// </summary>
		/// <param name="parAction">Действие редактирования</param>
		/// <param name="parYear">Год</param>
		public EditAdditionalDataEventArgs
		(
			StoredProcedureAction parAction,
			string                parYear
		)
		{
			Action = parAction;
			Year   = parYear;
		} // EditAdditionalDataEventArgs
	} // EditAdditionalDataEventArgs
} // MainFacilitiesUseAnalysisClient