// See https://aka.ms/new-console-template for more information
using System.Linq;
try
{
    Console.WriteLine("Enter a sentance.");

    var sentance = Console.ReadLine();
    var output = string.Empty;

    foreach (var (c, count) in from c in sentance
                               let count = sentance.Count(f => f == c && c != '\t' && c != ' ')
                               select (c, count))
    {
        if (count > 0) output += count;
        string v = sentance.Replace(c, '\t');
    }

    Console.WriteLine(output);
    var percentage = string.Empty;
    while (output.Length > 1 && percentage.Length != 2)
    {
        var begin = int.Parse(output[0] + "");
        var end = int.Parse(output[output.Length - 1] + "");
        percentage += (begin + end) + "";
        output = output.Substring(1, output.Length - 2);
        Console.WriteLine(percentage);
        if (output.Length == 1)
        {
            percentage += output + "";
            if (percentage.Length > 2)
            {
                output = percentage;
                percentage = string.Empty;
                Console.WriteLine("EOF - " + output);
            }
        }
    }
    if (int.Parse(percentage) > 80)
        Console.WriteLine(sentance + ": " + percentage + "%, good match!");
    else
        Console.WriteLine(sentance + ": " + percentage + '%');
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
try
{
    string path = "C:/Users/ntoko/Documents/data.csv";

    string[] lines = System.IO.File.ReadAllLines(path);
    foreach (string line in lines)
    {
        string[] columns = line.Split(',');
        foreach (string column in columns)
        {
            //Console.WriteLine(column);
            var sentance = column;
            var output = string.Empty;

            foreach (var (c, count) in from c in sentance
                                       let count = sentance.Count(f => f == c && c != '\t' && c != ' ')
                                       select (c, count))
            {
                if (count > 0) output += count;
                string v = sentance.Replace(c, '\t');
            }

            Console.WriteLine(output);
            var percentage = string.Empty;
            while (output.Length > 1 && percentage.Length != 2)
            {
                var begin = int.Parse(output[0] + "");
                var end = int.Parse(output[output.Length - 1] + "");
                percentage += (begin + end) + "";
                output = output.Substring(1, output.Length - 2);
                Console.WriteLine(percentage);
                if (output.Length == 1)
                {
                    percentage += output + "";
                    if (percentage.Length > 2)
                    {
                        output = percentage;
                        percentage = string.Empty;
                        Console.WriteLine("EOF - " + output);
                    }
                }
            }
            if (int.Parse(percentage) > 80)
                Console.WriteLine(sentance + ": " + percentage + "%, good match!");
            else
                Console.WriteLine(sentance + ": " + percentage + '%');

            

            var sort = from userData in sentance
                         orderby userData.Equals(percentage) descending
                         select userData;

            foreach (var user in sort)
            {
                Console.WriteLine(user);
            }

            

        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
