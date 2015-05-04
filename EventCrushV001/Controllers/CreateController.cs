using System.Web.Mvc;
using MySql.Data.MySqlClient;
using System;

namespace EventCrush.Controllers
{
    public class CreateController : Controller
    {
        public ActionResult PrivateUser()
        {
            return View();
        }

        public ActionResult CorporateUser()
        {
            return View();
        }

        public static MySqlConnection GetConnection(string host, string user, string pwd, string db)
        {
            string conStr = string.Format("server={0};uid={1};pwd={2};database={3}", host, user, pwd, db);
            var con = new MySqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            return con;
        }

        public static MySqlConnection GetDefaultConnection()
        {
            return GetConnection("localhost", "root", "", "EventCrush");
        }

        public ActionResult Submit(string Fornavn, string Efternavn, string Email, int Telefonnummer, string Brugernavn, string Password, string Vejnavn, int Postnummer, string By, string Land, int Vejnummer)
        {
            var con = GetDefaultConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into private_user(Username,PW,FirstName,LastName,Email,PhoneNumber) values (@Username, @PW, @FirstName, @LastName, @Email, @PhoneNumber)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Username", Brugernavn);
            cmd.Parameters.AddWithValue("@PW", Password);
            cmd.Parameters.AddWithValue("@FirstName", Fornavn);
            cmd.Parameters.AddWithValue("@LastName", Efternavn);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", Telefonnummer);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into address(Road, ZipCode, Town, Country, RoadNumber) values (@Road, @ZipCode, @Town, @Country, @RoadNumber)";
            cmd.Parameters.AddWithValue("@Road", Vejnavn);
            cmd.Parameters.AddWithValue("@ZipCode", Postnummer);
            cmd.Parameters.AddWithValue("@Town", By);
            cmd.Parameters.AddWithValue("@Country", Land);
            cmd.Parameters.AddWithValue("@RoadNumber", Vejnummer);
            cmd.ExecuteNonQuery();
            if (con != null) { con.Close(); }
            return RedirectToAction("Search_Event", "Home");
        }
    }
}