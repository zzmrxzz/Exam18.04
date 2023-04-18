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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet3.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.fitnes_LyskovDataSet3.View_1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
