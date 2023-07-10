

using OOPConcepts.Logica;

try
{
    var cliente1 = new Cliente()
    { 
        
        Clientes= "Carlos",
        Celular=0987330061,
        Correo= "menciasleal@gmail.com",
        Huespedes= 5,
        Pago= "Efectivo",
        Reserva= new Dates(2023,10,12),
     };

    var destinos = new Destino()
    {
        Pais = "Mexico",
        Ciudad = "Cancun"
    };
    Console.WriteLine(cliente1);
    Console.WriteLine(destinos);

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine("Sigo en pie");