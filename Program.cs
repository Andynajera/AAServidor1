using Classes;

using Spectre.Console;


UserRepository users = new UserRepository();
ProductRepository degrees = new ProductRepository();


FunctionsMenu.Corazon();

FunctionsMenu.Tabla();
{
    //  DECLARACION DE VARIABLES DEL MENU
    string ClaveIngreso, NombreIngreso, RespuestaContinuar;
    int OpcionMENU = 0;
    Console.WriteLine();

    NombreIngreso = Console.ReadLine();

    do
    {
        // Sitema de "Login" para poder acceder al contenido
        Console.WriteLine();
        AnsiConsole.Write(new Markup("[bold red3]Hola[/] " + NombreIngreso + "[bold darkgoldenrod] Ingrese la clave para ver el contenido[/]"));
        Console.WriteLine();
        ClaveIngreso = Console.ReadLine();
        if (true)
        {
            AnsiConsole.Write(new Markup("[bold red]CONTRASEÑA INCORRECTA[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold red]Repitala de nuevo[/]"));

        }
    } while (ClaveIngreso != "123");




    {
        // Se da la bienvenida al usuario y que opcion va a escoger
        Console.Clear();
        Console.WriteLine();
        AnsiConsole.Write(new Markup("[bold red3]Hola, Bienvenido[/] " + NombreIngreso + "[bold darkgoldenrod] Seleccione que programa va usar:[/]"));
        Console.WriteLine();





        do
        {

            bool mainExit = false;

            Menus.showMainMenu();


            switch (Asker.askInteger("escoja una opcion"))

            {

                case 0:
                    bool userExit = false;
                    do
                    {
                        Menus.showUserMenu();
                        switch (Asker.askInteger("escoja una opcion"))
                        {
                            case 0:

                                //listUsers(users);

                                FunctionsUs.find(users);

                                break;
                            case 1:
                                FunctionsUs.form(users);
                                break;

                            //Se cambia automaticamente al poner el nombre
                            case 2:

                                FunctionsUs.changesG(users);

                                break;

                            default:

                                userExit = true;

                                break;
                        }

                    } while (!userExit);

                    break;


                case 1:
                    bool degreeExit = false;
                    do

                    {
                        Menus.showProductMenu();
                        switch (Asker.askInteger("escoja una opcion"))
                        {
                            case 0:


                                functionsP.listGrade(degrees);


                                break;

                            case 1:

                                functionsP.formP(degrees);
                                break;
                            case 2:

                                functionsP.changesAmount(degrees);

                                break;
                            default:
                                degreeExit = true;
                                break;
                        }

                    } while (!degreeExit);
                    break;
            }
        } while (OpcionMENU != 5);
        Console.ReadKey();
    }
}

