using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licznik
{
    
    public partial class Logowanie : Form
    {
        public static string SetValueForText1 = "";
        public Logowanie()
        {
            InitializeComponent();
            //using (var connection = new SqliteConnection("Data Source=hello.db"))
            //{ 
            //    connection.Open();
            //    var command = connection.CreateCommand();
            //    command.CommandText =
            //        @"
            //            create table user(id integer primary key, username text, password text)
                        
            //        ";
            //    command.ExecuteNonQuery();
            //    command.CommandText =
            //       @"
            //            INSERT INTO user(username, password) values('admin', '123')
                        
            //        ";
            //   command.ExecuteNonQuery();
            //}
        }

                 
        private void Zaloguj_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @"
                    SELECT ID 
                    FROM user
                    WHERE username = $username and password = $password
                    ";
                command.Parameters.AddWithValue("$username", username);
                command.Parameters.AddWithValue("$password", password);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var name = reader.GetString(0);
                        SetValueForText1 = textBox1.Text;
                        //MessageBox.Show($"Hello, {username}!", "Hello", MessageBoxButtons.OK);
                        glowne g = new glowne();
                        this.Hide();
                        g.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong login or password", "Hello", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
