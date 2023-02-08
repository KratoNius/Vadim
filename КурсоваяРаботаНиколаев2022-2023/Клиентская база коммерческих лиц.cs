using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КурсоваяРаботаНиколаев2022_2023
{
    public partial class Клиентская_база_коммерческих_лиц : Form
    {

        public Клиентская_база_коммерческих_лиц()
        {
            InitializeComponent();  
        }
        static string conn = "server = localhost; user=root;database=николаев; password=toor; charset=utf8";
        MySqlDataAdapter ad;
        DataTable dt;
        DataSet ds;
        MySqlCommand Command;
        MySqlCommandBuilder commandBuilder;
        MySqlConnection mysql_dbc = new MySqlConnection(conn);
        public string ac;
        int ID;
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT `clientskaya baza kommercheskih lic`.id,  `clientskaya baza kommercheskih lic`.FIO,  " +
                "`clientskaya baza kommercheskih lic`.phone,  `clientskaya baza kommercheskih lic`.adres,  `clientskaya baza kommercheskih lic`.Companiya\r\n" +
                "FROM `clientskaya baza kommercheskih lic`, `clientskaya baza fizicheskih lic`\r\n" +
                "GROUP BY `clientskaya baza kommercheskih lic`.id";
            ad = new MySqlDataAdapter(query, mysql_dbc);
            mysql_dbc.Open();
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            mysql_dbc.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT `clientskaya baza kommercheskih lic`.id,  `clientskaya baza kommercheskih lic`.FIO,  " +
                "`clientskaya baza kommercheskih lic`.phone,  `clientskaya baza kommercheskih lic`.adres,  `clientskaya baza kommercheskih lic`.Companiya\r\n" +
                "FROM `clientskaya baza kommercheskih lic`, `clientskaya baza fizicheskih lic` " +
                "WHERE " +
                "`clientskaya baza kommercheskih lic`.FIO LIKE \"%"+textBox1.Text+"%\" OR " +
                "`clientskaya baza kommercheskih lic`.phone LIKE \"%"+textBox1.Text+"%\" OR " +
                "`clientskaya baza kommercheskih lic`.adres LIKE \"%"+textBox1.Text+"%\" OR " +
                "`clientskaya baza kommercheskih lic`.Companiya LIKE \"%"+textBox1.Text+"%\" " +
                "GROUP BY `clientskaya baza kommercheskih lic`.id ", mysql_dbc);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            mysql_dbc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Command = new MySqlCommand();
            mysql_dbc.Open();
            Command = mysql_dbc.CreateCommand();
            DialogResult dr = MessageBox.Show("Вы точно хотите добавить запись?", "Добавление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Command.CommandText = "INSERT INTO `clientskaya baza kommercheskih lic`(`FIO`, `phone`, `adres`, `Companiya`) " +
                    "VALUES(\""+textBox2.Text+"\", \""+textBox3.Text+"\", \""+textBox4.Text+"\", \""+textBox5.Text+"\")";
                Command.ExecuteNonQuery();

                ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            mysql_dbc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;

                    ID = Convert.ToInt32(row.Cells["id"].Value.ToString());
                }
                Command = new MySqlCommand();
                Command.Connection = mysql_dbc;
                mysql_dbc.Open();
                Command.CommandText = "DELETE FROM `clientskaya baza kommercheskih lic` WHERE id=" + ID;
                Command.ExecuteNonQuery();

                string query = "SELECT `clientskaya baza kommercheskih lic`.id,  `clientskaya baza kommercheskih lic`.FIO,  " +
                "`clientskaya baza kommercheskih lic`.phone,  `clientskaya baza kommercheskih lic`.adres,  `clientskaya baza kommercheskih lic`.Companiya\r\n" +
                "FROM `clientskaya baza kommercheskih lic`, `clientskaya baza fizicheskih lic`\r\n" +
                "GROUP BY `clientskaya baza kommercheskih lic`.id";
                ad = new MySqlDataAdapter(query, mysql_dbc);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.Columns[0].Visible = false;
                mysql_dbc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Command = new MySqlCommand();
            string id = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            mysql_dbc.Open();
            Command = mysql_dbc.CreateCommand();
            
                Command.CommandText = "UPDATE `clientskaya baza kommercheskih lic` " +
                "SET " +
                "FIO=\""+textBox6.Text+"\", " +
                "phone=\""+textBox7.Text+"\", " +
                "adres=\"" +textBox8.Text+"\", " +
                "Companiya=\"" +textBox9.Text+"\" " +
                "WHERE id="+id;
                Command.ExecuteNonQuery();

                ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            
            mysql_dbc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Авторизация f1 = new Авторизация();
            Hide();
            f1.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox6.Text = row.Cells["FIO"].Value.ToString();
                textBox7.Text = row.Cells["phone"].Value.ToString();
                textBox8.Text = row.Cells["adres"].Value.ToString();
                textBox9.Text = row.Cells["Companiya"].Value.ToString();
            }
        }
    }
}
