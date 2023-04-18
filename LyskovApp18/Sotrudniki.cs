﻿using System;
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
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnes_LyskovDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.fitnes_LyskovDataSet.Сотрудники);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnes_LyskovDataSet);

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
    }
}
