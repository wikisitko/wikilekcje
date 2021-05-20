using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoProjekt
{
    public class Menu
    {
        private ToDo todo;

        public Menu(ToDo todo)
        {
            this.todo = todo;
        }

        public void Petla()
        {
            int wybranaOpcja;
            do
            {
                PokazOpcje();
                Console.Write("Wybieram opcję: ");
                wybranaOpcja = int.Parse(Console.ReadLine());
                WykonajOpcje(wybranaOpcja);

            } while (wybranaOpcja != 0);

            //var wybranaOpcja = -1;
            //while (wybranaOpcja != 0)
            //{
            //    PokazOpcje();
            //    Console.Write("Wybieram opcję: ");
            //    wybranaOpcja = int.Parse(Console.ReadLine());
            //    WykonajOpcje(wybranaOpcja);
            //}
        }
        public void PokazOpcje()
        {
            Console.WriteLine("---------- CO CHCESZ ZROBIĆ? ----------- \n" +
                "0. WYJDŹ \n" +
                "1. DODAJ ZADANIE \n" +
                "2. USUŃ ZADANIE \n" +
                "3. OZNACZ ZADANIE JAKO WYKONANE \n" +
                "4. ODFILTRUJ ELEMENTY KTÓRE NIE ZOSTAŁY WYKONANE \n" +
                "5. ODFILTRUJ ELEMENTY KATEGORII 'WAZNE'");
        }
        public void WykonajOpcje(int wybranaOpcja)
        {
            switch (wybranaOpcja)
            {
                case 0:
                    Console.WriteLine("KONIEC");
                    break;

                case 1:
                    DodajZadanieMenu();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:
                    Console.WriteLine("Przykro nam, taka opcja nie jest dostępna.");
                    //tutaj można dodać "spróbuj wybrać ponownie i wrzucić program w pętlę while
                    break;
            }
        }

        private void DodajZadanieMenu()
        {
            Console.WriteLine("Dodaj opis: ");
            string opis = Console.ReadLine();

            Console.WriteLine("Podaj datę wykonania: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kategorie: (Dom/Szkola/Praca/Wazne/NaPozniej/Zakupy)");
            string kategoria = Console.ReadLine();
            Kategoria kat = (Kategoria)Enum.Parse(typeof(Kategoria), kategoria, true);

            todo.DodajZadanie(opis, data, kat);
            
        }
    }
}
