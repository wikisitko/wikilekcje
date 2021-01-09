using System;
using System.Collections.Generic;
using System.Text;

namespace zadanka5
{
    class Dane
    {
        private List<InfoWydatki> dane;

        public Dane()
        {
            this.dane = new List<InfoWydatki>();
        }

        public void DodajInfo(InfoWydatki info)
        {
            dane.Add(info);
        }

        public void Pokaz()
        {
            foreach (var info in dane)
            {
                Console.WriteLine(info);
            }
        }

        public void MniejNiz2Mln()
        {
            foreach (var info in dane)
            {
                if (info.WydatkiBiezace < 2000000)
                {
                    Console.WriteLine(info);
                }
            }
        }

        public void ProcPodmioty()
        {
            for (int i = 1; i < dane.Count; i++)
            {
                double proc = Math.Round(dane[i].IloscPodmiotow / (double)dane[0].IloscPodmiotow * 100, 2);
                Console.WriteLine($"{dane[i].Rejon} {proc}");
            }
        }

        public void PodmiotyMinMax()
        {
            InfoWydatki min = dane[1];
            InfoWydatki max = dane[1];

            for (int i = 2; i < dane.Count; i++)
            {
                if (dane[i].IloscPodmiotow > max.IloscPodmiotow)
                {
                    max = dane[i];
                }

                if (dane[i].IloscPodmiotow < min.IloscPodmiotow)
                {
                    min = dane[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }

        public InfoWydatki InwestycyjneMin()
        {
            InfoWydatki min = dane[1];

            for (int i = 2; i < dane.Count; i++)
            {
                if (dane[i].WydatkiInwestycyjne < min.WydatkiInwestycyjne)
                {
                    min = dane[i];
                }
            }

            return min;
        }
    }
}
