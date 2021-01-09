using System;
using System.Collections.Generic;
using System.Text;

namespace zadanka5
{
    class InfoWydatki
    {
        private string rejon;
        private int iloscPodmiotow;
        private double wydatkiOgolem;
        private double wydatkiBiezace;
        private double wydatkiInwestycyjne;

        public InfoWydatki(string rejon, int iloscPodmiotow, double wydatkiOgolem, double wydatkiBiezace, double wydatkiInwestycyjne)
        {
            this.rejon = rejon;
            this.iloscPodmiotow = iloscPodmiotow;
            this.wydatkiOgolem = wydatkiOgolem;
            this.wydatkiBiezace = wydatkiBiezace;
            this.wydatkiInwestycyjne = wydatkiInwestycyjne;
        }

        public string Rejon { get => rejon; set => rejon = value; }
        public int IloscPodmiotow { get => iloscPodmiotow; set => iloscPodmiotow = value; }
        public double WydatkiOgolem { get => wydatkiOgolem; set => wydatkiOgolem = value; }
        public double WydatkiBiezace { get => wydatkiBiezace; set => wydatkiBiezace = value; }
        public double WydatkiInwestycyjne { get => wydatkiInwestycyjne; set => wydatkiInwestycyjne = value; }

        public override string ToString()
        {
            return $"{rejon} {iloscPodmiotow} {wydatkiOgolem} {WydatkiBiezace} {wydatkiInwestycyjne}";
        }
    }
}
