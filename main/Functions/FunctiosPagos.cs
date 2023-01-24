namespace Classes;
using Spectre.Console;




class functionsPagos
{
    public static void ListInformation()
    {
        try
        {
            PagosGrados expediente = new PagosGrados("Andrea", 1000);
            Console.WriteLine($"Expediente {expediente.Number} was created for {expediente.Owner} with {expediente.Total} precio total.");
            expediente.MakeDeposit(750, DateTime.Now, "Precio Asignatura");
            Console.WriteLine(expediente.GetExpedienteHistory());



            PagosGrados expedienteMiriam = new PagosGrados("Miriam", 10000);
            Console.WriteLine($"Expediente {expedienteMiriam.Number} was created for {expedienteMiriam.Owner} with {expedienteMiriam.Total} precio total.");
            expedienteMiriam.MakeWithdrawal(500, DateTime.Now, "PrecioAsignatura");
            Console.WriteLine(expedienteMiriam.Total);
            expedienteMiriam.MakeDeposit(500, DateTime.Now, "Precio asignatura");
            Console.WriteLine(expedienteMiriam.Total);
            Console.WriteLine(expedienteMiriam.GetExpedienteHistory());


            var expedienteOscar = new Cuenta("Oscar", 1000, 50);
            Console.WriteLine($"Expediente {expedienteOscar.Number} was created for {expedienteOscar.Owner} with {expedienteOscar.Total} precio total.");
            Console.WriteLine(expedienteOscar.Total);
            expedienteOscar.MakeDeposit(750, DateTime.Now, "Precio asignatura");
            expedienteOscar.MakeDeposit(1250, DateTime.Now, "Precio asignaturas2");
            expedienteOscar.MakeWithdrawal(250, DateTime.Now, "Devolucion por convalidacion");
            expedienteOscar.IteresesFinanciacion();
            Console.WriteLine(expedienteOscar.GetExpedienteHistory());



            // accountVanessa.MakeWithdrawal(50000, DateTime.Now, "PrecioAsignatura");
            //Console.WriteLine(accountVanessa.Total);

            var savings = new InteresesExpediente("Segunda Matricula", 1000);
            savings.MakeDeposit(750, DateTime.Now, "Precio asignatura");
            savings.MakeDeposit(1250, DateTime.Now, "Precio asignaturas2");
            savings.MakeWithdrawal(250, DateTime.Now, "Devolucion por convalidacion");
            savings.IteresesFinanciacion();
            Console.WriteLine(savings.GetExpedienteHistory());



            var ExpedienteLorena = new Cuenta("Lorena", 1000, 50);
            Console.WriteLine($"Expediente {ExpedienteLorena.Number} was created for {ExpedienteLorena.Owner} with {ExpedienteLorena.Total} precio total.");
            ExpedienteLorena.MakeDeposit(300, DateTime.Now, "Precio asignatura");
            ExpedienteLorena.MakeWithdrawal(400, DateTime.Now, "Devolucion Convaliacion");
            ExpedienteLorena.IteresesFinanciacion();
            // can make additional deposits:
            ExpedienteLorena.MakeDeposit(300, DateTime.Now, "Precio asignatura3");
            Console.WriteLine(ExpedienteLorena.GetExpedienteHistory());


            var ExpedientePaloma = new financiacionExpediente("Paloma", 1000, 50);
            Console.WriteLine($"Expediente {ExpedientePaloma.Number} was created for {ExpedientePaloma.Owner} with {ExpedientePaloma.Total} precio total.");
            ExpedientePaloma.MakeDeposit(100m, DateTime.Now, "Precio asignatura");
            ExpedientePaloma.MakeDeposit(300m, DateTime.Now, "Precio asignatura2");
            ExpedientePaloma.MakeWithdrawal(50m, DateTime.Now, "Devolucion Convalidacion");
            ExpedientePaloma.MakeDeposit(150m, DateTime.Now, "Precio asignatura3");
            ExpedientePaloma.IteresesFinanciacion();
            Console.WriteLine(ExpedientePaloma.GetExpedienteHistory());
        }

        catch (Exception e)
        {
            Console.WriteLine("General exception caught trying to overdraw");
            Console.WriteLine(e.ToString());
        }


    }


}

