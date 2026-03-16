using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainFacilitiesUseAnalysisClient
{
	/// <summary>
	/// Форма анализа коэффициентов обеспеченности
	/// </summary>
	public partial class SupplyCoefficientsForm : Form
	{
		#region Поля
		/// <summary>
		/// Сущность двух лет
		/// </summary>
		protected TwoYears m_TwoYears;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Загрузка формы анализа коэффициентов обеспеченности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void SupplyCoefficientsForm_Load
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
			// Заполнение множества данных
			// согласно установленным параметрам двух лет
			this.m_TwoYears.RefreshSqlDataAdapters( ref this.m_DataSet );
		} // SupplyCoefficientsForm_Load

		/// <summary>
		/// Завершение работы с формой анализа коэффициентов обеспеченности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void SupplyCoefficientsForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // SupplyCoefficientsForm_FormClosing
		#endregion Методы

		/// <summary>
		/// Создание формы анализа коэффициентов обеспеченности
		/// </summary>
		/// <param name="parTwoYears">Два года</param>
		public SupplyCoefficientsForm( TwoYears parTwoYears )
		{
			InitializeComponent( );

			// Изменение шрифта шапок таблиц
			this.m_SupplyCoefficientsDataGridView.ColumnHeadersDefaultCellStyle.
				Font.Dispose( );
			this.m_SupplyCoefficientsDescriptionDataGridView.
				ColumnHeadersDefaultCellStyle.Font.Dispose( );
			this.m_SupplyCoefficientsDataGridView.ColumnHeadersDefaultCellStyle.
				Font = DataContainer.Instance( ).DataGridViewColumnHeadersFont;
			this.m_SupplyCoefficientsDescriptionDataGridView.
				ColumnHeadersDefaultCellStyle.Font =
				DataContainer.Instance( ).DataGridViewColumnHeadersFont;

			// Инициализация сущност двух лет
			this.m_TwoYears = parTwoYears;
			// Показ базового и нализируемого года
			this.m_TwoYearsToolStripLabel.Text = this.m_TwoYears.BaseYear +
				DataContainer.DASH_STRING + this.m_TwoYears.AnalysedYear;
		} // SupplyCoefficientsForm
	} // SupplyCoefficientsForm
} // MainFacilitiesUseAnalysisClient