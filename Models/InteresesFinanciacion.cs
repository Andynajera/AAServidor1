namespace Classes;

public class InteresesExpediente : PagosGrados
{
    public InteresesExpediente(string name, decimal PrecioTotal) : base(name, PrecioTotal)
        {
        }

    public override void IteresesFinanciacion()
    {
        if (Total > 10000m)
        {
            decimal interest = Total * 0.05m;
            MakeDeposit(interest, DateTime.Now, "apply monthly interest");
        }
    }
}