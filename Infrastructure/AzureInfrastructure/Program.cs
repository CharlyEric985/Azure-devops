using System;

namespace AzureInfrastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== DÉPLOIEMENT INFRASTRUCTURE =====");
            string vmName = "VM-Pret";
            string resourceGroup = "GroupePret";
            string region = "EastUS";
            string vmSize = "Standard_B1s";
            string adminUser = "azureuser";

            Console.WriteLine($"Nom de la VM : {vmName}");
            Console.WriteLine($"Groupe de ressources : {resourceGroup}");
            Console.WriteLine($"Région : {region}");
            Console.WriteLine($"Taille de la VM : {vmSize}");
            Console.WriteLine($"Utilisateur administrateur : {adminUser}");
            Console.WriteLine();
            Console.WriteLine("Simulation terminée : la VM serait créée avec ces paramètres sur Azure.");
        }
    }
}
