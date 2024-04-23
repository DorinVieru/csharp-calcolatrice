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
        public static int SottrInteri(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        // Differenza tra due numeri double
        public static double SottrDouble(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        // Moltiplicazione di due numeri interi
        public static int MoltInteri(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        // Moltiplicazione di due numeri double
        public static double MoltDouble(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        // Valore assoluto di un numero intero
        public static int ValAssolutoIntero(int numAbs)
        {
            return numAbs < 0 ? -numAbs : numAbs;
        }

        // Valore assoluto di un numero double
        public static double ValAssolutoDouble(double numAbs)
        {
            return numAbs < 0 ? -numAbs : numAbs;
        }

        // Minimo tra due numeri interi
        public static int MinInteri(int numOne, int numTwo)
        {
            return numOne < numTwo ? numOne : numTwo;
        }

        // Minimo tra due numeri double
        public static double MinDouble(double numOne, double numTwo)
        {
            return numOne < numTwo ? numOne : numTwo;
        }

        // Massimo tra due numeri interi
        public static int MaxInteri(int numOne, int numTwo)
        {
            return numOne > numTwo ? numOne : numTwo;
        }

        // Massimo tra due numeri double
        public static double MaxDouble(double numOne, double numTwo)
        {
            return numOne > numTwo ? numOne : numTwo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
