namespace Classes;

public class financiacionExpediente : PagosGrados
{

    public financiacionExpediente(string name, decimal precioTotal) : base(name, precioTotal) 
    {
    }

    public financiacionExpediente(string name, decimal precioTotal, decimal creditLimit) : base(name, precioTotal, -creditLimit)
    {
    }

   
   public override void IteresesFinanciacion()
    {
        if (Total < 0)
        {
            decimal interest = -Total * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Intereses financiacion");
        }
    }

    protected override Pagos? CheckWithdrawalLimit(bool isOverdrawn) 
    => isOverdrawn
        ? new Pagos(20, DateTime.Now, "Cargo por pronto pago")
        : default;
    

}