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
    public partial class Otdeli : Form
    {
        public Otdeli()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet);

        }

        private void Otdeli_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.fitnes_LyskovDataSet.Отделы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Sotrudniki = new Sotrudniki();
            Sotrudniki.Show();
        }
    }
}
