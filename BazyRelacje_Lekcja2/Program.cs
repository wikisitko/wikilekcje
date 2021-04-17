using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazyRelacje_Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection db = new DbConnection();

            Console.WriteLine("Nacisnij [z] aby zalogowac lub [r] aby dokonac rejestracji");
            char key = Console.ReadKey().KeyChar;
            if(key == 'r')
            {
                Console.WriteLine("Podaj login");
                string login = Console.ReadLine();
                Console.WriteLine("Podaj email");
                string email = Console.ReadLine();
                Console.WriteLine("Podaj haslo");
                string password = Console.ReadLine();
                if(db.CreateAccount(login, email, password.ToSha256Hash()))
                {
                    Console.WriteLine("Stworzono uzytkownika");
                }
                else
                {
                    Console.WriteLine("Blad!");
                }
            }
            else if(key == 'z')
            {
                Console.WriteLine("Podaj login");
                string login = Console.ReadLine();
                Console.WriteLine("Podaj haslo");
                string password = Console.ReadLine();

                User user = db.LogIn(login, password.ToSha256Hash());
                if(user == null)
                {
                    Console.WriteLine("Niepoprawne dane logowania");
                }
                else
                {
                    Console.WriteLine("Witaj: " + user.Email);
                    Console.WriteLine("Twoj wall:");
                    db.GetAllPosts().ForEach(x => Console.WriteLine($"({x.Id}) [{x.Owner.Login}] {x.Text}, data dodania: {x.Date} lajki: {x.Likes.Select(x => x.User.Login).ElementsToString()}"));
                    Console.WriteLine("Dodaj posta:");
                    string text = Console.ReadLine();
                    db.AddPost(user, text);
                    Console.WriteLine("Wybierz co chcesz polajkowac Id: ");
                    int id = int.Parse(Console.ReadLine());
                    if (db.AddLike(user, db.GetAllPosts().Where(x => x.Id == id).First()))
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Nie mozna polajkowac!");
                    }
                }
            }
        }
    }
}
