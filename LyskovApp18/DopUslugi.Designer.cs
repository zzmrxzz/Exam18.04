namespace LyskovApp18
{
    partial class DopUslugi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DopUslugi));
            this.fitnes_LyskovDataSet = new LyskovApp18.Fitnes_LyskovDataSet();
            this.дополнительные_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дополнительные_услугиTableAdapter = new LyskovApp18.Fitnes_LyskovDataSetTableAdapters.Дополнительные_услугиTableAdapter();
            this.tableAdapterManager = new LyskovApp18.Fitnes_LyskovDataSetTableAdapters.TableAdapterManager();
            this.дополнительные_услугиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.дополнительные_услугиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дополнительные_услугиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fitnes_LyskovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).BeginInit();
            this.дополнительные_услугиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnes_LyskovDataSet
            // 
            this.fitnes_LyskovDataSet.DataSetName = "Fitnes_LyskovDataSet";
            this.fitnes_LyskovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дополнительные_услугиBindingSource
            // 
            this.дополнительные_услугиBindingSource.DataMember = "Дополнительные услуги";
            this.дополнительные_услугиBindingSource.DataSource = this.fitnes_LyskovDataSet;
            // 
            // дополнительные_услугиTableAdapter
            // 
            this.дополнительные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LyskovApp18.Fitnes_LyskovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = this.дополнительные_услугиTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СчетTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // дополнительные_услугиBindingNavigator
            // 
            this.дополнительные_услугиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.дополнительные_услугиBindingNavigator.BindingSource = this.дополнительные_услугиBindingSource;
            this.дополнительные_услугиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.дополнительные_услугиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.дополнительные_услугиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.дополнительные_услугиBindingNavigatorSaveItem});
            this.дополнительные_услугиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.дополнительные_услугиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.дополнительные_услугиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.дополнительные_услугиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.дополнительные_услугиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.дополнительные_услугиBindingNavigator.Name = "дополнительные_услугиBindingNavigator";
            this.дополнительные_услугиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.дополнительные_услугиBindingNavigator.Size = new System.Drawing.Size(391, 25);
            this.дополнительные_услугиBindingNavigator.TabIndex = 0;
            this.дополнительные_услугиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // дополнительные_услугиBindingNavigatorSaveItem
            // 
            this.дополнительные_услугиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.дополнительные_услугиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("дополнительные_услугиBindingNavigatorSaveItem.Image")));
            this.дополнительные_услугиBindingNavigatorSaveItem.Name = "дополнительные_услугиBindingNavigatorSaveItem";
            this.дополнительные_услугиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.дополнительные_услугиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.дополнительные_услугиBindingNavigatorSaveItem.Click += new System.EventHandler(this.дополнительные_услугиBindingNavigatorSaveItem_Click);
            // 
            // дополнительные_услугиDataGridView
            // 
            this.дополнительные_услугиDataGridView.AutoGenerateColumns = false;
            this.дополнительные_услугиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.дополнительные_услугиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.дополнительные_услугиDataGridView.DataSource = this.дополнительные_услугиBindingSource;
            this.дополнительные_услугиDataGridView.Location = new System.Drawing.Point(0, 28);
            this.дополнительные_услугиDataGridView.Name = "дополнительные_услугиDataGridView";
            this.дополнительные_услугиDataGridView.Size = new System.Drawing.Size(390, 270);
            this.дополнительные_услугиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код дополнительной услуги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код дополнительной услуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Услуга";
            this.dataGridViewTextBoxColumn2.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DopUslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.дополнительные_услугиDataGridView);
            this.Controls.Add(this.дополнительные_услугиBindingNavigator);
            this.Name = "DopUslugi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.DopUslugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnes_LyskovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиBindingNavigator)).EndInit();
            this.дополнительные_услугиBindingNavigator.ResumeLayout(false);
            this.дополнительные_услугиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительные_услугиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Fitnes_LyskovDataSet fitnes_LyskovDataSet;
        private System.Windows.Forms.BindingSource дополнительные_услугиBindingSource;
        private Fitnes_LyskovDataSetTableAdapters.Дополнительные_услугиTableAdapter дополнительные_услугиTableAdapter;
        private Fitnes_LyskovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator дополнительные_услугиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton дополнительные_услугиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView дополнительные_услугиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}