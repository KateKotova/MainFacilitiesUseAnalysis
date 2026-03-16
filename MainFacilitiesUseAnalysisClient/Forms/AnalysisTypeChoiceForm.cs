using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма выбора типа анализа
	/// </summary>
	public partial class AnalysisTypeChoiceForm : Form, IEssenceForm
	{
		#region Поля
		/// <summary>
		/// Два года анализа
		/// </summary>
		protected TwoYears m_TwoYears;
		/// <summary>
		/// Признак необходимости завершения диалога выбора типа анализа
		/// </summary>
		protected bool     m_MustCloseDialog = true;
		#endregion Поля

		#region Методы
		#region Методы инициализации
		/// <summary>
		/// Инициализация формы выбора типа анализа
		/// </summary>
		protected virtual void Init( )
		{
			// Запоминание минимальных размеров формы
			System.Drawing.Size locMinimumSize = new Size( this.Width,this.Height );
			this.MinimumSize                   = locMinimumSize;
		} // Init

		/// <summary>
		/// Инициализация двух лет
		/// </summary>
		protected virtual void InitTwoYears( )
		{
			// Вид анализа
			AnalysisType locAnalysisType;
			// Название таблицы коэффициентов
			string       locCoefficientsDataSetTableName;
			// Название таблицы описания коэффициентов
			string       locCoefficientsDescriptionDataSetTableName;

			// Выбор параметров в зависимости от выбора вида анализа
			// Анализ структуры
			if ( this.m_StructureAnalysisRadioButton.Checked )
			{
				if ( this.m_CostAnalysisRadioButton.Checked )
				{
					// Анализ стоимости
					locAnalysisType                 = AnalysisType.COST;
					locCoefficientsDataSetTableName = this.m_DataSet.Cost.TableName;
					locCoefficientsDescriptionDataSetTableName =
						this.m_DataSet.CostDescription.TableName;
				} // if
				else
					if ( this.m_WeightAnalysisRadioButton.Checked )
					{
						// Анализ удельные веса
						locAnalysisType                 = AnalysisType.WEIGHT;
						locCoefficientsDataSetTableName = this.m_DataSet.Weight.TableName;
						locCoefficientsDescriptionDataSetTableName =
							this.m_DataSet.WeightDescription.TableName;
					} // if
					else
						if ( this.m_CostAndWeightAnalysisRadioButton.Checked )
						{
							// Анализ стоимости и удельные веса
							locAnalysisType = AnalysisType.COST_AND_WEIGHT;
							locCoefficientsDataSetTableName            =
								this.m_DataSet.CostAndWeight.TableName;
							locCoefficientsDescriptionDataSetTableName =
								this.m_DataSet.CostAndWeightDescription.TableName;
						} // if
						else
						{
							// Неизвестный анализ
							locAnalysisType = AnalysisType.UNKNOWN;
							locCoefficientsDataSetTableName            = string.Empty;
							locCoefficientsDescriptionDataSetTableName = string.Empty;
						} // else
			} // if
			else
			{
				if ( this.m_SupplyAnalysisRadioButton.Checked )
				{
					// Анализ коэффициентов oбecпeчeннocти
					locAnalysisType = AnalysisType.SUPPLY_COEFFICIENTS;
					locCoefficientsDataSetTableName            =
						this.m_DataSet.SupplyCoefficients.TableName;
					locCoefficientsDescriptionDataSetTableName =
						this.m_DataSet.SupplyCoefficientsDescription.TableName;
				} // if
				else
					if ( this.m_EfficiencyAnalysisRadioButton.Checked )
					{
						// Анализ коэффициентов эффeктивнocти
						locAnalysisType = AnalysisType.EFFICIENCY_COEFFICIENTS;
						locCoefficientsDataSetTableName            =
							this.m_DataSet.EfficiencyCoefficients.TableName;
						locCoefficientsDescriptionDataSetTableName =
							this.m_DataSet.EfficiencyCoefficientsDescription.TableName;
					} // if
					else
						if ( this.m_ChangeAnalysisRadioButton.Checked )
						{
							// Анализ коэффициентов измeнeния
							locAnalysisType = AnalysisType.CHANGE_COEFFICIENTS;
							locCoefficientsDataSetTableName            =
								this.m_DataSet.ChangeCoefficients.TableName;
							locCoefficientsDescriptionDataSetTableName =
								this.m_DataSet.ChangeCoefficientsDescription.TableName;
						} // if
						else
							if ( this.m_FactorsAnalysisRadioButton.Checked )
							{
								// Анализ факторов влияния
								locAnalysisType = AnalysisType.INFLUENCING_FACTORS;
								locCoefficientsDataSetTableName            =
									this.m_DataSet.InfluencingFactors.TableName;
								locCoefficientsDescriptionDataSetTableName =
									this.m_DataSet.InfluencingFactorsDescription.TableName;
							} // if
							else
							{
								// Неизвестный анализ
								locAnalysisType = AnalysisType.UNKNOWN;
								locCoefficientsDataSetTableName            = string.Empty;
								locCoefficientsDescriptionDataSetTableName = string.Empty;
							} // else
			} // else

			// Создание двух лет с заданными параметрами
			if ( this.m_TwoYears != null )
				this.m_TwoYears = null;
			this.m_TwoYears = new TwoYears( StoredProcedureAction.SET,
				 locAnalysisType, ref this.m_DataSet, locCoefficientsDataSetTableName,
				locCoefficientsDescriptionDataSetTableName );
		} // InitTwoYears
		#endregion Методы инициализации

		#region Стандартные методы
		/// <summary>
		/// Загрузка формы выбора типа анализа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void AnalysisTypeChoiceForm_Load
		(
			object sender,
			EventArgs e
		)
		{
			// Явное открытие соединения предотвратит лишние операции по неявному
			// открытию и закрытию его во время вызова метода SqlDataAdapter.Fill
			if ( DataContainer.Instance( ).CurrentSqlConnection.State !=
					ConnectionState.Open )
				DataContainer.Instance( ).CurrentSqlConnection.Open( );
		} // AnalysisTypeChoiceForm_Load

		/// <summary>
		/// Завершение работы с формой выбора типа анализа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void AnalysisTypeChoiceForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Закрытие формы зависит от корректности результата выбора типа анализа
			e.Cancel = ! this.m_MustCloseDialog;
			// Попытка совершена, и диалог может быть отменён
			// или предпринята новая попытка
			this.m_MustCloseDialog = true;
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			// DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // AnalysisTypeChoiceForm_FormClosing

		/// <summary>
		/// Смена состояния радиокнопки анализа структуры основных средств,
		/// влияющая на доступность группы радиокнопок
		/// анализа структуры основных средств доступна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void m_StructureAnalysisRadioButton_CheckedChanged
		(
			object    sender,
			EventArgs e
		)
		{
			// Подруппа радиокнопок анализа структуры основных средств доступна
			// при выборе радиокнопки анализа структуры основных средств
			// и недоступна, при снятии с неё флажка
			this.m_StructureAnalysisGroupBox.Enabled =
				this.m_StructureAnalysisRadioButton.Checked;
		} // AnalysisTypeChoiceForm
		#endregion Стандартные методы

		#region Методы обработки данных
		/// <summary>
		/// Очистка
		/// </summary>
		public virtual void Clear( )
		{
			// Очистка предупреждающих пометок полей
			m_ErrorProvider.Clear( );
			// Очистка полей параметров и установка флажка по умолчанию
			this.m_BaseYearTextBox.Text                 = string.Empty;
			this.m_AnalysedYearTextBox.Text             = string.Empty;
			this.m_StructureAnalysisRadioButton.Checked = true;
		} // Clear

		/// <summary>
		/// Загрузка параметров хранимой процедуры
		/// </summary>
		/// <returns>Отчёт операции установки с результатами: SUCCESSFUL,
		/// INVALID_BASE_YEAR, INVALID_ANALYSED_YEAR</returns>
		public virtual OperationReport LoadStoredProcedureParameters( )
		{
			// Загрузка параметров хранимой процедуры установки
			return this.m_TwoYears.LoadSetStoredProcedureParameters
				( this.m_BaseYearTextBox.Text, this.m_AnalysedYearTextBox.Text );
		} // LoadInsertStoredProcedureParameters

		/// <summary>
		/// Вывод параметров хранимой процедуры
		/// </summary>
		public virtual void OutputStoredProcedureParameters( )
		{
			// Вывод значений параметров процедуры установки в поля
			this.m_BaseYearTextBox.Text     = this.m_TwoYears.BaseYear;
			this.m_AnalysedYearTextBox.Text = this.m_TwoYears.AnalysedYear;
		} // OutputStoredProcedureParameters

		/// <summary>
		/// Выделение неверного параметра
		/// </summary>
		/// <param name="parOperationReport">Отчёт операции</param>
		public virtual void MarkInvalidParameter
			( OperationReport parOperationReport )
		{
			// Выделение поля неверного параметра процедуры установки
			switch ( parOperationReport.Result )
			{
				// Неверный базовый год
				case OperationResult.INVALID_BASE_YEAR :
					this.m_ErrorProvider.SetError( this.m_BaseYearTextBox,
						parOperationReport.Message );
					return;

				// Неверный анализируемый год
				case OperationResult.INVALID_ANALYSED_YEAR :
					this.m_ErrorProvider.SetError( this.m_AnalysedYearTextBox,
						parOperationReport.Message );
					return;

				// Прочие ошибки
				default:
					this.m_ErrorProvider.SetError( this.m_AnalyseButton,
						parOperationReport.Message );
					return;
			} // switch
		} // MarkInvalidParameter
		#endregion Методы обработки данных

		#region Конкретные методы анализа
		/// <summary>
		/// Показ диалога формы нализа
		/// </summary>
		protected virtual void ShowAnalysisFormDialog( )
		{
			// Показ диалога формы нализа в зависимости от выбранного типа анализа
			switch ( this.m_TwoYears.CurrentAnalysisType )
			{
				// Стоимости
				case AnalysisType.COST :
					new CostForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Удельные веса
				case AnalysisType.WEIGHT :
					new WeightForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Стоимости и удельные веса
				case AnalysisType.COST_AND_WEIGHT :
					new CostAndWeightForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Коэффициенты обеспеченности
				case AnalysisType.SUPPLY_COEFFICIENTS :
					new SupplyCoefficientsForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Коэффициенты эффективности
				case AnalysisType.EFFICIENCY_COEFFICIENTS :
					new EfficiencyCoefficientsForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Коэффициенты изменения
				case AnalysisType.CHANGE_COEFFICIENTS :
					new ChangeCoefficientsForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Факторы влияния
				case AnalysisType.INFLUENCING_FACTORS :
					new InfluencingFactorsForm( this.m_TwoYears ).ShowDialog( );
					break;

				// Прочие непредусмотренные типы анализа
				default :
					break;
			} // switch
		} // ShowAnalysisFormDialog

		/// <summary>
		/// Выполнение хранимой процедуры установки двух лет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_AnalyseButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			this.Cursor = Cursors.WaitCursor;
			// Диалог не может быть закрыт, пока не состоялась попытка выбора
			this.m_MustCloseDialog = false;
			// Очистка предупреждающих пометок полей
			this.m_ErrorProvider.Clear( );

			/// Инициализация двух лет
			this.InitTwoYears( );

			// Отчёт об операции загрузки параметров хранимой процедуры
			OperationReport locOperationReport =
				this.LoadStoredProcedureParameters( );

			// Если предварительная операция загрузки параметров не удачна
			if ( locOperationReport.Result != OperationResult.SUCCESSFUL )
			{
				this.Cursor = Cursors.Default;
				// Выделение неверного параметра
				this.MarkInvalidParameter( locOperationReport );
				return;
			} // if

			// Выполнение хранимой процедуры без сообщений об ошибках
			this.m_TwoYears.ExecuteStoredProcedure( ref this.m_DataSet, false );
			// Вывод параметров хранимой процедуры
			this.OutputStoredProcedureParameters( );

			// Диалог состоялся успешно и может быть закрыт
			this.m_MustCloseDialog = true;
			this.Cursor = Cursors.Default;

			// Вызов формы анализа
			this.ShowAnalysisFormDialog( );
			return;
		}// m_AnalyseButton_Click
		#endregion Конкретные методы анализа
		#endregion Методы

		/// <summary>
		/// Создание формы выбора вида аналза основных средств
		/// </summary>
		public AnalysisTypeChoiceForm( )
		{
			InitializeComponent( );
			// Инициализация формы выбора типа анализа
			this.Init( );
		} // AnalysisTypeChoiceForm
	} // ConnectionForm
} // MainFacilitiesUseAnalysisClient