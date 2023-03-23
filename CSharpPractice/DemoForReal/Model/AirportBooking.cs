using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FlightsAM
{
    public int AMID;
    public string AirportCode;
    public bool OneWay;
    public string DepartureDate;
    public string ReturnDate;
    public double Cost;

    public FlightsAM(int AMID, string AirportCode, bool OneWay, string DepartureDate, string ReturnDate, double Cost)
    {
        this.AMID = AMID;
        this.AirportCode = AirportCode;
        this.OneWay = OneWay;
        this.DepartureDate = DepartureDate;
        this.ReturnDate = ReturnDate;
        this.Cost = Cost;
    }
    public int IDAM
    {
        get { return AMID; }
        set { AMID = value; }
    }
    public string APCode
    {
        get { return AirportCode; }
        set { AirportCode = value; }
    }
    public bool IsOneWay
    {
        get { return OneWay; }
        set { OneWay = value; }
    }
    public string DDate
    {
        get { return DepartureDate; }
        set { DepartureDate = value; }
    }
    public string RDate
    {
        get { return ReturnDate; }
        set { ReturnDate = value; }
    }
    public double FlightCost
    {
        get { return Cost; }
        set { Cost = value; }
    }

}
public class Airport
{
    public static void Main(string[] args)
    {
        List<AMFlight> FlightsAM = new List<AMFlight>();
        FlightsAM.Add(new AMFlight(1, "ATL", 0, "June 12 , 2023",));


    }
    public static int WhichWay()
    {
        Console.WriteLine("---------Welcome to Porter Airlines---------");
        Console.WriteLine("Choose 1 if you are flying one time or do you also want a return flight \n ");
    }
}