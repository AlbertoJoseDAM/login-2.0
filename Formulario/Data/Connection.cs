using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;



namespace Formulario.Data
{
    internal static class Connection
    {

        public static string server = "127.0.0.1";
        public static string DataBase = "login";
        public static string User = "root";
        public static string psw = "root";

        public static MySqlConnection connMaster = new MySqlConnection();

        public static void OpenConnection()
        {
            String connectionString = $"server={server};database{DataBase};user{User};password{psw};";
            
            connMaster = new MySqlConnection(connectionString);
            connMaster.Open();

            if(connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion establecida");
            }
            else MessageBox.Show("Conexion NO se puede establecer");

        }

        public static void CloseConnection() 
        {
        
        }

    }
}
