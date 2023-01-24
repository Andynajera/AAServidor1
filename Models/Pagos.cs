
namespace Classes;

public class Pagos
{
    public decimal Price { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Pagos(decimal amount, DateTime date, string note)
    {
        Price = amount;
        Date = date;
        Notes = note;
    }

}