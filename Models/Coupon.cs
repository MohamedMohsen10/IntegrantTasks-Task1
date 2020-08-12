using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class Coupon
    {
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public List<Luggage> Luggages { get; set; } = new List<Luggage>();
        public Flight Flight { get; set; }  
      public Coupon(Ticket _ticket, Flight _flight)
      {
            Ticket = _ticket;
            Flight = _flight;
      }
        public Coupon()
        {

        }
    }
}
