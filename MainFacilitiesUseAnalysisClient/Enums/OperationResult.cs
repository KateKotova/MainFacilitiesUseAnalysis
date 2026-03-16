using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Результат операции
	/// </summary>
	public enum OperationResult
	{
		/// <summary>
		/// Неизвестный
		/// </summary>
		UNKNOWN    = -1,
		/// <summary>
		/// Успешный
		/// </summary>
		SUCCESSFUL = 0,
		/// <summary>
		/// Недействительный
		/// </summary>
		VOID,
		/// <summary>
		/// Неудачный
		/// </summary>
		FAILED,
		/// <summary>
		/// Неверный сервер
		/// </summary>
		INVALID_SERVER,
		/// <summary>
		/// Неверная база данных
		/// </summary>
		INVALID_DATABASE,
		/// <summary>
		/// Неверное имя пользователя или пароль
		/// </summary>
		INVALID_USER_NAME_OR_PASSWORD,
		/// <summary>
		/// Неизвестный Sql-тип
		/// </summary>
		UNKNOWN_SQL_TYPE,
		/// <summary>
		/// Неверное название
		/// </summary>
		INVALID_NAME,
		/// <summary>
		/// Неверное прежнее название
		/// </summary>
		INVALID_OLD_NAME,
		/// <summary>
		/// Неверное название типа производственности
		/// </summary>
		INVALID_PRODUCTION_TYPE_NAME,
		/// <summary>
		/// Неверное название типа активности
		/// </summary>
		INVALID_ACTIVITY_TYPE_NAME,
		/// <summary>
		/// Неверный инвентарный номер
		/// </summary>
		INVALID_INVENTORY_NUMBER,
		/// <summary>
		/// Неверное название группы
		/// </summary>
		INVALID_GROUP_NAME,
		/// <summary>
		/// Неверное название типа
		/// </summary>
		INVALID_TYPE_NAME,
		/// <summary>
		/// Неверное старое название типа
		/// </summary>
		INVALID_OLD_TYPE_NAME,
		/// <summary>
		/// Неверное название основного средства
		/// </summary>
		INVALID_MAIN_FACILITY_NAME,
		/// <summary>
		/// Неверное старое название основного средства
		/// </summary>
		INVALID_OLD_MAIN_FACILITY_NAME,
		/// <summary>
		/// Неверный год
		/// </summary>
		INVALID_YEAR,
		/// <summary>
		/// Неверный старый год
		/// </summary>
		INVALID_OLD_YEAR,
		/// <summary>
		/// Неверный месяц
		/// </summary>
		INVALID_MONTH,
		/// <summary>
		/// Неверный старый месяц
		/// </summary>
		INVALID_OLD_MONTH,
		/// <summary>
		/// Неверный день
		/// </summary>
		INVALID_DAY,
		/// <summary>
		/// Неверный старый день
		/// </summary>
		INVALID_OLD_DAY,
		/// <summary>
		/// Неверная соимость
		/// </summary>
		INVALID_COST,
		/// <summary>
		/// Неверный объём выпуска продукции
		/// </summary>
		INVALID_PRODUCTION_OUTPUT_AMOUNT,
		/// <summary>
		/// Неверный объём реализованной продукции
		/// </summary>
		INVALID_MARKETED_PRODUCTION_AMOUNT,
		/// <summary>
		/// Неверная себестоимость продукции
		/// </summary>
		INVALID_PRODUCTION_PRIME_COST,
		/// <summary>
		/// Неверная общая выручка
		/// </summary>
		INVALID_TOTAL_RECEIPTS,
		/// <summary>
		/// Неверное среднегодовое количество действующего оборудования
		/// </summary>
		INVALID_ACTING_EQUIPMENT_ANNUAL_AVERAGE_AMOUNT,
		/// <summary>
		/// Неверное количество часов, отработанных единицей оборудования
		/// </summary>
		INVALID_EQUIPMENT_UNIT_PERFECTED_HOURS,
		/// <summary>
		/// Неверное количество дней, отработанных единицей оборудования
		/// </summary>
		INVALID_EQUIPMENT_UNIT_PERFECTED_DAYS,
		/// <summary>
		/// Неверное количество смен, отработанных единицей оборудования
		/// </summary>
		INVALID_EQUIPMENT_UNIT_PERFECTED_CHANGES,
		/// <summary>
		/// Неверный базовый год
		/// </summary>
		INVALID_BASE_YEAR,
		/// <summary>
		/// Неверный анализируемый год
		/// </summary>
		INVALID_ANALYSED_YEAR
	} // OperationResult
} // MainFacilitiesUseAnalysisClient