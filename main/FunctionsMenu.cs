namespace Classes;
using System.Text;
using System.Text.Json;
using Spectre.Console;




class FunctionsMenu
{

    public static void Corazon()
    {
        AnsiConsole.Write(new Markup("[bold red]  000   000[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red] 0   00 00  0[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]   0      0[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]     0  0[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]       0  [/] "));
        Console.WriteLine("");
        Console.WriteLine("");
    }

    public static void Tabla()
    {
        var table = new Table();

        // Add some columns
        table.AddColumn("Informacion General");
        table.AddColumn(new TableColumn("San Valero").Centered());
        table.AddColumn(new TableColumn("FAQ").Centered());

        // Add some rows

        // Add some rowsç
        table.AddRow("images", "Buy");
        table.AddRow("News", "Newsletter");


        table.AddRow(new Markup("[blue]Introduzca el nombre de Administrador[/]"), new Panel("[blue]Name:[/]"));

        // Render the table to the console
        AnsiConsole.Write(table);


    }
}