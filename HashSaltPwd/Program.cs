using System.Security.Cryptography;

namespace HashSaltPwd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("https://code-maze.com/csharp-hashing-salting-passwords-best-practices/");
            HashSalt brownie = new HashSalt();
            Console.WriteLine("Write your password: ");
            string password = Console.ReadLine();
            string hash = brownie.HashPassword(password);

            bool OK = brownie.Verify(password, hash);

        }
    }
}
