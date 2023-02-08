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

namespace КурсоваяРаботаНиколаев2022_2023
{
    public partial class BD : Form
    {

        public BD()
        {
            InitializeComponent();  
        }
        static string conn = "server = localhost; user=root;database=николаев; password=toor; charset=utf8";
        MySqlDataAdapter ad;
        DataTable dt;
        DataSet ds;
        MySqlCommandBuilder commandBuilder;
        MySqlConnection mysql_dbc = new MySqlConnection(conn);
        public string ac;
        private void Form1_Load(object sender, EventArgs e)
        {
            if(ac=="1")
            {
                таблицаToolStripMenuItem.Visible = false;          }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void клиентскаяБазаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `clientskaya baza fizicheskih lic` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds); 
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void клиентскаяБазаКоммлицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `clientskaya baza kommercheskih lic` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void новоеЖильёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `novoe jilie` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `objectu` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void отделКоммнедвижимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `otdel kommercheskou nedvijimosti` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void отделПродажиЖилыхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `otdel prodaji jiluh pomesheniu` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void отделЗемельныхОтношенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `otdel zemeljnuh otnosheniu` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void сделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `sdelka` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void сделкиФизлицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `sdelki fizicheskih lic` ", mysql_dbc);
            mysql_dbc.Open();
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void сделкиЮрлицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `sdelki uridicheskih lic` ", mysql_dbc);
            mysql_dbc.Open();
            // dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            mysql_dbc.Close();
        }
        private void выручкаЗаПродажиКвартирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT Sum(`novoe jilie`.price) AS `Выручка`FROM `novoe jilie`", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void квартирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `novoe jilie`.adres,`novoe jilie`.etaj,`novoe jilie`.kvartira,`novoe jilie`.podjezd,`novoe jilie`.comnat,`novoe jilie`.sostoyanie,`novoe jilie`.otdelka,`novoe jilie`.price FROM `novoe jilie` WHERE `novoe jilie`.otdelka = \"нет\" ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void квартирыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `novoe jilie`.adres, `novoe jilie`.etaj, `novoe jilie`.kvartira, `novoe jilie`.podjezd, `novoe jilie`.comnat, `novoe jilie`.sostoyanie, `novoe jilie`.otdelka, `novoe jilie`.price FROM `novoe jilie` WHERE `novoe jilie`.sostoyanie = \"продаётся\" ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void квартирыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `novoe jilie`.adres, `novoe jilie`.etaj, `novoe jilie`.kvartira, `novoe jilie`.podjezd, `novoe jilie`.comnat, `novoe jilie`.sostoyanie, `novoe jilie`.otdelka, `novoe jilie`.price FROM `novoe jilie` WHERE `novoe jilie`.sostoyanie = \"не продаётся\" ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void квартирыСОтделкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `novoe jilie`.adres, `novoe jilie`.etaj, `novoe jilie`.kvartira, `novoe jilie`.podjezd, `novoe jilie`.comnat, `novoe jilie`.sostoyanie, `novoe jilie`.otdelka, `novoe jilie`.price FROM `novoe jilie` WHERE `novoe jilie`.otdelka = \"да\" ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void информацияОЖилыхПомещенияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `novoe jilie`.adres, `novoe jilie`.etaj, `novoe jilie`.kvartira, `novoe jilie`.podjezd, `novoe jilie`.comnat, `novoe jilie`.sostoyanie, `novoe jilie`.otdelka, `novoe jilie`.price, `otdel prodaji jiluh pomesheniu`.FIO AS `Сотрудники`, `otdel prodaji jiluh pomesheniu`.phone AS `Телефон сотрудника`, `otdel prodaji jiluh pomesheniu`.polnomochiya AS `Должность` FROM `novoe jilie` INNER JOIN sdelka ON `novoe jilie`.id = sdelka.id_kvartiru INNER JOIN `otdel prodaji jiluh pomesheniu` ON `otdel prodaji jiluh pomesheniu`.id = sdelka.id_menedjer ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void сделкаСФизическимиЛицамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();
            ad = new MySqlDataAdapter("SELECT `clientskaya baza fizicheskih lic`.FIO AS `Клиенты`, `clientskaya baza fizicheskih lic`.id AS `№`, `clientskaya baza fizicheskih lic`.phone AS `Телефон клиентов`, `clientskaya baza fizicheskih lic`.adres AS `Адрес клиентов`, `otdel zemeljnuh otnosheniu`.FIO AS `Сотрудники`, `otdel zemeljnuh otnosheniu`.phone AS `Телефон сотруднииков`, `otdel zemeljnuh otnosheniu`.polnomochiya AS `Должность` FROM `clientskaya baza fizicheskih lic` INNER JOIN `sdelki fizicheskih lic` ON `clientskaya baza fizicheskih lic`.id = `sdelki fizicheskih lic`.id_clienta INNER JOIN `otdel zemeljnuh otnosheniu` ON `otdel zemeljnuh otnosheniu`.id = `sdelki fizicheskih lic`.id_menedjera ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void сделкаСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection mysql_dbc = new MySqlConnection(conn);
            mysql_dbc.Open();   
            ad = new MySqlDataAdapter("SELECT `clientskaya baza kommercheskih lic`.id AS `№`, `clientskaya baza kommercheskih lic`.FIO AS `Клиенты`, `clientskaya baza kommercheskih lic`.phone AS `Телефон клиентов`, `clientskaya baza kommercheskih lic`.adres AS `Адрес клиента`, `clientskaya baza kommercheskih lic`.Companiya AS `Компания`, `otdel kommercheskou nedvijimosti`.FIO AS `Сотрудники`, `otdel kommercheskou nedvijimosti`.phone AS `Телефон сотрудника`, `otdel kommercheskou nedvijimosti`.polnomochiya AS `Должность` FROM `clientskaya baza kommercheskih lic` INNER JOIN `sdelki uridicheskih lic` ON `clientskaya baza kommercheskih lic`.id = `sdelki uridicheskih lic`.id_clienta INNER JOIN `otdel kommercheskou nedvijimosti` ON `otdel kommercheskou nedvijimosti`.id = `sdelki uridicheskih lic`.id_menedjera ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ad = new MySqlDataAdapter("SELECT * FROM `clientskaya baza fizicheskih lic`" +
                " WHERE `clientskaya baza fizicheskih lic`.`FIO` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`phone` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`adres` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`pasport dannue` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`mesto propiski` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`mesto rabotu` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`doljnost` LIKE \"%" + textBox1.Text + "%\" " +
                "OR `clientskaya baza fizicheskih lic`.`bank tranzakcii` LIKE \"%" + textBox1.Text + "%\"" +
                "OR `clientskaya baza fizicheskih lic`.`dannue o supruge` LIKE \"%" + textBox1.Text + "%\"" +
                "OR `clientskaya baza fizicheskih lic`.`vozrast` LIKE \"%" + textBox1.Text + "%\"" +
                "OR `clientskaya baza fizicheskih lic`.`pol` LIKE \"%" + textBox1.Text + "%\" ", mysql_dbc);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы точно хотите добавить запись?", "Добавление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ////mysql_dbc.Open();
            //ad = new MySqlDataAdapter("SELECT * FROM `clientskaya baza fizicheskih lic` ", mysql_dbc);
            //commandBuilder = new MySqlCommandBuilder(ad);
            //ad.InsertCommand = new MySqlCommand("clientskaya baza fizicheskih lic", mysql_dbc);
            //ad.InsertCommand.CommandType = CommandType.StoredProcedure;
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@FIO", MySqlDbType.VarChar, 255, "FIO"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@phone", MySqlDbType.VarChar, 255, "Phone"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@adres", MySqlDbType.VarChar, 255, "Adres"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@pasport dannue", MySqlDbType.VarChar, 255, "Pasport dannue"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@mesto propiski", MySqlDbType.VarChar, 255, "Mesto propiski"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@mesto rabotu", MySqlDbType.VarChar, 255, "Mesto rabotu"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@doljnost", MySqlDbType.VarChar, 255, "Doljnost"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@bank tranzakcii", MySqlDbType.VarChar, 255, "Bank tranzakcii"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@dannue o supruge", MySqlDbType.VarChar, 255, "Dannue o supruge"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@vozrast", MySqlDbType.Int32, 11, "Vozrast"));
            //ad.InsertCommand.Parameters.Add(new MySqlParameter("@pol", MySqlDbType.VarChar, 255, "Pol"));


            //MySqlParameter parameter = ad.InsertCommand.Parameters.Add("@Id", MySqlDbType.Int32, 11, "Id");
            //parameter.Direction = ParameterDirection.Output;

            ad.Update(ds);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
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

        private void button9_Click(object sender, EventArgs e)
        {
            Клиентская_база_коммерческих_лиц клиентская_база_коммерческих_лиц = new Клиентская_база_коммерческих_лиц();
            this.Hide();
            клиентская_база_коммерческих_лиц.ShowDialog();
            this.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Сделки_юридических_лиц сделки_юридических_лиц = new Сделки_юридических_лиц();
            this.Hide();
            сделки_юридических_лиц.ShowDialog();
            this.Show();
        }
    }
}
