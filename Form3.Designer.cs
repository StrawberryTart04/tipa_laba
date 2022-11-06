
namespace myach
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myachhDataSet = new myach.myachhDataSet();
            this.авторTableAdapter = new myach.myachhDataSetTableAdapters.авторTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSpektalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespektalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_author = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.restriction_age = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.возрастноеОграничениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторспектальBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спектальBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спектальBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.спектальTableAdapter = new myach.myachhDataSetTableAdapters.спектальTableAdapter();
            this.возрастноеОграничениеспектальBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.возрастное_ограничениеTableAdapter = new myach.myachhDataSetTableAdapters.возрастное_ограничениеTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnWord_Click = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myachhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возрастноеОграничениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторспектальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спектальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спектальBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возрастноеОграничениеспектальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDauthorDataGridViewTextBoxColumn,
            this.fIoDataGridViewTextBoxColumn,
            this.vekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.авторBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDauthorDataGridViewTextBoxColumn
            // 
            this.iDauthorDataGridViewTextBoxColumn.DataPropertyName = "ID_author";
            this.iDauthorDataGridViewTextBoxColumn.HeaderText = "ID_автора";
            this.iDauthorDataGridViewTextBoxColumn.Name = "iDauthorDataGridViewTextBoxColumn";
            // 
            // fIoDataGridViewTextBoxColumn
            // 
            this.fIoDataGridViewTextBoxColumn.DataPropertyName = "FIo";
            this.fIoDataGridViewTextBoxColumn.HeaderText = "ФИО_автора";
            this.fIoDataGridViewTextBoxColumn.Name = "fIoDataGridViewTextBoxColumn";
            // 
            // vekDataGridViewTextBoxColumn
            // 
            this.vekDataGridViewTextBoxColumn.DataPropertyName = "Vek";
            this.vekDataGridViewTextBoxColumn.HeaderText = "Век";
            this.vekDataGridViewTextBoxColumn.Name = "vekDataGridViewTextBoxColumn";
            // 
            // авторBindingSource
            // 
            this.авторBindingSource.DataMember = "автор";
            this.авторBindingSource.DataSource = this.myachhDataSet;
            // 
            // myachhDataSet
            // 
            this.myachhDataSet.DataSetName = "myachhDataSet";
            this.myachhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авторTableAdapter
            // 
            this.авторTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSpektalDataGridViewTextBoxColumn,
            this.namespektalDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.FIO_author,
            this.restriction_age});
            this.dataGridView2.DataSource = this.авторспектальBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(39, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDSpektalDataGridViewTextBoxColumn
            // 
            this.iDSpektalDataGridViewTextBoxColumn.DataPropertyName = "iD_Spektal";
            this.iDSpektalDataGridViewTextBoxColumn.HeaderText = "ID_спектакля";
            this.iDSpektalDataGridViewTextBoxColumn.Name = "iDSpektalDataGridViewTextBoxColumn";
            // 
            // namespektalDataGridViewTextBoxColumn
            // 
            this.namespektalDataGridViewTextBoxColumn.DataPropertyName = "name_spektal";
            this.namespektalDataGridViewTextBoxColumn.HeaderText = "название_спектакля";
            this.namespektalDataGridViewTextBoxColumn.Name = "namespektalDataGridViewTextBoxColumn";
            this.namespektalDataGridViewTextBoxColumn.Width = 150;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            // 
            // FIO_author
            // 
            this.FIO_author.DataPropertyName = "author_ID";
            this.FIO_author.DataSource = this.авторBindingSource;
            this.FIO_author.DisplayMember = "FIo";
            this.FIO_author.HeaderText = "фио автора";
            this.FIO_author.Name = "FIO_author";
            this.FIO_author.ValueMember = "ID_author";
            // 
            // restriction_age
            // 
            this.restriction_age.DataPropertyName = "age_restriction";
            this.restriction_age.DataSource = this.возрастноеОграничениеBindingSource;
            this.restriction_age.DisplayMember = "name_age";
            this.restriction_age.HeaderText = "ограничение по возрасту";
            this.restriction_age.Name = "restriction_age";
            this.restriction_age.ValueMember = "id_age_restricion";
            // 
            // возрастноеОграничениеBindingSource
            // 
            this.возрастноеОграничениеBindingSource.DataMember = "возрастное ограничение";
            this.возрастноеОграничениеBindingSource.DataSource = this.myachhDataSet;
            // 
            // авторспектальBindingSource
            // 
            this.авторспектальBindingSource.DataMember = "авторспекталь";
            this.авторспектальBindingSource.DataSource = this.авторBindingSource;
            // 
            // спектальBindingSource
            // 
            this.спектальBindingSource.DataMember = "спекталь";
            this.спектальBindingSource.DataSource = this.myachhDataSet;
            // 
            // спектальBindingSource1
            // 
            this.спектальBindingSource1.DataMember = "спекталь";
            this.спектальBindingSource1.DataSource = this.myachhDataSet;
            // 
            // спектальTableAdapter
            // 
            this.спектальTableAdapter.ClearBeforeFill = true;
            // 
            // возрастноеОграничениеспектальBindingSource
            // 
            this.возрастноеОграничениеспектальBindingSource.DataMember = "возрастное ограничениеспекталь";
            this.возрастноеОграничениеспектальBindingSource.DataSource = this.возрастноеОграничениеBindingSource;
            // 
            // возрастное_ограничениеTableAdapter
            // 
            this.возрастное_ограничениеTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.авторBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(476, 83);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 4;
            this.btnSave1.Text = "сохранить";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(51, 399);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 5;
            this.btnSave2.Text = "сохранить";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnWord_Click
            // 
            this.btnWord_Click.Location = new System.Drawing.Point(148, 398);
            this.btnWord_Click.Name = "btnWord_Click";
            this.btnWord_Click.Size = new System.Drawing.Size(111, 23);
            this.btnWord_Click.TabIndex = 6;
            this.btnWord_Click.Text = "Экспорт в Word";
            this.btnWord_Click.UseVisualStyleBackColor = true;
            this.btnWord_Click.Click += new System.EventHandler(this.btnWord_Click_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(295, 398);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(121, 23);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord_Click);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myachhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возрастноеОграничениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторспектальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спектальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спектальBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возрастноеОграничениеспектальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private myachhDataSet myachhDataSet;
        private System.Windows.Forms.BindingSource авторBindingSource;
        private myachhDataSetTableAdapters.авторTableAdapter авторTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource спектальBindingSource;
        private myachhDataSetTableAdapters.спектальTableAdapter спектальTableAdapter;
        private System.Windows.Forms.BindingSource авторспектальBindingSource;
        private System.Windows.Forms.BindingSource возрастноеОграничениеBindingSource;
        private myachhDataSetTableAdapters.возрастное_ограничениеTableAdapter возрастное_ограничениеTableAdapter;
        private System.Windows.Forms.BindingSource спектальBindingSource1;
        private System.Windows.Forms.BindingSource возрастноеОграничениеспектальBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSpektalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespektalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FIO_author;
        private System.Windows.Forms.DataGridViewComboBoxColumn restriction_age;
        private System.Windows.Forms.Button btnWord_Click;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExcel;
    }
}