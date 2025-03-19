namespace Encapsulationtask;

internal class Program
{
    static void Main(string[] args)

      
    {

        Console.WriteLine("UserName daxil edin");
        string username = Console.ReadLine();


        Console.WriteLine("password daxil edin");
        string password = Console.ReadLine();

        User user = new User( username, password);

        if (username.Length>=6 && username.Length<=25 && password.Length>=8 && password.Length<=25)
        {
            Console.WriteLine("istifadeci yaradildi");
            Console.WriteLine($"Username:{username}");
            Console.WriteLine($"Password:{password}");
        }
        else
        {
            Console.WriteLine("istifadeci yaradila bilmedi");
           
        }

           
    }
}
