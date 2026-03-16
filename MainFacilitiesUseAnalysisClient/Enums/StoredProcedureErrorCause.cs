using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Причина ошибки хранимой процедуры
	/// </summary>
	public enum StoredProcedureErrorCause
	{
		/// <summary>
		/// -1 - неизвестная
		/// </summary>
		UNKNOWN = -1,
		/// <summary>
		/// 0 - отсутствующая
		/// </summary>
		NONE    = 0,
		/// <summary>
		/// 1 - добавление записи
		/// </summary>
		ROW_INSERT,
		/// <summary>
		/// 2 - обновление записи
		/// </summary>
		ROW_UPDATE,
		/// <summary>
		/// 3 - удаление записи
		/// </summary>
		ROW_DELETE,
		/// <summary>
		/// 4 - пустое название
		/// </summary>
		EMPTY_NAME,
		/// <summary>
		/// 5 - существование названия
		/// </summary>
		NAME_EXISTENCE,
		/// <summary>
		/// 6 - отсутствие названия
		/// </summary>
		NAME_ABSENCE,
		/// <summary>
		/// 7 - отсутствие названия типа производственности
		/// </summary>
		PRODUCTION_TYPE_NAME_ABSENCE,
		/// <summary>
		/// 8 - отсутствие названия типа активности
		/// </summary>
		ACTIVITY_TYPE_NAME_ABSENCE,
		/// <summary>
		/// 9 - пустое прежнее название
		/// </summary>
		EMPTY_OLD_NAME,
		/// <summary>
		/// 10 - отсутствие прежнего названия
		/// </summary>
		OLD_NAME_ABSENCE,
		/// <summary>
		/// 11 - пустое название группы
		/// </summary>
		EMPTY_GROUP_NAME,
		/// <summary>
		/// 12 - отсутствие названия группы
		/// </summary>
		GROUP_NAME_ABSENCE,
		/// <summary>
		/// 13 - пустое название типа документа
		/// </summary>
		EMPTY_DOCUMENT_TYPE_NAME,
		/// <summary>
		/// 14 - отсутствие названия типа документа
		/// </summary>
		DOCUMENT_TYPE_NAME_ABSENCE,
		/// <summary>
		/// 15 - пустое название основного средства
		/// </summary>
		EMPTY_MAIN_FACILITY_NAME,
		/// <summary>
		/// 16 - отсутствие названия основного средства
		/// </summary>
		MAIN_FACILITY_NAME_ABSENCE,
		/// <summary>
		/// 17 - некорректная дата
		/// </summary>
		INCORRECT_DATE,
		/// <summary>
		/// 18 - существование набора названия типа документа,
		/// названия основного средства и даты
		/// </summary>
		DOCUMENT_TYPE_NAME_MAIN_FACILITY_NAME_DATE_EXISTENCE,
		/// <summary>
		/// 19 - пустое прежнее название типа документа
		/// </summary>
		EMPTY_OLD_DOCUMENT_TYPE_NAME,
		/// <summary>
		/// 20 - отсутствие прежнего названия типа документа
		/// </summary>
		OLD_DOCUMENT_TYPE_NAME_ABSENCE,
		/// <summary>
		/// 21 - пустое прежнее название основного средства
		/// </summary>
		EMPTY_OLD_MAIN_FACILITY_NAME,
		/// <summary>
		/// 22 - отсутствие прежнего названия основного средства
		/// </summary>
		OLD_MAIN_FACILITY_NAME_ABSENCE,
		/// <summary>
		/// 23 - некорректная прежняя дата
		/// </summary>
		INCORRECT_OLD_DATE,
			/// <summary>
		/// 24 - отсутствие набора названия типа документа,
		/// названия основного средства и даты
		/// </summary>
		DOCUMENT_TYPE_NAME_MAIN_FACILITY_NAME_DATE_ABSENCE,
		/// <summary>
		/// 25 - существование года
		/// </summary>
		YEAR_EXISTENCE,
		/// <summary>
		/// 26 - неопределённость года
		/// </summary>
		YEAR_UNCERTAINTY,
		/// <summary>
		/// 27 - неопределённость прежнего года
		/// </summary>
		OLD_YEAR_UNCERTAINTY,
		/// <summary>
		/// 28 - отсутствие прежнего года
		/// </summary>
		OLD_YEAR_ABSENCE,
		/// <summary>
		/// 29 - отсутствие года
		/// </summary>
		YEAR_ABSENCE
	} // StoredProcedureErrorCause
} // MainFacilitiesUseAnalysisClient