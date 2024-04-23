namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        // Somma di due numeri interi
        public static int SommaInteri(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        // IL FATTO DI UTILIZZARE LO STESSO METODO PER TIPI DI PARAMETRO DIVERSO INDICA CHE APPLICHIAMO IL PRINCIPIO DEL POLIMORFISMO, UNO DEI PRINCIPI DELLA PROGRAMMAZIONE AD OGGETTI
        // Somma di due numeri double
        public static double SommaDouble(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        // Differenza tra due numeri interi
        public static int DifferenzaInteri(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        // Differenza tra due numeri double
        public static double DifferenzaDouble(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        // Moltiplicazione di due numeri interi
        public static int MoltiplicazioneInteri(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        // Moltiplicazione di due numeri double
        public static double MoltiplicazioneDouble(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
