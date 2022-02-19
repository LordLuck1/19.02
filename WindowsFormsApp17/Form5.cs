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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "персональные_ЭВМDataSet._Фирма_реализатор". При необходимости она может быть перемещена или удалена.
            this.фирма_реализаторTableAdapter.Fill(this.персональные_ЭВМDataSet._Фирма_реализатор);

        }
    }
}
