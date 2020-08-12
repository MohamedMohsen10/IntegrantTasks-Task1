using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class Luggage
    {
        public float Weight { get; set; }
        public Coupon Coupon { get; set; }
        public Luggage(Coupon _coupon)
        {
            Coupon = _coupon;
        }
        public Luggage()
        {

        }
    }
}
