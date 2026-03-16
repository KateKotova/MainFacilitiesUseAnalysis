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
	/// Форма показа таблиц
	/// </summary>
	public partial class ShowTablesForm : Form
	{
		#region Поля
		/// <summary>
		/// Сущность группы
		/// </summary>
		protected Group          m_Group;
		/// <summary>
		/// Сущность основного средства
		/// </summary>
		protected MainFacility   m_MainFacility;
		/// <summary>
		/// Сущность документа
		/// </summary>
		protected Document       m_Document;
		/// <summary>
		/// Сущность дополнительных данных
		/// </summary>
		protected AdditionalData m_AdditionalData;
		#endregion Поля

		#region Методы
		#region Стандартные методы
		/// <summary>
		/// Загрузка формы показа таблиц
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void ShowTablesForm_Load
		(
			object sender,
			EventArgs e
		)
		{
			// Явное открытие соединения предотвратит лишние операции по неявному
			// открытиею и закрытию его во время вызова метода SqlDataAdapter.Fill
			DataContainer.Instance( ).CurrentSqlConnection.Open( );

			// Создание группы на показ
			this.m_Group          = new Group         ( StoredProcedureAction.SHOW,
				ref this.m_DataSet, this.m_DataSet.Groups.TableName,
				string.Empty, string.Empty );
			// Создание осноного средства на показ
			this.m_MainFacility   = new MainFacility  ( StoredProcedureAction.SHOW,
				ref this.m_DataSet, this.m_DataSet.MainFacilities.TableName,
				string.Empty );
			// Создание документа на показ
			this.m_Document       = new Document      ( StoredProcedureAction.SHOW,
				ref this.m_DataSet, this.m_DataSet.Documents.TableName,
				string.Empty, string.Empty );
			// Создание дополнительных данных на показ
			this.m_AdditionalData = new AdditionalData( StoredProcedureAction.SHOW,
				ref this.m_DataSet, this.m_DataSet.AdditionalData.TableName );
		} // ShowTablesForm_Load

		/// <summary>
		/// Завершение работы с формой показа таблиц
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void ShowTablesForm_FormClosing
		(
			object sender,
			FormClosingEventArgs e
		)
		{
			// Явное закрытие соединения необходимо, так как оно было явно открыто,
			// поэтому никогда не закрывалоть при вызове m_SqlDataAdapter.Fill
			DataContainer.Instance( ).CurrentSqlConnection.Close( );
		} // ShowTablesForm_FormClosing
		#endregion Стандартные методы

		#region Методы реакций на выполнение редактирования сущностей
		/// <summary>
		/// Обновление данных адаптеров Sql-данных cущностей
		/// </summary>
		public virtual void RefreshSqlDataAdapters( )
		{
			// Очиста необходима, так как метод SqlDataAdapter.Fill
			// не удаляет строки, удалёные из базы данных без вмешательства
			// данного приложения, хотя при вызове "поверх" существующих строк,
			// обновляет их содержимое в соответствии с первичным ключом
			this.m_DataSet.Clear( );
			// Заполнение адаптеров Sql-данных cущностей
			this.m_Group.FillSqlDataAdapters         ( ref this.m_DataSet );
			this.m_MainFacility.FillSqlDataAdapters  ( ref this.m_DataSet );
			this.m_Document.FillSqlDataAdapters      ( ref this.m_DataSet );
			this.m_AdditionalData.FillSqlDataAdapters( ref this.m_DataSet );
		} // RefreshSqlDataAdapters

		/// <summary>
		/// Установка текущей строки таблицы по значению ячейки
		/// </summary>
		/// <param name="parDataGridView">Таблица</param>
		/// <param name="parColumnNumber">Индекс столбца</param>
		/// <param name="parColumnValue">Значение столбца</param>
		public static void SetDataGridViewCurrentRow
		(
			ref DataGridView parDataGridView,
			int              parColumnNumber,
			string           parColumnValue
		)
		{
			// Индекс строки
			int locRowIndex = 0;
			// Поиск значения в строке для выделения
			while ( locRowIndex < parDataGridView.Rows.Count )
			{
				// Очередная ячейка
				DataGridViewCell locCell = parDataGridView
					[ parColumnNumber, locRowIndex ];
				// Текущая ячейка должна содержать заданное значение
				if ( Convert.ToString( locCell.Value ) == parColumnValue )
				{
					parDataGridView.CurrentCell = locCell;
					break;
				} // if
				// Перемещение к следующей строке
				locRowIndex++;
			} // while
		} // SetDataGridViewCurrentRow

		/// <summary>
		/// Реакция на выполнение редактирования группы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OnGroupEditingIsExecuted
		(
			object             sender,
			EditGroupEventArgs e
		)
		{
			// Обновление данных адаптеров Sql-данных cущностей
			RefreshSqlDataAdapters( );
			// Если группа была добавлена или обновлена, текущая строка
			// таблицы групп устанавливается в позицию отредактированной группы
			if ( ( e.Action == StoredProcedureAction.INSERT ) ||
					( e.Action == StoredProcedureAction.UPDATE ) )
				ShowTablesForm.SetDataGridViewCurrentRow
					( ref this.m_GroupsDataGridView,
					this.m_GroupGroupNameDataGridViewTextBoxColumn.Index, e.Name );
		} // OnGroupEditingIsExecuted

		/// <summary>
		/// Реакция на выполнение редактирования основного средства
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OnMainFacilityEditingIsExecuted
		(
			object                    sender,
			EditMainFacilityEventArgs e
		)
		{
			// Обновление данных адаптеров Sql-данных cущностей
			RefreshSqlDataAdapters( );
			// Если основное средство было добавлено или обновлено, текущая строка
			// таблицы основных средств устанавливается
			// в позицию отредактированнго осноного средства
			if ( ( e.Action == StoredProcedureAction.INSERT ) ||
					( e.Action == StoredProcedureAction.UPDATE ) )
				ShowTablesForm.SetDataGridViewCurrentRow
					( ref this.m_MainFacilitiesDataGridView,
					this.m_MainFacilityMainFacilityNameDataGridViewTextBoxColumn.Index,
					e.Name );
		} // OnMainFacilityEditingIsExecuted

		/// <summary>
		/// Реакция на выполнение редактирования документа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OnDocumentEditingIsExecuted
		(
			object                sender,
			EditDocumentEventArgs e
		)
		{
			// Обновление данных адаптеров Sql-данных cущностей
			RefreshSqlDataAdapters( );
			// Если документ был добавлен или обновлён, текущая строка
			// таблицы документов устанавливается
			// в позицию отредактированнго документа
			if ( ( e.Action == StoredProcedureAction.INSERT ) ||
					( e.Action == StoredProcedureAction.UPDATE ) )
			{
				// Индекс строки
				int locRowIndex = 0;
				// Поиск значения в строке для выделения
				while ( locRowIndex < this.m_DocumentsDataGridView.Rows.Count )
				{
					// Очередная ячейка названия типа документа
					DataGridViewCell locDocumentTypeNameCell =
						this.m_DocumentsDataGridView
						[ this.m_TypeNameDataGridViewTextBoxColumn.Index, locRowIndex ];
					// Очередная ячейка названия основного средства
					DataGridViewCell locMainFacilityNameCell =
						this.m_DocumentsDataGridView
						[ this.m_DocumentMainFacilityNameDataGridViewTextBoxColumn.Index,
						locRowIndex ];
					// Очередная ячейка даты
					DataGridViewCell locDateCell = this.m_DocumentsDataGridView
						[ this.m_DateDataGridViewTextBoxColumn.Index, locRowIndex ];

					// Текущая строка должна содержать заданные значения
					if ( ( Convert.ToString( locDocumentTypeNameCell.Value ) ==
						e.DocumentTypeName ) &&
						( Convert.ToString( locMainFacilityNameCell.Value ) ==
						e.MainFacilityName ) &&
						( Convert.ToString( locDateCell.Value ) == e.Date ) )
					{
						this.m_DocumentsDataGridView.CurrentCell =
							locDocumentTypeNameCell;
						break;
					} // if
					// Перемещение к следующей строке
					locRowIndex++;
				} // while
			} // if
		} // OnDocumentEditingIsExecuted

		/// <summary>
		/// Реакция на выполнение редактирования дополнительных данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OnAdditionalDataEditingIsExecuted
		(
			object                      sender,
			EditAdditionalDataEventArgs e
		)
		{
			// Обновление данных адаптеров Sql-данных cущностей
			RefreshSqlDataAdapters( );
			// Если ополнительные данные были добавлены или обновлены,
			// текущая строка таблицы дополнительных данных устанавливается
			// в позицию отредактированнгых дополнительных данных
			if ( ( e.Action == StoredProcedureAction.INSERT ) ||
					( e.Action == StoredProcedureAction.UPDATE ) )
				ShowTablesForm.SetDataGridViewCurrentRow
					( ref this.m_AdditionalDataDataGridView,
					this.m_YearDataGridViewTextBoxColumn.Index,
					e.Year );
		} // OnAdditionalDataEditingIsExecuted
		#endregion Методы реакций на выполнение редактирования сущностей

		#region Методы обращения к сущностям без инициализации параметров
		/// <summary>
		/// Показ формы диалога редактрирования сущности в заданном режиме
		/// </summary>
		/// <param name="parAction">Действие хранимой процедуры -
		/// режим редактирования сущности</param>
		protected virtual void ShowEditEssenceFormDialog
			( StoredProcedureAction parAction )
		{
			// Выбор редактируемой сущности активной закладки
			switch ( this.m_TabControl.SelectedIndex )
			{
				// Закладка групп
				case 0 :
					// Форма редактирования группы в заданном режиме
					EditGroupForm locEditGroupForm = new EditGroupForm( parAction );
					// Подписка на событие выполнения редактирования группы
					locEditGroupForm.GroupEditingIsExecuted +=
						this.OnGroupEditingIsExecuted;
					// Показ диалога редактирования группы
					locEditGroupForm.ShowDialog( );
					return;

				// Закладка основных средств
				case 1 :
					// Форма редактирования основного средства в заданном режиме
					EditMainFacilityForm locEditMainFacilityForm           =
						new EditMainFacilityForm( parAction );
					// Подписка на событие выполнения редактирования основного средства
					locEditMainFacilityForm.MainFacilityEditingIsExecuted +=
						this.OnMainFacilityEditingIsExecuted;
					// Показ диалога редактирования основного средства
					locEditMainFacilityForm.ShowDialog( );
					return;

				// Закладка документов
				case 2 :
					// Форма редактирования документа в заданном режиме
					EditDocumentForm locEditDocumentForm = new EditDocumentForm
						( parAction );
					// Подписка на событие выполнения редактирования документа
					locEditDocumentForm.DocumentEditingIsExecuted +=
						this.OnDocumentEditingIsExecuted;
					// Показ диалога редактирования документа
					locEditDocumentForm.ShowDialog( );
					return;

				// Закладка дополнительных данных
				case 3 :
					// Форма редактирования дополнительных данных в заданном режиме
					EditAdditionalDataForm locEditAdditionalDataForm           =
						new EditAdditionalDataForm( parAction );
					// Подписка на событие выполнения редактирования
					// дополнительных данных
					locEditAdditionalDataForm.AdditionalDataEditingIsExecuted +=
						this.OnAdditionalDataEditingIsExecuted;
					// Показ диалога редактирования дополнительных данных
					locEditAdditionalDataForm.ShowDialog( );
					return;

				// Прочие непредусмотренные закладки
				default :
					return;
			} // switch
		} // ShowEditEssenceFormDialog

		/// <summary>
		/// Добавление сущности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_InsertToolStripButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Показ формы диалога добавления сущности
			this.ShowEditEssenceFormDialog( StoredProcedureAction.INSERT );
		} // m_InsertToolStripButton_Click

		/// <summary>
		/// Обновление сущности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_UpdateToolStripButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Показ формы диалога добавления сущности
			this.ShowEditEssenceFormDialog( StoredProcedureAction.UPDATE );
		} // m_UpdateToolStripButton_Click

		/// <summary>
		/// Удаление сущности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_DeleteToolStripButton_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Показ формы диалога добавления сущности
			this.ShowEditEssenceFormDialog( StoredProcedureAction.DELETE );
		} // m_DeleteToolStripButton_Click

		/// <summary>
		/// Анализ основнйх средт при помощи сущности двух лет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void m_AnalyseToolStripButton_Click(
			object sender,
			EventArgs e
		)
		{
			// Показ формы диалога выбора вида анализа
			new AnalysisTypeChoiceForm( ).ShowDialog( );
		} // m_AnalyseToolStripButton_Click
		#endregion Методы обращения к сущностям без инициализации параметров

		#region Методы редактирования сущностей с инициализацией параметров
		/// <summary>
		/// Добавление сущности с инициализацией параметров
		/// из текущей строки текущей таблицы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_InsertToolStripMenuItem_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Выбор редактируемой сущности активной закладки
			switch ( this.m_TabControl.SelectedIndex )
			{
				// Закладка групп
				case 0 :
					// Форма редактирования группы в режиме добавления
					EditGroupForm locEditGroupForm           = new EditGroupForm
						( this.m_GroupsDataGridView
							[ this.m_GroupGroupNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].Value.ToString( ),
						this.m_GroupsDataGridView
							[ this.m_ProductionTypeNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].Value.ToString( ),
						this.m_GroupsDataGridView
							[ this.m_ActivityTypeNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования группы
					locEditGroupForm.GroupEditingIsExecuted +=
						this.OnGroupEditingIsExecuted;
					// Показ диалога редактирования группы
					locEditGroupForm.ShowDialog( );
					return;

				// Закладка основных средств
				case 1 :
					// Форма редактирования основного средства в режиме добавления
					EditMainFacilityForm locEditMainFacilityForm           =
						new EditMainFacilityForm
						( this.m_MainFacilitiesDataGridView
							[ this.m_InventoryNumberDataGridViewTextBoxColumn.Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityGroupNameDataGridViewTextBoxColumn.Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования основного средства
					locEditMainFacilityForm.MainFacilityEditingIsExecuted +=
						this.OnMainFacilityEditingIsExecuted;
					// Показ диалога редактирования основного средства
					locEditMainFacilityForm.ShowDialog( );
					return;

				// Закладка документов
				case 2 :
					// Форма редактирования документа в режиме добавления
					EditDocumentForm locEditDocumentForm = new EditDocumentForm
						( this.m_DocumentsDataGridView
							[ this.m_TypeNameDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DocumentMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DateDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_CostDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования документа
					locEditDocumentForm.DocumentEditingIsExecuted +=
						this.OnDocumentEditingIsExecuted;
					// Показ диалога редактирования документа
					locEditDocumentForm.ShowDialog( );
					return;

				// Закладка дополнительных данных
				case 3 :
					// Форма редактирования дополнительных данных в режиме добавления
					EditAdditionalDataForm locEditAdditionalDataForm           =
						new EditAdditionalDataForm
						( this.m_AdditionalDataDataGridView
							[ this.m_YearDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_ProductionOutputAmountDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_MarketedProductionAmountDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_ProductionPrimeCostDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_TotalReceiptsDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.
							m_ActingEquipmentAnnualAverageAmountDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedHoursDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedDaysDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedChangesDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования
					// дополнительных данных
					locEditAdditionalDataForm.AdditionalDataEditingIsExecuted +=
						this.OnAdditionalDataEditingIsExecuted;
					// Показ диалога редактирования дополнительных данных
					locEditAdditionalDataForm.ShowDialog( );
					return;

				// Прочие непредусмотренные закладки
				default :
					return;
			} // switch
		} // m_InsertToolStripMenuItem_Click

		/// <summary>
		/// Обновление сущности с инициализацией параметров
		/// из текущей строки текущей таблицы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_UpdateToolStripMenuItem_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Выбор редактируемой сущности активной закладки
			switch ( this.m_TabControl.SelectedIndex )
			{
				// Закладка групп
				case 0 :
					// Форма редактирования группы в режиме обновления
					EditGroupForm locEditGroupForm           = new EditGroupForm
						( this.m_GroupsDataGridView
							[ this.m_GroupGroupNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].Value.ToString( ),
						this.m_GroupsDataGridView
							[ this.m_GroupGroupNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].Value.ToString( ),
						this.m_GroupsDataGridView
							[ this.m_ProductionTypeNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].Value.ToString( ),
						this.m_GroupsDataGridView
							[ this.m_ActivityTypeNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования группы
					locEditGroupForm.GroupEditingIsExecuted +=
						this.OnGroupEditingIsExecuted;
					// Показ диалога редактирования группы
					locEditGroupForm.ShowDialog( );
					return;

				// Закладка основных средств
				case 1 :
					// Форма редактирования основного средства в режиме обновления
					EditMainFacilityForm locEditMainFacilityForm           =
						new EditMainFacilityForm
						( this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_MainFacilitiesDataGridView
							[ this.m_InventoryNumberDataGridViewTextBoxColumn.Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityGroupNameDataGridViewTextBoxColumn.Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования основного средства
					locEditMainFacilityForm.MainFacilityEditingIsExecuted +=
						this.OnMainFacilityEditingIsExecuted;
					// Показ диалога редактирования основного средства
					locEditMainFacilityForm.ShowDialog( );
					return;

				// Закладка документов
				case 2 :
					// Форма редактирования документа в режиме обновления
					EditDocumentForm locEditDocumentForm = new EditDocumentForm
						( this.m_DocumentsDataGridView
							[ this.m_TypeNameDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DocumentMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DateDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_TypeNameDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DocumentMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DateDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_CostDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования документа
					locEditDocumentForm.DocumentEditingIsExecuted +=
						this.OnDocumentEditingIsExecuted;
					// Показ диалога редактирования документа
					locEditDocumentForm.ShowDialog( );
					return;

				// Закладка дополнительных данных
				case 3 :
					// Форма редактирования дополнительных данных в режиме обновления
					EditAdditionalDataForm locEditAdditionalDataForm           =
						new EditAdditionalDataForm
						( this.m_AdditionalDataDataGridView
							[ this.m_YearDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_YearDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_ProductionOutputAmountDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_MarketedProductionAmountDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_ProductionPrimeCostDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_TotalReceiptsDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.
							m_ActingEquipmentAnnualAverageAmountDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedHoursDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedDaysDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_AdditionalDataDataGridView
							[ this.m_EquipmentUnitPerfectedChangesDataGridViewTextBoxColumn.
							Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования
					// дополнительных данных
					locEditAdditionalDataForm.AdditionalDataEditingIsExecuted +=
						this.OnAdditionalDataEditingIsExecuted;
					// Показ диалога редактирования дополнительных данных
					locEditAdditionalDataForm.ShowDialog( );
					return;

				// Прочие непредусмотренные закладки
				default :
					return;
			} // switch
		} // m_UpdateToolStripMenuItem_Click

		/// <summary>
		/// Удаление сущности с инициализацией параметров
		/// из текущей строки текущей таблицы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void m_DeleteToolStripMenuItem_Click
		(
			object sender,
			EventArgs e
		)
		{
			// Выбор редактируемой сущности активной закладки
			switch ( this.m_TabControl.SelectedIndex )
			{
				// Закладка групп
				case 0 :
					// Форма редактирования группы в режиме удаления
					EditGroupForm locEditGroupForm           = new EditGroupForm
						( this.m_GroupsDataGridView
							[ this.m_GroupGroupNameDataGridViewTextBoxColumn.Index,
							this.m_GroupsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования группы
					locEditGroupForm.GroupEditingIsExecuted +=
						this.OnGroupEditingIsExecuted;
					// Показ диалога редактирования группы
					locEditGroupForm.ShowDialog( );
					return;

				// Закладка основных средств
				case 1 :
					// Форма редактирования основного средства в режиме удаления
					EditMainFacilityForm locEditMainFacilityForm           =
						new EditMainFacilityForm
						( this.m_MainFacilitiesDataGridView
							[ this.m_MainFacilityMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_MainFacilitiesDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования основного средства
					locEditMainFacilityForm.MainFacilityEditingIsExecuted +=
						this.OnMainFacilityEditingIsExecuted;
					// Показ диалога редактирования основного средства
					locEditMainFacilityForm.ShowDialog( );
					return;

				// Закладка документов
				case 2 :
					// Форма редактирования документа в режиме удаления
					EditDocumentForm locEditDocumentForm = new EditDocumentForm
						( this.m_DocumentsDataGridView
							[ this.m_TypeNameDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DocumentMainFacilityNameDataGridViewTextBoxColumn.
							Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ),
						this.m_DocumentsDataGridView
							[ this.m_DateDataGridViewTextBoxColumn.Index,
							this.m_DocumentsDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования документа
					locEditDocumentForm.DocumentEditingIsExecuted +=
						this.OnDocumentEditingIsExecuted;
					// Показ диалога редактирования документа
					locEditDocumentForm.ShowDialog( );
					return;

				// Закладка дополнительных данных
				case 3 :
					// Форма редактирования дополнительных данных в режиме удаления
					EditAdditionalDataForm locEditAdditionalDataForm           =
						new EditAdditionalDataForm
						( this.m_AdditionalDataDataGridView
							[ this.m_YearDataGridViewTextBoxColumn.Index,
							this.m_AdditionalDataDataGridView.CurrentRow.Index ].
							Value.ToString( ) );
					// Подписка на событие выполнения редактирования
					// дополнительных данных
					locEditAdditionalDataForm.AdditionalDataEditingIsExecuted +=
						this.OnAdditionalDataEditingIsExecuted;
					// Показ диалога редактирования дополнительных данных
					locEditAdditionalDataForm.ShowDialog( );
					return;

				// Прочие непредусмотренные закладки
				default :
					return;
			} // switch
		} // m_DeleteToolStripMenuItem_Click
		#endregion Методы редактирования сущностей с инициализацией параметров
		#endregion Методы

		/// <summary>
		/// Создание формы показа таблиц
		/// </summary>
		public ShowTablesForm( )
		{
			InitializeComponent( );

			// Изменение шрифта шапок таблиц
			this.m_GroupsDataGridView.ColumnHeadersDefaultCellStyle.Font.Dispose( );
			this.m_MainFacilitiesDataGridView.ColumnHeadersDefaultCellStyle.
				Font.Dispose( );
			this.m_DocumentsDataGridView.ColumnHeadersDefaultCellStyle.
				Font.Dispose( );
			this.m_AdditionalDataDataGridView.ColumnHeadersDefaultCellStyle.
				Font.Dispose( );

			this.m_GroupsDataGridView.ColumnHeadersDefaultCellStyle.Font =
				DataContainer.Instance( ).DataGridViewColumnHeadersFont;
			this.m_MainFacilitiesDataGridView.ColumnHeadersDefaultCellStyle.Font =
				DataContainer.Instance( ).DataGridViewColumnHeadersFont;
			this.m_DocumentsDataGridView.ColumnHeadersDefaultCellStyle.Font =
				DataContainer.Instance( ).DataGridViewColumnHeadersFont;
			this.m_AdditionalDataDataGridView.ColumnHeadersDefaultCellStyle.Font =
				DataContainer.Instance( ).DataGridViewColumnHeadersFont;
		} // ShowTablesForm
	} // ShowTablesForm
} // MainFacilitiesUseAnalysisClient