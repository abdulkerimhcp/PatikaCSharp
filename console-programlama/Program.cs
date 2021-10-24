using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsim Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
