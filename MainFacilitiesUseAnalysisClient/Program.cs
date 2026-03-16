using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Программа
	/// </summary>
	static class Program
	{
		/// <summary>
		/// Главная точка запуска приложенияч
		/// </summary>
		[STAThread]
		static void Main( )
		{
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );

			// Отображение главной формы в случае удачного подключения
			if ( new ConnectionForm( ).ShowDialog( ) == DialogResult.OK )
			{
				Application.Run( new ShowTablesForm( ) );
				//new EditGroupForm( StoredProcedureAction.INSERT ).ShowDialog( );
				//new EditGroupForm( StoredProcedureAction.UPDATE ).ShowDialog( );
				//new EditGroupForm( StoredProcedureAction.DELETE ).ShowDialog( );
			} // if
		} // Main
	} // Program
} // MainFacilitiesUseAnalysisClient