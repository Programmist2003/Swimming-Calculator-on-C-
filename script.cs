using System;

class SwimmingEfficiencyCalculator
{
    static void Main()
    {
        Console.Write("Enter the distance swam in meters: ");
        float distance = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the time taken in hours: ");
        float hours = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the time taken in minutes: ");
        float minutes = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the time taken in seconds: ");
        float seconds = Convert.ToSingle(Console.ReadLine());

        // Calculate total time in seconds
        float totalTimeSec = (hours * 3600) + (minutes * 60) + seconds;

        // Calculate efficiency (distance per time)
        float efficiency = distance / totalTimeSec;

        // Calculate speed in meters per second
        float speedMps = distance / totalTimeSec;

        // Calculate speed in kilometers per hour
        float speedKph = (distance / 1000.0f) / (totalTimeSec / 3600.0f);

        // Calculate speed in miles per hour
        float speedMph = speedKph / 1.609f;

        Console.WriteLine($"Efficiency: {efficiency} meters/second");
        Console.WriteLine($"Speed in meters/second: {speedMps}");
        Console.WriteLine($"Speed in kilometers/hour: {speedKph}");
        Console.WriteLine($"Speed in miles/hour: {speedMph}");
    }
}
