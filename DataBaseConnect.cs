using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace heumnEXdemo2
{
    public class DataBaseConnect
    {
        private static string path = "server=192.168.3.11;port=3306;database = heumndb; user = heumnDB; password = 12312345";

        private static MySqlConnection sqlConnection = new MySqlConnection(path);

        public string getLogin(string login, string password)
        {

            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            string command = $"SELECT id FROM employee WHERE password=\"{password}\" AND login=\"{login}\"";

            MySqlCommand cmd = new MySqlCommand(command, sqlConnection);
            object z = cmd.ExecuteScalar();
            Console.WriteLine("Вывод");


            Console.WriteLine(z);
            if (z == null)
            {
                z = "null";
            }
            Console.WriteLine("Вывод 2");


            Console.WriteLine(z);
            return z.ToString();
        }

        public string[] getinfo(string id)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            string command = $"SELECT first_name, last_name, patronymic, doljnost FROM employee WHERE id={id}";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            string[] answer = new string[table.Columns.Count];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = table.Rows[0][i].ToString();
            }
            return answer;
        }

        public void typeLogin(string login, string typelogin)
        {
            try
            {
                sqlConnection.Open();
            }
            catch { }

            string command = $"UPDATE employee SET last_login=\"{DateTime.Now}\", type_login=\"{typelogin}\" WHERE login=\"{login}\"";

            MySqlCommand cmd = new MySqlCommand(command, sqlConnection);
            cmd.ExecuteNonQuery();
        }

        public bool addZakaz(string dataCreate, string timeCreate, string codeKlient, string yslygs, string status, string dataClose, string timeMinuts)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            try
            {
                Console.WriteLine(dataCreate);
                Console.WriteLine(timeCreate);
                Console.WriteLine(codeKlient);
                Console.WriteLine(yslygs);
                Console.WriteLine(status);
                Console.WriteLine(dataClose);
                Console.WriteLine(timeMinuts);

                string commandId = "SELECT MAX(id) FROM zakazi";

                MySqlCommand cmd = new MySqlCommand(commandId, sqlConnection);
                object a = cmd.ExecuteScalar();
                int b = int.Parse(a.ToString()) + 1;

                string codeZ = "" + codeKlient + "/" + dataCreate;

                string command = $"INSERT INTO zakazi VALUES(" +
                    $"{b},\"{codeZ}\",\"{dataCreate}\",\"{timeCreate}\",\"{codeKlient}\"," +
                    $"\"{yslygs}\",\"{status}\",\"{dataClose}\",\"{timeMinuts}\")";

                Console.WriteLine(command);

                MySqlCommand cmdz = new MySqlCommand(command, sqlConnection);
                cmdz.ExecuteNonQuery();

                MessageBox.Show("Заказ добавлен");

            }
            catch {
                MessageBox.Show("ошибка в добавлении товара");
                return false;
            }

            return true;
        }

        public DataTable getLogins()
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }
            string command = "SELECT * FROM employee";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            table.Columns[0].ColumnName = "id";
            table.Columns[1].ColumnName = "Должность";
            table.Columns[2].ColumnName = "Фамилия";
            table.Columns[3].ColumnName = "Имя";
            table.Columns[4].ColumnName = "Отчество";
            table.Columns[5].ColumnName = "Логин";
            table.Columns[6].ColumnName = "Пароль";
            table.Columns[7].ColumnName = "Последний вход";
            table.Columns[8].ColumnName = "Тип входа";


            return table;
        }

        public DataTable getTovars()
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            string command = "SELECT * FROM zakazi";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, sqlConnection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            table.Columns[0].ColumnName = "id";
            table.Columns[1].ColumnName = "код заказа";
            table.Columns[2].ColumnName = "дата создания";
            table.Columns[3].ColumnName = "время заказа";
            table.Columns[4].ColumnName = "код клиента";
            table.Columns[5].ColumnName = "услуги";
            table.Columns[6].ColumnName = "статус";
            table.Columns[7].ColumnName = "дата закрытия";
            table.Columns[8].ColumnName = "время";

            return table;
        }

        public DataTable getLoginsByUser(string login)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }
            string command = $"SELECT * FROM employee WHERE login = \"{login}\"";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            return table;
        }


        public DataTable getDataSort(string data)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }
            string command = $"SELECT * FROM employee WHERE last_login = \"{data}\"";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            return table;

        }

        public DataTable getYslugs()
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }
            string yslygs = $"SELECT name_yslyga FROM ysluga";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(yslygs, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            return table;
        }

        public void loginUser(string user, string lastLogin)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            string command = $"UPDATE employee SET last_login=\"{lastLogin}\" WHERE login=\"{user}\"";

            MySqlCommand commandsql = new MySqlCommand(command, sqlConnection);
            commandsql.ExecuteNonQuery();
        }

        public DataTable getTable(string tablesql)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }
            string command = $"SELECT * FROM {tablesql}";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, sqlConnection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public void setYsluga(string name, string code, string cost)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            string getMaxId = "SELECT MAX(id) FROM ysluga";

            MySqlCommand commandGetId = new MySqlCommand(getMaxId, sqlConnection);

            Object id = commandGetId.ExecuteScalar();
            int idmain = int.Parse(id.ToString());
            idmain++;

            string commandMain = $"INSERT INTO ysluga VALUES ({idmain}, \"{name}\",  \"{code}\", \"{cost}\")";

            MySqlCommand command = new MySqlCommand(commandMain, sqlConnection);

            command.ExecuteNonQuery();
        }

        public void addUser(string doljnost, string name, string lastname, string patronymic, string login, string password)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }

            MySqlCommand command = new MySqlCommand("SELECT MAX(id) FROM employee", sqlConnection);

            int id = int.Parse(command.ExecuteScalar().ToString()) + 1;

            MySqlCommand commandAddUser = new MySqlCommand($"INSERT INTO employee VALUES ({id}, \"{doljnost}\", \"{lastname}\", \"{name}\", \"{patronymic}\", \"{login}\", \"{password}\", \"{DateTime.Now.ToString()}\", \"true\") ", sqlConnection);
            commandAddUser.ExecuteNonQuery();
        }


        public void addKlient(
            string lastname,
            string name,
            string patronymic,
            string passNumber,
            string passSeries,
            string dataBirth,
            string adressIndex,
            string adressCity,
            string adressStreet,
            string adressHouse,
            string adressKvartira,
            string email,
            string password)
        {
            try
            {
                sqlConnection.Open();
            }
            catch
            {
            }


            MySqlCommand commandId = new MySqlCommand("SELECT MAX(code_klient) FROM klients", sqlConnection);

            int id = int.Parse(commandId.ExecuteScalar().ToString()) + 1;


            string commandstr = $"INSERT INTO klients VALUES ({id}, \"{lastname}\",\"{name}\",\"{patronymic}\",\"{passNumber}\",\"{passSeries}\",\"{dataBirth}\",\"{adressIndex}\",\"{adressCity}\",\"{adressStreet}\",\"{adressHouse}\",\"{adressKvartira}\",\"{email}\",\"{password}\") ";


            MySqlCommand command = new MySqlCommand(commandstr, sqlConnection);

            command.ExecuteNonQuery();

        }

        public string getInfoFromTable(string tablename, string name)
        {
            DataTable table = getTable(tablename);

            string temp = "";

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    DataRow row = table.Rows[j];

                    temp += name + ": ";

                for (int n = 0; n < table.Columns.Count; n++)
                    {
                        DataColumn column = table.Columns[n];

                        temp += " " + (row[column]);
                    }
                temp += "\n";
                }



            return temp;
        }
    }
}
