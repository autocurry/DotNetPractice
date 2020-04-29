using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wehelp_Bank
{
    class SQL_Database
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public void CreateDatabaseAndTable()
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");

                string sql = @"CREATE TABLE Customer(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               FirstName TEXT NOT NULL,
                               LastName TEXT NOT NULL,
                               Age INTEGER NOT NULL
                            );";
                con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            }


        }
    }
}
