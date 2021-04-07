using System;
using System.Linq;

namespace BazyRelacje_Lekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            DbData data = new DbData();
            /*data.AddClient(new Client()
            {
                Code = "1214123413",
                Firstname = "Adam",
                Surname = "Kowalski"
            });*/
            data.GetAllClients().ForEach(x => Console.WriteLine($"{x.ClientId} {x.Firstname}"));
            data.GetAllComplaints().ForEach(x => Console.WriteLine($"{x.Text} {x.Client.Firstname}"));

            var clients = data.GetAllClients();

            //Complaint complaint = new Complaint
            //{
            //    Client = clients[0],
            //    Text = "not works"
            //};
            //data.AddComplaint(complaint);


            Console.WriteLine("Podaj kod abonenta");
            string kod = Console.ReadLine();
            /*if(clients.Any(x => x.Code == kod))
            {
                Client c = clients.Find(x => x.Code == kod);
                Console.WriteLine($"Zalogowano: {c.Firstname}");
            }
            else
            {
                Console.WriteLine("Niepoprawne dane logowania");
            }*/

            Client c = clients.Find(x => x.Code == kod);
            if (c != null)
            {
                Console.WriteLine($"Zalogowano: {c.Firstname} {c.Surname}");
                //var complaints = data.GetAllComplaints().FindAll(x => x.Client.ClientId == c.ClientId);
                Console.WriteLine("Twoje skargi:");
                c.Complaints.ForEach(x => Console.WriteLine(x.Text));
                //complaints.ForEach(x => Console.WriteLine(x.Text));
                Console.WriteLine("Czy chcesz zmienic nazwisko? [tak/nie]");
                string odp = Console.ReadLine();
                if(odp == "tak")
                {
                    Console.WriteLine("Podaj nowe nazwisko");
                    string nazwisko = Console.ReadLine();
                    c.Surname = nazwisko; //zmieni w bazie danych nazwisko dla tego klienta
                    data.Save(); //zapisuje zmiany dodane na obiektach z bazy
                }
            }
            else
            {
                Console.WriteLine("Niepoprawne dane logowania");
            }
        }
    }
}
