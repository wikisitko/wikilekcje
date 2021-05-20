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
                "5. ODFILTRUJ ELEMENTY KATEGORII");
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
                    UsunZadanieMenu();
                    break;

                case 3:
                    OznaczJakoWykonaneMenu();
                    break;

                case 4:
                    OdfiltrujNiewykonaneMenu();
                    break;

                case 5:
                    OdfiltrujKategorieMenu();
                    break;

                default:
                    Console.WriteLine("Przykro nam, taka opcja nie jest dostępna.");
                    //tutaj można dodać "spróbuj wybrać ponownie i wrzucić program w pętlę while
                    break;
            }
        }

        private void OdfiltrujKategorieMenu()
        {
            Console.WriteLine("Jaką kategorię chcesz zobaczyć?");
            string kategoria = Console.ReadLine();
            Kategoria kat = (Kategoria)Enum.Parse(typeof(Kategoria), kategoria, true);
            todo.OdfiltrujKategorie(kat);
        }

        private void OdfiltrujNiewykonaneMenu()
        {
            Console.WriteLine("Niewykonane zadania: ");
            todo.OdfiltrujNiewykonane();
        }

        private void OznaczJakoWykonaneMenu()
        {
            Console.WriteLine("Podaj numer zadania: ");
            int numer = Int32.Parse(Console.ReadLine());
            todo.OznaczJakoWykonane(numer);
        }

        private void UsunZadanieMenu()
        {
            Console.WriteLine("Podaj numer zadania: ");
            int numer = Int32.Parse(Console.ReadLine());
            todo.UsunZadanie(numer);
        }

        private void DodajZadanieMenu()
        {
            Console.WriteLine("Dodaj opis: ");
            string opis = Console.ReadLine();

            Console.Write("Podaj datę wykonania: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kategorie: (Dom/Szkola/Praca/Wazne/NaPozniej/Zakupy)");
            string kategoria = Console.ReadLine();
            Kategoria kat = (Kategoria)Enum.Parse(typeof(Kategoria), kategoria, true);

            todo.DodajZadanie(opis, data, kat);
            
        }
    }
}
