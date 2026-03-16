using System;
using System.Collections.Generic;
using System.Text;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Отчёт операции
	/// </summary>
	public class OperationReport : IClearAble
	{
		#region Поля
		/// <summary>
		/// Результат
		/// </summary>
		protected OperationResult m_Result  = OperationResult.SUCCESSFUL;
		/// <summary>
		/// Сообщение
		/// </summary>
		protected string          m_Message = string.Empty;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Признак совершения очистки сообщения успешной операции
		/// </summary>
		protected virtual bool IsClearedSuccessfulResultMessage( )
		{
			// Если операция успешна, то строка сообщения очищается
			if ( this.m_Result == OperationResult.SUCCESSFUL )
			{
				this.m_Message = string.Empty;
				return true;
			} // if
			else
				return false;
		} // IsClearedSuccessfulResultMessage

		/// <summary>
		/// Очистка
		/// </summary>
		public virtual void Clear( )
		{
			// Успешный резльтат и пустое сообщение
			this.Result = OperationResult.SUCCESSFUL;
		} // Clear
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание отчёта операции по умолчанию
		/// </summary>
		public OperationReport( )
		{
		} // OperationReport

		/// <summary>
		/// Создание отчёта операции с заданным результатом
		/// и сообщением по умолчанию
		/// </summary>
		/// <param name="parResult">Результат</param>
		public OperationReport( OperationResult parResult )
		{
			this.Result = parResult;
		} // OperationReport

		/// <summary>
		/// Создание отчёта операции с заданными результатом и сообщением
		/// </summary>
		/// <param name="parResult">Результат</param>
		/// <param name="parMessage">Сообщение</param>
		public OperationReport
		(
			OperationResult parResult,
			string          parMessage
		)
		{
			this.Result  = parResult;
			this.Message = parMessage;
		} // OperationReport
		#endregion Конструкторы

		#region Свойства
		/// <summary>
		/// Результат
		/// </summary>
		public virtual OperationResult Result
		{
			get
			{
				return this.m_Result;
			} // get
			set
			{
				this.m_Result = value;
				// Если операция успешна, то строка сообщения очищается
				this.IsClearedSuccessfulResultMessage( );
			} // set
		} // Result

		/// <summary>
		/// Сообщение
		/// </summary>
		public virtual string Message
		{
			get
			{
				return this.m_Message;
			} // get
			set
			{
				// Если операция успешна, то строка сообщения очищается,
				// иначе просто удаляются ведущие и завершающие пробелы
				if ( ! this.IsClearedSuccessfulResultMessage( ) )
					this.m_Message = value.Trim( );
			} // set
		} // Message
		#endregion Свойства
	} // OperationReport
} // MainFacilitiesUseAnalysisClient