namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        // Somma di due numeri interi
        public static int SommaInteri(int a, int b)
        {
            return a + b;
        }

        // IL FATTO DI UTILIZZARE LO STESSO METODO PER TIPI DI PARAMETRO DIVERSO INDICA CHE APPLICHIAMO IL PRINCIPIO DEL POLIMORFISMO, UNO DEI PRINCIPI DELLA PROGRAMMAZIONE AD OGGETTI
        // Somma di due numeri double
        public static double SommaDouble(double a, double b)
        {
            return a + b;
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
