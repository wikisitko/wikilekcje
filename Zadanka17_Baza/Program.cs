using System;

namespace Zadanka17_Baza
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Baza()) 
            {
               
                User u1 = new User
                {
                    Imie = "Ada",
                    Login = "lama1234",
                    Haslo = "foto"
                };
                
                context.Userzy.Add(u1);
                context.SaveChanges();
            }

            using (var context = new Baza())
            {
                foreach (var item in context.Userzy)
                {
                    Console.WriteLine($"{item.Imie} {item.Login} ");
                    for (int i = 0; i < item.Haslo.Length; i++)
                    {
                        Console.Write("*");
                    }
                    
                }
            }

            Console.WriteLine("Koniec");
        }
    }
}
