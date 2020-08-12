using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task.Models
{
    public class InitData
    {
        public List<Customers> Customers { get; set; } = new List<Customers>();
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Coupon> Coupons { get; set; } = new List<Coupon>();
        public List<Luggage> Luggages { get; set; } = new List<Luggage>();
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public List<FlightNumber> FlightNumbers { get; set; } = new List<FlightNumber>();
        public List<Airport> Airports { get; set; } = new List<Airport>();


        public InitData()
        {
            InitAirports();
            InitFlightNumbers();
            InitFlights();
            InitLuggage();
            InitCoupons();
            InitTickets();
            InitCustomers();
        }


        private void InitCustomers()
        {
            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.Name = "Mohamed";
            customer1.Tickets.Add(Tickets.Find(t => t.Id == 1));
            Customers customer2 = new Customers();
            customer2.Id = 2;
            customer2.Name = "Ahmed";
            customer2.Tickets.Add(Tickets.Find(t => t.Id == 2));
            Customers customer3 = new Customers();
            customer3.Id = 3;
            customer3.Name = "Ali";
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Tickets.Find(t => t.Id == 1).Customer = customer1;
            Tickets.Find(t => t.Id == 2).Customer = customer2;
        }
        private void InitTickets()
        {
            Ticket ticket1 = new Ticket();
            Ticket ticket2 = new Ticket();
            ticket1.Id = 1;
            ticket1.Coupons[0] = Coupons.Find(f => f.Id == 1);
            ticket1.Coupons[1] = Coupons.Find(f => f.Id == 3);
            ticket2.Id = 2;
            ticket2.Coupons[0] = Coupons.Find(f => f.Id == 2);
            Tickets.Add(ticket1);
            Tickets.Add(ticket2);
            Coupons.Find(c => c.Id == 1).Ticket = ticket1;
            Coupons.Find(c => c.Id == 2).Ticket = ticket2;
            Coupons.Find(c => c.Id == 3).Ticket = ticket1;
        }

        private void InitCoupons()
        {
            Coupon coupon1 = new Coupon();
            Coupon coupon2 = new Coupon();
            Coupon coupon3 = new Coupon();
            coupon1.Id = 1;
            coupon1.Luggages = Luggages;
            coupon1.Flight = Flights.Find(f => f.Id == 1);
            coupon2.Id = 2;
            coupon2.Flight = Flights.Find(f => f.Id == 2);
            coupon2.Luggages.Add(Luggages.Find(l => l.Weight == 50));
            coupon3.Id = 3;
            Coupons.Add(coupon1);
            Coupons.Add(coupon2);
            Coupons.Add(coupon3);
            Flights.Find(f => f.Id == 1).Coupons.Add(coupon1);
            Flights.Find(f => f.Id == 2).Coupons.Add(coupon2);
        }

        private void InitLuggage()
        {
            Luggage luggage1 = new Luggage();
            luggage1.Weight = 50;
            Luggage luggage2 = new Luggage();
            luggage2.Weight = 60;
            Luggages.Add(luggage1);
            Luggages.Add(luggage2);

        }
        private void InitFlights()
        {
            Flight flight1 = new Flight();
            Flight flight2 = new Flight();
            flight1.Id = 1;
            flight2.Id = 2;
            flight1.FlightNumber = FlightNumbers.Find(f => f.Airline == "EgyAir");
            flight2.FlightNumber = FlightNumbers.Find(f => f.Airline == "USAir");
            Flights.Add(flight1);
            Flights.Add(flight2);
            FlightNumbers.Find(fn => fn.Airline == "EgyAir").Flights = Flights;
            FlightNumbers.Find(fn => fn.Airline == "USAir").Flights.Add(flight2);

        }

        private void InitFlightNumbers()
        {
            FlightNumber flightNumber1 = new FlightNumber();
            FlightNumber flightNumber2 = new FlightNumber();
            flightNumber1.Airline = "EgyAir";
            flightNumber1.Departure = DateTime.Now;
            flightNumber1.Description = "New Flight";
            flightNumber2.Airline = "USAir";
            flightNumber2.Departure = DateTime.Now;
            flightNumber2.Description = "New Air Flight";
            flightNumber1.StartAirport = Airports.Find(p => p.Id == 1);
            flightNumber1.DestinationAirport = Airports.Find(p => p.Id == 2);
            flightNumber2.StartAirport = Airports.Find(p => p.Id == 2);
            flightNumber2.DestinationAirport = Airports.Find(p => p.Id == 1);
            FlightNumbers.Add(flightNumber1);
            FlightNumbers.Add(flightNumber2);
            Airports.Find(a => a.Id == 1).FlightNumbers = FlightNumbers;
            Airports.Find(a => a.Id == 2).FlightNumbers = FlightNumbers;
        }
        private void InitAirports()
        {
            Airport airport1 = new Airport();
            Airport airport2 = new Airport();
            airport1.Id = 1;
            airport1.Name = "Cairo";
            airport2.Id = 2;
            airport2.Name = "Alex";
            Airports.Add(airport1);
            Airports.Add(airport2);
        }


    }
}
