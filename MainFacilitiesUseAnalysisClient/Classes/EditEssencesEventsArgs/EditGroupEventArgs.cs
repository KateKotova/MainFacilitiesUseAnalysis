using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Аргументы события выполнения редактирования группы
	/// </summary>
	public class EditGroupEventArgs: EventArgs
	{
		#region Поля
		/// <summary>
		/// Действие редактирования
		/// </summary>
		public StoredProcedureAction Action;
		/// <summary>
		/// Название
		/// </summary>
		public string                Name;
		#endregion Поля

		/// <summary>
		/// Создание аргументов события выполнения редактирования группы
		/// </summary>
		/// </summary>
		/// <param name="parAction">Действие редактирования</param>
		/// <param name="parName">Название</param>
		public EditGroupEventArgs
		(
			StoredProcedureAction parAction,
			string parName
		)
		{
			Action = parAction;
			Name = parName;
		} // EditGroupEventArgs
	} // EditGroupEventArgs
} // MainFacilitiesUseAnalysisClient