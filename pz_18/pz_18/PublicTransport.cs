using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

public enum TransportType
{
    Trolleybus,
    Bus,
    Train
}

public class PublicTransport
{
    public TransportType Type { get; set; }
    public string LicensePlate { get; set; }
    private string driver;
    public string Driver
    {
        get
        {
            return string.IsNullOrEmpty(driver) ? "не назначен" : driver;
        }
        set
        {
            driver = value;
        }
    }
    public TimeOnly DepartureTime { get; set; }
    public TimeOnly EndTime { get; set; }

    private static int numberOfInstances = 0;

    public static int NumberOfInstances
    {
        get { return numberOfInstances; }
    }

    public PublicTransport(TransportType type, string licensePlate, string driver, TimeOnly departureTime, TimeOnly endTime)
    {
        Type = type;
        LicensePlate = ValidateLicensePlate(licensePlate) ? licensePlate : throw new ArgumentException("Некорректный госномер!");
        Driver = driver;
        DepartureTime = departureTime;
        EndTime = endTime;
        numberOfInstances++;
    }
    private static bool ValidateLicensePlate(string licensePlate)
    {
        string pattern = @"^[A-Z]{2}\s\d{3}\s[A-Z]{2}$";
        return Regex.IsMatch(licensePlate, pattern);
    }
}