using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyskovApp18
{
    public partial class DopUslugi : Form
    {
        public DopUslugi()
        {
            InitializeComponent();
        }

        private void дополнительные_услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дополнительные_услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet);

        }

        private void DopUslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet.Дополнительные_услуги". При необходимости она может быть перемещена или удалена.
            this.дополнительные_услугиTableAdapter.Fill(this.fitnes_LyskovDataSet.Дополнительные_услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Uslugi = new Uslugi();
            Uslugi.Show();
        }
    }
}
