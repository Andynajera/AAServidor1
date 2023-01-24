namespace Classes;
using System.Text;
using System.Text.Json;
using Spectre.Console;




class FunctionsUs
{
    UserRepository users = new UserRepository();
    //formulario
    public static void form(UserRepository users)
    {

        try
        {
            string name = Asker.askString("Nombre del usuario nuevo: ");
            string email = Asker.askString("Email del usuario nuevo: x@x.com ");
            bool gender = Asker.askBool("Introduzca el genero MASCULINO TRUE,FEMENINO FALSE");
            DateTime birth = Asker.askDate("Introduzca el la fecha de nacimiento xx/xx/xxxx ");
            decimal height = Asker.askDecimal("Introduzca la altura ");
            int brothers = Asker.askInteger("Introduzca el numero de hermanos");
            User newUser = new User(name, email, gender, birth, height, brothers);
            users.create(newUser);
        }
        catch (Exception ex)
        {
            //Console.WriteLine("ha habido un error");
            AnsiConsole.Write(new Markup(" [red]ha habido un error! no lo has escrito bien[/]"));
            Console.WriteLine();


        }

    }
    //Buscador de usuarios
    public static void find(UserRepository users)
    {
        try
        {
            string userName = Asker.askString("Nombre del usuario que quieras buscar: ");
            User Name = users.find(userName);

            Console.WriteLine(Name.Summary());
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]No se ha encontrado el nombre[/]"));
            Console.WriteLine();
        }

    }
    //Cambiar genero solo con poner el nombre
    public static void changesG(UserRepository users)
    {
        try
        {
            string userNameToChange = Asker.askString("Nombre del usuario para cambiar el genero: ");
            User userToChange = users.find(userNameToChange);
            userToChange.ChangeGender();
        }
        catch (Exception ex)
        {
             AnsiConsole.Write(new Markup(" [red]No has escrito bien el nombre de Usuario[/]"));
        }
    }

}