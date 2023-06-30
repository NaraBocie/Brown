
class RuchyBrowna
{
    private static void Main(string[] args)
    {
        StreamWriter plik = new StreamWriter("BrownianMotion.xls");

           /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        Random rand = new Random(); // initialization of the random number generator
        double x = 0, y = 0; // initial particle position
        double vx = 0, vy = 0; // initial particle velocity
        double dt = 0.01; // time step
        double D = 1; // diffusion coefficient
        double n; // variable n
        double pi = 3.14159f, p; // variable representing the value of π


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        Console.WriteLine("Enter the number of steps: ");

        n = double.Parse(Console.ReadLine()); // converting the string variable to double

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        file.WriteLine(x + "\t" + y + "\t"); // write initial coordinates to the file

        Console.WriteLine("Initial position \nx = " + x.ToString() + " " + "\ny = " + y.ToString() + " "); // initial particle position

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        for (int i = 0; i < n; i++) // loop simulating Brownian motion
        {

            double fx = rand.NextDouble() * 2 * pi;  // random force component in the x direction
            double fy = rand.NextDouble() * 2 * pi;  // random force component in the y direction

            vx += fx * Math.Sqrt(2 * D * dt); // change in velocity in the x direction
            vy += fy * Math.Sqrt(2 * D * dt); // change in velocity in the y direction

            x = x + (double)Math.Cos(fx); // new x coordinate
            y = y + (double)Math.Sin(fy); // new y coordinate

            file.WriteLine(x + "\t" + y + "\t");
            Console.WriteLine($"Iteration {i}: \nx = {x} \ny = {y}"); // print particle position
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        file.Close(); // close the file

        p = Math.Sqrt(x * x + y * y); // displacement length

        Console.WriteLine("\nThe displacement vector is: " + Math.Round(p, 5)); // round the value of p to an integer
        Console.WriteLine("\nFinal position X: " + Math.Round(x, 5));
        Console.WriteLine("Final position Y: " + Math.Round(y, 5));

        Console.ReadKey(); // wait for a key press before closing the program
    }

}
