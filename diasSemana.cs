internal class Program
{
    private static void Main(string[] args)
    {
        int d;
        Console.WriteLine("Ingrese un numero (1-7): ");
        d= int.Parse(Console.ReadLine());
        switch (d)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                break;   

        }

    }
}