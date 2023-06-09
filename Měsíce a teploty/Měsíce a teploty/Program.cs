﻿using Spectre.Console;
List<int> list = new List<int>();//list pro teploty
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
        }));//výběr dnů 
int den = int.Parse(vyber);
Console.WriteLine("Zadej hodnoty pro " + den + ". den v stupních Celsia");
list.Add(int.Parse(Console.ReadLine()));//dosazování do listu teplotami
var reset = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[green]Chceš zadat další den?[/]")
        .PageSize(10)
        .MoreChoicesText("[grey](nikdy)[/]")
        .AddChoices(new[] {
            "Ano", "Ne",
        }));//ptá se uživatele zda chce znovu pokračovat pokud ne zobrazí se menu 
if (reset == "Ano")
{
    goto starter;//jde na začátek
    Console.Clear();

}
else if (reset == "Ne")//zpuštění menu
{
menu:
    var menu = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green]Chceš zadat další den?[/]")
            .PageSize(10)
            .MoreChoicesText("[grey](nikdy)[/]")
            .AddChoices(new[] {
            "Maximalní teplota", "Minimální teplota","Průměrná teplota",//výběr z daných požadavků
            }));
    if (menu == "Maximalní teplota")//postup při volbě max tep.
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
    if (menu == "Minimální teplota")//postup při volbě min tep.
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
    if (menu == "Průměrná teplota")//postup při přůměrné tep.
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


