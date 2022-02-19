
namespace WindowsFormsApp17
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.персональные_ЭВМDataSet = new WindowsFormsApp17.Персональные_ЭВМDataSet();
            this.партияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.партияTableAdapter = new WindowsFormsApp17.Персональные_ЭВМDataSetTableAdapters.ПартияTableAdapter();
            this.iDПартииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаПартииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.партияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПартииDataGridViewTextBoxColumn,
            this.объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn,
            this.ценаПартииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.партияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(241, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // персональные_ЭВМDataSet
            // 
            this.персональные_ЭВМDataSet.DataSetName = "Персональные_ЭВМDataSet";
            this.персональные_ЭВМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // партияBindingSource
            // 
            this.партияBindingSource.DataMember = "Партия";
            this.партияBindingSource.DataSource = this.персональные_ЭВМDataSet;
            // 
            // партияTableAdapter
            // 
            this.партияTableAdapter.ClearBeforeFill = true;
            // 
            // iDПартииDataGridViewTextBoxColumn
            // 
            this.iDПартииDataGridViewTextBoxColumn.DataPropertyName = "ID_Партии";
            this.iDПартииDataGridViewTextBoxColumn.HeaderText = "ID_Партии";
            this.iDПартииDataGridViewTextBoxColumn.Name = "iDПартииDataGridViewTextBoxColumn";
            // 
            // объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn
            // 
            this.объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn.DataPropertyName = "Объём партиии рыночного предложение";
            this.объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn.HeaderText = "Объём партиии рыночного предложение";
            this.объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn.Name = "объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn";
            // 
            // ценаПартииDataGridViewTextBoxColumn
            // 
            this.ценаПартииDataGridViewTextBoxColumn.DataPropertyName = "Цена партии";
            this.ценаПартииDataGridViewTextBoxColumn.HeaderText = "Цена партии";
            this.ценаПартииDataGridViewTextBoxColumn.Name = "ценаПартииDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.партияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Персональные_ЭВМDataSet персональные_ЭВМDataSet;
        private System.Windows.Forms.BindingSource партияBindingSource;
        private Персональные_ЭВМDataSetTableAdapters.ПартияTableAdapter партияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПартииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмПартиииРыночногоПредложениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаПартииDataGridViewTextBoxColumn;
    }
}