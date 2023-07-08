

using OOPConcepts.Logica;

try
{
    var cliente1 = new Clientes()
    { 
        Cliente= "Carlos",
        Celular=0987330061,
        Correo= "menciasleal@gmail.com",
        Huespedes= 5,
        Pago= "Efectivo",
        Reserva= new Date(2023,10,12),
    };

    Console.WriteLine(cliente1);

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine("Sigo en pie");