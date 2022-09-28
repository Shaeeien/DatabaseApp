using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace DatabaseApp.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string login, string password)
        {
            connection.Open();
            string query = string.Format("SELECT AccountType FROM Accounts WHERE Login='{0}' AND Password='{1}'", login, password);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int result = -1;
            if (reader.Read())
            {
                result = reader.GetInt32(0);
                connection.Close();
                return View();
            }                
            connection.Close();
            return View("LoginError", result);
        }
        //DODAĆ TRY CATCH WSZĘDZIE
        public IActionResult Register(string login, string password, string repeatedPassword)
        {
            if(login != null && password != null)
            {
                if (CheckIfAccountExists(login))
                {
                    return View("AccountExists");
                }
                else if (password != repeatedPassword)
                {
                    return View("SamePassword");
                }
                else
                {
                    connection.Open();
                    string query = string.Format("INSERT INTO Accounts(ID, AccountType, Login, Password) VALUES(NEXT VALUE FOR accounts_number, 0, '{0}', '{1}')", login, password);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int result = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (result > 0)
                        return View("RegistrationSuccess");
                    else
                        return View("RegistrationError");
                }
            }
            else
            {
                return View("RegistrationError");
            }
        }

        public IActionResult RegisterPage()
        {
            return View("Register");
        }

        private bool CheckIfAccountExists(string login)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM Accounts WHERE Login = '{0}'", login);
            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if(result > 0)
                return true;
            return false;
        }
    }
}
