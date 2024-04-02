using System;

class Program
{
    // Function to convert seconds to minutes
    static double ConvertSecondsToMinutes(double seconds)
    {
        return seconds / 60;
    }

    // Function to convert minutes to hours
    static double ConvertMinutesToHours(double minutes)
    {
        return minutes / 60;
    }

    // Function to convert hours to days
    static double ConvertHoursToDays(double hours)
    {
        return hours / 24;
    }

    // Function to convert days to months
    static double ConvertDaysToMonths(double days)
    {
        return days / 30; // It's roughly a month, but not exact
    }

    static void Main()
    {
        double seconds = 3600;

        // Perform conversions
        double minutes = ConvertSecondsToMinutes(seconds);
        double hours = ConvertMinutesToHours(minutes);
        double days = ConvertHoursToDays(hours);
        double months = ConvertDaysToMonths(days);

        // Display results in a friendly manner
        Console.WriteLine("Let's do some time conversions!");
        Console.WriteLine($"If you have {seconds} seconds:");
        Console.WriteLine($"That's about {minutes} minutes.");
        Console.WriteLine($"Which is approximately {hours} hours.");
        Console.WriteLine($"That's around {days} days.");
        Console.WriteLine($"And roughly {months} months.");

        Console.WriteLine("Time flies when you're converting it!");
    }
}
