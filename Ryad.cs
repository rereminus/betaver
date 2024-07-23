using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace betaver
{
    public partial class Ryad : Form
    {
        public Ryad()
        {
            InitializeComponent();
        }

        private void Ryad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.hotelDataSet.uslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.bron_uslugi". При необходимости она может быть перемещена или удалена.
            this.bron_uslugiTableAdapter.Fill(this.hotelDataSet.bron_uslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.bronirovania". При необходимости она может быть перемещена или удалена.
            this.bronirovaniaTableAdapter.Fill(this.hotelDataSet.bronirovania);
        }

        private void Ryad_FormClosing(object sender, FormClosingEventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите закрыть приложение?",
            "Закрытие Мастер Отеля", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messagebox == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(Environment.ExitCode);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
