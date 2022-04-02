using System;

namespace hello
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "haha";
            Console.WriteLine("str={0}", nameof(str));

            Console.WriteLine(nameof(str));



            // string state = WaterState(32);

            // Console.WriteLine($"state={state}");
            // Console.WriteLine($"a={a},b={b}");

            // var (name, population, area) = QueryCityData("New York City");

            // Console.WriteLine($"{name},{population},{area}");

        }

        static string WaterState(int tempInFahrenheit) =>
        tempInFahrenheit switch
        {
            (> 32) and (< 212) => "liquid",
            < 32 => "solid",
            > 212 => "gas",
            32 => "solid/liquid transition",
            212 => "liquid / gas transition",
        };

        static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }
    }
}
