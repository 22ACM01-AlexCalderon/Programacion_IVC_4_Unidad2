internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Pizza");
        Console.WriteLine("3. Pollo Frito");
        Console.WriteLine("4. Ensalada");
        Console.WriteLine("Ingrese el número de su elección: ");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("Has elegido Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Has elegido Pizza");
                break;
            case 3:
                Console.WriteLine("Has elegido Pollo Frito");
                break;
            case 4:
                Console.WriteLine("Has elegido Ensalada");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
