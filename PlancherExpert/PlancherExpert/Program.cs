using System.ComponentModel.Design;

namespace PlancherExpert
{
    internal class Program
    {
        // Méthode principal du programme
        static void Main(string[] args)
        {
            // Déclaration des variables et initialisation de variable a 0 
            double Longueur, Largeur, Superficie, Total_Materiaux = 0, Total_Maindoeuvre = 0, Total_Taxe = 0, Total_Combine = 0, Taxe = 0.15;
            int Choix_Couvreplancher = 0;
            string motCouvreplancher = "";
            // Affichage du menu des types de couvre-plancher
            Console.WriteLine();
            Console.WriteLine("************************Type de couvre-plancher*************************");
            Console.WriteLine("*                    1 - Tapis commercial                              *");
            Console.WriteLine("*                    2 - Tapis de qualité                              *");
            Console.WriteLine("*                    3 - Plancher de bois franc                        *");
            Console.WriteLine("*                    4 - Plancher flottant                             *");
            Console.WriteLine("*                    5 - Céramique                                     *");
            Console.WriteLine("************************************************************************");
            
            // Demande de saisi du type de couvre-plancher
            Console.Write(" Veuillez choisir un numéro valide parmit ceux ci-dessus : ");
            Choix_Couvreplancher = Convert.ToInt16(Console.ReadLine());
            
            // initialisation de la boucle while qui assure que le chiffre donné se trouve entre 1 à 5
            while (Choix_Couvreplancher < 1 || Choix_Couvreplancher > 5)
            {
                Console.Write(" Choix invalide. Veuillez choisir à nouveau dans la plage de 1 à 5 seulement : ");
                Choix_Couvreplancher = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine();
            
            // initialisation de la boucle qui s'assure que la longueur donnée est bien une valeur numérique
            do
            {
                // Invitation de saisi pour la longueur
                Console.Write(" Donnez-moi la longueur de la pièce à couvrir en pied carrés: ");
            } while (!double.TryParse(Console.ReadLine(), out Longueur));

            // initialisation de la boucle qui s'assure que la largeur donnée est bien une valeur numérique
            Console.WriteLine() ;
            do {
                // Invitation de saisi pour la largeur
                Console.Write(" Donnez-moi la largeur de la pièce à couvrir en pied carrés : ");
            } while (!double.TryParse(Console.ReadLine(),out Largeur));


            // Calcul de la superficie par rapport a la largeur et la longueur donnée
            Superficie = Longueur * Largeur;
            // CasEntry pour faire calcul des sommes totales dépendamment du choix de couvreplancher
            switch (Choix_Couvreplancher)
            {
                case 1:
                    // Calcul Total_materiaux pour tapis commercial et de la main d'oeuvre
                    motCouvreplancher = "Tapis commercial";
                    Total_Materiaux = Superficie * 1.29;
                    Total_Maindoeuvre = Superficie * 2.00;
                    // Calcul du total de la taxe applicable sur le montant total des matériaux et de la main d'oeuvre
                    Total_Taxe = (Total_Materiaux + Total_Maindoeuvre) * Taxe;
                    // Calcul du total combine des matériaux, de la main d'oeuvre et des taxes
                    Total_Combine = Total_Materiaux + Total_Maindoeuvre + Total_Taxe;
                    break;

                case 2:
                    // Calcul Total_materiaux pour tapis commercial et de la main d'oeuvre
                    motCouvreplancher = "Tapis de qualité";
                    Total_Materiaux = Superficie * 3.99;
                    Total_Maindoeuvre = Superficie * 2.25;
                    // Calcul du total de la taxe applicable sur le montant total des matériaux et de la main d'oeuvre
                    Total_Taxe = (Total_Materiaux + Total_Maindoeuvre) * Taxe;
                    // Calcul du total combine des matériaux, de la main d'oeuvre et des taxes
                    Total_Combine = Total_Materiaux + Total_Maindoeuvre + Total_Taxe;
                    break;

                case 3:
                    // Calcul Total_materiaux pour tapis commercial et de la main d'oeuvre
                    motCouvreplancher = "Plancher de bois franc";
                    Total_Materiaux = Superficie * 3.49;
                    Total_Maindoeuvre = Superficie * 3.25;
                    // Calcul du total de la taxe applicable sur le montant total des matériaux et de la main d'oeuvre
                    Total_Taxe = (Total_Materiaux + Total_Maindoeuvre) * Taxe;
                    // Calcul du total combine des matériaux, de la main d'oeuvre et des taxes
                    Total_Combine = Total_Materiaux + Total_Maindoeuvre + Total_Taxe;
                    break;

                case 4:
                    // Calcul Total_materiaux pour tapis commercial et de la main d'oeuvre
                    motCouvreplancher = "Plancher flottant";
                    Total_Materiaux = Superficie * 1.99;
                    Total_Maindoeuvre = Superficie * 2.25;
                    // Calcul du total de la taxe applicable sur le montant total des matériaux et de la main d'oeuvre
                    Total_Taxe = (Total_Materiaux + Total_Maindoeuvre) * Taxe;
                    // Calcul du total combine des matériaux, de la main d'oeuvre et des taxes
                    Total_Combine = Total_Materiaux + Total_Maindoeuvre + Total_Taxe;
                    break;

                case 5:
                    // Calcul Total_materiaux pour tapis commercial et de la main d'oeuvre
                    motCouvreplancher = "Céramique";
                    Total_Materiaux = Superficie * 1.49;
                    Total_Maindoeuvre = Superficie * 3.25;
                    // Calcul du total de la taxe applicable sur le montant total des matériaux et de la main d'oeuvre
                    Total_Taxe = (Total_Materiaux + Total_Maindoeuvre) * Taxe;
                    // Calcul du total combine des matériaux, de la main d'oeuvre et des taxes
                    Total_Combine = Total_Materiaux + Total_Maindoeuvre + Total_Taxe;
                    break;
            }

            // Affichage de la superficie
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" Vous avez donné une superficie à couvrir de {Superficie} pied carrés.");
            // Affichage du type de couvre-plancher choisi
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" Vous avez choisi {motCouvreplancher} comme type de couvre-plancher.");
            Console.WriteLine();
            Console.WriteLine();
            // Affichage du coût total relié au matériaux
            Console.WriteLine($" Le montant total pour les coûts reliés au matériaux est de {Total_Materiaux.ToString("0.00")} $.");
            Console.WriteLine();
            Console.WriteLine();
            // Affichage du coût total reliés à la main d'oeuvre 
            Console.WriteLine($" Le montant total pour les coûts reliés à la main d'oeuvre est de {Total_Maindoeuvre.ToString("0.00")} $.");
            Console.WriteLine();
            Console.WriteLine();
            // Affichage du cout total des taxes pour la main d'oeuvre et les matériaux
            Console.WriteLine($" Le montant total des taxes pour les coûts reliés aux matériaux et à la main d'oeuvre est de {Total_Taxe.ToString("0.00")} $.");
            Console.WriteLine();
            Console.WriteLine();
            // Affichage du cout total combiné de la main d'oeuvre, des matériaux et des taxes.
            Console.WriteLine($" Le montant total des coûts pour l'achat et l'installation du couvre-plancher est de {Total_Combine.ToString("0.00")} $, taxes incluses.");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}