internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero  (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Enero");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 2:
                Console.WriteLine("Febrero");
                Console.WriteLine("Tiene 28 o 29 dias");
                break;
            case 3:
                Console.WriteLine("Marzo");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 4:
                Console.WriteLine("Abril");
                Console.WriteLine("Tiene 30 dias"); 
                break;
            case 5:
                Console.WriteLine("Mayo");
                Console.WriteLine("Tiene 31 dias");         
                break;
            case 6:
                Console.WriteLine("Junio");
                Console.WriteLine("Tiene 30 dias"); 
                break;
            case 7:
                Console.WriteLine("Julio");
                Console.WriteLine("Tiene 31 dias"); 
                break;
            case 8:
                Console.WriteLine("Agosto");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 9:
                Console.WriteLine("Septiembre");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 10:
                Console.WriteLine("Octubre");
                Console.WriteLine("Tiene 31 dias"); 
                break;
            case 11:
                Console.WriteLine("Noviembre");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 12:
                Console.WriteLine("Diciembre");
                Console.WriteLine("Tiene 31 dias");
                break;
            default:
                Console.WriteLine("Numero invalido");
                break;
        }
    }
}
