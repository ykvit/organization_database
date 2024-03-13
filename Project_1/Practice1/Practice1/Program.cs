using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice1
{
    internal static class Program
    {
        private const string ConnectionString = "Server=tcp:accident20.database.windows.net,1433;" +
            "Initial Catalog=traffic_accident;" +
            "Persist Security Info=False;" +
            "User ID=qungxixdx;" +
            "Password=t0talZrada;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection " +
            "Timeout=30;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(ConnectionString)) // Создаем новый объект SqlConnection для подключения к базе данных
            {
                try
                {
                    connection.Open(); // Пытаемся открыть соединение с базой данных
                    MessageBox.Show("Соединение успешно установлено!"); // Выводим сообщение об успешном подключении
                }
                catch (SqlException ex) // Ловим исключение, если подключение не удалось
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message); // Выводим сообщение об ошибке подключения
                }
            }

            Application.Run(new Form1());
        }
    }
}
