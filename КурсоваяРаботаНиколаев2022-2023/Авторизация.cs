using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace КурсоваяРаботаНиколаев2022_2023
{
    public partial class Авторизация : Form
    {
        int pop = -1;
        private List<Person> list;
        public Авторизация()
        {
            InitializeComponent();
        }
        static string conn = "server = localhost; user=root;database=николаев; password=toor; charset=utf8";
        private void Авторизация_Load(object sender, EventArgs e)
        {
            var db = new DBconnect();
            list = db.Get();
        }

        class Person
        {
            public int id { get; set; }

            public string login { get; set; }
            public string pass { get; set; }
        }
        class DBconnect
        {
            private readonly MySqlConnection connection;

            public DBconnect()
            {
                var builder = new MySqlConnectionStringBuilder();

                builder.Server = "localhost";
                builder.Database = "николаев";//
                builder.UserID = "root";
                builder.Password = "toor";//

                connection = new MySqlConnection(builder.ConnectionString);

            }

            private bool OpenConnection()
            {
                try
                {

                    connection.Open();

                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Невозможно подключиться к серверу, " +
                                "связаться с админ-панелью");
                            break;
                        case 1045:
                            MessageBox.Show("Неверное имя пользователя / пароль, " +
                                "пожалуйста, попробуйте еще раз");
                            break;
                        default:
                            MessageBox.Show(ex.Message);
                            break;
                    }
                    return false;
                }
            }
            private void CloseConnection()
            {
                try
                {

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public List<Person> Get()
            {

                // string query = " SELECT * FROM `клас груп`";
                string query = "SELECT Sum(`novoe jilie`.price) AS `Выручка`FROM `novoe jilie`";

                var list = new List<Person>();
                try
                {
                    if (OpenConnection())
                    {

                        using (var cmd = new MySqlCommand(query, connection))
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var person = new Person();

                                person.id = Convert.ToInt32(dataReader.GetString(0));
                                person.login = dataReader.GetString(2);
                                person.pass = dataReader.GetString(3);

                                list.Add(person);

                            }
                        }


                        CloseConnection();
                    }

                    return list;

                }
                catch
                {
                    return list;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = николаев; password = toor; charset = utf8");
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter();
            string login = textBox1.Text;
            string pass = textBox2.Text;
            MySqlCommand comm = new MySqlCommand("select * from `Sotrudniki` where `Login`= @Login and `Password` = @Password", conn);
            comm.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
            comm.Parameters.Add("@Password", MySqlDbType.VarChar).Value = pass;
            ad.SelectCommand = comm;
            ad.Fill(dt);
            BD form1 = new BD();
            if (dt.Rows.Count > 0)
            {
                form1.ac = dt.Rows[0]["Dostyp"].ToString();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }









            //if (textBox1.Text == "root")
            //{
            //    pop = pop + 1;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (textBox1.Text == list[i].login && textBox2.Text == list[i].pass && pop <= 5)
            //        {

            //            var f = new Form1();
            //            f.Show();

            //            this.Hide();
            //        }

            //    }
            //}
            //else if (textBox1.Text != "root")
            //{
            //    pop = pop + 1;
            //    for (int i = 0; i < list.Count; i++)
            //    {


            //        if (textBox1.Text == list[i].login && textBox2.Text == list[i].pass && pop <= 5)
            //        {

            //            var f = new Form1();
            //            f.Show();

            //            this.Hide();
            //        }

            //    }

            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
