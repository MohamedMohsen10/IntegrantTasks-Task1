using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FlightNumber> FlightNumbers { get; set; } = new List<FlightNumber>();

        //public Airport(List<FlightNumber> _flightNumber)
        //{
        //    if(_flightNumber!=null)
        //    foreach (var item in _flightNumber)
        //    {
        //        FlightNumbers.Add(item);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Airport should have at least one FlightNumber");
        //    }
        //}
        public Airport()
        {

        }

    }
}
