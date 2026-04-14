internal class Program
{
    private static void Main()
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("=== VENTA DE ENTRADAS ===");
        Console.WriteLine("1. Palco (Q300.00)");
        Console.WriteLine("2. Tribuna (Q100.00 - Q125.00)");
        Console.WriteLine("3. Preferencia (Q50.00 - Q75.00)");
        Console.WriteLine("4. Generales (Q30.00 - Q50.00)");
        Console.Write("Seleccione el sector (1-4): ");
        sector = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de entradas: ");
        cantidad = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                Console.Write("Ingrese el precio (100 - 125): ");
                precio = double.Parse(Console.ReadLine());
                if (precio < 100 || precio > 125)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            case 3:
                Console.Write("Ingrese el precio (50 - 75): ");
                precio = double.Parse(Console.ReadLine());
                if (precio < 50 || precio > 75)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            case 4:
                Console.Write("Ingrese el precio (30 - 50): ");
                precio = double.Parse(Console.ReadLine());
                if (precio < 30 || precio > 50)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        total = precio * cantidad;

        Console.WriteLine("\n=== DETALLE DE COMPRA ===");
        Console.WriteLine("Cantidad de entradas: " + cantidad);
        Console.WriteLine("Precio por entrada: Q" + precio);
        Console.WriteLine("Total a pagar: Q" + total);

        Console.ReadKey();
    }
}