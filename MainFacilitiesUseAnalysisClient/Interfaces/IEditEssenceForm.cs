using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма редактирования сущности
	/// </summary>
	public interface IEditEssenceForm : IEssenceForm
	{
		/// <summary>
		/// Инициализация формы редактирования сущности
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры</param>
		void Init( StoredProcedureAction parAction );

		/// <summary>
		/// Выполнение хранимой процедуры редактирования сущности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void m_ExecuteButton_Click
		(
			object sender,
			EventArgs e
		); // m_ExecuteButton_Click
	} // IEditEssenceForm
} // MainFacilitiesUseAnalysisClient