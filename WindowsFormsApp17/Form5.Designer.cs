
namespace WindowsFormsApp17
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.персональные_ЭВМDataSet = new WindowsFormsApp17.Персональные_ЭВМDataSet();
            this.фирмареализаторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фирма_реализаторTableAdapter = new WindowsFormsApp17.Персональные_ЭВМDataSetTableAdapters.Фирма_реализаторTableAdapter();
            this.iDФирмареализаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмареализаторBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФирмареализаторDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фирмареализаторBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(208, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // персональные_ЭВМDataSet
            // 
            this.персональные_ЭВМDataSet.DataSetName = "Персональные_ЭВМDataSet";
            this.персональные_ЭВМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фирмареализаторBindingSource
            // 
            this.фирмареализаторBindingSource.DataMember = "Фирма-реализатор";
            this.фирмареализаторBindingSource.DataSource = this.персональные_ЭВМDataSet;
            // 
            // фирма_реализаторTableAdapter
            // 
            this.фирма_реализаторTableAdapter.ClearBeforeFill = true;
            // 
            // iDФирмареализаторDataGridViewTextBoxColumn
            // 
            this.iDФирмареализаторDataGridViewTextBoxColumn.DataPropertyName = "ID_Фирма-реализатор";
            this.iDФирмареализаторDataGridViewTextBoxColumn.HeaderText = "ID_Фирма-реализатор";
            this.iDФирмареализаторDataGridViewTextBoxColumn.Name = "iDФирмареализаторDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмареализаторBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Персональные_ЭВМDataSet персональные_ЭВМDataSet;
        private System.Windows.Forms.BindingSource фирмареализаторBindingSource;
        private Персональные_ЭВМDataSetTableAdapters.Фирма_реализаторTableAdapter фирма_реализаторTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФирмареализаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}