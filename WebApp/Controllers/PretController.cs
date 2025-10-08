using Microsoft.AspNetCore.Mvc;
using WebApp.Models; // N'oublie pas d'ajouter le namespace de ton modèle
using System;
using System.Collections.Generic;

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
            var schedule = new List<AmortizationRow>();

            if (taux > 0 && duree > 0)
            {
                double tauxMensuel = taux / 12 / 100;
                mensualite = montant * tauxMensuel / (1 - Math.Pow(1 + tauxMensuel, -duree));

                double solde = montant;
                for (int i = 1; i <= duree; i++)
                {
                    double interet = solde * tauxMensuel;
                    double capital = mensualite - interet;
                    solde -= capital;

                    schedule.Add(new AmortizationRow
                    {
                        Mois = i,
                        Mensualite = Math.Round(mensualite, 2),
                        Interet = Math.Round(interet, 2),
                        Capital = Math.Round(capital, 2),
                        Solde = Math.Round(solde > 0 ? solde : 0, 2)
                    });
                }
            }

            ViewBag.Mensualite = Math.Round(mensualite, 2);
            ViewBag.Montant = montant;
            ViewBag.Taux = taux;
            ViewBag.Duree = duree;

            return View(schedule);
        }
    }
}
