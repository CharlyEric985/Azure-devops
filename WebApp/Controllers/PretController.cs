using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(double montant, double taux, int duree)
        {
            double mensualite = 0;
            if (taux > 0 && duree > 0)
            {
                double tauxMensuel = taux / 12 / 100;
                mensualite = montant * tauxMensuel / (1 - Math.Pow(1 + tauxMensuel, -duree));
            }

            ViewBag.Mensualite = Math.Round(mensualite, 2);
            ViewBag.Montant = montant;
            ViewBag.Taux = taux;
            ViewBag.Duree = duree;

            return View();
        }
    }
}
