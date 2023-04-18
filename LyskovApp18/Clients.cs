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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet2);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet2.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.fitnes_LyskovDataSet2.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet2.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.fitnes_LyskovDataSet2.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.fitnes_LyskovDataSet2.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void клиентыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet2);

        }
    }
}
