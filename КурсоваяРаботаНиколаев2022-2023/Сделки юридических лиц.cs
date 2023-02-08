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
    public partial class Сделки_юридических_лиц : Form
    {

        public Сделки_юридических_лиц()
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
        int ID, ID1;
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT objectu.id, `sdelki uridicheskih lic`.id AS `id123`, objectu.gorod, objectu.ylica, objectu.dom, objectu.etajeu, objectu.kvartir, objectu.podiezdov, `otdel kommercheskou nedvijimosti`.FIO FROM `sdelki uridicheskih lic` INNER JOIN objectu ON \t`sdelki uridicheskih lic`.id_objecta = objectu.id LEFT JOIN `otdel kommercheskou nedvijimosti` ON \t`sdelki uridicheskih lic`.id_menedjera = `otdel kommercheskou nedvijimosti`.id";
            ad = new MySqlDataAdapter(query, mysql_dbc);
            mysql_dbc.Open();
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            //перемещение из бд в комбобоксы

            string combox = "SELECT `FIO` FROM `otdel kommercheskou nedvijimosti`";
            MySqlCommand command = new MySqlCommand(combox, mysql_dbc);
            command.CommandTimeout = 0;
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();

            //string combox1 = "SELECT `gorod` FROM `objectu`";
            //MySqlCommand command1 = new MySqlCommand(combox1, mysql_dbc);
            //command.CommandTimeout = 0;
            //MySqlDataReader reader1 = command1.ExecuteReader();
            //comboBox2.Items.Clear();
            //comboBox5.Items.Clear();
            //while (reader1.Read())
            //{
            //    comboBox2.Items.Add(reader1[0].ToString());
            //    comboBox5.Items.Add(reader1[0].ToString());
            //}
            //reader1.Close();

            //string combox2 = "SELECT `FIO` FROM `clientskaya baza kommercheskih lic`";
            //MySqlCommand command2 = new MySqlCommand(combox2, mysql_dbc);
            //command2.CommandTimeout = 0;
            //MySqlDataReader reader2 = command2.ExecuteReader();
            //comboBox3.Items.Clear();
            //comboBox6.Items.Clear();
            //while (reader2.Read())
            //{
            //    comboBox3.Items.Add(reader2[0].ToString());
            //    comboBox6.Items.Add(reader2[0].ToString());
            //}
            //reader2.Close();

            mysql_dbc.Close();
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
            string id = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            //DialogResult dr = MessageBox.Show("Вы точно хотите добавить запись?", "Добавление", MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            //if (dr == DialogResult.Yes)
            // {
            Command.CommandText = "INSERT INTO `objectu`(objectu.gorod, objectu.ylica, objectu.dom, objectu.etajeu, objectu.kvartir, objectu.podiezdov) " + 
                "VALUES(\"" + textBox2.Text + "\", \"" +textBox3.Text+"\", \""+textBox4.Text+"\", \""+textBox5.Text+"\", \""+textBox6.Text+"\", \""+textBox7.Text+"\")";
                Command.ExecuteNonQuery();

            //присвоение максимального id объекта в переменную SUM
            string SUM;
            string query1 = "SELECT MAX(id) FROM `objectu`";
            Command = new MySql.Data.MySqlClient.MySqlCommand(query1, mysql_dbc);
            var queryResult = Command.ExecuteScalar();
            if (queryResult != null)
            {
                SUM = Convert.ToString(queryResult);
            }
            else
            {
                SUM = "";
            }
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                ID1 = Convert.ToInt32(row.Cells["id123"].Value.ToString());
            }
            //добавление этой переменой
            Command.CommandText = " INSERT INTO `sdelki uridicheskih lic`(`id_objecta`) VALUES("+SUM+"); " +
                "UPDATE `sdelki uridicheskih lic`, `otdel kommercheskou nedvijimosti` SET `sdelki uridicheskih lic`.`id_menedjera`=`otdel kommercheskou nedvijimosti`.id WHERE " +
                "`otdel kommercheskou nedvijimosti`.`FIO`=\""+comboBox1.SelectedItem+ "\" and `sdelki uridicheskih lic`.id="+ID1;
            Command.ExecuteNonQuery();

            Command.CommandText ="UPDATE `sdelki uridicheskih lic`, `otdel kommercheskou nedvijimosti` SET `sdelki uridicheskih lic`.`id_menedjera`=`otdel kommercheskou nedvijimosti`.id WHERE " +
                "`otdel kommercheskou nedvijimosti`.`FIO`=\"" + comboBox1.SelectedItem + "\" and `sdelki uridicheskih lic`.id=\"" + id+"\"";
            Command.ExecuteNonQuery();

            ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


           // }


            string query = "SELECT objectu.id, objectu.gorod, objectu.ylica, objectu.dom, objectu.etajeu, objectu.kvartir, objectu.podiezdov, `otdel kommercheskou nedvijimosti`.FIO FROM `sdelki uridicheskih lic` INNER JOIN objectu ON \t`sdelki uridicheskih lic`.id_objecta = objectu.id LEFT JOIN `otdel kommercheskou nedvijimosti` ON \t`sdelki uridicheskih lic`.id_menedjera = `otdel kommercheskou nedvijimosti`.id";
            ad = new MySqlDataAdapter(query, mysql_dbc);

            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns[0].Visible = false;
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
            
                //Command.CommandText = "UPDATE `clientskaya baza kommercheskih lic` " +
                //"SET " +
                //"FIO=\""+comboBox4.SelectedItem +"\", " +
                //"phone=\""+comboBox5.SelectedItem +"\", " +
                //"adres=\"" +comboBox6.SelectedItem +"\" " +
                //"WHERE id="+id;
                //Command.ExecuteNonQuery();

                //ds = new DataSet();
                //ad.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
            
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
            //для отображения из гида в текстбоксы или комбобоксы 

            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            //{
            //    cell = selectedCell;
            //    break;
            //}
            //if (cell != null)
            //{
            //    DataGridViewRow row = cell.OwningRow;
            //    comboBox4.Text = row.Cells["FIO"].Value.ToString();
            //    comboBox5.Text = row.Cells["gorod"].Value.ToString();
            //    comboBox6.Text = row.Cells["клиенты"].Value.ToString();
            //}
        }
    }
}
