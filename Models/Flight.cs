using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class Flight
    {
        public int Id { get; set; }
        public List<Coupon> Coupons { get; set; } = new List<Coupon>();
        public FlightNumber FlightNumber { get; set; }
        //public Flight(FlightNumber _flightNumber)
        //{
        //    FlightNumber = _flightNumber;
        //}
        public Flight()
        {

        }
    }
}
