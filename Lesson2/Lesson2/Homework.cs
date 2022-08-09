class Program1
{
    public void Homework()
    {

        Console.WriteLine("Введіть значення х:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double mathfunctions1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
        //bad naming
        double mathfunctions2 = Math.Abs(x) * Math.Sin(x);
        //bad naming
        double mathfunctions3 = 2 * Math.PI * x;
        //bad naming
        double mathfunctions4 = Math.Max(x, y);
        //bad naming

        Console.WriteLine($"Значення mathfunctions1 = {mathfunctions1}");
        Console.WriteLine($"Значення mathfunctions2 = {mathfunctions2}");
        Console.WriteLine($"Значення mathfunctions3 = {mathfunctions3}");
        Console.WriteLine($"Значення mathfunctions4 = {mathfunctions4}");

    }
}
//checked
