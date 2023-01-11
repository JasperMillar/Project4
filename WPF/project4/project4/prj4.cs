using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project4
{
    class prj4
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=prj4;Uid=root;Pwd=;");
        public DataTable Selectpizzasoort()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM pizzasoort;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public DataTable Selecttoppings()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM toppings;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Insertpizzasoort(string pizzasoort, string toppings, string prijs)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `pizzasoort` (`pizzaid`, `pizzasoort`, `toppings`, `prijs`) VALUES (NULL, @pizzasoort, @toppings, @prijs) ";
                command.Parameters.AddWithValue("@pizzasoort", pizzasoort);
                command.Parameters.AddWithValue("@toppings", toppings);
                command.Parameters.AddWithValue("@prijs", prijs);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception ex)
            {
                //Problem with the database
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        public bool Updatepizza(string pizzasoort, string toppings, string prijs, string id)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE `pizzasoort` SET `pizzasoort` = @pizzasoort, `toppings` = @toppings, `prijs` = @prijs WHERE `pizzasoortsoort`.`pizzaid` = @id; ";
                command.Parameters.AddWithValue("@pizzasoort", pizzasoort);
                command.Parameters.AddWithValue("@toppings", toppings);
                command.Parameters.AddWithValue("@prijs", prijs);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception ex)
            {
                //Problem with the database
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        public bool Deletepizza(string id)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `pizzasoort` WHERE `pizzasoort`.`pizzaid` = @id;";
                command.Parameters.AddWithValue("@id", id);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        public bool Insertstandpunt(string standpunt, string thema)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `standpunt` (`thema_id`, `standpunt`) VALUES (@thema_id, @standpunt) ";
                command.Parameters.AddWithValue("@standpunt", standpunt);
                command.Parameters.AddWithValue("@thema_id", thema);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception ex)
            {
                //Problem with the database
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        public bool Updatestandpunt(string id, string thema, string standpunt)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE `standpunt` SET `standpunt` = @standpunt, `thema_id` = @thema_id WHERE `standpunt`.`standpunt_id` = @id; ";
                command.Parameters.AddWithValue("@standpunt", standpunt);
                command.Parameters.AddWithValue("@thema_id", thema);
                command.Parameters.AddWithValue("@id", id);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception ex)
            {
                //Problem with the database
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
        public bool Deletestandpunt(string id)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `standpunt` WHERE `standpunt`.`standpunt_id` = @id;";
                command.Parameters.AddWithValue("@id", id);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }
    }
}
