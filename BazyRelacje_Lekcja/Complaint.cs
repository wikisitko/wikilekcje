using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BazyRelacje_Lekcja
{
    class Complaint
    {
        [Key]
        public int ComplaintId { get; set; }
        public string Text { get; set; }
        public Client Client { get; set; }
    }
}
