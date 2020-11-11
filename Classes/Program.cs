using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "Paul";
            john.LastName = "Padian";
            john.Introduce();
        
        }
    }
}
