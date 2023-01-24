namespace Classes;

public class Cuenta : PagosGrados
{
    private readonly decimal _monthlyDeposit = 0m;

    public Cuenta(string name, decimal initialTotal, decimal monthlyDeposit = 0) : base(name, initialTotal) 
    => _monthlyDeposit = monthlyDeposit;
   
   public override void IteresesFinanciacion()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, DateTime.Now, "pago mensual");
        }
    }
}