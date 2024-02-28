using MVC_3.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace MVC_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            List<Prodotti> prodotto = new List<Prodotti>();

            try
            {
                conn.Open();
                string query = "SELECT * FROM Prodotti";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Prodotti prodotto2 = new Prodotti();
                    prodotto2.NomeProdotto = reader.GetString(1);
                    prodotto2.ImgCop = reader.GetString(4);
                    prodotto.Add(prodotto2);
                }
            }
            catch (SqlException e)
            {
                ViewBag.Message = e.Message;
            }
            finally
            {
                conn.Close();
            }

            return View(prodotto);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}