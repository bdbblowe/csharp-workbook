using System;

public class Program
{
    public static void Main()
    {
        bool isHuman = true;

        bool f = false;

        decimal num = 9.99m;

        decimal total = num * num;

        string firstName = "Benjamin";
        string lastName = "Blowe";
        int age = 24;
        string job = "Developer";
        string favoriteBand = "Mal Devisa";
        string favoriteSportsTeams = "Spurs";

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Job: " + job);
        Console.WriteLine("Favorite Band: " + favoriteBand);
        Console.WriteLine("Favorite Sports Team: " + favoriteSportsTeams);


        int myInteger = (int)num;

        Console.WriteLine("My Integer: " + myInteger);





        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
}
