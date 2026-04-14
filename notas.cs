internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su Nota (A-F):");
        string nota = Console.ReadLine().ToUpper();
        switch (nota)
        {
            case "A":
                Console.WriteLine("Excelente");
                break;
            case "B":
                Console.WriteLine("Bien");
                break;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Nota igresada no válida");
                break;
        }
    }
}
