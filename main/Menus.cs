namespace Classes;
using System.Text;
using System.Text.Json;
using Spectre.Console;
class Menus
{


    public static void Login()
    {

        AnsiConsole.Write(new Markup("[bold Red]Elige[/] "));
        AnsiConsole.Write(new Markup("[bold green]2 - datos publicos[/] "));
        AnsiConsole.Write(new Markup("[bold green]3 - datos con login[/] "));

    }
    public static void showMainMenu()
    {

        AnsiConsole.Write(new Markup("[bold green] Menu principal[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Usuarios[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Grados[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - Pagos[/] "));
        Console.WriteLine("");




    }
    public static void showUserMenu()
    {
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold Green] Menú de usuarios[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Buscar usuarios[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar usuario[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - Cambiar genero[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));
        Console.WriteLine("");


    }
    public static void showProductMenu()
    {
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold Green] Menú para administrar los grados[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Listar grados[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar grados[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - Cambiar si quedan plazas plazas[/] "));
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));
        Console.WriteLine("");

    }

    public static void showPagosMenu()
    {
        Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold Green] Menú para administrar los pagos del usuario[/] "));
        Console.WriteLine("");

    }

}