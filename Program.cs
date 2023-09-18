using ActividadExtraClase_Recursividad_MCLG.Clases;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero");
            int numero =  Convert.ToInt16(Console.ReadLine());
            Recursivo recursividad = new Recursivo();
            Console.WriteLine(recursividad.SumaDigitos(numero));
        }
    }
}