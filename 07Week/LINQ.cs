using System;
using System.Linq;

public class Program
{
    //static void Main()
    //{
    //    string names = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";

    //    int i = 1;
    //    var players = from name in names.Split(',')
    //                  select String.Format("{0} {1}", name, i++);

    //    players.ToList().ForEach(Console.Write);
    //}

    //static void Main()
    //{
    //    string players = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";

    //    var output = from player in players.Split(';')
    //                 let splitted = player.Split(',')
    //                 let date = DateTime.ParseExact(splitted[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
    //                 select new
    //                 {
    //                     Name = splitted[0],
    //                     Date = splitted[1],
    //                     Old = new DateTime((DateTime.Now - date).Ticks).Year
    //                 };

    //    output.ToList().ForEach(Console.WriteLine);
    //}

    static void Main()
    {
        string durations = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

        var output = from d in durations.Split(',')
                     select TimeSpan.Parse(String.Format("{0}:{0},", d)).TotalSeconds;

    }

}
