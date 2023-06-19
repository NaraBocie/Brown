
class RuchyBrowna
{
    private static void Main(string[] args)
    {
        StreamWriter plik = new StreamWriter("RuchyBrowna.xls"); // deklaracja i otworzenie pliku wyjściowego

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        Random rand = new Random(); // inicjalizacja generatora liczb losowych
        double x = 0, y = 0; // początkowe położenie cząsteczki
        double vx = 0, vy = 0; // początkowa prędkość cząsteczki
        double dt = 0.01; // krok czasowy
        double D = 1; // współczynnik dyfuzji
        double n; // def. zmiennej n 
        double pi = 3.14159f, p; // def. zmiennej będącej liczbą π


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        Console.WriteLine("Podaj liczbę ruchów: ");

        n = double.Parse(Console.ReadLine()); // przekształcanie zmiennej typu string na double 

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        plik.WriteLine(x + "\t" + y + "\t"); // zapis początkowych współrzędnych do pliku

        Console.WriteLine("Pozycja początkowa \nx = " + x.ToString() + " " + "\ny = " + y.ToString() + " "); // pozycja początkowa cząsteczki

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        for (int i = 0; i < n; i++) // pętla symulująca ruchy Browna
        {

            double fx = rand.NextDouble() * 2 * pi;  // składowa losowa siły w kierunku x
            double fy = rand.NextDouble() * 2 * pi;  // -||- y

            vx += fx * Math.Sqrt(2 * D * dt); // zmiana prędkości w kierunku x
            vy += fy * Math.Sqrt(2 * D * dt); // -||- y

            x = x + (double)Math.Cos(fx); // nowa współrzędna x
            y = y + (double)Math.Sin(fy); // nowa współrzędna y

            plik.WriteLine(x + "\t" + y + "\t");
            Console.WriteLine($"Iteracja {i}: \nx = {x} \ny = {y}"); // wypisanie położenia cząsteczki
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        plik.Close(); // zamknięcie pliku

        p = Math.Sqrt(x * x + y * y); // długość przemieszczenia

        Console.WriteLine("\nWektor przesunięcia jest równy: " + Math.Round(p, 5)); // zaokrąglanie wyniku zmiennej p do liczby całkowitej
        Console.WriteLine("\nOstateczna pozycja X: " + Math.Round(x, 5));
        Console.WriteLine("Ostateczna pozycja Y: " + Math.Round(y, 5));

        Console.ReadKey(); // oczekiwanie na naciśnięcie klawisza przed zamknięciem programu
    }
}