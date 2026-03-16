using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Аргументы события выполнения редактирования документа
	/// </summary>
	public class EditDocumentEventArgs: EventArgs
	{
		#region Поля
		/// <summary>
		/// Действие редактирования
		/// </summary>
		public StoredProcedureAction Action;
		/// <summary>
		/// Название типа документа
		/// </summary>
		public string                DocumentTypeName;
		/// <summary>
		/// Название основного средства
		/// </summary>
		public string                MainFacilityName;
		/// <summary>
		/// Дата
		/// </summary>
		public string                Date;
		#endregion Поля

		/// <summary>
		/// Создание аргументов события выполнения редактирования документа
		/// </summary>
		/// </summary>
		/// <param name="parAction">Действие редактирования</param>
		/// <param name="parDocumentTypeName">Название типа документа</param>
		/// <param name="parMainFacilityName">Название основного средства</param>
		/// <param name="parDate">Дата</param>
		public EditDocumentEventArgs
		(
			StoredProcedureAction parAction,
			string                parDocumentTypeName,
			string                parMainFacilityName,
			string                parDate
		)
		{
			Action           = parAction;
			DocumentTypeName = parDocumentTypeName;
			MainFacilityName = parMainFacilityName;
			Date             = parDate;
		} // EditDocumentEventArgs
	} // EditDocumentEventArgs
} // MainFacilitiesUseAnalysisClient