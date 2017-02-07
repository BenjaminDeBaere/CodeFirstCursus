using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new VDABContext())
            {
                System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VDABContext>());
                var jean = new Instructeur
                {
                    Voornaam = "Jean",
                    Familienaam = "Smits",
                    Wedde = 1000,
                    InDienst = new DateTime(1994, 8, 1),
                    HeeftRijbewijs = true,
                    Adres = new Adres { Straat = "Keizerslaan", HuisNr = "11", PostCode = "1000", Gemeente = "Brussel" }
                };
                context.Instructeurs.Add(jean);
                context.Cursussen.Add(new KlassikaleCrusus { Naam = "Frans in 24 uur", Van = DateTime.Today, Tot = DateTime.Today });
                context.Cursussen.Add(new ZelfstudieCursus { Naam = "Engels in 24 uur", AantalDagen = 1 });
                context.SaveChanges();
                Console.WriteLine(jean.InstructeurNr);
                Console.WriteLine(context.Instructeurs.Find(1).Familienaam);
            }
            Console.ReadLine();
        }
    }
}
