using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class Ticket
    {
        public int Id { get; set; }
        public Customers Customer { get; set; }
        public Coupon[] Coupons { get; set; } = new Coupon[4];
        //public Ticket(Customers _customers,Coupon[] _coupon)
        //{
        //    Customers = _customers;
        //    int i = 0;
        //    foreach (var item in _coupon)
        //    {
        //        if (i < 4)
        //        {
        //            Coupons[i] = item;
        //            i++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("4 Coupons only allowed for each ticket");
        //            break;
        //        }
        //    }
        //}
        public Ticket()
        {

        }
    }
}
