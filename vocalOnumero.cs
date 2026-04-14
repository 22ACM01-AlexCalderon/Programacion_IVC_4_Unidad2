internal class Program
{
    private static void Main()
    {
        char caracter;

        Console.Write("Ingrese un caracter: ");
        caracter = Convert.ToChar(Console.ReadLine());

        if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
            caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U')
        {
            Console.WriteLine("Es una vocal");
        }
        else if (caracter >= '0' && caracter <= '9')
        {
            Console.WriteLine("Es un digito");
        }
        else
        {
            Console.WriteLine("No es vocal ni digito");
        }

        Console.ReadKey();
    }
}