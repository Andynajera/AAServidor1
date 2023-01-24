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
        AnsiConsole.Write(new Markup("[bold white]1 - Productos[/] "));

        
        
    }
    public static void showUserMenu()
    {
        
        AnsiConsole.Write(new Markup("[bold Green] Menú de usuarios[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Listar usuarios[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar usuario[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - Cambiar genero[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));
                       

    }
       public static void showProductMenu()
    {
        AnsiConsole.Write(new Markup("[bold Green] Menú de productos[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]0 - Listar productos[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]1 - Insertar producto[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold white]2 - ¿Queda stock[/] "));
         Console.WriteLine("");
        AnsiConsole.Write(new Markup("[bold red]3 - Elija 3 para poder salir[/] "));

    }
    


   
}