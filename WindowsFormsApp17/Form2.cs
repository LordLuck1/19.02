using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "персональные_ЭВМDataSet.Процессор". При необходимости она может быть перемещена или удалена.
            this.процессорTableAdapter.Fill(this.персональные_ЭВМDataSet.Процессор);

        }
    }
}
