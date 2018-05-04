using System;
using System.Collections.Generic;

public class Program
{
    // Fields
    private static Engine _engine; // value is null
    private static Workflow _workflow; // value is null

    // Properties

    // Constructor
    static Program()
    {
        _engine = new Engine();
        _workflow = new Workflow();
    }

    // Methods  
    public static void Main()
    {
        _engine.Run(_workflow);

        Console.ReadLine();
    }

}

public interface IActivity
{
    //Properties
    string Message { get; set; }


    //Methods
    void Execute();
}

public class Engine
{
    // Fields

    // Properties

    // Constructors

    // Methods
    public void Run(Workflow workflow)
    {
        foreach (var activity in workflow.Activities)
        {
            activity.Execute();
        }
    }
}

public class Workflow
{
    // Fields

    // Properties
    public List<Activity> Activities { get; set; }

    // Constructors

    // Methods

}

public class Activity
{
    // Fields

    // Properties
    public string Message { get; private set; }

    // Constructors
    public Activity(string message)
    {
        Message = message;
    }

    // Methods
    public void Execute()
    {

    }
}
