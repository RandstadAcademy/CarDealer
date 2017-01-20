using CarDealer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealerModelContainer db = new CarDealerModelContainer();

            //CarModel cm = new CarModel();

            //cm.ModelName = "Golf";
            //cm.Color = "Grey";
            //cm.CarDoor = 5;
            //cm.Km = 0;
            //cm.Year = 2007;


            //cm.ManifactureId = 3;


            //db.CarModels.Add(cm);

            //db.SaveChanges();



            //foreach (CarModel cm in db.CarModels)
            //{
            //    Console.WriteLine(String.Format("{0} - {1}", cm.ModelName, cm.Manifacture.Name));
            //}




            foreach (var m in db.Manifactures)
            {
                Console.WriteLine(m.Name);
                foreach (var cm in m.CarModels)
                {
                    Console.WriteLine("\t"+cm.ModelName);
                }
            }



            Console.ReadKey();
        }

        private static void Test1()
        {
            //qui potrei scrivere CarDealer.DataLayer
            //ma in realtà siccome il namespace qui è CarDealer posso limitarmi
            //a scrivere solo DataLayer.NomeCLasseNellaLibreria se non
            //voglio fare la using

            CarDealerModelContainer db = new CarDealerModelContainer();


            //per aggiungere un nuovo fornitore
            /*var man = new Manifacture();
            man.Name = "Audi";
            man.Website = "www.audi.it";

            db.Manifactures.Add(man);

            //salvo sul db
            db.SaveChanges();*/

            //db.Manifactures.First().Website = "www.fiat.it";


            //per rimuovere
            //var m1 = db.Manifactures.First();
            //db.Manifactures.Remove(m1);


            //foreach (Manifacture m in db.Manifactures)
            //{
            //    Console.WriteLine(m.Name + " "+ m.Website);
            //}



            //var s = new List<string>() { "pippo", "pluto", "topolino" };


            ////a ogni elemento applica il predicato e si prende nella nuova lista solo i true
            ////vedi la definizione della funzione anonima

            //string toCheck = "p";

            //var result = s.Where(a => a.StartsWith(toCheck));
            //a => a.Name.StartsWith("x")

            //var result = db.Manifactures.FirstOrDefault(a => a.Name.StartsWith("x"));


            //List<Manifacture> results = db.Manifactures
            //    .Where(a => a.Name.StartsWith("a"))
            //    .OrderBy(a => a.Name ).ToList();



            /*var results = from a in db.Manifactures
                         where a.Name.StartsWith("a")
                         orderby a.Name,a.Website
                         select new { Nome=a.Name , Website=a.Website};
                         */
        }
    }
}
