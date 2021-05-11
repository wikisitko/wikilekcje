using System;

namespace ToDoProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo todo = new ToDo();
            todo.DodajZadanie("opisopisipis", DateTime.Now.AddDays(7), "Zakupy");
            todo.DodajZadanie("testtesttest", DateTime.Now.AddDays(1), "Praca");
            todo.PobierzListeZadan().ForEach(x => Console.WriteLine(x));
        }
    }
}
