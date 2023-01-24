namespace Classes;

public class PagosGrados
{
    public string Number { get; }
    public string Owner { get; set; }

    public decimal Total
    {
        get
        {
            decimal total = 0;
            foreach (var pago in allPago)
            {
                total += pago.Price;
            }

            return total;
        }
    }

    private static int accountNumberSeed = 1;
    private List<Pagos> allPago = new List<Pagos>();
    private readonly decimal _minimumTotal;


    public PagosGrados(string name, decimal initialTotal) : this(name, initialTotal, 0) { }

    public PagosGrados(string name, decimal initialTotal, decimal minimumTotal)
    {
        Number = accountNumberSeed.ToString();
        accountNumberSeed++;
        Owner = name;
        _minimumTotal = minimumTotal;
        if (initialTotal > 0)
            MakeDeposit(initialTotal, DateTime.Now, "Matricula");
    }

    public void MakeDeposit(decimal price, DateTime date, string note)
    {
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Precio Correcto");
        }
        var deposit = new Pagos(price, date, note);
        allPago.Add(deposit);
    }

    public void MakeWithdrawalNoCheckLimit(decimal price, DateTime date, string note)
    {
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Precio Correcto");
        }
        if (this.Total - price < _minimumTotal)
        {
            throw new InvalidOperationException("Falta por pagar");
        }
        var withdrawal = new Pagos(-price, date, note);
        allPago.Add(withdrawal);
    }

    public void MakeWithdrawal(decimal price, DateTime date, string note)
    {
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Precio Correcto");
        }
        Pagos? overdraftTransaction = CheckWithdrawalLimit(Total - price < _minimumTotal);
        Pagos? withdrawal = new Pagos(-price, date, note);
        allPago.Add(withdrawal);
        if (overdraftTransaction != null)
            allPago.Add(overdraftTransaction);
    }

    protected virtual Pagos? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Falta por pagar");
        }
        else
        {
            return default;
        }
    }

    public string GetExpedienteHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal total = 0;
        report.AppendLine("Date\t\tPrice\tTotal\tNote");
        foreach (var item in allPago)
        {
            total += item.Price;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Price}\t{total}\t{item.Notes}");
        }

        return report.ToString();
    }

    public virtual void IteresesFinanciacion() { }
}