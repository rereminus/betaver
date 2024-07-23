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
    public partial class EnterForm : Form
    {
        public string Kod_Enter;
        public EnterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string login = LoginBox.Text;
            string password = PassBox.Text;
            string querystring = $"select login, parol from sotrud where login = '{login}' and parol = '{password}'";
            SqlCommand command = new SqlCommand(querystring, sqlConnection1);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Kod_Enter = login;
                sqlConnection1.Open();
                MessageBox.Show("Вход выполнен успешно под именем " + login);
                this.Hide();
                string query = $"select kod_role from sotrud where login = '{login}' and parol = '{password}'";
                SqlCommand cmd = new SqlCommand(query, sqlConnection1);
                int role = (int)cmd.ExecuteScalar();
                sqlConnection1.Close();
                if (role == 1)
                {
                    Admin main = new Admin();
                    main.Kod = Kod_Enter;
                    main.button.Visible = true;
                    main.button.Enabled = true;
                    main.combobox.Visible = false;
                    main.combobox.Enabled = false;
                    main.button1_.Visible = false;
                    main.button1_.Enabled = false;
                    main.button2_.Enabled = false;
                    main.button2_.Visible = false;
                    main.label1_.Visible = false;
                    main.ShowDialog();
                }
                else if (role == 2)
                {
                    Admin main = new Admin();
                    main.Kod = Kod_Enter;
                    main.ShowDialog();
                }
                else if (role == 3)
                {
                    Account acc = new Account();
                    acc.ShowDialog();
                }
                else
                {
                    Ryad r = new Ryad();
                    r.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Не удалось войти в систему","Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoginBox.Clear();
                this.PassBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.PassBox.PasswordChar == '*')
            {
                this.PassBox.PasswordChar = '\0';
            }
            else
            {
                this.PassBox.PasswordChar = '*';
            }
        }
    }
}
