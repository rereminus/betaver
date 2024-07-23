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
using Microsoft.VisualBasic;

namespace betaver
{
    public partial class Admin : Form
    {
        public string Kod;
        public Button button;
        public Button button1_;
        public Button button2_;
        public ComboBox combobox;
        public Label label1_;
        public Admin()
        {
            InitializeComponent();
            button = this.edit_categ;
            button1_ = this.button2;
            button2_ = this.button3;
            combobox = this.comboBox3;
            label1_ = this.label20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.bron_uslugi". При необходимости она может быть перемещена или удалена.
            this.bron_uslugiTableAdapter.Fill(this.hotelDataSet.bron_uslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.schet". При необходимости она может быть перемещена или удалена.
            this.schetTableAdapter.Fill(this.hotelDataSet.schet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.hotelDataSet.uslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.schet". При необходимости она может быть перемещена или удалена.
            this.schetTableAdapter.Fill(this.hotelDataSet.schet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.hotelDataSet.categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.klienty". При необходимости она может быть перемещена или удалена.
            this.klientyTableAdapter.Fill(this.hotelDataSet.klienty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.nomera". При необходимости она может быть перемещена или удалена.
            this.nomeraTableAdapter.Fill(this.hotelDataSet.nomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.bronirovania". При необходимости она может быть перемещена или удалена.
            this.bronirovaniaTableAdapter.Fill(this.hotelDataSet.bronirovania);
            sqlConnection1.Open();
            string query_user = $"select familiya, imya, otchestvo from sotrud where login = '{Kod}'";
            SqlCommand cmd = new SqlCommand(query_user, sqlConnection1);
            SqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                this.username.Text = string.Format("{0} {1} {2}",rdr["familiya"].ToString().Trim(), rdr["imya"].ToString().Trim(), rdr["otchestvo"].ToString().Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            bronirovaniaBindingSource.Filter = string.Format("data_konech >= #{0:yyyy/MM/dd}#", today);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            bronirovaniaBindingSource.Filter = string.Format("data_nach = #{0:yyyy/MM/dd}#", today);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tomorrow = DateTime.Now.AddDays(1);
            bronirovaniaBindingSource.Filter = string.Format("data_nach = #{0:yyyy/MM/dd}#", tomorrow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            bronirovaniaBindingSource.Filter = string.Format("data_konech <= #{0:yyyy/MM/dd}#", today);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Запуск добавления
            foreach (Control c in panel4.Controls)
            {
                TextBox t = (c as TextBox);
                if (t != null)
                    t.Text = "";
                MaskedTextBox ms = (c as MaskedTextBox);
                if (ms != null)
                    ms.Text = "";
                ComboBox com = (c as ComboBox);
                if (com != null)
                    com.SelectedIndex = 0;
            }
            this.panel4.Visible = true;
            this.delete_bron.Enabled = false;
            this.delete_bron.Visible = false;
            this.update_button.Enabled = false;
            this.update_button.Visible = false;
            this.save_new.Enabled = true;
            this.save_new.Visible = true;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            //Запуск редактирования
            this.panel4.Visible = true;
            this.delete_bron.Enabled = true;
            this.delete_bron.Visible = true;
            this.save_new.Enabled = false;
            this.save_new.Visible = false;
            this.update_button.Enabled = true;
            this.update_button.Visible = true;

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            var kod = Convert.ToString(selectedRow.Cells["kodklientDataGridViewTextBoxColumn"].Value);

            string query_ = $"select familiya, imya, otchestvo, pasport, pol, telephone, email, gorod, strana, data_rozhd, nomer, data_nach, data_konech, kolvo_vzros, kolvo_det from klienty join bronirovania on bronirovania.kod_klient = klienty.kod_klient where klienty.kod_klient = {kod}";
            SqlCommand cmd = new SqlCommand(query_, sqlConnection1);
            SqlDataReader rdr = null;

            try
            {
                sqlConnection1.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.textBox3.Text = rdr["familiya"].ToString();
                    this.textBox4.Text = rdr["imya"].ToString();
                    this.textBox5.Text = rdr["otchestvo"].ToString();
                    this.textBox6.Text = rdr["pasport"].ToString();
                    this.textBox7.Text = rdr["pol"].ToString();
                    this.textBox8.Text = rdr["telephone"].ToString();
                    this.textBox9.Text = rdr["email"].ToString();
                    this.textBox10.Text = rdr["gorod"].ToString();
                    this.textBox11.Text = rdr["strana"].ToString();
                    this.maskedTextBox1.Text = rdr["data_rozhd"].ToString();
                    this.comboBox4.Text = rdr["nomer"].ToString();

                    this.maskedTextBox2.Text = rdr["data_nach"].ToString();
                    this.maskedTextBox3.Text = rdr["data_konech"].ToString();
                    this.textBox13.Text = rdr["kolvo_vzros"].ToString();
                    this.textBox19.Text = rdr["kolvo_det"].ToString();
                }
            }
            catch
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            sqlConnection1.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Сохранение данных
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            var fam = this.textBox3.Text;
            var imya = this.textBox4.Text;
            var otch = this.textBox5.Text;
            DateTime data = DateTime.Parse(this.maskedTextBox1.Text);
            var pass = this.textBox6.Text;
            var pol = this.textBox7.Text;
            var tel = this.textBox8.Text;
            var email = this.textBox9.Text;
            var gor = this.textBox10.Text;
            var country = this.textBox11.Text;

            var nomer = this.comboBox4.GetItemText(this.comboBox4.SelectedItem);
            DateTime nach = DateTime.Parse(this.maskedTextBox2.Text);
            DateTime end = DateTime.Parse(this.maskedTextBox3.Text);
            var kolvo_vzros = int.Parse(this.textBox13.Text);
            var kolvo_det = int.Parse(this.textBox19.Text);

            string query = $"select kod_klient from klienty where familiya = N'{fam}' and imya = N'{imya}' and otchestvo = N'{otch}' and pol = N'{pol}' and telephone = N'{tel}' and pasport = N'{pass}' and email = N'{email}' and gorod = N'{gor}' and strana = N'{country}' and data_rozhd = '{data.ToString("yyyy-MM-dd")}'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection1);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //sqlConnection1.Open();
                int id = (int)cmd.ExecuteScalar();
                string query1 = $"insert into bronirovania (kod_klient, nomer, data_nach, data_konech, kolvo_vzros, kolvo_det) values ({id}, {nomer}, {nach}, {end}, {kolvo_vzros}, {kolvo_det})";
                SqlCommand cmd1 = new SqlCommand(query1, sqlConnection1);
                cmd1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Новое бронирование добавлено!");
            }
            else
            {
                //sqlConnection1.Open();
                string query2 = $"insert into klienty (familiya, imya, otchestvo, pol, telephone, email, pasport, gorod, strana, data_rozhd) values (N'{fam}', N'{imya}', N'{otch}', N'{pol}', N'{tel}', N'{email}', N'{pass}', N'{gor}', N'{country}', '{data.ToString("yyyy-MM-dd")}')";
                SqlCommand cmd2 = new SqlCommand(query2, sqlConnection1);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                int id = (int)cmd.ExecuteScalar();
                string query3 = $"insert into bronirovania (kod_klient, nomer, data_nach, data_konech, kolvo_vzros, kolvo_det) values ({id}, {nomer}, '{nach.ToString("yyyy-MM-dd")}', '{end.ToString("yyyy-MM-dd")}', {kolvo_vzros}, {kolvo_det})";
                SqlCommand cmd3 = new SqlCommand(query3, sqlConnection1);
                cmd3.ExecuteNonQuery();
                //sqlConnection1.Close();
                MessageBox.Show("Новые бронирование и клиент добавлены!");
            }
            this.bronirovaniaTableAdapter.Fill(this.hotelDataSet.bronirovania);
            this.nomeraTableAdapter.Fill(this.hotelDataSet.nomera);
            this.klientyTableAdapter.Fill(this.hotelDataSet.klienty);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            if (comboBox2.SelectedIndex == 0 && int.TryParse(this.textBox2.Text, out num))
            {
                nomeraBindingSource.Filter = "nomer = " + num.ToString();
            }
            else if (comboBox2.SelectedIndex == 1 && int.TryParse(this.textBox2.Text, out num))
            {
                nomeraBindingSource.Filter = string.Format("kod_categ = {0}", num);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                var zan = this.textBox2.Text;
                nomeraBindingSource.Filter = string.Format("zanyatost = '{0}'", zan);
            }
            else
            {
                MessageBox.Show("Ошибка. Введите корректные значения");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string id_klient = Convert.ToString(selectedRow.Cells["kodklientDataGridViewTextBoxColumn"].Value);
            string id_bron = Convert.ToString(selectedRow.Cells["kodbronDataGridViewTextBoxColumn"].Value);

            var fam = this.textBox3.Text;
            var imya = this.textBox4.Text;
            var otch = this.textBox5.Text;
            DateTime data = DateTime.Parse(this.maskedTextBox1.Text);
            var pass = this.textBox6.Text;
            var pol = this.textBox7.Text;
            var tel = this.textBox8.Text;
            var email = this.textBox9.Text;
            var gor = this.textBox10.Text;
            var country = this.textBox11.Text;

            var nomer = this.comboBox4.GetItemText(this.comboBox4.SelectedItem);
            DateTime nach = DateTime.Parse(this.maskedTextBox2.Text);
            DateTime end = DateTime.Parse(this.maskedTextBox3.Text);
            var kolvo_vzros = int.Parse(this.textBox13.Text);
            var kolvo_det = int.Parse(this.textBox19.Text);

            sqlConnection1.Open();
            string query = $"update klienty set familiya = N'{fam}', imya = N'{imya}', otchestvo = N'{otch}', pol = N'{pol}', telephone = N'{tel}', pasport = N'{pass}', email = N'{email}', gorod = N'{gor}', strana = N'{country}', data_rozhd = '{data.ToString("yyyy-MM-dd")}' where kod_klient = {id_klient}";
            SqlCommand cmd = new SqlCommand(query, sqlConnection1);
            string query1 = $"update bronirovania set nomer = {nomer}, data_nach = '{nach.ToString("yyyy-MM-dd")}', data_konech = '{end.ToString("yyyy-MM-dd")}', kolvo_vzros = {kolvo_vzros}, kolvo_det = {kolvo_det} where kod_bron = {id_bron}";
            SqlCommand cmd1 = new SqlCommand(query1, sqlConnection1);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Данные были успешно изменены!");
            this.bronirovaniaTableAdapter.Fill(this.hotelDataSet.bronirovania);
            this.nomeraTableAdapter.Fill(this.hotelDataSet.nomera);
            this.klientyTableAdapter.Fill(this.hotelDataSet.klienty);
        }

        private void search_klient_Click(object sender, EventArgs e)
        {
            var f = this.textBox1.Text.Split(' ')[0];
            var i = this.textBox1.Text.Split(' ')[1];
            var o = this.textBox1.Text.Split(' ')[2];
            klientyBindingSource.Filter = string.Format($"familiya = '{f}' and imya = '{i}' and otchestvo = '{o}'");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button14_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            schetBindingSource1.Filter = "data_oplaty is null";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            schetBindingSource1.Filter = "data_oplaty is not null";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                var kod = this.comboBox3.GetItemText(this.comboBox1.SelectedItem);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string query1 = $"select * from schet where kod_bron = {kod}";
                SqlCommand cmd = new SqlCommand(query1, sqlConnection1);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if(table.Rows.Count > 1)
                {
                    MessageBox.Show("Счет на данное бронирование уже существует");
                }
                else
                {
                    string query = $"insert into schet (kod_bron) values ({kod})";
                    sqlConnection1.Open();
                    SqlCommand cmd1 = new SqlCommand(query, sqlConnection1);
                    cmd1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    this.schetTableAdapter.Fill(this.hotelDataSet.schet);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var sposob = Interaction.InputBox("Введите способ оплаты\nНАЛ/БЕЗНАЛ", "Способ оплаты");
            var kod_bron = this.comboBox3.GetItemText(this.comboBox1.SelectedItem);
            string getkod = $"select kod_sotr from sotrud where login = '{Kod}'";
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand(getkod, sqlConnection1);
            int sotr = (int)cmd.ExecuteScalar();
            var date = DateTime.Now;
            string queryprin = $"update schet set data_oplaty = '{date.ToString("yyy-MM-dd")}', prin_oplatu = {sotr}, sposob_oplaty = N'{sposob}' where kod_bron = {kod_bron}";
            SqlCommand cmd1 = new SqlCommand(queryprin, sqlConnection1);
            cmd1.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Данные внесены успешно!");
            this.schetTableAdapter.Fill(this.hotelDataSet.schet);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var bron = this.comboBox5.GetItemText(this.comboBox5.SelectedItem);
            var usluga = this.comboBox6.SelectedValue;
            string query = $"insert into bron_uslugi (kod_bron, kod_uslugi) values ({bron}, {usluga})";
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection1);
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            this.bron_uslugiTableAdapter.Fill(this.hotelDataSet.bron_uslugi);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'Ж' && e.KeyChar != 'М' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            try
            {
                var check = new System.Net.Mail.MailAddress(this.textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Адрес электронной почты был введен неверно");
                this.textBox9.Text = "";
            }

        }

        private void edit_categ_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel1.Enabled = true;
            int selectedrowindex = dataGridView4.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];
            var kod = Convert.ToString(selectedRow.Cells["kodcategDataGridViewTextBoxColumn1"].Value);
            string query = $"select naimen, stoimost, kolvo_mest, dop_info from categories where kod_categ = {kod}";
            SqlCommand cmd = new SqlCommand(query, sqlConnection1);
            SqlDataReader rdr = null;
            try
            {
                sqlConnection1.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.textBox14.Text = rdr["naimen"].ToString();
                    this.textBox15.Text = rdr["stoimost"].ToString();
                    this.textBox16.Text = rdr["kolvo_mest"].ToString();
                    this.textBox17.Text = rdr["dop_info"].ToString();
                }
            }
            catch
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
            sqlConnection1.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var naimen = this.textBox14.Text;
            decimal stoimost = Convert.ToDecimal(this.textBox15.Text);
            var mest = this.textBox16.Text;
            var dop = this.textBox17.Text;

            sqlConnection1.Open();
            string query = $"update categories set naimen = '{naimen}', stoimost = {stoimost}, kolvo_mest = {mest}, dop_info = '{dop}'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection1);
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Изменения внесены успешно!");
            this.categoriesTableAdapter.Fill(this.hotelDataSet.categories);
        }

        private void dataGridView4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Kod == "dmitriadi")
            {
                try
                {
                    this.edit_categ_Click(sender, e);
                }
                catch { }
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void delete_bron_Click(object sender, EventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите удалить бронирование?",
            "Удаление бронирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messagebox == DialogResult.Yes)
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string id_bron = Convert.ToString(selectedRow.Cells["kodbronDataGridViewTextBoxColumn"].Value);
                string query = $"delete from bronirovania where kod_bron = {id_bron}";
                sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection1);
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Бронирование № " + id_bron + "было успешно удалено");
                this.bronirovaniaTableAdapter.Fill(this.hotelDataSet.bronirovania);
            }
            else
            {
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\erema\Documents\rukovodstvo.txt");
        }
    }
}
