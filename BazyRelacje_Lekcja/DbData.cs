using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazyRelacje_Lekcja
{
    class DbData
    {
        public List<Client> GetAllClients()
        {
            using(DB context = new DB())
            {
                var clients = context.Clients.ToList();
                return clients;
            }
        }

        public List<Complaint> GetAllComplaints()
        {
            using (DB context = new DB())
            {
                var complaints = context.Complaints.ToList();
                return complaints;
            }
        }

        public void AddClient(Client client)
        {
            using (DB context = new DB())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public void AddComplaint(Complaint complaint)
        {
            using (DB context = new DB())
            {
                context.Complaints.Add(complaint);
                context.SaveChanges();
            }
        }
    }
}
