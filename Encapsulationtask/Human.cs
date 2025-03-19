namespace Encapsulationtask;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public byte age;
    public byte Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 150)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("bu yasda adam olar ala");
            }
        }
        
    }


    public Human()
    {

    }

    public Human(string name)
    {
        Name = name;
    }
    public Human(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }


    public void ShowFullData()
    {
        Console.WriteLine($"ad:{Name},  soyad:{Surname}, Age:{Age}");
    }
    public void GetFullName()
    {
        Console.WriteLine($"ad:{Name} soyad:{Surname}");
    }

}

public class User:Human
{
    private string username { get; set; }
private string password { get; set; }

    public string UserName 
{ 
        get { return username; } 
    set
        {
            if (value.Length >= 6 && value.Length <= 25)
            {
                username = value;

            }
            else
            {
                Console.WriteLine("daxil etdiyiniz username 6-25 simvol olmalidir");
            }
        } }
    public string Password {
        get { return password; }
        set
        {
            if (value.Length >= 8 && value.Length <= 25)
            {
                password = value;

            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz password 8-25 simvoldan ibaret olmalidir");
            }


        }
    }

    public User( string username, string password) 
    {
        UserName = username;
        Password = password;
    
    }
       
    }
