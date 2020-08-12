using Session_1_Task.Models;
using System;
using System.IO;

namespace Session_1_Task
{
    class Program
    {

        static void Main(string[] args)
        {
            Context context = new Context();

            display(context);
        }

        private static void display(Context context)
        {
            Console.WriteLine("Welcome to Our Flight System");
            Console.WriteLine("Press 1 for Displaying all customers");
            Console.WriteLine("Press 2 for Displaying all tickets and coupons for specific customer");
            Console.WriteLine("Press 3 for Displaying Coupon Details");
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 1)
                {
                    Console.WriteLine("-----------------------------------------------");
                    displayAllCustomers(context);
                    Console.WriteLine("-----------------------------------------------");
                    display(context);
                }
                else if (input == 2)
                {
                    Console.WriteLine("-----------------------------------------------");
                    displayTicketsPerCustomer(context);
                    Console.WriteLine("-----------------------------------------------");
                    display(context);
                }
                else if (input == 3)
                {
                    Console.WriteLine("-----------------------------------------------");
                    displayCouponDetails(context);
                    display(context);
                }
                else
                {
                    Console.WriteLine("Kindly choose a correct number");
                    display(context);
                }

            }

        }
        private static void displayAllCustomers(Context context)
        {

            foreach (var item in context.InitData.Customers)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
            }
        }
        private static void displayTicketsPerCustomer(Context context)
        {
            Console.WriteLine("Enter Customer ID");
            int CustomerId;
            if (int.TryParse(Console.ReadLine(), out CustomerId))
            {
                try
                {
                    var cst = context.InitData.Customers.Find(c => c.Id == CustomerId);
                    foreach (var ticket in cst.Tickets)
                    {
                        foreach (var item in ticket.Coupons)
                        {
                            if(item!=null)
                            Console.WriteLine($"Ticket ID: {ticket.Id}, Coupon ID: {item.Id}");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("We can't find this customer");
                    displayTicketsPerCustomer(context);
                }
            }
            else
            {
                Console.WriteLine("Kindly enter a valid number");
                displayTicketsPerCustomer(context);
            }
        }

        private static void displayCouponDetails(Context context)
        {

            foreach(var coupon in context.InitData.Coupons)
            {
                foreach (var luggage in coupon.Luggages)
                {
                    Console.WriteLine($"Coupon ID: {coupon.Id}, Flight ID: {coupon.Flight.Id}," +
                        $" Transports Luggage Weight: {luggage?.Weight??0}, FlightNumber AirLine{coupon.Flight.FlightNumber.Airline}, " +
                        $"Flight Number Departure: {coupon.Flight.FlightNumber.Departure.ToString()}, " +
                        $"Flight Number Description: {coupon.Flight.FlightNumber.Description}, " +
                        $"Start Airport ID: {coupon.Flight.FlightNumber.StartAirport.Id}, " +
                        $"Start Airport Name: {coupon.Flight.FlightNumber.StartAirport.Name}, " +
                        $"Destination Airport ID: {coupon.Flight.FlightNumber.DestinationAirport.Id}, " +
                        $"Destination Airport Name: {coupon.Flight.FlightNumber.DestinationAirport.Name}.");
                    Console.WriteLine("-----------------------------------------------");

                }
            }
        }

    }
}
