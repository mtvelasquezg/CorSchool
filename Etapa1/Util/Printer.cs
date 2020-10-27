using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void DibujarTitulo(string titulo)
        {
            var tam = titulo.Length + 4;             
            WriteLine("".PadLeft(tam, '='));
            WriteLine($"| {titulo} |");
            WriteLine("".PadLeft(tam, '='));
        }
        
    }
}