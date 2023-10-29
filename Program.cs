﻿namespace datetimeMetot;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(2));
        Console.WriteLine(DateTime.Now.AddMonths(2));

        //Format

        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));
        
        //MATH 

        Console.WriteLine(Math.Abs(-25)); //mutlak
        Console.WriteLine(Math.Sin(10));   
        
        Console.WriteLine(Math.Ceiling(22.3)); //kendinden büyük olana yuvarla
        Console.WriteLine(Math.Round(22.3));//hangisine yakınsa
        Console.WriteLine(Math.Floor(22.7));  // küçük olana yuvarla 

        Console.WriteLine(Math.Max(10,20));
        Console.WriteLine(Math.Min(10,20)); 

        Console.WriteLine(Math.Pow(2,3));
        Console.WriteLine(Math.Sqrt(25));
        Console.WriteLine(Math.Log(9));
        Console.WriteLine(Math.Exp(3)); //e^3 verir
        

    }
}
