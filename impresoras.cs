using System;

class Program
{
    static void Main()
    {
        int cantidad, opcion;
        double precioUnitario = 650;
        double iva = 0.12;
        double precioConIVA, totalSinDescuento, descuento = 0, totalPagar;

        Console.WriteLine("=== VENTA DE IMPRESORAS ===");

        Console.Write("Ingrese la cantidad de impresoras: ");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");
        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        precioConIVA = precioUnitario + (precioUnitario * iva);

        totalSinDescuento = cantidad * precioConIVA;
        string formaPago = "";

        switch (opcion)
        {
            case 1:
                descuento = totalSinDescuento * 0.10;
                formaPago = "Efectivo";
                break;
            case 2:
                descuento = totalSinDescuento * 0.05;
                formaPago = "Tarjeta de crédito";
                break;
            case 3:
                descuento = totalSinDescuento * 0.15;
                formaPago = "Vale de regalo";
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        totalPagar = totalSinDescuento - descuento;

        Console.WriteLine("\n=== DETALLE DE PAGO ===");
        Console.WriteLine("Cantidad de impresoras: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioConIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + totalPagar);

        Console.ReadKey();
    }
}
