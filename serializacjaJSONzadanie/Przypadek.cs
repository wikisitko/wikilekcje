using System;
using System.Collections.Generic;
using System.Text;

namespace serializacjaJSONzadanie
{
    public class Przypadek
    {
        private string id;
        private string date;
        private string voivodeship;
        private string region;
        private string gender;
        private string description;

        public string ID { get => id; set => id = value; }
        public string DATE { get => date; set => date = value; }
        public string VOIVODESHIP { get => voivodeship; set => voivodeship = value; }
        public string REGION { get => region; set => region = value; }
        public string GENDER { get => gender; set => gender = value; }
        public string DESCRIPTION { get => description; set => description = value; }

        public override string ToString()
        {
            return $"{ID}. [{DATE}] {VOIVODESHIP} - {REGION} - {GENDER} - {DESCRIPTION}";
        }
    }
}
