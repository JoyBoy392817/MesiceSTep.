using Spectre.Console;
List<int> list = new List<int>();
starter:

var vyber = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[green]Vyber si den a doplň hodnoty[/]")
        .PageSize(10)
        .MoreChoicesText("[grey](Pohybuj se na horu a dolu pro více dnů)[/]")
        .AddChoices(new[] {
            "1", "2", "3",
            "4", "5", "6",
            "7", "8", "9",
            "10", "11", "12",
            "13", "14", "15",
            "16", "17", "18",
            "19", "20", "21",
            "22", "23", "24",
            "25", "26", "27",
            "28", "29", "30",
            "31"
        }));
int den = int.Parse(vyber);
Console.WriteLine("Zadej hodnoty pro " + den + ". den v stupních Celsia");
list.Add(int.Parse(Console.ReadLine()));
var reset = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[green]Chceš zadat další den?[/]")
        .PageSize(10)
        .MoreChoicesText("[grey](nikdy)[/]")
        .AddChoices(new[] {
            "Ano", "Ne",
        }));
if(reset == "Ano")
{
    goto starter;
    Console.Clear();

}
else if (reset == "Ne")
{
    menu:
    var menu = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green]Chceš zadat další den?[/]")
            .PageSize(10)
            .MoreChoicesText("[grey](nikdy)[/]")
            .AddChoices(new[] {
            "Maximalní teplota", "Minimální teplota","Průměrná teplota",
            }));
    if (menu == "Maximalní teplota")
    {
        Console.WriteLine("_______________________________________________");
        int maxmalni = list.Max();
        Console.WriteLine("Maximální teplota je " + maxmalni);
        Console.WriteLine("Pro vracení zpět do menu stiskni Space");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            goto menu;
        }
    }
    if (menu == "Minimální teplota")
    {
        Console.WriteLine("_______________________________________________");
        int minmalni = list.Min();
        Console.WriteLine("Minimální teplota je " + minmalni);
        Console.WriteLine("Pro vracení zpět do menu stiskni Space");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            goto menu;
        }
    }
    if (menu == "Průměrná teplota")
    {
        Console.WriteLine("_______________________________________________");
        double avr = list.Average();
        Console.WriteLine("Průměrná teplota je " + avr);
        Console.WriteLine("Pro vracení zpět do menu stiskni Space");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            goto menu;
        }
    }
}



