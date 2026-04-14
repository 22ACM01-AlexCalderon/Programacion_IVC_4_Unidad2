internal class Program
{
    private static void Main(string[] args)
    {
        int op;
        double a; 
        Console.WriteLine("CALCULADORA DE FUNCIONES TRIGONOMETRICAS");
        Console.WriteLine("****************************************");
        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");
        Console.WriteLine("****************************************");
        Console.WriteLine("Ingrese una opcion: ");
        op = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el angulo: ");
        a = Convert.ToInt32(Console.ReadLine());

        a = a * double.Pi / 180;

        switch (op)
        {
            case 1 :
                Console.WriteLine("El seno del angulo es: "+ double.Sin(a));
                break;
            case 2 :
                Console.WriteLine("El coseno del angulo es: "+ double.Cos(a));
                break;
            case 3 :
                Console.WriteLine("La tangente del angulo es: "+double.Tan(a));
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }


    }
}