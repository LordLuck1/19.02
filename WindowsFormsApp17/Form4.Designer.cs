
namespace WindowsFormsApp17
{
    partial class Form4
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
            this.фирмаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фирмаTableAdapter = new WindowsFormsApp17.Персональные_ЭВМDataSetTableAdapters.ФирмаTableAdapter();
            this.iDФирмыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаизготовительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоФирмыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФирмыDataGridViewTextBoxColumn,
            this.фирмаизготовительDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.местоФирмыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фирмаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // персональные_ЭВМDataSet
            // 
            this.персональные_ЭВМDataSet.DataSetName = "Персональные_ЭВМDataSet";
            this.персональные_ЭВМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фирмаBindingSource
            // 
            this.фирмаBindingSource.DataMember = "Фирма";
            this.фирмаBindingSource.DataSource = this.персональные_ЭВМDataSet;
            // 
            // фирмаTableAdapter
            // 
            this.фирмаTableAdapter.ClearBeforeFill = true;
            // 
            // iDФирмыDataGridViewTextBoxColumn
            // 
            this.iDФирмыDataGridViewTextBoxColumn.DataPropertyName = "ID_Фирмы";
            this.iDФирмыDataGridViewTextBoxColumn.HeaderText = "ID_Фирмы";
            this.iDФирмыDataGridViewTextBoxColumn.Name = "iDФирмыDataGridViewTextBoxColumn";
            // 
            // фирмаизготовительDataGridViewTextBoxColumn
            // 
            this.фирмаизготовительDataGridViewTextBoxColumn.DataPropertyName = "Фирма-изготовитель";
            this.фирмаизготовительDataGridViewTextBoxColumn.HeaderText = "Фирма-изготовитель";
            this.фирмаизготовительDataGridViewTextBoxColumn.Name = "фирмаизготовительDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // местоФирмыDataGridViewTextBoxColumn
            // 
            this.местоФирмыDataGridViewTextBoxColumn.DataPropertyName = "Место фирмы";
            this.местоФирмыDataGridViewTextBoxColumn.HeaderText = "Место фирмы";
            this.местоФирмыDataGridViewTextBoxColumn.Name = "местоФирмыDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Персональные_ЭВМDataSet персональные_ЭВМDataSet;
        private System.Windows.Forms.BindingSource фирмаBindingSource;
        private Персональные_ЭВМDataSetTableAdapters.ФирмаTableAdapter фирмаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФирмыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаизготовительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоФирмыDataGridViewTextBoxColumn;
    }
}