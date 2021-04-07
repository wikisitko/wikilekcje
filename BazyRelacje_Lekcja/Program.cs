using System;

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
            Complaint complaint = new Complaint
            {
                Client = clients[0],
                Text = "not works"
            };
            data.AddComplaint(complaint);
        }
    }
}
