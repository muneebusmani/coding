using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        Auth userAuth = new Auth();
        userAuth.ProcessOption();
    }
}

class Auth
{
    private const int SignUp = 1;
    private const int SignIn = 2;

    private List<NewUser> users; // Store user data in memory

    public Auth()
    {
        users = LoadUsersFromJsonFile("users.json");
    }

    public void ProcessOption()
    {
        Console.WriteLine("1. Sign Up\n2. Sign in");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case SignUp:
                Signup();
                break;

            case SignIn:
                Signin();
                break;

            default:
                Console.WriteLine("Please choose the correct option.");
                Thread.Sleep(2000);
                Console.Clear();
                Program.Main();
                break;
        }
    }

    private void Signup()
    {
        string name;

        do
        {
            Console.WriteLine("Enter your Name");
            name = Console.ReadLine();

            if (Regex.IsMatch(name, @"\d"))
            {
                Console.Clear();
                Console.WriteLine("Name Must not Contain Numbers");
                Thread.Sleep(2000);
                Console.Clear();
            }
        } while (Regex.IsMatch(name, @"\d"));

        Console.WriteLine("Enter your email");
        string email = Console.ReadLine();

        Console.WriteLine("Create a Password");
        string password = Console.ReadLine();

        Console.WriteLine("Confirm Password");
        string cPassword = Console.ReadLine();

        if (password == cPassword)
        {
            NewUser newUser = new NewUser
            {
                Name = name,
                Email = email,
                Password = password
            };

            users.Add(newUser);

            SaveUsersToJsonFile("users.json", users);

            Console.Clear();
            Console.WriteLine("Signed Up Successfully!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Sign in");
            Thread.Sleep(2000);
            Console.Clear();
            Signin();
        }
        else
        {
            Console.WriteLine("Password and confirm password do not match.");
        }

        Console.ReadKey();
    }

    private void Signin()
    {
        Console.Clear();
        Console.WriteLine("Enter your email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Your Password");
        string password = Console.ReadLine();

        // Check if the provided email and password match any existing user's credentials
        bool isSignInSuccessful = users.Exists(user => user.Email == email && user.Password == password);

        if (isSignInSuccessful)
        {
            Console.Clear();
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid email or password.");
            Thread.Sleep(2000);
            Console.Clear();
            this.Signin();
        }

        Console.ReadKey();
    }

    private List<NewUser> LoadUsersFromJsonFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<UserList>(json)?.Users ?? new List<NewUser>();
        }
        return new List<NewUser>();
    }

    private void SaveUsersToJsonFile(string fileName, List<NewUser> userList)
    {
        string jsonOutput = JsonSerializer.Serialize(new UserList { Users = userList }, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsonOutput);
    }
}

class UserList
{
    public List<NewUser> Users { get; set; }
}

class NewUser
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
