using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BazyRelacje_Lekcja
{
    class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Code { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        //public virtual ICollection<Complaint> Complaints { get; set; }
    }
}
