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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Clients = new Clients();
            Clients.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Uslugi = new Uslugi();
            Uslugi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Sotrudniki = new Sotrudniki();
            Sotrudniki.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Print = new Print();
            Print.Show();
        }
    }
}
