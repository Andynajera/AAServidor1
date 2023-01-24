namespace Classes;
using System.Text;
using System.Text.Json;
using Spectre.Console;


class functionsP
{

    ProductRepository degrees = new ProductRepository();


public static void listGrade(ProductRepository degrees)
{
    List<Product> allProducts = degrees.all();
    foreach (Product individualProduct in allProducts)
    {
        Console.WriteLine(individualProduct.Summary());
    }

}


    public static void formP(ProductRepository degrees)
    {
        try
        {
            string name = Asker.askString("nombre con identificador grado: ");
            string nameDegree = Asker.askString("nombre del grado: ");
            bool quedanPlazas = Asker.askBool("Introduzca si queda plazas true si no false");
            DateTime dataExpediente = Asker.askDate("Introduzca el la fecha de comiezo ");
            decimal price = Asker.askDecimal("Introduzca el precio ");
            int cantidadPlazas = Asker.askInteger("Introduzca la cantidad de plazas");
            Product newProduct = new Product(name, nameDegree, quedanPlazas, dataExpediente, price, cantidadPlazas);
            degrees.create(newProduct);
        }
        catch (Exception ex)
        {
            //Console.WriteLine("ha habido un error");
            AnsiConsole.Write(new Markup(" [red]ha habido un error![/]"));

        }
    }

//Cambiar Cantidad de plazas
    public static void changesAmount(ProductRepository degrees)
    {
        try
        {
            string degreeNameToChange = Asker.askString("Nombre del grado para cambiar si quedan plazas o no : ");
            Product degreeToChange = degrees.find(degreeNameToChange);
            degreeToChange.ChangeGender();
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]No has escrito bien el nombre del grado[/] "));
        }
        
    }

}
