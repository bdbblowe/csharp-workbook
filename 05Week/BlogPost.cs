using System;
using System.Text;

public class Program
{
    //Fields
    private static bool _votes = false;
    private static string _command;

    //Constructor
    static Program()
    {
        _votes = false;
    }

    public static void Main()
    {
        BlogPost blogPost = new BlogPost(
            title: "My first blog post",
            description: "/////",
            created: DateTime.Now
            );

        Console.WriteLine("My BlogPost");

        while (!_votes)
        {
            Console.Clear();

            //Display Blog Post

            Console.WriteLine(">>>Blog Post Voting<<<");
            Console.Write("Please enter a command (star or unstar): ");
            Console.ReadLine();

            if (_command == "star")
            {
                Console.Clear();
                blogPost.UpVote();
            }
            else if (_command == "unstar")
            {
                Console.Clear();
                bool success = blogPost.DownVote();
            }

        }

    }
}

public class BlogPost
{
    //Fields
    private static int _votes = 0;
    private StringBuilder _summary;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }

    //Constructor
    public BlogPost(string title, string description, DateTime created)
    {
        _summary = new StringBuilder();

        Title = title;
        Description = description;
        Created = created;
    }

    //Methods


    public bool UpVote()
    {
        _votes++;

        return true;
    }

    public bool DownVote()
    {
        _votes--;

        return true;
    }

}
