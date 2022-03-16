using System;

namespace _16MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user user = new user();
            user.Password = "adhasdas1A";
            user.Username = "asd";
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Username);
        }
    }
}
