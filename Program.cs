namespace Enum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday);       // Sunday
        Console.WriteLine((int)Days.Friday);  // 5

        int temperature = 32;
        if(temperature <= (int) WeatherForecast.Normal)
            Console.WriteLine("The weather is cold to go outside.");
        else if(temperature >= (int)WeatherForecast.Hot)
            Console.WriteLine("The weather is too hot to go outside");
        else if(temperature >= (int)WeatherForecast.Normal && temperature < (int)WeatherForecast.Hot)
            Console.WriteLine("You can go outside.");
    }
}

enum Days
{
    Monday =1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum WeatherForecast
{
    Cold = 5,
    Normal = 20,
    Warm = 25,
    Hot = 30
}