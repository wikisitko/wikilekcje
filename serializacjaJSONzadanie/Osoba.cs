using System;
using System.Collections.Generic;
using System.Text;

namespace serializacjaJSONzadanie
{
    class Osoba //klasa-model - reprezentuje tabele danych - bez metod - tabela nie musi sie pokrywac nazwowo/typodanowo ze zmniennymi z klasy Przypadek 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Voivodeship { get; set; }
        public string Region { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }
}
