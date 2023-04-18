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
    public partial class Uslugi : Form
    {
        public Uslugi()
        {
            InitializeComponent();
        }

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet);

        }

        private void Uslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.fitnes_LyskovDataSet.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Otdeli = new Otdeli();
            Otdeli.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DopUslugi = new DopUslugi();
            DopUslugi.Show();
        }
    }
}
