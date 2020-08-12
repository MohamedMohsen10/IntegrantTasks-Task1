using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Session_1_Task
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
        public Customers()
        {
            Tickets = new List<Ticket>();
        }
        
    }
}
