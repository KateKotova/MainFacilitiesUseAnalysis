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
	/// Форма показа сообщений
	/// </summary>
	public partial class MessageForm : Form
	{
		#region Поля
		/// <summary>
		/// Строка символа показа детализированного сообщения
		/// </summary>
		protected const string m_ShowDetailsSymbol = " >>";
		/// <summary>
		/// Строка символа сокрытия детализированного сообщения
		/// </summary>
		protected const string m_HideDetailsSymbol = " <<";

		/// <summary>
		/// Высота окошка отображаемого детализированного сообщения
		/// </summary>
		protected const int m_ShownDetailsMessageRichTextBoxHeight = 120;
		/// <summary>
		/// Высота отображаемого ботрика-перегородки на форме
		/// </summary>
		protected const int m_BorderHeight = 10;

		/// <summary>
		/// Признак показа детализированного сообщения
		/// </summary>
		protected bool   m_DetailsAreShown;
		/// <summary>
		/// Основная надпись на кнопке деталей
		/// </summary>
		protected string m_BaseDetailsButtonText;
		#endregion Поля

		#region Методы
		/// <summary>
		/// Загрузка формы сообщений
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void MessageForm_Load
		(
			object sender,
			EventArgs e
		)
		{
			// Вначале детали не показываются
			this.m_DetailsAreShown = false;

			// Сокрытие окошка детализированного сообщения
			this.m_DetailsMessageRichTextBox.Visible = false;
			// Сжатие высоты формы на высоту области окна деталей
			// и бортика-перегородки перед ним
			this.Height -= Convert.ToInt32
				( this.m_AllFormTableLayoutPanel.RowStyles[ 2 ].Height +
				this.m_AllFormTableLayoutPanel.RowStyles[ 3 ].Height );
			// Сжатие области окна деталей и бортика-перегородки перед ним
			this.m_AllFormTableLayoutPanel.RowStyles[ 2 ].Height = 0;
			this.m_AllFormTableLayoutPanel.RowStyles[ 3 ].Height = 0;

			// Если детализированное сообщение пусто,
			// то нет смысла отображатье его атрибуты
			if ( this.m_DetailsMessageRichTextBox.Text == string.Empty )
				this.m_DetailsButton.Visible = false;
			else
			{
				// Базовая надпись на кнопке деталей
				this.m_BaseDetailsButtonText = this.m_DetailsButton.Text;
				// Изменение подписи на кнопке деталей: разрешение показа
				this.m_DetailsButton.Text   += MessageForm.m_ShowDetailsSymbol;
			} // else
		} // m_DetailsButton_Click

		/// <summary>
		/// Показ\сокрытие детализированного сообщения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_DetailsButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Отрицание прежнего значения признака
			// показа детализированного сообщения
			this.m_DetailsAreShown = ! this.m_DetailsAreShown;

			// Если детали отображаются
			if ( this.m_DetailsAreShown )
			{
				// Разжатие высоты формы на высоту отображения окошка и бортика
				this.Height               += MessageForm.m_BorderHeight +
					MessageForm.m_ShownDetailsMessageRichTextBoxHeight;
				// Показ области окна деталей и бортика-перегородки перед ним
				this.m_AllFormTableLayoutPanel.RowStyles[ 2 ].Height =
					MessageForm.m_BorderHeight;
				this.m_AllFormTableLayoutPanel.RowStyles[ 3 ].Height =
					MessageForm.m_ShownDetailsMessageRichTextBoxHeight;
				// Показ окошка детализированного сообщения
				this.m_DetailsMessageRichTextBox.Visible = true;

				// Изменение подписи на кнопке деталей: разрешение сокрытия
				this.m_DetailsButton.Text  = this.m_BaseDetailsButtonText +
					MessageForm.m_HideDetailsSymbol;
			} // if
			else
			{
				// Сокрытие окошка детализированного сообщения
				this.m_DetailsMessageRichTextBox.Visible = false;
				// Сжатие области окна деталей и бортика-перегородки перед ним
				this.m_AllFormTableLayoutPanel.RowStyles[ 2 ].Height = 0;
				this.m_AllFormTableLayoutPanel.RowStyles[ 3 ].Height = 0;
				// Сжатие высоты формы на высоту отображения
				// скрываемого окошка и бортика
				this.Height               -= MessageForm.m_BorderHeight +
					MessageForm.m_ShownDetailsMessageRichTextBoxHeight;

				// Изменение подписи на кнопке деталей: разрешение показа
				this.m_DetailsButton.Text  = this.m_BaseDetailsButtonText +
					MessageForm.m_ShowDetailsSymbol;
			} // else
		} // m_DetailsButton_Click
		#endregion Методы

		#region Конструкторы
		/// <summary>
		/// Создание формы сообщений по умолчаию
		/// </summary>
		public MessageForm( )
		{
			// Инициализация компонентоа
			InitializeComponent( );
		} // MessageForm

		/// <summary>
		/// Создание формы сообщений с заданным кратким сообщением
		/// и детализированным по умолчанию
		/// </summary>
		/// <param name="parShortMessage">Краткое сообщение</param>
		public MessageForm( string parShortMessage )
		{
			// Инициализация компонентоа
			InitializeComponent( );
			this.m_ShortMessageLabel.Text = parShortMessage;
		} // MessageForm

		/// <summary>
		/// Создание формы сообщений с заданными кратким
		/// и детализированным сообщениями
		/// </summary>
		/// <param name="parShortMessage">Краткое сообщение</param>
		/// <param name="parDetailsMessage">Детализированное сообщение</param>
		public MessageForm
		(
			string parShortMessage,
			string parDetailsMessage
		)
		{
			// Инициализация компонентоа
			InitializeComponent( );
			this.m_ShortMessageLabel.Text         = parShortMessage;
			this.m_DetailsMessageRichTextBox.Text = parDetailsMessage;
		} // MessageForm
		#endregion Конструкторы
	} // MessageForm
} // MainFacilitiesUseAnalysisClient