
namespace WindowsFormsApp17
{
    partial class Form2
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
            this.процессорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процессорTableAdapter = new WindowsFormsApp17.Персональные_ЭВМDataSetTableAdapters.ПроцессорTableAdapter();
            this.iDПроцессораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типПроцессораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тактоваяЧастотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмОЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмЖесткогоДискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыпускаПЭВМDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процессорBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПроцессораDataGridViewTextBoxColumn,
            this.типПроцессораDataGridViewTextBoxColumn,
            this.тактоваяЧастотаDataGridViewTextBoxColumn,
            this.объёмОЗУDataGridViewTextBoxColumn,
            this.объёмЖесткогоДискаDataGridViewTextBoxColumn,
            this.датаВыпускаПЭВМDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.процессорBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // персональные_ЭВМDataSet
            // 
            this.персональные_ЭВМDataSet.DataSetName = "Персональные_ЭВМDataSet";
            this.персональные_ЭВМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // процессорBindingSource
            // 
            this.процессорBindingSource.DataMember = "Процессор";
            this.процессорBindingSource.DataSource = this.персональные_ЭВМDataSet;
            // 
            // процессорTableAdapter
            // 
            this.процессорTableAdapter.ClearBeforeFill = true;
            // 
            // iDПроцессораDataGridViewTextBoxColumn
            // 
            this.iDПроцессораDataGridViewTextBoxColumn.DataPropertyName = "ID_Процессора";
            this.iDПроцессораDataGridViewTextBoxColumn.HeaderText = "ID_Процессора";
            this.iDПроцессораDataGridViewTextBoxColumn.Name = "iDПроцессораDataGridViewTextBoxColumn";
            // 
            // типПроцессораDataGridViewTextBoxColumn
            // 
            this.типПроцессораDataGridViewTextBoxColumn.DataPropertyName = "Тип процессора";
            this.типПроцессораDataGridViewTextBoxColumn.HeaderText = "Тип процессора";
            this.типПроцессораDataGridViewTextBoxColumn.Name = "типПроцессораDataGridViewTextBoxColumn";
            // 
            // тактоваяЧастотаDataGridViewTextBoxColumn
            // 
            this.тактоваяЧастотаDataGridViewTextBoxColumn.DataPropertyName = "Тактовая частота";
            this.тактоваяЧастотаDataGridViewTextBoxColumn.HeaderText = "Тактовая частота";
            this.тактоваяЧастотаDataGridViewTextBoxColumn.Name = "тактоваяЧастотаDataGridViewTextBoxColumn";
            // 
            // объёмОЗУDataGridViewTextBoxColumn
            // 
            this.объёмОЗУDataGridViewTextBoxColumn.DataPropertyName = "Объём ОЗУ";
            this.объёмОЗУDataGridViewTextBoxColumn.HeaderText = "Объём ОЗУ";
            this.объёмОЗУDataGridViewTextBoxColumn.Name = "объёмОЗУDataGridViewTextBoxColumn";
            // 
            // объёмЖесткогоДискаDataGridViewTextBoxColumn
            // 
            this.объёмЖесткогоДискаDataGridViewTextBoxColumn.DataPropertyName = "Объём жесткого диска";
            this.объёмЖесткогоДискаDataGridViewTextBoxColumn.HeaderText = "Объём жесткого диска";
            this.объёмЖесткогоДискаDataGridViewTextBoxColumn.Name = "объёмЖесткогоДискаDataGridViewTextBoxColumn";
            // 
            // датаВыпускаПЭВМDataGridViewTextBoxColumn
            // 
            this.датаВыпускаПЭВМDataGridViewTextBoxColumn.DataPropertyName = "Дата выпуска ПЭВМ";
            this.датаВыпускаПЭВМDataGridViewTextBoxColumn.HeaderText = "Дата выпуска ПЭВМ";
            this.датаВыпускаПЭВМDataGridViewTextBoxColumn.Name = "датаВыпускаПЭВМDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персональные_ЭВМDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процессорBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Персональные_ЭВМDataSet персональные_ЭВМDataSet;
        private System.Windows.Forms.BindingSource процессорBindingSource;
        private Персональные_ЭВМDataSetTableAdapters.ПроцессорTableAdapter процессорTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроцессораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПроцессораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тактоваяЧастотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмОЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмЖесткогоДискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыпускаПЭВМDataGridViewTextBoxColumn;
    }
}