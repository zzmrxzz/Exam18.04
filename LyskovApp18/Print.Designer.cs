namespace LyskovApp18
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            System.Windows.Forms.Label код_счетаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label expr1Label;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label услугаLabel;
            this.fitnes_LyskovDataSet3 = new LyskovApp18.Fitnes_LyskovDataSet3();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new LyskovApp18.Fitnes_LyskovDataSet3TableAdapters.View_1TableAdapter();
            this.tableAdapterManager = new LyskovApp18.Fitnes_LyskovDataSet3TableAdapters.TableAdapterManager();
            this.view_1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.view_1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_счетаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.услугаTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            код_счетаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            expr1Label = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            услугаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnes_LyskovDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingNavigator)).BeginInit();
            this.view_1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fitnes_LyskovDataSet3
            // 
            this.fitnes_LyskovDataSet3.DataSetName = "Fitnes_LyskovDataSet3";
            this.fitnes_LyskovDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "View_1";
            this.view_1BindingSource.DataSource = this.fitnes_LyskovDataSet3;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = LyskovApp18.Fitnes_LyskovDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_1BindingNavigator
            // 
            this.view_1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.view_1BindingNavigator.BindingSource = this.view_1BindingSource;
            this.view_1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.view_1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.view_1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_1BindingNavigatorSaveItem});
            this.view_1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.view_1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.view_1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.view_1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.view_1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.view_1BindingNavigator.Name = "view_1BindingNavigator";
            this.view_1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.view_1BindingNavigator.Size = new System.Drawing.Size(480, 25);
            this.view_1BindingNavigator.TabIndex = 0;
            this.view_1BindingNavigator.Text = "bindingNavigator1";
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
            // view_1BindingNavigatorSaveItem
            // 
            this.view_1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.view_1BindingNavigatorSaveItem.Enabled = false;
            this.view_1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_1BindingNavigatorSaveItem.Image")));
            this.view_1BindingNavigatorSaveItem.Name = "view_1BindingNavigatorSaveItem";
            this.view_1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.view_1BindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // код_счетаLabel
            // 
            код_счетаLabel.AutoSize = true;
            код_счетаLabel.Location = new System.Drawing.Point(46, 62);
            код_счетаLabel.Name = "код_счетаLabel";
            код_счетаLabel.Size = new System.Drawing.Size(100, 13);
            код_счетаLabel.TabIndex = 1;
            код_счетаLabel.Text = "Номер квитанции:";
            // 
            // код_счетаTextBox
            // 
            this.код_счетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Код счета", true));
            this.код_счетаTextBox.Location = new System.Drawing.Point(152, 59);
            this.код_счетаTextBox.Name = "код_счетаTextBox";
            this.код_счетаTextBox.Size = new System.Drawing.Size(107, 20);
            this.код_счетаTextBox.TabIndex = 2;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(87, 92);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(152, 89);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(182, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(114, 119);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(152, 116);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(182, 20);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(89, 150);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(152, 147);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(182, 20);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Location = new System.Drawing.Point(83, 182);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(63, 13);
            expr1Label.TabIndex = 9;
            expr1Label.Text = "Сотрудник:";
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(152, 179);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.Size = new System.Drawing.Size(182, 20);
            this.expr1TextBox.TabIndex = 10;
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(78, 209);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(68, 13);
            должностьLabel.TabIndex = 11;
            должностьLabel.Text = "Должность:";
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(152, 206);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(182, 20);
            this.должностьTextBox.TabIndex = 12;
            // 
            // услугаLabel
            // 
            услугаLabel.AutoSize = true;
            услугаLabel.Location = new System.Drawing.Point(50, 236);
            услугаLabel.Name = "услугаLabel";
            услугаLabel.Size = new System.Drawing.Size(96, 26);
            услугаLabel.TabIndex = 13;
            услугаLabel.Text = "Дополнительная \r\nуслуга:";
            // 
            // услугаTextBox
            // 
            this.услугаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Услуга", true));
            this.услугаTextBox.Location = new System.Drawing.Point(152, 242);
            this.услугаTextBox.Name = "услугаTextBox";
            this.услугаTextBox.Size = new System.Drawing.Size(263, 20);
            this.услугаTextBox.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(услугаLabel);
            this.Controls.Add(this.услугаTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(код_счетаLabel);
            this.Controls.Add(this.код_счетаTextBox);
            this.Controls.Add(this.view_1BindingNavigator);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квитанция";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnes_LyskovDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingNavigator)).EndInit();
            this.view_1BindingNavigator.ResumeLayout(false);
            this.view_1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Fitnes_LyskovDataSet3 fitnes_LyskovDataSet3;
        private System.Windows.Forms.BindingSource view_1BindingSource;
        private Fitnes_LyskovDataSet3TableAdapters.View_1TableAdapter view_1TableAdapter;
        private Fitnes_LyskovDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator view_1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton view_1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_счетаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox expr1TextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox услугаTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}