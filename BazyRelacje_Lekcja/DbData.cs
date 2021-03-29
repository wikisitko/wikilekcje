using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazyRelacje_Lekcja
{
    class DbData
    {
        private DB context;

        public DbData()
        {
            context = new DB();
        }

        public List<Client> GetAllClients()
        {
                var clients = context.Clients.ToList();
                return clients;
        }

        public List<Complaint> GetAllComplaints()
        {
                var complaints = context.Complaints.ToList();
                return complaints;
        }

        public void AddClient(Client client)
        {
                context.Clients.Add(client);
                context.SaveChanges();
        }

        public void AddComplaint(Complaint complaint)
        {
                context.Complaints.Add(complaint);
                context.SaveChanges();
        }
    }
}
