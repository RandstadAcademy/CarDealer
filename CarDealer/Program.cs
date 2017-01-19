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


            var result = db.Manifactures.First(a => a.Name.StartsWith("a"));



            Console.ReadKey();
        }
    }
}
