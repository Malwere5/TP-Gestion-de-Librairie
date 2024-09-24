using System;

namespace TP_Gestion_de_Librairie
{
    internal class Media
    {
        public string Titre { get; set; }
        public int NumeroDeReference { get; set; }
        public int NombreDExemplairesDisponibles { get; set; }

        public virtual void AfficherInfos()
        {
            Console.WriteLine($"Titre: {Titre}, Numéro de Référence: {NumeroDeReference}, Nombre d'Exemplaires Disponibles: {NombreDExemplairesDisponibles}");
        }
    }

    internal class Livre : Media
    {
        public string Auteur { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Auteur: {Auteur}");
        }
    }

    internal class DVD : Media
    {
        public int Duree { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Durée: {Duree} minutes");
        }
    }

    internal class CD : Media
    {
        public string Artiste { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Artiste: {Artiste}");
        }
    }
}
