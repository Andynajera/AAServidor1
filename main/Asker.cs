namespace Classes;
class Asker
{
    public static int askInteger(string prompt = "Introduzca un entero: ")
    {
        Console.WriteLine(prompt);

        return Int32.Parse(Console.ReadLine());

    }
    

    public static string askString(string prompt = "Introduzca un texto: ")
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    public static bool askBool(string prompt = "Introduzca un Booleano:")
    {
        Console.WriteLine(prompt);
        return Boolean.Parse(Console.ReadLine());
        
    }
     public static DateTime askDate(string prompt = "Introduzca una fecha:")
    {
        Console.WriteLine(prompt);
        return DateTime.Parse(Console.ReadLine());
    }

     public static decimal askDecimal(string prompt = "Introduzca un numero decimal:")
    {
        Console.WriteLine(prompt);
        return Decimal.Parse(Console.ReadLine());
    }



}