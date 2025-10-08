using System;

namespace AzureInfrastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomVM = "MaVM";
            string groupeRessource = "GroupePret";
            string region = "EastUS";
            string tailleVM = "Standard_B1s";
            string utilisateurAdmin = "azureuser";

            Console.WriteLine("Simulation de création d'une VM sur Azure...");
            Console.WriteLine($"Nom de la VM : {nomVM}");
            Console.WriteLine($"Groupe de ressources : {groupeRessource}");
            Console.WriteLine($"Région : {region}");
            Console.WriteLine($"Taille VM : {tailleVM}");
            Console.WriteLine($"Utilisateur Admin : {utilisateurAdmin}");
            Console.WriteLine("La VM serait créée avec ces paramètres si Azure était connecté.");
        }
    }
}
