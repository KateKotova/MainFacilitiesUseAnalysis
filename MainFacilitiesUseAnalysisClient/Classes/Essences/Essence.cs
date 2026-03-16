using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Сущность
	/// </summary>
	public abstract class Essence : IClearAble
	{
		#region Поля
		/// <summary>
		/// Заголовок сущности
		/// </summary>
		public const string ESSENCE_CAPTION = "Сущность";
		/// <summary>
		/// Текщее действие хранимой процедуры
		/// </summary>
		public readonly StoredProcedureAction CurrentAction;

		#region Заголовки действий
		/// <summary>
		/// Заголовок действия показа
		/// </summary>
		protected const string SHOW_ACTION_CAPTION   = "Показать";
		/// <summary>
		/// Заголовок действия установки
		/// </summary>
		protected const string SET_ACTION_CAPTION    = "Установить";
		/// <summary>
		/// Заголовок действия добавления
		/// </summary>
		protected const string INSERT_ACTION_CAPTION = "Добавить";
		/// <summary>
		/// Заголовок действия обновления
		/// </summary>
		protected const string UPDATE_ACTION_CAPTION = "Обновить";
		/// <summary>
		/// Заголовок действия удаления
		/// </summary>
		protected const string DELETE_ACTION_CAPTION = "Удалить";
		#endregion Заголовки действий

		#region Названия хранимых процедур
		/// <summary>
		/// Название хранимой процедуры показа
		/// </summary>
		public const string    SHOW_STORED_PROCEDURE_NAME   = null;

		/// <summary>
		/// Название хранимой процедуры установки
		/// </summary>
		protected const string SET_STORED_PROCEDURE_NAME    = null;
		/// <summary>
		/// Название хранимой процедуры добавления
		/// </summary>
		protected const string INSERT_STORED_PROCEDURE_NAME = null;
		/// <summary>
		/// Название хранимой процедуры обновления
		/// </summary>
		protected const string UPDATE_STORED_PROCEDURE_NAME = null;
		/// <summary>
		/// Название хранимой процедуры удаления
		/// </summary>
		protected const string DELETE_STORED_PROCEDURE_NAME = null;
		#endregion Названия хранимых процедур
		#endregion Поля

		#region Методы
		#region Методы инициализации и очистки
		/// <summary>
		/// Заполнение адаптеров Sql-данных
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		public abstract void FillSqlDataAdapters
			( ref MainFacilitiesUseAnalysisDataSet parDataSet );

		/// <summary>
		/// Обновление данных адаптеров Sql-данных
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		public virtual void RefreshSqlDataAdapters
			( ref MainFacilitiesUseAnalysisDataSet parDataSet )
		{
			// Очиста необходима, так как метод SqlDataAdapter.Fill
			// не удаляет строки, удалёные из базы данных без вмешательства
			// данного приложения, хотя при вызове "поверх" существующих строк,
			// обновляет их содержимое в соответствии с первичным ключом
			parDataSet.Clear( );
			// Заполнение адаптеров Sql-данных
			this.FillSqlDataAdapters( ref parDataSet );
		} // RefreshSqlDataAdapters

		/// <summary>
		/// Инициализация
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		public virtual void Init
			( ref MainFacilitiesUseAnalysisDataSet parDataSet )
		{
			// Заполнение адаптеров Sql-данных
			this.FillSqlDataAdapters( ref parDataSet );
		} // Init

		/// <summary>
		/// Очистка
		/// </summary>
		public virtual void Clear( )
		{
		} // Clear
		#endregion Методы инициализации и очистки

		#region Методы добавления и вывода параметров хранимых процедур
		/// <summary>
		/// Добавление параметров хранимой процедуры
		/// </summary>
		/// <param name="parStoredProcedure">Хранимая процедура</param>
		protected abstract void AddStoredProcedureParameters
			( ref SqlCommand parStoredProcedure );

		/// <summary>
		/// Вывод параметров хранимой процедуры
		/// </summary>
		/// <param name="parStoredProcedure">Хранимая процедура</param>
		protected abstract void OutputStoredProcedureParameters
			( SqlCommand parStoredProcedure );
		#endregion Методы добавления и вывода параметров хранимых процедур

		#region Методы выполнения хранимых процедур
		/// <summary>
		/// Выполнение хранимой процедуры
		/// </summary>
		/// <param name="parDataSet">Множество данных</param>
		/// <param name="parErrorsMessagesAreUsed">
		/// Признак использования сообщений об ошибках</param>
		public virtual void ExecuteStoredProcedure
		(
			ref MainFacilitiesUseAnalysisDataSet parDataSet,
			bool                                 parErrorsMessagesAreUsed
		)
		{
			// Название хранимой процедуры
			string locStoredProcedureName = this.CurrentActionStoredProcedureName;

			using ( SqlCommand locCommand = new SqlCommand( locStoredProcedureName,
				DataContainer.Instance( ).CurrentSqlConnection ) )
			{
				// Команда выполняет хранимую процедуру
				locCommand.CommandType               = CommandType.StoredProcedure;
				// Хранимая процедура
				SqlCommand locStoredProcedureCommand = locCommand;

				try
				{
					// Запись параметров
					this.AddStoredProcedureParameters( ref locStoredProcedureCommand );

					// Если используются сообщения об ошибках,
					// то они добавляются в качестве параметров
					if ( parErrorsMessagesAreUsed )
					{
						// Краткое сообщение об ошибке
						locStoredProcedureCommand.Parameters.Add
							( DataContainer.Instance( ).ShortErrorMessageParameter );
						// Системное сообщение об ошибке
						locStoredProcedureCommand.Parameters.Add
							( DataContainer.Instance( ).SystemErrorMessageParameter );
						// Код ошибки
						locStoredProcedureCommand.Parameters.Add
							( DataContainer.Instance( ).ErrorCodeParameter );
					} // if

					// Признак желательности обновления адаптеров Sql-данных
					// в случае такой возможности
					bool locShouldRefreshSqlDataAdapters = false;
					// Выполенине команды
					using ( SqlDataReader locReader =
						locStoredProcedureCommand.ExecuteReader( ) )
					{
						// Чтение первой записи
						locReader.Read( );
						// Вывод параметров
						OutputStoredProcedureParameters( locStoredProcedureCommand );
						// Необходимость обновления адаптеров Sql-данных
						// в случае заведомо безошибочной или удачной операции
						if ( ( ! parErrorsMessagesAreUsed ) ||
								( Convert.ToInt32( DataContainer.Instance( ).
								ErrorCodeParameter.Value ) == 0 ) )
							locShouldRefreshSqlDataAdapters = true;

						// Окончание чтения
						locReader.Close( );
					} // using

					// Очистка параметров команды необходима, ибо при повторной
					// попытке будет сигнал существования вышеуказанных параметров
					locStoredProcedureCommand.Parameters.Clear( );
					locStoredProcedureCommand.Dispose( );

					// Обновление адаптеров Sql-данных в случае необходимости
					// и возсожности
					if ( locShouldRefreshSqlDataAdapters )
						this.RefreshSqlDataAdapters( ref parDataSet );
				} // try

				// Недействительная операция
				catch
				{
					MessageBox.Show( DataContainer.VOID_OPERATION_ERROR_MESSAGE,
						DataContainer.ERROR_MESSAGE_CAPTION, MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				} // catch
			} // using
		} // ExecuteStoredProcedure
		#endregion Методы выполнения хранимых процедур
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание сущности по умолчанию
		/// </summary>
		public Essence( )
		{
			// Установка неизвестного текущего действия
			this.CurrentAction = StoredProcedureAction.UNKNOWN;
		} // Essence

		/// <summary>
		/// Создание сущности с заданным действием хранимой процедуры
		/// </summary>
		/// <param name="parAction">Действие</param>
		/// <param name="parDataSet">Множество данных</param>
		public Essence
		(
			StoredProcedureAction                parAction,
			ref MainFacilitiesUseAnalysisDataSet parDataSet
		)
		{
			// Установка текущего действия
			this.CurrentAction = parAction;
			// Инициализация
			this.Init( ref parDataSet );
		} // Essence
		#endregion Конструкторы

		#region Свойства
		/// <summary>
		/// Заголовок текущего действия
		/// </summary>
		public virtual string CurrentActionCaption
		{
			get
			{
				switch ( this.CurrentAction )
				{
					// Показ
					case StoredProcedureAction.SHOW :
						return Essence.SHOW_ACTION_CAPTION;

					// Установка
					case StoredProcedureAction.SET :
						return Essence.SET_ACTION_CAPTION;

					// Добавление
					case StoredProcedureAction.INSERT :
						return Essence.INSERT_ACTION_CAPTION;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return Essence.UPDATE_ACTION_CAPTION;

					// Удаление
					case StoredProcedureAction.DELETE :
						return Essence.DELETE_ACTION_CAPTION;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionCaption

		/// <summary>
		/// Название хранимой процедуры текущего действия
		/// </summary>
		public virtual string CurrentActionStoredProcedureName
		{
			get
			{
				switch ( this.CurrentAction )
				{
					// Показ
					case StoredProcedureAction.SHOW :
						return Essence.SHOW_STORED_PROCEDURE_NAME;

					// Установка
					case StoredProcedureAction.SET :
						return Essence.SET_STORED_PROCEDURE_NAME;

					// Добавление
					case StoredProcedureAction.INSERT :
						return Essence.INSERT_STORED_PROCEDURE_NAME;

					// Обновление
					case StoredProcedureAction.UPDATE :
						return Essence.UPDATE_STORED_PROCEDURE_NAME;

					// Удаление
					case StoredProcedureAction.DELETE :
						return Essence.DELETE_STORED_PROCEDURE_NAME;

					// Прочие непредусмотренные процедуры
					default :
						return string.Empty;
				} // switch
			} // get
		} // CurrentActionStoredProcedureName
		#endregion Свойства
	} // Essence
} // MainFacilitiesUseAnalysisClient